namespace ERP
{
    partial class AdvanceAdjustment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvanceAdjustment));
            this.Grid = new System.Windows.Forms.DataGridView();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.lblWaitIco = new System.Windows.Forms.Label();
            this.lblDelIco = new System.Windows.Forms.Label();
            this.lblInfoIco = new System.Windows.Forms.Label();
            this.lblSadIco = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblMsgIco = new System.Windows.Forms.Label();
            this.MsgTimer = new System.Windows.Forms.Timer(this.components);
            this.lblShowTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 308);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(1076, 330);
            this.Grid.TabIndex = 167;
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PanelTop.Controls.Add(this.lblWaitIco);
            this.PanelTop.Controls.Add(this.lblDelIco);
            this.PanelTop.Controls.Add(this.lblInfoIco);
            this.PanelTop.Controls.Add(this.lblSadIco);
            this.PanelTop.Controls.Add(this.lblMsg);
            this.PanelTop.Controls.Add(this.label26);
            this.PanelTop.Controls.Add(this.lblMsgIco);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1100, 30);
            this.PanelTop.TabIndex = 168;
            // 
            // lblWaitIco
            // 
            this.lblWaitIco.BackColor = System.Drawing.Color.Transparent;
            this.lblWaitIco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitIco.ForeColor = System.Drawing.Color.Transparent;
            this.lblWaitIco.Image = ((System.Drawing.Image)(resources.GetObject("lblWaitIco.Image")));
            this.lblWaitIco.Location = new System.Drawing.Point(3, 3);
            this.lblWaitIco.Name = "lblWaitIco";
            this.lblWaitIco.Size = new System.Drawing.Size(31, 24);
            this.lblWaitIco.TabIndex = 69;
            this.lblWaitIco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWaitIco.Visible = false;
            // 
            // lblDelIco
            // 
            this.lblDelIco.BackColor = System.Drawing.Color.Transparent;
            this.lblDelIco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelIco.ForeColor = System.Drawing.Color.Transparent;
            this.lblDelIco.Image = ((System.Drawing.Image)(resources.GetObject("lblDelIco.Image")));
            this.lblDelIco.Location = new System.Drawing.Point(3, 3);
            this.lblDelIco.Name = "lblDelIco";
            this.lblDelIco.Size = new System.Drawing.Size(31, 24);
            this.lblDelIco.TabIndex = 68;
            this.lblDelIco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDelIco.Visible = false;
            // 
            // lblInfoIco
            // 
            this.lblInfoIco.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoIco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoIco.ForeColor = System.Drawing.Color.Transparent;
            this.lblInfoIco.Image = ((System.Drawing.Image)(resources.GetObject("lblInfoIco.Image")));
            this.lblInfoIco.Location = new System.Drawing.Point(3, 3);
            this.lblInfoIco.Name = "lblInfoIco";
            this.lblInfoIco.Size = new System.Drawing.Size(31, 24);
            this.lblInfoIco.TabIndex = 67;
            this.lblInfoIco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSadIco
            // 
            this.lblSadIco.BackColor = System.Drawing.Color.Transparent;
            this.lblSadIco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSadIco.ForeColor = System.Drawing.Color.Transparent;
            this.lblSadIco.Image = ((System.Drawing.Image)(resources.GetObject("lblSadIco.Image")));
            this.lblSadIco.Location = new System.Drawing.Point(3, 3);
            this.lblSadIco.Name = "lblSadIco";
            this.lblSadIco.Size = new System.Drawing.Size(31, 24);
            this.lblSadIco.TabIndex = 66;
            this.lblSadIco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSadIco.Visible = false;
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.White;
            this.lblMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMsg.Location = new System.Drawing.Point(32, 2);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(377, 26);
            this.lblMsg.TabIndex = 64;
            this.lblMsg.Text = "Notification...";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(934, 4);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(191, 23);
            this.label26.TabIndex = 0;
            this.label26.Text = "Advance Adjustment...";
            // 
            // lblMsgIco
            // 
            this.lblMsgIco.BackColor = System.Drawing.Color.Transparent;
            this.lblMsgIco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgIco.ForeColor = System.Drawing.Color.White;
            this.lblMsgIco.Image = ((System.Drawing.Image)(resources.GetObject("lblMsgIco.Image")));
            this.lblMsgIco.Location = new System.Drawing.Point(3, 3);
            this.lblMsgIco.Name = "lblMsgIco";
            this.lblMsgIco.Size = new System.Drawing.Size(31, 24);
            this.lblMsgIco.TabIndex = 65;
            this.lblMsgIco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMsgIco.Visible = false;
            // 
            // MsgTimer
            // 
            this.MsgTimer.Enabled = true;
            this.MsgTimer.Interval = 5000;
            this.MsgTimer.Tick += new System.EventHandler(this.MsgTimer_Tick);
            // 
            // lblShowTotal
            // 
            this.lblShowTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblShowTotal.ForeColor = System.Drawing.Color.White;
            this.lblShowTotal.Location = new System.Drawing.Point(933, 282);
            this.lblShowTotal.Name = "lblShowTotal";
            this.lblShowTotal.Size = new System.Drawing.Size(155, 23);
            this.lblShowTotal.TabIndex = 169;
            this.lblShowTotal.Text = "Total Record : 0";
            this.lblShowTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdvanceAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.lblShowTotal);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.Grid);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdvanceAdjustment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdvanceAdjustment";
            this.Load += new System.EventHandler(this.AdvanceAdjustment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label lblWaitIco;
        private System.Windows.Forms.Label lblDelIco;
        private System.Windows.Forms.Label lblInfoIco;
        private System.Windows.Forms.Label lblSadIco;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblMsgIco;
        private System.Windows.Forms.Timer MsgTimer;
        private System.Windows.Forms.Label lblShowTotal;
    }
}