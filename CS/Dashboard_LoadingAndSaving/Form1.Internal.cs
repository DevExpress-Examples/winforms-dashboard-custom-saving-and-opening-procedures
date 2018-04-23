using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;

namespace Dashboard_LoadingAndSaving {
    public partial class Form1 {
        public DialogResult InvokeMessageBox() {
            return XtraMessageBox.Show(new UserLookAndFeel(dashboardDesigner1), 
                                       "Do you want to save the dashboard to the default location?", 
                                       "Save As", 
                                       MessageBoxButtons.OKCancel);
        }
    }
}
