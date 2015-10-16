using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SageCRM.AspNet;

public partial class summary : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string whereClause = "";
        if ( (Request.QueryString.Get("proj_projectid") != null) &&
             (Request.QueryString.Get("proj_projectid").ToString() != ""))
        {
            Session.Add("proj_projectid", Request.QueryString.Get("proj_projectid").ToString());
        }
        else
        if ((Request.QueryString.Get("nrid") != null) &&
            (Request.QueryString.Get("nrid").ToString() != ""))
        {
            Session.Add("proj_projectid", Request.QueryString.Get("nrid").ToString());
        }
        whereClause = "proj_projectid=" + Session["proj_projectid"];
        this.SageCRMEntryBlock.EntityWhere = whereClause;
        this.SageCRMTopContent.EntityWhere = whereClause;
        this.SageCRMEntryBlock1.EntityWhere = whereClause;
    }
    protected void SageCRMButtonChange_BeforeRendering(object source, ref string HTMLSource)
    {
        SageCRMButtonChange btn =(source as SageCRMButtonChange);
        if (btn == null)
            return;
        if (btn.ID == "SageCRMButtonChange") 
        {
            HTMLSource = HTMLSource.Replace("document.EntryForm.submit();", "ajax_change();");
        }else
            if (btn.ID == "SageCRMButtonChange1") 
            {
                HTMLSource = HTMLSource.Replace("document.EntryForm.submit();", "ajax_change1();");
            }

    }
    protected void SageCRMButtonSave_BeforeRendering(object source, ref string HTMLSource)
    {
        SageCRMButtonSave btn = (source as SageCRMButtonSave);
        if (btn == null)
            return;
        if (btn.ID == "SageCRMButtonSave")
        {
            HTMLSource = HTMLSource.Replace("document.EntryForm.submit();", "ajax_change();");
        }
        else
            if (btn.ID == "SageCRMButtonSave1")
            {
                HTMLSource = HTMLSource.Replace("document.EntryForm.submit();", "ajax_change1();");
            }

    }
}
