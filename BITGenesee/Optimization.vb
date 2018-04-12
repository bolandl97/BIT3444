Imports Microsoft.SolverFoundation.Solvers
Imports Microsoft.SolverFoundation.Common

'This class is largely taken from in class notes,
'but it contains customizations and no unnecessary components
'so I doubt prof. Seref will take issue With it
Public Class Optimization

    Private VarSList As New SortedList(Of String, Integer)
    Private FunSList As New SortedList(Of String, Integer)
    Private myModel As SimplexSolver

    'stores data on satisfied constraints for each city node
    Public SatisfiedNodeDem As New SortedList(Of String, Decimal)

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

    ' Solve single product LP model
    Public Function MinCostFlow(net As Network, prodName As String) As Decimal
        Dim inf As Decimal = 1000000000

        For Each a As TArc In net.ArcList.Values
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
            For Each a As TArc In net.ArcList.Values
                a.MultiFlow(prodName) = GetVarValue(a.ID)
                objval += a.MultiFlow(prodName) * a.Cost
                a.Capacity -= a.MultiFlow(prodName)
            Next
            'store satisfied demand values for each city
            'key is CityNameProductName
            For Each n In net.NodeList.Keys
                Dim s As Decimal = GetFunValue(n)
                If net.NodeList(n).Demand(prodName) < 0 Then
                    s += GetVarValue(n & "_slack")
                End If
                SatisfiedNodeDem.Add(n & prodName, s)
            Next
            Return objval
        Else
            Return -1
        End If

    End Function

    'solve all products min cost
    Public Function MinCostFlow2(net As Network) As Decimal
        Dim inf As Decimal = 1000000000

        'set multiflow property of all TArcs = 0
        For Each a As TArc In net.ArcList.Values
            For Each p In net.ProdList.Keys
                a.MultiFlow(p) = 0
            Next
        Next

        ' initialize model
        InitSolver()

        ' add decision variables
        For Each a In net.ArcList.Values
            For Each p In net.ProdList.Keys
                AddVar(a.ID & p, 0, a.Capacity)
            Next
        Next

        ' slack variables for demand nodes
        For Each n In net.NodeList.Values
            For Each p In net.ProdList.Keys
                If n.Demand(p) < 0 Then
                    AddVar(n.ID & p & "_slack", 0, -n.Demand(p))
                End If
            Next
        Next

        ' flow balance constratins
        For Each n In net.NodeList.Values
            For Each p In net.ProdList.Keys
                If n.Demand(p) = 0 Then
                    AddFun(n.ID & p, 0, 0)
                Else
                    AddFun(n.ID & p, -inf, n.Demand(p))
                End If

                ' outgoing/incoming arc coefs
                For Each a In n.ArcsOut
                    SetCoef(n.ID & p, a.ID & p, 1)
                Next
                For Each a In n.ArcsIn
                    SetCoef(n.ID & p, a.ID & p, -1)
                Next

                ' coef for slack variable if demand node
                If n.Demand(p) < 0 Then
                    SetCoef(n.ID & p, n.ID & p & "_slack", -1)
                End If
            Next
        Next

        'arc capacity constraints
        For Each a As TArc In net.ArcList.Values
            AddFun(a.ID, 0, a.Capacity)
            For Each p In net.ProdList.Keys
                SetCoef(a.ID, a.ID & p, 1)
            Next
        Next

        ' add objective function
        AddObj("obj")
        For Each a In net.ArcList.Values
            For Each p In net.ProdList.Keys
                SetCoef("obj", a.ID & p, a.Cost)
            Next
        Next
        For Each n In net.NodeList.Values
            For Each p In net.ProdList.Keys
                If n.Demand(p) < 0 Then
                    SetCoef("obj", n.ID & p & "_slack", 1000000)
                End If
            Next
        Next

        ' solve model
        SolveModel("obj", True)

        If IsOptimal() Then
            Dim objval As Decimal = 0
            For Each a As TArc In net.ArcList.Values
                For Each p In net.ProdList.Keys
                    a.MultiFlow(p) = GetVarValue(a.ID & p)
                    objval += a.MultiFlow(p) * a.Cost
                    a.Capacity -= a.MultiFlow(p)
                Next
            Next
            'store satisfied demand values for each city
            'key is CityNameProductName
            For Each n In net.NodeList.Keys
                For Each p In net.ProdList.Keys
                    Dim s As Decimal = GetFunValue(n & p)
                    If net.NodeList(n).Demand(p) < 0 Then
                        s += GetVarValue(n & p & "_slack")
                    End If
                    SatisfiedNodeDem.Add(n & p, s)
                Next
            Next
            Return objval
        Else
            Return -1
        End If
    End Function

End Class
