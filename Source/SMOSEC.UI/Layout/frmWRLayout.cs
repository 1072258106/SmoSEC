using SMOSEC.UI.ConsumablesManager;
using System;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmWRLayout : Smobiler.Core.Controls.MobileUserControl
    {
        private void Panel1_Press(object sender, EventArgs e)
        {
            try
            {
                frmWRDetail boDetail = new frmWRDetail() { WRID = LblID.BindDataValue.ToString() };
                Form.Show(boDetail);
            }
            catch (Exception ex)
            {
                Parent.Form.Toast(ex.Message);
            }
        }
    }
}