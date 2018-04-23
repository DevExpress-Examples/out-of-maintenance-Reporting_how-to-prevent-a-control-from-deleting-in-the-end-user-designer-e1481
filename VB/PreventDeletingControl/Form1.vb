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

    Public Function CanHandleCommand(ByVal command As ReportCommand, _
        ByRef useNextHandler As Boolean) As Boolean Implements ICommandHandler.CanHandleCommand
        useNextHandler = command <> ReportCommand.Delete AndAlso Not IsXRLabelSelected()
        Return Not useNextHandler
    End Function

    Public Sub HandleCommand(ByVal command As ReportCommand, _
        ByVal args() As Object) Implements ICommandHandler.HandleCommand
        MessageBox.Show("Cannot delete label!")
    End Sub

	Private Function IsXRLabelSelected() As Boolean
		Dim controls() As Object = panel.GetSelectedComponents()

		For Each obj As Object In controls
			If TypeOf obj Is XRLabel Then
				Return True
			End If
		Next obj

		Return False
	End Function
End Class