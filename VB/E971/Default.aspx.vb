Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI.WebControls
Imports System.Collections.Generic

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			lGauge1.Scales(0).MaxValue = DSAdapter.RetrieveMaxGoalFromDataSource("year", "2008")
			lGauge1.Scales(0).Value = DSAdapter.RetrieveSumProjectValuesFromDataSource("year", "2008")
		End If
	End Sub
End Class
Public Class DSAdapter
	Private Shared objectDataSource As ObjectDataSource
	Shared Sub New()
		objectDataSource = New ObjectDataSource()
		objectDataSource.TypeName = "DevProjectsDataStore"
	End Sub
	Public Shared Function RetrieveMaxGoalFromDataSource(ByVal param As String, ByVal value As String) As Integer
		Dim queryResult() As Object = TryCast(GetSelectQueryResult(objectDataSource, "SelectFromGoalsWhereYearAreEqual", param, value), Object())
		If (queryResult IsNot Nothing AndAlso queryResult.Length > 0) Then
			Return (CType(queryResult(0), DevProjectsGoal)).Goal
		Else
			Return 200
		End If
	End Function
	Public Shared Function RetrieveSumProjectValuesFromDataSource(ByVal param As String, ByVal value As String) As Integer
		Dim queryResult() As DevProject = TryCast(GetSelectQueryResult(objectDataSource, "SelectFromProjectsWhereYearAreEqual", param, value), DevProject())
		Dim result As Integer = 0
		If (queryResult IsNot Nothing AndAlso queryResult.Length > 0) Then
			For i As Integer = 0 To queryResult.Length - 1
				result += queryResult(i).Value
			Next i
		End If
		Return result
	End Function
	Private Shared Function GetSelectQueryResult(ByVal ds As ObjectDataSource, ByVal method As String, ByVal param As String, ByVal value As String) As Object
		ds.SelectParameters.Clear()
		ds.SelectMethod = method
		ds.SelectParameters.Add(param, value)
		Return ds.Select()
	End Function
End Class