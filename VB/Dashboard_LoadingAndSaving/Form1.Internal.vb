Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.LookAndFeel

Namespace Dashboard_LoadingAndSaving

    Public Partial Class Form1

        Public Function InvokeMessageBox() As DialogResult
            Return XtraMessageBox.Show(New UserLookAndFeel(dashboardDesigner1), "Do you want to save the dashboard to the default location?", "Save As", MessageBoxButtons.OKCancel)
        End Function
    End Class
End Namespace
