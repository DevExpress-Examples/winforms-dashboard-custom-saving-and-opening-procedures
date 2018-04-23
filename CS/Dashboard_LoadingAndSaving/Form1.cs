using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;

namespace Dashboard_LoadingAndSaving {
    public partial class Form1 : RibbonForm {

        // Specifies the path to the dashboard XML definition.
        string filePath = @"..\..\Data\DashboardDefinition.xml";

        public Form1() {
            InitializeComponent();

            // Creates and initializes a Ribbon in the DashboardDesigner's parent control.
            dashboardDesigner1.CreateRibbon();

            // Loads a dashboard from an XML file.
            dashboardDesigner1.LoadDashboard(filePath);
        }

        // Handles the DashboardSaving event.
        private void dashboardDesigner1_DashboardSaving(object sender, 
            DevExpress.DashboardWin.DashboardSavingEventArgs e) {

            // Determines whether the user has called the Save command.
            if (e.Command == DevExpress.DashboardWin.DashboardSaveCommand.Save) {

                // Saves the dashboard to the specified XML file.
                dashboardDesigner1.Dashboard.SaveToXml(filePath);

                // Specifies that the dashboard has been saved and no default actions are required.
                e.Handled = true;
            }

            // Determines whether the user has called the Save As command.
            if (e.Command == DevExpress.DashboardWin.DashboardSaveCommand.SaveAs) {
                DialogResult result = InvokeMessageBox();
                if (result == System.Windows.Forms.DialogResult.OK) {
                    dashboardDesigner1.Dashboard.SaveToXml(filePath);
                    e.Handled = true;

                    // Specifies that the dashboard has been saved.
                    e.Saved = true;
                }
                if (result == System.Windows.Forms.DialogResult.Cancel) {
                    e.Handled = true;
                    e.Saved = false;
                }
            }
        }

        // Handles the DashboardOpening event.
        private void dashboardDesigner1_DashboardOpening(object sender, 
            DevExpress.DashboardWin.DashboardOpeningEventArgs e) {

            // Loads the previously saved dashboard from an XML file.
            dashboardDesigner1.LoadDashboard(filePath);

            // Specifies that the dashboard opening procedure has been provided.
            e.Handled = true;
        }
    }
}
