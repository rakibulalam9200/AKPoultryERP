using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class ItemInfo : Form
    {

        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        string ComID = "";
        string locID = "";
        string Qry = "";
        string checkqry = "";
        string EdtQry = "";

        Int32 TdAcct = 0;
        Int32 AvgPurchase = 0;
        Int32 TdTotal = 0;
        Int32 DRaw = 0;
        Int32 DBag = 0;
        public ItemInfo()
        {
            InitializeComponent();

            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void ItemInfo_Load(object sender, EventArgs e)
        {
            cboComName.Select();
            btnLoadCombo_Click(null, null);
            btnLoadGridData_Click(null, null);
        }

        private void ShowMessage(string type, string msg)
        {
            if (type == "info")
            {
                MsgTimer.Stop();
                MsgTimer.Start();
                lblSadIco.Visible = false;
                lblDelIco.Visible = false;
                lblWaitIco.Visible = false;
                lblMsgIco.Visible = false;
                lblInfoIco.Visible = true;
                lblMsg.Text = msg;
                this.PanelTop.BackColor = Color.DarkBlue;
                lblMsg.ForeColor = Color.White;
            }
            else if (type == "save")
            {
                MsgTimer.Stop();
                MsgTimer.Start();
                lblSadIco.Visible = false;
                lblDelIco.Visible = false;
                lblInfoIco.Visible = false;
                lblWaitIco.Visible = false;
                lblMsgIco.Visible = true;
                lblMsg.Text = "Save Successfully....!";
                this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(168)))), ((int)(((byte)(73)))));
                lblMsg.ForeColor = Color.White;
            }
            else if (type == "update")
            {
                MsgTimer.Stop();
                MsgTimer.Start();
                lblSadIco.Visible = false;
                lblDelIco.Visible = false;
                lblInfoIco.Visible = false;
                lblWaitIco.Visible = false;
                lblMsgIco.Visible = true;
                lblMsg.Text = "Edit Successfully....!";
                this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(168)))), ((int)(((byte)(73)))));
                lblMsg.ForeColor = Color.White;
            }
            else if (type == "delete")
            {
                MsgTimer.Stop();
                MsgTimer.Start();
                lblSadIco.Visible = false;
                lblInfoIco.Visible = false;
                lblMsgIco.Visible = false;
                lblWaitIco.Visible = false;
                lblDelIco.Visible = true;
                lblMsg.Text = "Delete Successfully....!";
                this.PanelTop.BackColor = Color.OrangeRed;
                lblMsg.ForeColor = Color.White;
            }
            else if (type == "wait")
            {
                MsgTimer.Stop();
                MsgTimer.Start();
                lblSadIco.Visible = false;
                lblInfoIco.Visible = false;
                lblDelIco.Visible = false;
                lblMsgIco.Visible = false;
                lblWaitIco.Visible = true;
                lblMsg.Text = "Please wait, Loading...!";
                this.PanelTop.BackColor = Color.DarkOrange;
                lblMsg.ForeColor = Color.White;
            }
            else if (type == "not found")
            {
                MsgTimer.Stop();
                MsgTimer.Start();
                lblInfoIco.Visible = false;
                lblMsgIco.Visible = false;
                lblDelIco.Visible = false;
                lblWaitIco.Visible = false;
                lblSadIco.Visible = true;
                lblMsg.Text = "Sorry..! No Record Found";
                this.PanelTop.BackColor = Color.OrangeRed;
                lblMsg.ForeColor = Color.White;
            }
        }

        private void MsgTimer_Tick(object sender, EventArgs e)
        {
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            lblMsg.Text = "Notification...";
            lblMsgIco.Visible = false;
            lblSadIco.Visible = false;
            lblDelIco.Visible = false;
            lblWaitIco.Visible = false;
            lblInfoIco.Visible = true;

            MsgTimer.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.grpSrc.Size = new System.Drawing.Size(1089, 608);
            this.grpSrc.Location = new System.Drawing.Point(5, 33);
            grpSrc.Visible = true;
        }

        private void btnCloseSrc_Click(object sender, EventArgs e)
        {
            grpSrc.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (chkTdAcct.Checked == true)
            {
                TdAcct = 1;
            }
            else
            {
                TdAcct = 0;
            }

            if (chkAvgPurchase.Checked == true)
            {
                AvgPurchase = 1;
            }
            else
            {
                AvgPurchase = 0;
            }


            if (chkTdTotal.Checked == true)
            {
                TdTotal = 1;
            }
            else
            {
                TdTotal = 0;
            }


            if (chkDRaw.Checked == true)
            {
                DRaw = 1;
            }
            else
            {
                DRaw = 0;
            }

            if (chkDBag.Checked == true)
            {
                DBag = 1;
            }
            else
            {
                DBag = 0;
            }


            if (cboItemCode.Text.Trim() == "")
            {
                MessageBox.Show("Item Code  Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboItemCode.Select();
                return;
            }

            if (txtItemName.Text.Trim() == "")
            {
                MessageBox.Show("Item Name  Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtItemName.Select();
                return;
            }

            if (cboBagSize.Text.Trim() == "")
            {
                cboBagSize.Text = 0.ToString();
            }

           
                SvCls.toGetData("SELECT ComId FROM Company WHERE ComName = '" + cboComName.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ComID = SvCls.GblRdrToGetData["ComId"].ToString();
                }

               
            
            
           
                SvCls.toGetData("select WhsId from Whs where WhsName = '" + cboItemloc.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    locID = SvCls.GblRdrToGetData["WhsId"].ToString();
                }

                
            
            

            Qry = "insert iteminfo(ComID, ItemCode, ItemName,ShortName,IGroup, Unit,BagSize,LocID, Rmk, VName,TdAcct,AvgPurchase,TdTotal,DRaw,DBag,Usercode,PcName) values ('" + ComID + "','" + cboItemCode.Text.Trim() + "','" + txtItemName.Text.Trim() + "','" + cboSName.Text.Trim() + "','" + cboIGroup.Text.Trim() + "','" + cboUnit.Text.Trim() + "'," + cboBagSize.Text.Trim() + ",'" + locID + "','" + txtRmk.Text.Trim() + "','" + cboAutoVoucher.Text.Trim() + "'," + TdAcct + "," + AvgPurchase + "," + TdTotal + "," + DRaw + "," + DBag + ",'"+ ClsVar.GblUserId + "','" + ClsVar.GblPcName + "')";
            checkqry = "select  ItemName, Unit from ItemInfo where ItemCode = '" + cboItemCode.Text.Trim() + "'";
            EdtQry = "update iteminfo set ComID = '" + ComID + "', ItemName = '" + txtItemName.Text.Trim() + "', ShortName = '"+cboSName.Text.Trim()+"',Unit  = '" + cboUnit.Text.Trim() + "', IGroup = '" + cboIGroup.Text.Trim() + "', LocID = '" + locID + "', BagSize = " + cboBagSize.Text.Trim() + ", Rmk= '" + txtRmk.Text.Trim() + "', VName = '" + cboAutoVoucher.Text.Trim() + "',TdAcct = " + TdAcct + ",AvgPurchase = " + AvgPurchase + ",TdTotal = " + TdTotal + ",DRaw = " + DRaw + ",DBag = " + DBag + ",Usercode = '"+ ClsVar.GblUserId + "',PcName = '"+ ClsVar.GblPcName + "' where ItemCode = '" + cboItemCode.Text.Trim() + "'";

            SvCls.toGetData(checkqry);
            if (SvCls.GblRdrToGetData.Read())
            {
                SvCls.insertUpdate(EdtQry);
                //Message
                ShowMessage("update", "");
            }
            else
            {
                SvCls.insertUpdate(Qry);
                //Message
                ShowMessage("save", "");

            }
            cboComName.Focus();
            btnLoadGridData_Click(null, null);
        }

   

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboComName.Text = "";
            cboItemCode.Text = "";
            txtItemName.Text = "";
            cboSName.Text = "";
            cboUnit.Text = "";
            cboIGroup.Text = "";
            cboItemloc.Text = "";
            cboUnit.Text = "";
            cboBagSize.Text = "";
            txtRmk.Text = "";
            cboAutoVoucher.Text = "";
            cboAutoNo.Text = "";
            if (chkTdAcct.Checked == true)
            {
                chkTdAcct.Checked = false;
            }

            if (chkAvgPurchase.Checked == true)
            {
                chkAvgPurchase.Checked = false;
            }


            if (chkTdTotal.Checked == true)
            {
                chkTdTotal.Checked = false;
            }


            if (chkDRaw.Checked == true)
            {
                chkDRaw.Checked = false;
            }

            if (chkDBag.Checked == true)
            {
                chkDBag.Checked = false;
            }
        }

        private void btnLoadCombo_Click(object sender, EventArgs e)
        {
            Qry = "select ComName from Company";
            cboComName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboComName.DisplayMember = "ComName";
            cboComName.Text = "";

            Qry = "select distinct ItemCode from itemInfo";
            cboItemCode.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboItemCode.DisplayMember = "ItemCode";
            cboItemCode.Text = "";

            Qry = "select distinct IGroup from ItemInfo";
            cboIGroup.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboIGroup.DisplayMember = "IGroup";
            cboIGroup.Text = "";

            Qry = "select distinct Unit from ItemInfo";
            cboUnit.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboUnit.DisplayMember = "unit";
            cboUnit.Text = "";

            Qry = "select WhsName from Whs";
            cboItemloc.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboItemloc.DisplayMember = "WhsName";
            cboItemloc.Text = "";

            Qry = "select distinct cast(BagSize as decimal(10,2))  as 'BagSize' from itemInfo";
            cboBagSize.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboBagSize.DisplayMember = "BagSize";
            cboBagSize.Text = "";

            Qry = "select distinct VName from itemInfo where VName != ''";
            cboAutoVoucher.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboAutoVoucher.DisplayMember = "VName";
            cboAutoVoucher.Text = "";


        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SvCls.toGetData("select isnull(max(convert(numeric,ItemCode)),100)+1 as ItemCode from itemInfo");

            if (SvCls.GblRdrToGetData.Read())
            {
                cboItemCode.Text = SvCls.GblRdrToGetData["ItemCode"].ToString();
                SvCls.GblCon.Close();
            }


            txtItemName.Text = "";
            cboSName.Text = "";
            cboUnit.Text = "";
            cboIGroup.Text = "";
            cboItemloc.Text = "";
            cboUnit.Text = "";
            cboBagSize.Text = "";
            txtRmk.Text = "";
            cboAutoVoucher.Text = "";
            cboAutoNo.Text = "";

            txtItemName.Focus();

            if (chkTdAcct.Checked == true)
            {
                chkTdAcct.Checked = false;
            }

            if (chkAvgPurchase.Checked == true)
            {
                chkAvgPurchase.Checked = false;
            }


            if (chkTdTotal.Checked == true)
            {
                chkTdTotal.Checked = false;
            }


            if (chkDRaw.Checked == true)
            {
                chkDRaw.Checked = false;
            }

            if (chkDBag.Checked == true)
            {
                chkDBag.Checked = false;
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboItemCode.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter valid Item Code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboItemCode.Select();
                return;
            }


            checkqry = "select * from itemInfo where ItemCode = '" + cboItemCode.Text.Trim() + "'";
            Qry = "delete from itemInfo where ItemCode = '" + cboItemCode.Text.Trim() + "'";
            if (MessageBox.Show("Do you realy want to delete ?", "Powerpoint Technologies.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SvCls.toGetData(checkqry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    SvCls.insertUpdate(Qry);
                    //Message
                    ShowMessage("delete", "");
                }

                else
                {
                    ShowMessage("not found", "");
                }

                cboComName.Select();
                btnLoadGridData_Click(null, null);
            }
        }

        private void cboComName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\r")
            {
                btnAddNew.Select();
            }
        }

        private void cboItemCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtItemName.Select();
            }
        }

        private void txtItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboSName.Select();
            }
        }

        private void cboSName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboIGroup.Select();
            }
        }

        private void cboIGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboUnit.Select();
            }
        }

        private void cboUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboBagSize.Select();
            }
        }

        private void cboBagSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboItemloc.Select();
            }
        }

        private void cboItemloc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtRmk.Select();
            }
        }

        private void txtRmk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboAutoVoucher.Select();
            }
        }

        private void cboAutoVoucher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnSave.Select();
            }
        }

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            Grid.DataSource = SvCls.GblDataTable("select AutoNo,ItemCode as 'Item Code', ItemName as 'Item Name',ShortName as 'Short Name',IGroup as 'Item Group', Unit,BagSize as 'Bag Size', Rmk as 'Remarks', VName as 'Auto Voucher Name',TdAcct as 'TD Account',AvgPurchase as 'Average Purchase' ,TdTotal as 'TD Total Production',DRaw as 'Deduct Raw Materials' ,DBag as 'Deduct Raw Bag' from ItemInfo");
            Grid.Refresh();

            lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            Grid.Columns[0].Visible = false;
        }

        private void cboItemCode_Leave(object sender, EventArgs e)
        {
            if (cboItemCode.Text.Trim() != "")
            {

                Qry = "select AutoNo,ComID, ItemCode, ItemName,ShortName,IGroup, Unit,BagSize,LocID, Rmk, VName,TdAcct,AvgPurchase,TdTotal,DRaw,DBag from ItemInfo where ItemCode = '" + cboItemCode.Text.Trim() + "'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    ComID = SvCls.GblRdrToGetData["ComId"].ToString();
                    cboItemCode.Text = SvCls.GblRdrToGetData["ItemCode"].ToString();
                    txtItemName.Text = SvCls.GblRdrToGetData["ItemName"].ToString();
                    cboSName.Text = SvCls.GblRdrToGetData["ShortName"].ToString();
                    txtRmk.Text = SvCls.GblRdrToGetData["Rmk"].ToString();
                    cboIGroup.Text = SvCls.GblRdrToGetData["IGroup"].ToString();
                    cboUnit.Text = SvCls.GblRdrToGetData["Unit"].ToString();
                    cboBagSize.Text = SvCls.GblRdrToGetData["BagSize"].ToString();
                    locID = SvCls.GblRdrToGetData["LocID"].ToString();
                    cboAutoVoucher.Text = SvCls.GblRdrToGetData["VName"].ToString();
                    cboAutoNo.Text = SvCls.GblRdrToGetData["AutoNo"].ToString();
                    TdAcct = Convert.ToInt32(SvCls.GblRdrToGetData["TdAcct"].ToString());
                    AvgPurchase = Convert.ToInt32(SvCls.GblRdrToGetData["AvgPurchase"].ToString());
                    TdTotal = Convert.ToInt32(SvCls.GblRdrToGetData["TdTotal"].ToString());
                    DRaw = Convert.ToInt32(SvCls.GblRdrToGetData["DRaw"].ToString());
                    DBag = Convert.ToInt32(SvCls.GblRdrToGetData["DBag"].ToString());

                    Qry = "select WhsName from Whs where WhsId = '" + locID + "'";
                    SvCls.toGetData(Qry);
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        cboItemloc.Text = SvCls.GblRdrToGetData["WhsName"].ToString();
                    }

                    else
                    {
                        cboItemloc.Text = "";
                    }

                    Qry = "select ComName from Company where ComId = '" + ComID + "'";
                    SvCls.toGetData(Qry);
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        cboComName.Text = SvCls.GblRdrToGetData["ComName"].ToString();
                    }

                    else
                    {
                        cboComName.Text = "";
                    }

                    if(TdAcct == 1)
                    {
                        chkTdAcct.Checked = true;
                    }
                    else
                        chkTdAcct.Checked = false;

                    if (AvgPurchase == 1)
                    {
                        chkAvgPurchase.Checked = true;
                    }
                    else
                        chkAvgPurchase.Checked = false;

                    if (TdTotal == 1)
                    {
                        chkTdTotal.Checked = true;
                    }
                    else
                        chkTdTotal.Checked = false;

                    if (DRaw == 1)
                    {
                        chkDRaw.Checked = true;
                    }
                    else
                        chkDRaw.Checked = false;

                    if (DBag == 1)
                    {
                        chkDBag.Checked = true;
                    }
                    else
                        chkDBag.Checked = false;

                }
                else
                {
                    ShowMessage("not found", "");
                    cboAutoNo.Text = "";
                    txtItemName.Text = "";
                    cboUnit.Text = "";
                    cboIGroup.Text = "";
                    cboItemloc.Text = "";
                    cboUnit.Text = "";
                    cboBagSize.Text = "";
                    txtRmk.Text = "";
                    cboAutoVoucher.Text = "";
                    cboAutoNo.Text = "";
                    if (chkTdAcct.Checked == true)
                    {
                        chkTdAcct.Checked = false;
                    }

                    if (chkAvgPurchase.Checked == true)
                    {
                        chkAvgPurchase.Checked = false;
                    }


                    if (chkTdTotal.Checked == true)
                    {
                        chkTdTotal.Checked = false;
                    }


                    if (chkDRaw.Checked == true)
                    {
                        chkDRaw.Checked = false;
                    }

                    if (chkDBag.Checked == true)
                    {
                        chkDBag.Checked = false;
                    }
                    cboItemCode.Focus();
                }

            }
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            cboItemCode.Text = Grid.Rows[i].Cells[1].Value.ToString();
            cboItemCode_Leave(null, null);
            cboComName.Focus();
        }
    }
}
