Imports Microsoft.VisualBasic
Imports System
Namespace PreventDeletingControl
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.xrDesignPanel1 = New DevExpress.XtraReports.UserDesigner.XRDesignPanel()
			CType(Me.xrDesignPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xrDesignPanel1
			' 
			Me.xrDesignPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xrDesignPanel1.Location = New System.Drawing.Point(0, 0)
			Me.xrDesignPanel1.Name = "xrDesignPanel1"
			Me.xrDesignPanel1.Padding = New System.Windows.Forms.Padding(1)
			Me.xrDesignPanel1.Size = New System.Drawing.Size(426, 293)
			Me.xrDesignPanel1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(426, 293)
			Me.Controls.Add(Me.xrDesignPanel1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.xrDesignPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private xrDesignPanel1 As DevExpress.XtraReports.UserDesigner.XRDesignPanel
	End Class
End Namespace

