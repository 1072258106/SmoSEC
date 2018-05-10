using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.UI.AssetsManager;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class BorrowOrderLayout : Smobiler.Core.Controls.MobileUserControl
    {
        private void Panel1_Press(object sender, EventArgs e)
        {
            try
            {
                frmBoDetail boDetail=new frmBoDetail();
                boDetail.BoId = LblID.BindDataValue.ToString();
                Form.Show(boDetail);
            }
            catch (Exception ex)
            {
                Parent.Form.Toast(ex.Message);
            }
        }
    }
}