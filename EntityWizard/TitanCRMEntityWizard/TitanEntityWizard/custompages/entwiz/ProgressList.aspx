<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProgressList.aspx.cs" Inherits="ProgressList" %>

<%@ Register Assembly="SageCRM" Namespace="SageCRM.AspNet" TagPrefix="SageCRM" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Sage CRM</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" /> 
    <link type="text/css" rel="Stylesheet" href="eware.css" />  
<meta http-equiv="cache-control" content="no-cache" />
<meta http-equiv="pragma" content="no-cache" />
<meta http-equiv="expires" content="-1" />    
</head>
<body>
    <form id="EntryForm" runat="server">
    <div>
        <sagecrm:sagecrmconnection id='SageCRMConnection' runat="server" CRMPath="http://localhost/crm" SID="149078205431453"></sagecrm:sagecrmconnection>
<input type="hidden" name="yearEntry" />
<input type="hidden" name="monthEntry" />
<input type="hidden" name="dayEntry" />    
      <table style="height: 500px; vertical-align:top" width="100%" border="0"  cellpadding="0" cellspacing="0" >
            <tr valign="top" >
                <td colspan="3" style="height: 5%" valign="top" >
                    <SageCRM:SageCRMTabGroup ID="SageCRMTabGroup" runat="server" EntityName="xxxxxxxxx" TabGroupName="aspxxxxxxx" />
                </td>
            </tr>
            <tr valign="top" >
                <td style="width: 2%; height: 90%" valign="top" >&nbsp;</td>
                <td style="width: 77%; height: 90%" valign="top" >
                    &nbsp;<SageCRM:SageCRMListBlock ID="SageCRMListBlock" runat="server" BlockTitle="" EntityName="xxxxxxxxxProgress" EntityWhere="xxxx_xxxxxxxxxID=-1" ListBlock="xxxxxxxxxProgressList" />
                    <br />
                    <br />
                    <br />
                    <br />
                    &nbsp;&nbsp;
                </td>
                <td style="width: 20%; height: 90%" valign="top" >
                    &nbsp;&nbsp;
                </td>
            </tr>
            <tr valign="top" >
                <td colspan="3" style="height: 5%" valign="top" >
                &nbsp;&nbsp;                    <SageCRM:SageCRMTopContent ID="SageCRMTopContent" runat="server" EntityName="xxxxxxxxx" EntityWhere="xxxx_xxxxxxxxxID=-1" EntryBlockName="xxxxxxxxxTopContent" />
                </td>
            </tr>
        </table>    
    </div>
    </form>
</body>
</html>
