<!-- #include file ="SageCRM.js" -->
<%
//******************************************************************************
//******************************************************************************
/*
*  Sage CRM ASP.NET Component Suite
*  Version 2.0
*/
//******************************************************************************
try
{
  var Family=Request.QueryString('Family');
  var Caption=Request.QueryString('Caption');
  var result=eWare.GetTrans(Family, Caption);
  Response.Write(result);
}catch(e){
  logerror(e);
}
%>
