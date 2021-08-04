using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;

        public MDIParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void SetDateFormat()
        {
            //using Microsoft.Win32;
            //Get Data From Text Boxes


            string DateFormat = "dd/MM/yyyy";

            //string TimeFormat = txtTimeFormat.Text.Trim();

            //string Currency = txtCurrency.Text.Trim();



            //Registry Logic

            //Open Sub key

            RegistryKey rkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);

            ///Set Values

            //rkey.SetValue("sTimeFormat", TimeFormat);

            rkey.SetValue("sShortDate", DateFormat);

            //rkey.SetValue("sCurrency", Currency);

            //Close the Registry

            rkey.Close();


        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
            SetDateFormat();

            StreamReader sr = new StreamReader(Application.StartupPath + "\\check.sys");
            ClsVar.ServerName = sr.ReadLine();
            ClsVar.DataBaseName = sr.ReadLine();
            ClsVar.SqlPassword = sr.ReadLine();
            ClsVar.SqlUId = sr.ReadLine();
            ClsVar.gblPwdFroShow = sr.ReadLine();
            ClsVar.directPrint = sr.ReadLine();
            sr.Close();

            ClsMain SvCls = new ClsMain();

            SvCls.toGetData("select host_name()");
            if (SvCls.GblRdrToGetData.Read())
            {
                ClsVar.GblPcName = SvCls.GblRdrToGetData[""].ToString();
            }

            //this.Text = "ERP System For " + ClsVar.GblComName + " (Connected to " + ClsVar.ServerName + ") (" + ClsVar.GblUserId + ")";
        }


        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartyInfo frm = new PartyInfo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void partyCreditInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartyCreditInfo frm = new PartyCreditInfo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void createBankACToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateBankAc frm = new CreateBankAc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void voucherEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VoucherEntry frm = new VoucherEntry();
            frm.MdiParent = this;
            frm.Show();
        }

        private void itemInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemInfo frm = new ItemInfo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void employeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee frm = new Employee();
            frm.MdiParent = this;
            frm.Show();
        }

        private void challanEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Challan frm = new Challan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void companyInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company frm = new Company();
            frm.MdiParent = this;
            frm.Show();
        }

        private void batchInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BatchInfo frm = new BatchInfo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void vehicleInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleInfo frm = new VehicleInfo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void responsibilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResInfo frm = new ResInfo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void warehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Warehouse frm = new Warehouse();
            frm.MdiParent = this;
            frm.Show();
        }

        private void designationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Designation frm = new Designation();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Section frm = new Section();
            frm.MdiParent = this;
            frm.Show();
        }

        private void userCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserCreation frm = new UserCreation();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eggSettingFuctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EggSettingConfig frm = new EggSettingConfig();
            frm.MdiParent = this;
            frm.Show();

        }

        private void purchaseReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase frm = new Purchase();
            frm.MdiParent = this;
            frm.Show();
        }

        private void invoiceSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale frm = new Sale();
            frm.MdiParent = this;
            frm.Show();
        }

        private void comissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comission frm = new Comission();
            frm.MdiParent = this;
            frm.Show();
        }

        private void diselToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DieselUsage frm = new DieselUsage();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dairyProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DairyProduction frm = new DairyProduction();
            frm.MdiParent = this;
            frm.Show();
        }

        private void globalSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings frm = new Settings();
            frm.MdiParent = this;
            frm.Show();
        }

        private void productionDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductionDelivery frm = new ProductionDelivery();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dailyAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyAttn frm = new DailyAttn();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eggProductionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EggProduction frm = new EggProduction();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eggSettingToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EggSetting frm = new EggSetting();
            frm.MdiParent = this;
            frm.Show();
        }

        private void advancePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Advance frm = new Advance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void advanceAdjustmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdvanceAdjustment frm = new AdvanceAdjustment();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
