namespace FlexMold.Forms
{
    partial class FrmDashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tpProject = new System.Windows.Forms.TabPage();
            this.INFOPANEL = new System.Windows.Forms.Panel();
            this.CSVFILEPANEL = new System.Windows.Forms.Panel();
            this.dgvcsvfiles = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listLaserFiles = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbpanel = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbparentfolder = new System.Windows.Forms.ComboBox();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.tabControl1.SuspendLayout();
            this.tpProject.SuspendLayout();
            this.INFOPANEL.SuspendLayout();
            this.CSVFILEPANEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcsvfiles)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tpProject);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(12, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(888, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // tpProject
            // 
            this.tpProject.BackColor = System.Drawing.Color.Transparent;
            this.tpProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpProject.Controls.Add(this.INFOPANEL);
            this.tpProject.Controls.Add(this.CSVFILEPANEL);
            this.tpProject.Controls.Add(this.panel2);
            this.tpProject.Controls.Add(this.panel1);
            this.tpProject.Location = new System.Drawing.Point(4, 29);
            this.tpProject.Name = "tpProject";
            this.tpProject.Padding = new System.Windows.Forms.Padding(3);
            this.tpProject.Size = new System.Drawing.Size(888, 378);
            this.tpProject.TabIndex = 1;
            this.tpProject.Text = "Project";
            // 
            // INFOPANEL
            // 
            this.INFOPANEL.Controls.Add(this.metroSetLabel1);
            this.INFOPANEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.INFOPANEL.Location = new System.Drawing.Point(463, 3);
            this.INFOPANEL.Name = "INFOPANEL";
            this.INFOPANEL.Size = new System.Drawing.Size(420, 141);
            this.INFOPANEL.TabIndex = 3;
            // 
            // CSVFILEPANEL
            // 
            this.CSVFILEPANEL.Controls.Add(this.dgvcsvfiles);
            this.CSVFILEPANEL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CSVFILEPANEL.Location = new System.Drawing.Point(463, 144);
            this.CSVFILEPANEL.Name = "CSVFILEPANEL";
            this.CSVFILEPANEL.Size = new System.Drawing.Size(420, 229);
            this.CSVFILEPANEL.TabIndex = 2;
            // 
            // dgvcsvfiles
            // 
            this.dgvcsvfiles.AllowUserToAddRows = false;
            this.dgvcsvfiles.AllowUserToDeleteRows = false;
            this.dgvcsvfiles.AllowUserToResizeColumns = false;
            this.dgvcsvfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcsvfiles.ColumnHeadersVisible = false;
            this.dgvcsvfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcsvfiles.Location = new System.Drawing.Point(0, 0);
            this.dgvcsvfiles.Name = "dgvcsvfiles";
            this.dgvcsvfiles.Size = new System.Drawing.Size(420, 229);
            this.dgvcsvfiles.TabIndex = 0;
            this.dgvcsvfiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcsvfiles_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.listLaserFiles);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(233, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 370);
            this.panel2.TabIndex = 1;
            // 
            // listLaserFiles
            // 
            this.listLaserFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLaserFiles.FormattingEnabled = true;
            this.listLaserFiles.ItemHeight = 20;
            this.listLaserFiles.Location = new System.Drawing.Point(0, 0);
            this.listLaserFiles.Name = "listLaserFiles";
            this.listLaserFiles.Size = new System.Drawing.Size(226, 366);
            this.listLaserFiles.TabIndex = 0;
            this.listLaserFiles.SelectedIndexChanged += new System.EventHandler(this.listLaserFiles_SelectedIndexChanged);
            this.listLaserFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listLaserFiles_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 370);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbpanel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 152);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Panel";
            // 
            // cmbpanel
            // 
            this.cmbpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbpanel.FormattingEnabled = true;
            this.cmbpanel.Location = new System.Drawing.Point(3, 23);
            this.cmbpanel.Name = "cmbpanel";
            this.cmbpanel.Size = new System.Drawing.Size(220, 28);
            this.cmbpanel.TabIndex = 0;
            this.cmbpanel.SelectedIndexChanged += new System.EventHandler(this.cmbpanel_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbparentfolder);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project";
            // 
            // cmbparentfolder
            // 
            this.cmbparentfolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbparentfolder.FormattingEnabled = true;
            this.cmbparentfolder.Location = new System.Drawing.Point(3, 23);
            this.cmbparentfolder.Name = "cmbparentfolder";
            this.cmbparentfolder.Size = new System.Drawing.Size(220, 28);
            this.cmbparentfolder.TabIndex = 0;
            this.cmbparentfolder.SelectedIndexChanged += new System.EventHandler(this.cmbparentfolder_SelectedIndexChanged);
            this.cmbparentfolder.SelectedValueChanged += new System.EventHandler(this.cmbparentfolder_SelectedValueChanged);
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(820, 2);
            this.metroSetControlBox1.MaximizeBox = false;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 1;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(28, 29);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(211, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 0;
            this.metroSetLabel1.Text = "Panel Info";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 493);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tpProject.ResumeLayout(false);
            this.INFOPANEL.ResumeLayout(false);
            this.CSVFILEPANEL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcsvfiles)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpProject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbparentfolder;
        private System.Windows.Forms.ComboBox cmbpanel;
        private System.Windows.Forms.ListBox listLaserFiles;
        private System.Windows.Forms.Panel INFOPANEL;
        private System.Windows.Forms.Panel CSVFILEPANEL;
        private System.Windows.Forms.DataGridView dgvcsvfiles;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
    }
}