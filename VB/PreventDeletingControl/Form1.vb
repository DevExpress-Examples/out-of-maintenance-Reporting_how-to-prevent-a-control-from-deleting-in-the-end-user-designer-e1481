Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner
' ...


Namespace PreventDeletingControl
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.xrDesignPanel1.AddCommandHandler(New DeleteCommandHandler(Me.xrDesignPanel1))
			' Load a report into the design form and show the form.
			Me.xrDesignPanel1.OpenReport(New XtraReport1())
		End Sub
	End Class
End Namespace

Public Class DeleteCommandHandler
	Implements ICommandHandler
	Private panel As XRDesignPanel

	Public Sub New(ByVal panel As XRDesignPanel)
		Me.panel = panel
	End Sub

	Public Overridable Sub HandleCommand(ByVal command As ReportCommand, ByVal args() As Object, ByRef handled As Boolean) Implements ICommandHandler.HandleCommand
		If (Not CanHandleCommand(command)) Then
			Return
		End If

		Dim controls() As Object = panel.GetSelectedComponents()

		For Each obj As Object In controls
			If obj.GetType() Is GetType(XRLabel) Then
				MessageBox.Show("Cannot delete label!")
				handled = True
			End If
		Next obj
	End Sub

	Public Overridable Function CanHandleCommand(ByVal command As ReportCommand) As Boolean Implements ICommandHandler.CanHandleCommand
		Return command = ReportCommand.Delete
	End Function

End Class