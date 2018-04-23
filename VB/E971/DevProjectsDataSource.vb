Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

	Public Class DevProjectsDataStore
		Private goalsCore As Dictionary(Of Integer, DevProjectsGoal)
		Private projects_Renamed As List(Of DevProject)
		'
		Public Sub New()
			goalsCore = New Dictionary(Of Integer, DevProjectsGoal)()
			projects_Renamed = New List(Of DevProject)()
			'
			AddGoal(New DevProjectsGoal(2007, 150))
			AddGoal(New DevProjectsGoal(2008, 175))
			'
			AddProject(New DevProject(2007, 37))
			AddProject(New DevProject(2007, 41))
			AddProject(New DevProject(2007, 17))

			AddProject(New DevProject(2008, 53))
			AddProject(New DevProject(2008, 18))
			AddProject(New DevProject(2008, 62))
			AddProject(New DevProject(2008, 33))
		End Sub
		Protected Sub AddGoal(ByVal goal As DevProjectsGoal)
			If (Not Goals.ContainsKey(goal.Year)) Then
				Goals.Add(goal.Year, goal)
			End If
		End Sub
		Protected Sub AddProject(ByVal project As DevProject)
			Projects.Add(project)
		End Sub
		Protected ReadOnly Property Goals() As Dictionary(Of Integer, DevProjectsGoal)
			Get
				Return goalsCore
			End Get
		End Property
		Protected ReadOnly Property Projects() As List(Of DevProject)
			Get
				Return projects_Renamed
			End Get
		End Property
		Public Function SelectFromGoalsWhereYearAreEqual(ByVal year As Integer) As DevProjectsGoal
			Dim result As DevProjectsGoal = Nothing
			Goals.TryGetValue(year, result)
			Return result
		End Function
		Public Function SelectFromProjectsWhereYearAreEqual(ByVal year As Integer) As DevProject()
			Dim result As List(Of DevProject) = New List(Of DevProject)()
			For Each p As DevProject In Projects
				If p.Year = year Then
					result.Add(p)
				End If
			Next p
			Return result.ToArray()
		End Function
	End Class
	Public Class DevProjectsGoal
		Private yearCore As Integer
		Private goalCore As Integer
		'
		Public Sub New(ByVal year As Integer, ByVal goal As Integer)
			yearCore = year
			goalCore = goal
		End Sub
		Public Property Year() As Integer
			Get
				Return yearCore
			End Get
			Set(ByVal value As Integer)
				yearCore = value
			End Set
		End Property
		Public Property Goal() As Integer
			Get
				Return goalCore
			End Get
			Set(ByVal value As Integer)
				goalCore = value
			End Set
		End Property
	End Class
Public Class DevProject
	Private yearCore As Integer
	Private valueCore As Integer
	Public Sub New(ByVal year As Integer, ByVal value As Integer)
		yearCore = year
		valueCore = value
	End Sub
	Public Property Year() As Integer
		Get
			Return yearCore
		End Get
		Set(ByVal value As Integer)
			yearCore = value
		End Set
	End Property
	Public Property Value() As Integer
		Get
			Return valueCore
		End Get
		Set(ByVal value As Integer)
			valueCore = value
		End Set
	End Property
End Class