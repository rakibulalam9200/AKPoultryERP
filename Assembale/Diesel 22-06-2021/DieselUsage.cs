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
    public partial class DieselUsage : Form
    {
        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        string ComID = "";
        string itemCode = "";
        string Qry = "";
        string checkqry = "";
        string EdtQry = "";

        public DieselUsage()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void DieselUsage_Load(object sender, EventArgs e)
        {
            cboComName.Select();
            btnLoadGridData_Click(null, null);
            btnLoadCombo_Click(null, null);
            grpSrc.Visible = false;
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

        private void cboComName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\r")
            {
                btnAddNew.Select();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboComName.Text = "";
            cboItemName.Text = "";
            cboItemGroup.Text = "";
            dtpTheDate.Text = DateTime.Today.ToString();
            cboSlNo.Text = "";
            txtQty.Text = "";
            cboRmk.Text = "";
            mskGenOnTime.Text = "00:00";
            mskGenOffTime.Text = "00:00";
         
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SvCls.toGetData("select isnull(max(convert(numeric,SlNo)),100)+1 as SlNo from DieselUse where ISNUMERIC(SlNo) = 1");

            if (SvCls.GblRdrToGetData.Read())
            {
                cboSlNo.Text = SvCls.GblRdrToGetData["SlNo"].ToString();
                SvCls.GblCon.Close();
            }

            
            cboItemName.Text = "";
            cboItemGroup.Text = "";
            dtpTheDate.Text = DateTime.Today.ToString();
          
            txtQty.Text = "";
            cboRmk.Text = "";
            mskGenOnTime.Text = "00:00";
            mskGenOffTime.Text = "00:00";
            dtpTheDate.Select();
        }

        private void cboSlNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboItemName.Select();
            }
        }

        private void cboItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtQty.Select();
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                mskGenOnTime.Select();
            }
        }

        private void mskGenOnTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                mskGenOffTime.Select();
            }
        }

        private void mskGenOffTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboRmk.Select();
            }
            
        }

        private void cboRmk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnSave.Select();
            }
        }

        private void dtpTheDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboItemName.Select();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadCombo_Click(object sender, EventArgs e)
        {
            Qry = "select ComName from Company";
            cboComName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboComName.DisplayMember = "ComName";
            cboComName.Text = "";

            Qry = "select SlNo from DieselUse";
            cboSlNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboSlNo.DisplayMember = "SlNo";
            cboSlNo.Text = "";

            Qry = "select itemName from itemInfo";
            cboItemName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboItemName.DisplayMember = "itemName";
            cboItemName.Text = "";


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboSlNo.Text.Trim() == "")
            {
                MessageBox.Show("Serial No Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboSlNo.Select();
                return;
            }

            if (cboItemName.Text.Trim() == "")
            {
                MessageBox.Show("Item Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboItemName.Select();
                return;
            }

            if (txtQty.Text.Trim() == "")
            {
                MessageBox.Show("Quantity Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtQty.Select();
                return;
            }

            SvCls.toGetData("SELECT ComId FROM Company WHERE ComName = '" + cboComName.Text.Trim() + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                ComID = SvCls.GblRdrToGetData["ComId"].ToString();
            }

            if (cboItemName.Text.Trim() != "")
            {
                SvCls.toGetData("select ItemCode from ItemInfo WHERE ItemName = '" + cboItemName.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    itemCode = SvCls.GblRdrToGetData["ItemCode"].ToString();
                    
                }
                else
                {
                    ShowMessage("info", "Invalid Item Name!!!");
                    cboItemName.Select();
                    return;
                }
            }

            Qry = "insert into DieselUse(ComId,SlNo,TheDate,ItemCode,Qty,GenOnTime,GenOffTime,rmk,PcName,UserCode) VALUES ('"+ComID+"','"+cboSlNo.Text.Trim()+"',convert(datetime,'"+dtpTheDate.Text.Trim()+"',103),'"+itemCode+"',"+txtQty.Text.Trim()+",convert(datetime,'"+mskGenOnTime.Text.Trim()+"',108),convert(datetime,'"+mskGenOffTime.Text.Trim()+"',108),'"+cboRmk.Text.Trim()+"','"+ClsVar.GblPcName+"','"+ClsVar.GblUserId+"')";
            checkqry = "select TheDate,qty from DieselUse where SlNo = '"+cboSlNo.Text.Trim()+"'";
            EdtQry = "update DieselUse set ComId = '"+ComID+"',TheDate = convert(datetime,'" + dtpTheDate.Text.Trim() + "',103),itemCode = '" + itemCode+ "',qty = "+txtQty.Text.Trim()+",GenOnTime = convert(datetime,'" + mskGenOnTime.Text.Trim() + "',108) ,GenOffTime = convert(datetime,'" + mskGenOffTime.Text.Trim() + "',108),rmk = '" + cboRmk.Text.Trim() + "',PcName = '" + ClsVar.GblPcName + "',UserCode = '" + ClsVar.GblUserId+"' where SlNo = '"+cboSlNo.Text.Trim()+"'";

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

        private void cboItemName_Leave(object sender, EventArgs e)
        {
            if (cboItemName.Text.Trim() != "")
            {
                SvCls.toGetData("select IGroup from ItemInfo WHERE ItemName = '" + cboItemName.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboItemGroup.Text = SvCls.GblRdrToGetData["IGroup"].ToString();
                }
                else
                {
                    ShowMessage("info", "Invalid Item Name!!!");
                    cboItemName.Select();
                    return;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboSlNo.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter Serial No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSlNo.Select();
                return;
            }


            checkqry = "select TheDate,qty from DieselUse where SlNo = '" + cboSlNo.Text.Trim() + "'";
            Qry = "delete from DieselUse where SlNo = '" + cboSlNo.Text.Trim() + "'";
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

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            Grid.DataSource = SvCls.GblDataTable("select du.AutoNo,SlNo as 'Serial NO',convert(datetime,TheDate,103) as 'Date',i.ItemName as 'Item Name',i.IGroup as 'Item Group',cast(qty as decimal(10,2)) as 'Quantity',convert(time,GenOnTime,108) as 'Genarator On Time',convert(time,GenOffTime,108) as 'Genarator off Time',du.rmk as 'Remarks' from DieselUse as du,ItemInfo as i where i.ItemCode = du.ItemCode");
            Grid.Refresh();
           // lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            Grid.Columns[0].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.grpSrc.Size = new System.Drawing.Size(1089, 608);
            this.grpSrc.Location = new System.Drawing.Point(5, 33);
            grpSrc.Visible = true;

            GridSrc.DataSource = SvCls.GblDataTable("select du.AutoNo,SlNo as 'Serial NO',convert(datetime,TheDate,103) as 'Date',i.ItemName as 'Item Name',i.IGroup as 'Item Group',cast(qty as decimal(10,2)) as 'Quantity',convert(time,GenOnTime,108) as 'Genarator On Time',convert(time,GenOffTime,108) as 'Genarator off Time',du.rmk as 'Remarks' from DieselUse as du,ItemInfo as i where i.ItemCode = du.ItemCode");
            GridSrc.Refresh();

            //lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            GridSrc.Columns[0].Visible = false;
           // chkPurOrItem = "Purchased";
            txtSrcText.Select();
        }

        private void txtSrcText_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSrcText.Text.Trim() != "")
            {
                GridSrc.DataSource = SvCls.GblDataTable("select du.AutoNo,SlNo as 'Serial NO',convert(datetime,TheDate,103) as 'Date',i.ItemName as 'Item Name',i.IGroup as 'Item Group',cast(qty as decimal(10,2)) as 'Quantity',convert(time,GenOnTime,108) as 'Genarator On Time',convert(time,GenOffTime,108) as 'Genarator off Time',du.rmk as 'Remarks' from DieselUse as du,ItemInfo as i where i.ItemCode = du.ItemCode and (i.ItemName LIKE '%" + txtSrcText.Text.Trim() + "%')");
                GridSrc.Refresh();
                GridSrc.Columns[0].Visible = false;
            }
        }

        private void btnCloseSrc_Click(object sender, EventArgs e)
        {
            grpSrc.Visible = false;
        }

        private void txtSrcText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSrcText.Text == "")
            {
                if (e.KeyChar.ToString() == "\r")
                {
                    grpSrc.Visible = false;
                    cboComName.Focus();
                }
            }
        }

        private void txtSrcText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                GridSrc.Focus();
            }
        }
    }
}
