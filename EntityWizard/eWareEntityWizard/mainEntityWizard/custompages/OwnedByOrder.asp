<!-- #include file ="..\crmwizard.js" -->

<%

CurrentID=eWare.GetContextInfo("Orders", "Orde_OrderQuoteId");

var sURL=new String( Request.ServerVariables("URL")() + "?" + Request.QueryString );

List=eWare.GetBlock("**&customGridName&**");
List.prevURL=sURL;

container = eWare.GetBlock('container');
container.AddBlock(List);

if( !(**&bWorkflow&**) )
{
  container.AddButton(eWare.Button("New", "new.gif", eWare.URL("**&newTabASP&**")+"&E=**&EntityName&**", '**&EntityName&**', 'insert'));
}

container.DisplayButton(Button_Default) = false;

if( **&bWorkflow&** )
{
  container.WorkflowTable = '**&EntityName&**';
  container.ShowNewWorkflowButtons = true;
}

if( CurrentID != null && CurrentID != '' )
{
  eWare.AddContent(container.Execute("**&ColPrefix&**_OrderId="+CurrentID));
}
else
{
  eWare.AddContent(container.Execute("**&ColPrefix&**_OrderId IS NULL"));
}

Response.Write(eWare.GetPage('Order'));

%>