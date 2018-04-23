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


