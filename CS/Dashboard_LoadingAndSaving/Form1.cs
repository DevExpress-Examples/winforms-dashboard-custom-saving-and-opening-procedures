using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Dashboard_LoadingAndSaving
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        string filePath = @"..\..\Data\DashboardDefinition.xml";

        public Form1() {
            InitializeComponent();
            dashboardDesigner1.CreateRibbon();
        }
        private void dashboardDesigner1_DashboardSaving(object sender, 
            DevExpress.DashboardWin.DashboardSavingEventArgs e) {
            if (e.Command == DevExpress.DashboardWin.DashboardSaveCommand.Save) {
                dashboardDesigner1.Dashboard.SaveToXml(filePath);
                e.Handled = true;
            }
            if (e.Command == DevExpress.DashboardWin.DashboardSaveCommand.SaveAs) {
                DialogResult result = InvokeMessageBox();
                if (result == DialogResult.OK) {
                    dashboardDesigner1.Dashboard.SaveToXml(filePath);
                    e.Handled = true;
                    e.Saved = true;
                }
                if (result == DialogResult.Cancel) {
                    e.Handled = true;
                    e.Saved = false;
                }
            }
        }
        private void dashboardDesigner1_DashboardOpening(object sender, 
            DevExpress.DashboardWin.DashboardOpeningEventArgs e) {
            dashboardDesigner1.LoadDashboard(filePath);
            e.Handled = true;
        }
        public DialogResult InvokeMessageBox()
        {
            return XtraMessageBox.Show(new UserLookAndFeel(dashboardDesigner1),
                                       "Do you want to save the dashboard to the default location?",
                                       "Save As",
                                       MessageBoxButtons.OKCancel);
        }
    }
}
