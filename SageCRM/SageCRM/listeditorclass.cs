using System;
using System.Design;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using SageCRM.AspNet;

namespace SageCRM.AspNet.Design
{
    public class SageCRMComponentListEditor : WindowsFormsComponentEditor
    {
        public override bool EditComponent(ITypeDescriptorContext context, object component,
            IWin32Window owner)
        {
            SageCRMBaseListBlock block = component as SageCRMBaseListBlock;
            if (block == null)
            {
                throw new ArgumentException("Component must be a SageCRMListBlock or a SageCRMPortalListBlock", "component");
            }
            IServiceProvider site = block.Site;
            IComponentChangeService changeservice = null;
            DesignerTransaction transaction = null;
            bool changed = false;
            try
            {
                if (site != null)
                {
                    IDesignerHost designerhost = (IDesignerHost)site.GetService(typeof(IDesignerHost));
                    transaction = designerhost.CreateTransaction("Sage CRM Administration");
                    changeservice = (IComponentChangeService)site.GetService(typeof(IComponentChangeService));
                    if (changeservice != null)
                    {
                        try
                        {
                            changeservice.OnComponentChanging(block, null);
                        }
                        catch (CheckoutException ex)
                        {
                            if (ex == CheckoutException.Canceled)
                                return false;
                            throw ex;
                        }
                    }
                }
                try
                {
                    block.SageCRMConnection.DesignRequest = true;
                    crmEditor form = new crmEditor(block, null, null, null, null);
                    form.ShowDialog(owner);
                    changed = true;
                    block.SageCRMConnection.DesignRequest = false;
                }
                finally
                {
                    if (changed && changeservice != null)
                    {
                        changeservice.OnComponentChanged(block, null, null, null);
                    }
                }
            }
            finally
            {
                if (transaction != null)
                {
                    if (changed)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        transaction.Cancel();
                    }
                }
            }
            return changed;
        }

    }

}