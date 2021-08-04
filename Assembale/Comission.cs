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
    public partial class Comission : Form
    {
        ClsMain SvCls = new ClsMain();
        string qry = "";

        public Comission()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private void Comission_Load(object sender, EventArgs e)
        {
            cboPartyCode.Select();
            btnLoadCombo_Click_1(null, null);
            Grid_Head(null,null);
        }

        private void Grid_Head(object sender, EventArgs e)
        {
            GridParty.DataSource = SvCls.GblDataTable("Select PartyCode as[Party Code],PartyName as[Party Name],Phone from PartyInfo");
            GridParty.Refresh();

            lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();
            // Grid.Columns[0].Visible = false;
        }
        private void btnLoadCombo_Click(object sender, EventArgs e)
        {          
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cboPartyCode.Text.Trim() == "")
            {
                MessageBox.Show("Party Code Can't be Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPartyCode.Select();
                return;
            }
            if (cboPartyName.Text.Trim() == "")
            {
                MessageBox.Show("Party Name Can't be Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPartyName.Select();
                return;
            }
            if (cboItemCode.Text.Trim() == "")
            {
                MessageBox.Show("Item Code Can't be Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboItemCode.Select();
                return;
            }
            if (cboItemName.Text.Trim() == "")
            {
                MessageBox.Show("Item Name Can't be Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboItemName.Select();
                return;
            }


            string SaveQry;
            string SelectQry;
            string EdtQry;

            SaveQry = "Insert into Commission(ComId,PartyCode,ItemCode,ItemAutoNo,Perc,Conv,Transport,BaseCom,MonCom,YearlyCom,Rmk,PcName,UserCode,UserIP)values('" + ClsVar.GblComId + "','" + cboPartyCode.Text.Trim() + "','" + cboItemCode.Text.Trim() + "','" + txtItemAutoNo.Text.Trim() + "'," + txtPerc.Text.Trim() + "," + txtConv.Text.Trim() + "," + txtTrans.Text.Trim() + "," + txtBaseCom.Text.Trim() + "," + txtMonCom.Text.Trim() + "," + txtYearlyCom.Text.Trim() + ",'" + cboRmk.Text.Trim() + "','" + ClsVar.GblPcName + "','" + ClsVar.GblUserId + "','" + ClsVar.GblUserIp + "')";
            SelectQry = "Select ComId,ItemCode,ItemAutoNo,Perc,Conv,Transport,BaseCom,YearlyCom,Rmk,ComName,PcName,UserCode,UserIP from Commission where PartyCode='" + cboPartyCode.Text.Trim() + "'";
            EdtQry = "Update Commission set ComId='" + ClsVar.GblComId + "',ItemCode='" + cboItemCode.Text.Trim() + "',Perc=" + txtPerc.Text.Trim() + ",Conv=" + txtConv.Text.Trim() + ",Transport=" + txtTrans.Text.Trim() + ",BaseCom=" + txtBaseCom.Text.Trim() + ",YearlyCom=" + txtYearlyCom.Text.Trim() + ",Rmk='" + cboRmk.Text.Trim() + "',PcName='" + ClsVar.GblPcName + "',UserCode='" + ClsVar.GblUserId + "',UserIP='" + ClsVar.GblUserIp + "' where PartyCode='" + cboPartyCode.Text.Trim() + "' and ItemCode='" + cboItemCode.Text.Trim() + "'";

            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {
                SvCls.insertUpdate(SaveQry);
                ShowMessage("save", "");
                btnSave.Text = "Edit";
                btnAddNew.Focus();
            }
            else
            {
                SvCls.insertUpdate(EdtQry);
                ShowMessage("update", "");
                btnAddNew.Focus();
            }
            btnLoadGridData_Click(null,null);
            
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboPartyCode_Leave(object sender, EventArgs e)
        {
            if (cboPartyCode.Text.Trim() != "")
            {
                SvCls.toGetData("Select p.PartyName,c.ItemCode,i.ItemName,i.ShortName,c.ItemAutoNo,cast(c.Perc as decimal(10,2)) as Perc,cast(c.Conv as decimal(10,2)) as Conv,cast(c.Transport as decimal(10,2)) as Transport,cast(c.BaseCom as decimal(10,2)) as BaseCom,cast(c.MonCom as decimal(10,2))as MonCom,cast(c.YearlyCom as decimal(10,2)) as YearlyCom,c.Rmk from Commission C ,PartyInfo p,ItemInfo i where c.PartyCode=p.PartyCode and c.ItemCode=i.ItemCode and c.PartyCode='" + cboPartyCode.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboPartyName.Text = SvCls.GblRdrToGetData["PartyName"].ToString();
                    cboItemCode.Text = SvCls.GblRdrToGetData["ItemCode"].ToString();
                    cboItemName.Text = SvCls.GblRdrToGetData["ItemName"].ToString();
                    cboShortName.Text = SvCls.GblRdrToGetData["ShortName"].ToString();
                    txtItemAutoNo.Text = SvCls.GblRdrToGetData["ItemAutoNo"].ToString();
                    txtPerc.Text = SvCls.GblRdrToGetData["Perc"].ToString();
                    txtConv.Text = SvCls.GblRdrToGetData["Conv"].ToString();

                    txtTrans.Text = SvCls.GblRdrToGetData["Transport"].ToString();
                    txtBaseCom.Text = SvCls.GblRdrToGetData["BaseCom"].ToString();
                    txtMonCom.Text = SvCls.GblRdrToGetData["MonCom"].ToString();
                    txtYearlyCom.Text = SvCls.GblRdrToGetData["YearlyCom"].ToString();
                    cboRmk.Text = SvCls.GblRdrToGetData["Rmk"].ToString();                    
                }
                else
                {
                    ShowMessage("not found", "");

                    //cboPartyName.Text = "";
                    //cboItemCode.Text = "";
                    //cboItemName.Text = "";
                    //cboShortName.Text = "";

                    //txtConv.Text = "";
                    //txtItemAutoNo.Text = "";
                    //txtMonCom.Text = "";
                    //txtYearlyCom.Text = "";

                    //txtTrans.Text = "";
                    //cboRmk.Text = "";
                    //txtBaseCom.Text = "";
                    //txtPerc.Text = "";
                }
            }
        }

        private void cboItemCode_Leave(object sender, EventArgs e)
        {
            if (cboItemCode.Text.Trim() != "")
            {
                SvCls.toGetData("Select ItemName,ShortName from ItemInfo where ItemCode='" + cboItemCode.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboItemName.Text = SvCls.GblRdrToGetData["ItemName"].ToString();
                    cboShortName.Text = SvCls.GblRdrToGetData["ShortName"].ToString();                 
                }
                else
                {
                    ShowMessage("not found", "");
                    //cboItemName.Text = "";
                    //cboShortName.Text = "" ;   
      
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboPartyCode.Text = "";
            cboPartyName.Text = "";
            cboItemCode.Text = "";
            cboItemName.Text = "";
            cboShortName.Text = "";

            txtConv.Text = "";
            txtItemAutoNo.Text = "";
            txtMonCom.Text = "";
            txtYearlyCom.Text = "";

            txtTrans.Text = "";
            cboRmk.Text = "";
            txtBaseCom.Text = "";
            txtPerc.Text = "";

            cboPartyCode.Select();
        }

        private void btnLoadCombo_Click_1(object sender, EventArgs e)
        {
            qry = "Select PartyCode from PartyInfo";
            cboPartyCode.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboPartyCode.DisplayMember = "PartyCode";
            cboPartyCode.Text = "";

            qry = "Select ItemCode from ItemInfo";
            cboItemCode.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboItemCode.DisplayMember = "ItemCode";
            cboItemCode.Text = "";

        }

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            Grid.DataSource = SvCls.GblDataTable("Select c.PartyCode as[Party Code],p.PartyName as[Party Name],c.ItemCode as[Item Code],i.ItemName as[Item Name],i.ShortName as[Short Name],c.ItemAutoNo as[Item AutoNo],cast(c.Perc as decimal(10,2)) as [Percentage],cast(c.Conv as decimal(10,2)) as[Convayence],cast(c.Transport as decimal(10,2)) as Transport,cast(c.BaseCom as decimal(10,2)) as [Base Com],cast(c.MonCom as decimal(10,2))as [Monthly Com],cast(c.YearlyCom as decimal(10,2)) as [Yearly Com],c.Rmk as[Remarks] from Commission C ,PartyInfo p,ItemInfo i where c.PartyCode=p.PartyCode and c.ItemCode=i.ItemCode ");
            Grid.Refresh();
            lblShowTotal.Text = "Total : " + Grid.Rows.Count.ToString();           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboPartyCode.Text.Trim() == "")
            {
                MessageBox.Show("Please, Enter valid Party Code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboPartyCode.Select();
                return;
            }
            string Qry;           
            Qry = "Delete from Commission where PartyCode='" + cboPartyCode.Text.Trim() + "'";
            if (MessageBox.Show("Do you realy want to delete ?", "Powerpoint Technologies.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {             
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

            }
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            cboPartyCode.Text = Grid.Rows[i].Cells[0].Value.ToString();
            cboPartyCode_Leave(null, null);

            cboPartyCode.Focus();
        }

        private void cboPartyCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboPartyName.Select();
            }
        }

        private void cboPartyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboItemCode.Select();
            }
        }

        private void cboItemCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboShortName.Select();
            }
        }

        private void cboShortName_KeyPress(object sender, KeyPressEventArgs e)
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
                txtPerc.Select();
            }
        }

        private void txtPerc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtConv.Select();
            }
        }

        private void txtConv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtTrans.Select();
            }
        }

        private void txtTrans_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtBaseCom.Select();
            }
        }

        private void txtBaseCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtMonCom.Select();
            }
        }

        private void txtMonCom_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txtMonCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtYearlyCom.Select();
            }
        }

        private void txtYearlyCom_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                Grid.Select();
            }
        }

        private void Grid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnClear.Select();
            }
        }

        private void btnClear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboPartyCode.Select();
            }
        }

        private void GridParty_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = GridParty.SelectedCells[0].RowIndex;
            cboPartyCode.Text = Grid.Rows[i].Cells[0].Value.ToString();
            cboPartyName.Text = Grid.Rows[i].Cells[1].Value.ToString();
        }
    }
}

