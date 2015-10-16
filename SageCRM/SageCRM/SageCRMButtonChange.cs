using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security;
using System.Security.Permissions;
using System.IO;
using System.Net;
using System.Configuration;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing;

[assembly: TagPrefix("SageCRM.AspNet", "SageCRM")]
namespace SageCRM.AspNet
{
    [AspNetHostingPermission(SecurityAction.Demand,
        Level = AspNetHostingPermissionLevel.Minimal)]
    [AspNetHostingPermission(SecurityAction.InheritanceDemand,
        Level = AspNetHostingPermissionLevel.Minimal)]
    [ParseChildren(true, "PermissionsEntity")]
    [DefaultProperty("PermissionsEntity")]
    [ToolboxData("<{0}:SageCRMButtonChange ID='SageCRMButtonChange' runat=server></{0}:SageCRMButtonChange>")]
    [ToolboxBitmap(typeof(ImageButton))]
    public class SageCRMButtonChange : SageCRMBaseClass
    {

        [Browsable(true)]
        [Category("Data")]
        [DefaultValue("")]
        [Description("PermissionsEntity is the name of the entity")]
        public virtual string PermissionsEntity
        {
            get
            {
                string s = (string)ViewState["PermissionsEntity"];
                return (s == null) ? "" : s;
            }
            set
            {
                ViewState["PermissionsEntity"] = value;
            }
        }
        [Browsable(true)]
        [Category("Data")]
        [DefaultValue("")]
        [Description("PermissionsType is either VIEW, EDIT,DELETE or INSERT")]
        public virtual string PermissionsType
        {
            get
            {
                string s = (string)ViewState["PermissionsType"];
                return (s == null) ? "" : s;
            }
            set
            {
                ViewState["PermissionsType"] = value;
            }
        }
        protected override void RenderContents(HtmlTextWriter output)
        {
            output.Write(this._GetHTML());
        }
        [Browsable(true)]
        [Category("Data")]
        [DefaultValue("")]
        [Description("Name of the block that the change button is being used with")]
        public virtual string BlockName
        {
            get
            {
                string s = (string)ViewState["BlockName"];
                return (s == null) ? "" : s;
            }
            set
            {
                ViewState["BlockName"] = value;
            }
        }

        public override string _GetHTML()
        {
            if (SageCRMConnection != null)
            {
                return this._GetHTML("/CustomPages/SageCRM/component/change.asp",
                    "&PermissionsEntity=" + this.PermissionsEntity +
                    "&PermissionsType=" + this.PermissionsType +
                    "&BlockName="+this.BlockName,"", true);
            }
            else
            {
                return "<div id=\"designmode1\" style=\"background-color:DarkGray;height:50px;width:125px;\">No SageCRMConnection set (SageCRMButtonChange)</div>";
            }
        }
    }
}
