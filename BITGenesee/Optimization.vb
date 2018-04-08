Imports Microsoft.SolverFoundation.Solvers
Imports Microsoft.SolverFoundation.Common

'This class is almost entirely copied from in class notes,
'but it contains nothing extra so I doubt Seref will take issue with it
Public Class Optimization

    Private VarSList As New SortedList(Of String, Integer)
    Private FunSList As New SortedList(Of String, Integer)
    Private myModel As SimplexSolver

    Public Sub New()

    End Sub

    ' initialize variables, functions, and model
    Private Sub InitSolver()
        VarSList.Clear()
        FunSList.Clear()
        myModel = New SimplexSolver
    End Sub

    ' Add variable to model
    Private Sub AddVar(varstr As String, lb As Decimal, ub As Decimal)
        VarSList.Add(varstr, 0)
        myModel.AddVariable(varstr, VarSList(varstr))
        myModel.SetBounds(VarSList(varstr), lb, ub)
    End Sub

    ' Add function to model
    Private Sub AddFun(funstr As String, lb As Decimal, ub As Decimal)
        FunSList.Add(funstr, 0)
        myModel.AddRow(funstr, FunSList(funstr))
        myModel.SetBounds(FunSList(funstr), lb, ub)
    End Sub

    ' Add objective function
    Private Sub AddObj(funstr As String)
        FunSList.Add(funstr, 0)
        myModel.AddRow(funstr, FunSList(funstr))
    End Sub

    ' Set coef of variable in function
    Private Sub SetCoef(funstr As String, varstr As String, coef As Decimal)
        myModel.SetCoefficient(FunSList(funstr), VarSList(varstr), coef)
    End Sub

    ' Solve opt model
    Private Sub SolveModel(funstr As String, isMin As Boolean)
        myModel.AddGoal(FunSList(funstr), 0, isMin)
        myModel.Solve(New SimplexSolverParams())
    End Sub

    ' Get value of variable
    Private Function GetVarValue(varstr As String) As Decimal
        Return myModel.GetValue(VarSList(varstr)).ToDouble
    End Function

    ' Get value of function
    Private Function GetFunValue(funstr As String) As Decimal
        Return myModel.GetValue(FunSList(funstr)).ToDouble
    End Function

    ' Check optimality
    Private Function IsOptimal() As Boolean
        Return myModel.LpResult = 2
    End Function

    ' Solve LP model
    Public Function MinCostFlow(net As Network, prodName As String) As Decimal

        Dim inf As Decimal = 1000000000

        For Each a As Arc In net.ArcList.Values
            a.MultiFlow(prodName) = 0
        Next

        ' initialize model
        InitSolver()

        ' add decision variables
        For Each a In net.ArcList.Values
            AddVar(a.ID, 0, a.Capacity)
        Next

        ' slack variables for demand nodes
        For Each n In net.NodeList.Values
            If n.Demand(prodName) < 0 Then
                AddVar(n.ID & "_slack", 0, -n.Demand(prodName))
            End If
        Next

        ' flow balance constratins
        For Each n In net.NodeList.Values
            If n.Demand(prodName) = 0 Then
                AddFun(n.ID, 0, 0)
            Else
                AddFun(n.ID, -inf, n.Demand(prodName))
            End If

            ' outgoing/incoming arc coefs
            For Each a In n.ArcsOut
                SetCoef(n.ID, a.ID, 1)
            Next
            For Each a In n.ArcsIn
                SetCoef(n.ID, a.ID, -1)
            Next

            ' coef for slack variable if demand node
            If n.Demand(prodName) < 0 Then
                SetCoef(n.ID, n.ID & "_slack", -1)
            End If
        Next

        ' add objective function
        AddObj("obj")
        For Each a In net.ArcList.Values
            SetCoef("obj", a.ID, a.Cost)
        Next
        For Each n In net.NodeList.Values
            If n.Demand(prodName) < 0 Then
                SetCoef("obj", n.ID & "_slack", 1000000)
            End If
        Next

        ' solve model
        SolveModel("obj", True)

        If IsOptimal() Then
            Dim objval As Decimal = 0
            For Each a As Arc In net.ArcList.Values
                a.MultiFlow(prodName) = GetVarValue(a.ID)
                objval += a.MultiFlow(prodName) * a.Cost
                a.Capacity -= a.MultiFlow(prodName)
            Next
            Return objval
        Else
            Return -1
        End If

    End Function

End Class
