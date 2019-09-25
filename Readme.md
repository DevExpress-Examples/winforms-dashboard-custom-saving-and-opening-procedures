<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Dashboard_LoadingAndSaving/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_LoadingAndSaving/Form1.vb))
<!-- default file list end -->
# How to Override Save and Load Procedures in Dashboard Designer


This example demonstrates how to implement custom save and open procedures in Dashboard Designer.

The application handles the [DashboardOpening](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.DashboardOpening) and [DashboardSaving](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.DashboardSaving) events to open (save) the dashboard located at the path defined in code.

Run the application and click the **File -> Open** button to load the dashboard from the file specified in code. Make any changes and click **File -> Save** to save changes to the same file.


![screenshot](/images/screenshot.png)

