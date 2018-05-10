using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.CommLib;
using SMOSEC.UI.MasterData;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.Domain.Entity;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssetsExLayout : Smobiler.Core.Controls.MobileUserControl
    {
        private AutofacConfig _autofacConfig = new AutofacConfig();//����������

        private void touchPanel1_Press(object sender, EventArgs e)
        {
            try
            {
                frmAssetsDetail detail=new frmAssetsDetail();
                detail.AssId = lblID.BindDataValue.ToString();
                Form.Show(detail, (MobileForm sender1, object args) =>
                    {
                        if (detail.ShowResult == ShowResult.Yes)
                        {
                            frmAssets assets = (frmAssets) Form;
                            assets.Bind();
                        }

                    }
                );
//                Form.Show(detail);
            }
            catch (Exception ex)
            {
                Parent.Form.Toast(ex.Message);
            }
        }

        private void touchPanel1_LongPress(object sender, EventArgs e)
        {
            try
            {
//                MobileMessageBox messageBox=new MobileMessageBox(this.Form);
//                messageBox.Show("�Ƿ�ɾ�����ʲ���",MessageBoxButtons.YesNo, (object s1, MessageBoxHandlerArgs args) =>
//                {
//                    try
//                    {
//                        if (args.Result == ShowResult.Yes)
//                        {
////                            ReturnInfo returnInfo=_autofacConfig.SettingService
//                        }
//                    }
//                    catch (Exception ex)
//                    {
//                        Parent.Form.Toast(ex.Message);
//                    }
//                });
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
		/// <summary>
        /// ʹ���˱��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Press(object sender, EventArgs e)
        {
            ((frmAssets)Form).popCurrentUser.Groups.Clear();
            PopListGroup poli = new PopListGroup();
            ((frmAssets)Form).popCurrentUser.Groups.Add(poli);
            poli.Title = "ʹ���߱��";
            List<coreUser> users = _autofacConfig.coreUserService.GetAll();
            foreach (coreUser Row in users)
            {
                poli.AddListItem(Row.USER_NAME, Row.USER_ID);
            }
            Assets assets= _autofacConfig.orderCommonService.GetAssetsByID(lblID.BindDataValue.ToString());
            foreach (PopListItem Item in poli.Items)
            {
                if (Item.Value == assets.CURRENTUSER)
                {
                    ((frmAssets)Form).popCurrentUser.SetSelections(Item);
                    ((frmAssets)Form).LastUser = assets.CURRENTUSER;
                    ((frmAssets)Form).ASSID = lblID.BindDataValue.ToString();
                }                   
            }
            ((frmAssets)Form).popCurrentUser.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    ((frmAssets) Form).SelectAssId = lblID.Text;
                }           
                else
                {
                    ((frmAssets)Form).SelectAssId = "";
                }
                ((frmAssets)Form).Bind();
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}