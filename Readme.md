<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581160/18.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4754)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to Override Save and Load Procedures in Dashboard Designer

This example demonstrates how to implement custom save and open procedures in Dashboard Designer.

The application handles the [DashboardOpening](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.DashboardOpening) and [DashboardSaving](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.DashboardSaving) events to open/save the dashboard located at the path defined in code.

Run the application and click the **File -> Open** button to load the dashboard from the file specified in code. Make any changes and click **File -> Save** to save changes to the same file.

![screenshot](/images/screenshot.png)

## Files to Review:

* [Form1.cs](./CS/Dashboard_LoadingAndSaving/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_LoadingAndSaving/Form1.vb))

## Documentation

- [Save and Load a Dashboard](https://docs.devexpress.com/Dashboard/15405)
