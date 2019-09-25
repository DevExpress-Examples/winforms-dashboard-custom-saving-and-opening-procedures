Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports System.Windows.Forms

Namespace Dashboard_LoadingAndSaving
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Private filePath As String = "..\..\Data\DashboardDefinition.xml"

		Public Sub New()
			InitializeComponent()
			dashboardDesigner1.CreateRibbon()
		End Sub
		Private Sub dashboardDesigner1_DashboardSaving(ByVal sender As Object, ByVal e As DevExpress.DashboardWin.DashboardSavingEventArgs) Handles dashboardDesigner1.DashboardSaving
			If e.Command = DevExpress.DashboardWin.DashboardSaveCommand.Save Then
				dashboardDesigner1.Dashboard.SaveToXml(filePath)
				e.Handled = True
			End If
			If e.Command = DevExpress.DashboardWin.DashboardSaveCommand.SaveAs Then
				Dim result As DialogResult = InvokeMessageBox()
				If result = DialogResult.OK Then
					dashboardDesigner1.Dashboard.SaveToXml(filePath)
					e.Handled = True
					e.Saved = True
				End If
				If result = DialogResult.Cancel Then
					e.Handled = True
					e.Saved = False
				End If
			End If
		End Sub
		Private Sub dashboardDesigner1_DashboardOpening(ByVal sender As Object, ByVal e As DevExpress.DashboardWin.DashboardOpeningEventArgs) Handles dashboardDesigner1.DashboardOpening
			dashboardDesigner1.LoadDashboard(filePath)
			e.Handled = True
		End Sub
		Public Function InvokeMessageBox() As DialogResult
			Return XtraMessageBox.Show(New UserLookAndFeel(dashboardDesigner1), "Do you want to save the dashboard to the default location?", "Save As", MessageBoxButtons.OKCancel)
		End Function
	End Class
End Namespace
