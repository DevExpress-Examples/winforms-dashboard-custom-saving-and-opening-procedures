<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581160/13.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4754)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Dashboard_LoadingAndSaving/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_LoadingAndSaving/Form1.vb))
<!-- default file list end -->
# How to implement custom saving and opening procedures in Dashboard Designer


<p>The following example demonstrates how to implement custom saving and opening procedures in Dashboard Designer using the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardDesigner_DashboardSavingtopic"><u>DashboardSaving</u></a> and <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardDesigner_DashboardOpeningtopic"><u>DashboardOpening</u></a> events respectively.</p>
<br />
<p>In this example, the dashboard XML definition can be saved (opened) only to(from) the specified default location.</p>
<br />
<p>The <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardDesigner_DashboardSavingtopic"><u>DashboardSaving</u></a> event is handled to implement a custom saving routine. Its <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardSavingEventArgs_Commandtopic"><u>DashboardSavingEventArgs.Command</u></a> event parameter allows determining what user action raises the event. The <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboard_SaveToXmltopic7"><u>Dashboard.SaveToXml</u></a> method is used to save the dashboard to the specified XML file. Then, the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardSavingEventArgs_Handledtopic"><u>DashboardSavingEventArgs.Handled</u></a> event parameter is used to specify that the dashboard has been saved and no default actions are required.</p>
<p>Clicking the Save As button invokes a message box that allows saving the dashboard to the default location or cancel the saving procedure. The <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardSavingEventArgs_Savedtopic"><u>DashboardSavingEventArgs.Saved</u></a> event parameter is used to notify whether the custom saving routine has succeeded.</p>
<br />
<p>The <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardDesigner_DashboardOpeningtopic"><u>DashboardOpening</u></a> event is handled to implement a custom opening procedure. The <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardDesigner_LoadDashboardtopic"><u>DashboardDesigner.LoadDashboard</u></a> method is called to load the dashboard from the default location. The <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardOpeningEventArgs_Handledtopic"><u>DashboardOpeningEventArgs.Handled</u></a> event parameter allows specifying that no default actions are required to open the dashboard.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-custom-save-and-open-procedures&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-custom-save-and-open-procedures&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
