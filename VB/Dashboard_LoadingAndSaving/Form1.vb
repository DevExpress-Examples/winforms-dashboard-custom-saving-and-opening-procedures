Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon

Namespace Dashboard_LoadingAndSaving

    Public Partial Class Form1
        Inherits RibbonForm

        ' Specifies the path to the dashboard XML definition.
        Private filePath As String = "..\..\Data\DashboardDefinition.xml"

        Public Sub New()
            InitializeComponent()
            ' Creates and initializes a Ribbon in the DashboardDesigner's parent control.
            dashboardDesigner1.CreateRibbon()
            ' Loads a dashboard from an XML file.
            dashboardDesigner1.LoadDashboard(filePath)
        End Sub

        ' Handles the DashboardSaving event.
        Private Sub dashboardDesigner1_DashboardSaving(ByVal sender As Object, ByVal e As DevExpress.DashboardWin.DashboardSavingEventArgs)
            ' Determines whether the user has called the Save command.
            If e.Command = DevExpress.DashboardWin.DashboardSaveCommand.Save Then
                ' Saves the dashboard to the specified XML file.
                dashboardDesigner1.Dashboard.SaveToXml(filePath)
                ' Specifies that the dashboard has been saved and no default actions are required.
                e.Handled = True
            End If

            ' Determines whether the user has called the Save As command.
            If e.Command = DevExpress.DashboardWin.DashboardSaveCommand.SaveAs Then
                Dim result As DialogResult = InvokeMessageBox()
                If result = DialogResult.OK Then
                    dashboardDesigner1.Dashboard.SaveToXml(filePath)
                    e.Handled = True
                    ' Specifies that the dashboard has been saved.
                    e.Saved = True
                End If

                If result = DialogResult.Cancel Then
                    e.Handled = True
                    e.Saved = False
                End If
            End If
        End Sub

        ' Handles the DashboardOpening event.
        Private Sub dashboardDesigner1_DashboardOpening(ByVal sender As Object, ByVal e As DevExpress.DashboardWin.DashboardOpeningEventArgs)
            ' Loads the previously saved dashboard from an XML file.
            dashboardDesigner1.LoadDashboard(filePath)
            ' Specifies that the dashboard opening procedure has been provided.
            e.Handled = True
        End Sub
    End Class
End Namespace
