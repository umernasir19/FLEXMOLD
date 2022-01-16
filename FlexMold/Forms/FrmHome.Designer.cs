namespace FlexMold.Forms
{
    partial class FrmHome
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.TbContrl = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tbhome = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroSetTile1 = new MetroSet_UI.Controls.MetroSetTile();
            this.tbProject = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.tabllayoutmain = new System.Windows.Forms.TableLayoutPanel();
            this.btnexecutecsv = new MetroSet_UI.Controls.MetroSetButton();
            this.Parent = new System.Windows.Forms.GroupBox();
            this.cmbparentfolder = new MetroSet_UI.Controls.MetroSetComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbpanel = new MetroSet_UI.Controls.MetroSetComboBox();
            this.grpboxlaserfiles = new System.Windows.Forms.GroupBox();
            this.cmlaserfiles = new MetroSet_UI.Controls.MetroSetComboBox();
            this.grpboxcsvFiles = new System.Windows.Forms.GroupBox();
            this.btnexecutelasfile = new MetroSet_UI.Controls.MetroSetButton();
            this.tbllayoutinneruser = new System.Windows.Forms.TableLayoutPanel();
            this.btnsavecsv = new MetroSet_UI.Controls.MetroSetButton();
            this.btnincrement = new MetroSet_UI.Controls.MetroSetButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtboxnewvaue = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtboxMaxValue = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtBoxMinValue = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroSetSetTabPage1 = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.metroSetPanel4 = new MetroSet_UI.Controls.MetroSetPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtfilepath = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbllayoutpanelsysinfo = new System.Windows.Forms.TableLayoutPanel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnmotorlimt = new MetroSet_UI.Controls.MetroSetButton();
            this.nmrcmotorvalue = new System.Windows.Forms.NumericUpDown();
            this.metroSetSetTabPage2 = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.cmbcsvfiles = new MetroSet_UI.Controls.MetroSetComboBox();
            this.TbContrl.SuspendLayout();
            this.tbhome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tbProject.SuspendLayout();
            this.tabllayoutmain.SuspendLayout();
            this.Parent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpboxlaserfiles.SuspendLayout();
            this.grpboxcsvFiles.SuspendLayout();
            this.tbllayoutinneruser.SuspendLayout();
            this.metroSetSetTabPage1.SuspendLayout();
            this.metroSetPanel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tbllayoutpanelsysinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcmotorvalue)).BeginInit();
            this.SuspendLayout();
            // 
            // TbContrl
            // 
            this.TbContrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbContrl.AnimateEasingType = MetroSet_UI.Enums.EasingType.None;
            this.TbContrl.AnimateTime = 800;
            this.TbContrl.BackgroundColor = System.Drawing.Color.White;
            this.TbContrl.Controls.Add(this.tbhome);
            this.TbContrl.Controls.Add(this.tbProject);
            this.TbContrl.Controls.Add(this.metroSetSetTabPage1);
            this.TbContrl.Controls.Add(this.metroSetSetTabPage2);
            this.TbContrl.Cursor = System.Windows.Forms.Cursors.Default;
            this.TbContrl.IsDerivedStyle = true;
            this.TbContrl.ItemSize = new System.Drawing.Size(100, 38);
            this.TbContrl.Location = new System.Drawing.Point(12, 70);
            this.TbContrl.Name = "TbContrl";
            this.TbContrl.SelectedIndex = 1;
            this.TbContrl.SelectedTextColor = System.Drawing.Color.White;
            this.TbContrl.Size = new System.Drawing.Size(835, 519);
            this.TbContrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TbContrl.Speed = 100;
            this.TbContrl.Style = MetroSet_UI.Enums.Style.Light;
            this.TbContrl.StyleManager = null;
            this.TbContrl.TabIndex = 0;
            this.TbContrl.ThemeAuthor = "Narwin";
            this.TbContrl.ThemeName = "MetroLite";
            this.TbContrl.UnselectedTextColor = System.Drawing.Color.Gray;
            this.TbContrl.UseAnimation = false;
            // 
            // tbhome
            // 
            this.tbhome.BaseColor = System.Drawing.Color.White;
            this.tbhome.Controls.Add(this.chart1);
            this.tbhome.Controls.Add(this.metroSetTile1);
            this.tbhome.Font = null;
            this.tbhome.ImageIndex = 0;
            this.tbhome.ImageKey = null;
            this.tbhome.IsDerivedStyle = true;
            this.tbhome.Location = new System.Drawing.Point(4, 42);
            this.tbhome.Name = "tbhome";
            this.tbhome.Size = new System.Drawing.Size(827, 473);
            this.tbhome.Style = MetroSet_UI.Enums.Style.Light;
            this.tbhome.StyleManager = null;
            this.tbhome.TabIndex = 0;
            this.tbhome.Text = "Home";
            this.tbhome.ThemeAuthor = "Narwin";
            this.tbhome.ThemeName = "MetroLite";
            this.tbhome.ToolTipText = null;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 46);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Motor";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Laser";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Error";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Rotation";
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(827, 341);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart";
            title9.Name = "Motor Info";
            title10.Name = "Machine Info";
            title11.Name = "Timer";
            title12.Name = "Cycles";
            this.chart1.Titles.Add(title9);
            this.chart1.Titles.Add(title10);
            this.chart1.Titles.Add(title11);
            this.chart1.Titles.Add(title12);
            // 
            // metroSetTile1
            // 
            this.metroSetTile1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTile1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTile1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTile1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroSetTile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTile1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.metroSetTile1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetTile1.IsDerivedStyle = true;
            this.metroSetTile1.Location = new System.Drawing.Point(0, 0);
            this.metroSetTile1.Name = "metroSetTile1";
            this.metroSetTile1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetTile1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.PressTextColor = System.Drawing.Color.White;
            this.metroSetTile1.Size = new System.Drawing.Size(827, 46);
            this.metroSetTile1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTile1.StyleManager = null;
            this.metroSetTile1.TabIndex = 0;
            this.metroSetTile1.Text = "System Status";
            this.metroSetTile1.ThemeAuthor = "Narwin";
            this.metroSetTile1.ThemeName = "MetroLite";
            this.metroSetTile1.TileAlign = MetroSet_UI.Enums.TileAlign.BottomCenter;
            // 
            // tbProject
            // 
            this.tbProject.BaseColor = System.Drawing.Color.White;
            this.tbProject.Controls.Add(this.tabllayoutmain);
            this.tbProject.Font = null;
            this.tbProject.ImageIndex = 0;
            this.tbProject.ImageKey = null;
            this.tbProject.IsDerivedStyle = true;
            this.tbProject.Location = new System.Drawing.Point(4, 42);
            this.tbProject.Name = "tbProject";
            this.tbProject.Size = new System.Drawing.Size(827, 473);
            this.tbProject.Style = MetroSet_UI.Enums.Style.Light;
            this.tbProject.StyleManager = null;
            this.tbProject.TabIndex = 1;
            this.tbProject.Text = "Project";
            this.tbProject.ThemeAuthor = "Narwin";
            this.tbProject.ThemeName = "MetroLite";
            this.tbProject.ToolTipText = null;
            // 
            // tabllayoutmain
            // 
            this.tabllayoutmain.ColumnCount = 2;
            this.tabllayoutmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.18138F));
            this.tabllayoutmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.81862F));
            this.tabllayoutmain.Controls.Add(this.btnexecutecsv, 1, 2);
            this.tabllayoutmain.Controls.Add(this.Parent, 0, 0);
            this.tabllayoutmain.Controls.Add(this.groupBox1, 1, 0);
            this.tabllayoutmain.Controls.Add(this.grpboxlaserfiles, 0, 1);
            this.tabllayoutmain.Controls.Add(this.grpboxcsvFiles, 1, 1);
            this.tabllayoutmain.Controls.Add(this.btnexecutelasfile, 0, 2);
            this.tabllayoutmain.Controls.Add(this.tbllayoutinneruser, 0, 3);
            this.tabllayoutmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabllayoutmain.Location = new System.Drawing.Point(0, 0);
            this.tabllayoutmain.Name = "tabllayoutmain";
            this.tabllayoutmain.RowCount = 4;
            this.tabllayoutmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.28198F));
            this.tabllayoutmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.02089F));
            this.tabllayoutmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.62791F));
            this.tabllayoutmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.38055F));
            this.tabllayoutmain.Size = new System.Drawing.Size(827, 473);
            this.tabllayoutmain.TabIndex = 3;
            // 
            // btnexecutecsv
            // 
            this.btnexecutecsv.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnexecutecsv.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnexecutecsv.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnexecutecsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnexecutecsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnexecutecsv.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnexecutecsv.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnexecutecsv.HoverTextColor = System.Drawing.Color.White;
            this.btnexecutecsv.IsDerivedStyle = true;
            this.btnexecutecsv.Location = new System.Drawing.Point(418, 230);
            this.btnexecutecsv.Name = "btnexecutecsv";
            this.btnexecutecsv.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnexecutecsv.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnexecutecsv.NormalTextColor = System.Drawing.Color.White;
            this.btnexecutecsv.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnexecutecsv.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnexecutecsv.PressTextColor = System.Drawing.Color.White;
            this.btnexecutecsv.Size = new System.Drawing.Size(406, 48);
            this.btnexecutecsv.Style = MetroSet_UI.Enums.Style.Light;
            this.btnexecutecsv.StyleManager = null;
            this.btnexecutecsv.TabIndex = 5;
            this.btnexecutecsv.Text = "Execute CSV File";
            this.btnexecutecsv.ThemeAuthor = "Narwin";
            this.btnexecutecsv.ThemeName = "MetroLite";
            this.btnexecutecsv.Click += new System.EventHandler(this.btncsvfile_Click);
            // 
            // Parent
            // 
            this.Parent.Controls.Add(this.cmbparentfolder);
            this.Parent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Parent.ForeColor = System.Drawing.Color.Black;
            this.Parent.Location = new System.Drawing.Point(3, 3);
            this.Parent.Name = "Parent";
            this.Parent.Size = new System.Drawing.Size(409, 108);
            this.Parent.TabIndex = 0;
            this.Parent.TabStop = false;
            this.Parent.Text = "Project";
            // 
            // cmbparentfolder
            // 
            this.cmbparentfolder.AllowDrop = true;
            this.cmbparentfolder.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbparentfolder.BackColor = System.Drawing.Color.Transparent;
            this.cmbparentfolder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbparentfolder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbparentfolder.CausesValidation = false;
            this.cmbparentfolder.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbparentfolder.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbparentfolder.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbparentfolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbparentfolder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbparentfolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbparentfolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbparentfolder.FormattingEnabled = true;
            this.cmbparentfolder.IsDerivedStyle = true;
            this.cmbparentfolder.ItemHeight = 50;
            this.cmbparentfolder.Location = new System.Drawing.Point(3, 19);
            this.cmbparentfolder.Name = "cmbparentfolder";
            this.cmbparentfolder.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbparentfolder.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbparentfolder.Size = new System.Drawing.Size(403, 56);
            this.cmbparentfolder.Style = MetroSet_UI.Enums.Style.Light;
            this.cmbparentfolder.StyleManager = null;
            this.cmbparentfolder.TabIndex = 0;
            this.cmbparentfolder.ThemeAuthor = "Narwin";
            this.cmbparentfolder.ThemeName = "MetroLite";
            this.cmbparentfolder.SelectedIndexChanged += new System.EventHandler(this.cmbparentfolder_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbpanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(418, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel";
            // 
            // cmbpanel
            // 
            this.cmbpanel.AllowDrop = true;
            this.cmbpanel.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbpanel.BackColor = System.Drawing.Color.Transparent;
            this.cmbpanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbpanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbpanel.CausesValidation = false;
            this.cmbpanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbpanel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbpanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbpanel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbpanel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbpanel.FormattingEnabled = true;
            this.cmbpanel.IsDerivedStyle = true;
            this.cmbpanel.ItemHeight = 50;
            this.cmbpanel.Location = new System.Drawing.Point(3, 19);
            this.cmbpanel.Name = "cmbpanel";
            this.cmbpanel.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbpanel.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbpanel.Size = new System.Drawing.Size(400, 56);
            this.cmbpanel.Style = MetroSet_UI.Enums.Style.Light;
            this.cmbpanel.StyleManager = null;
            this.cmbpanel.TabIndex = 1;
            this.cmbpanel.ThemeAuthor = "Narwin";
            this.cmbpanel.ThemeName = "MetroLite";
            this.cmbpanel.SelectedIndexChanged += new System.EventHandler(this.cmbpanel_SelectedIndexChanged);
            // 
            // grpboxlaserfiles
            // 
            this.grpboxlaserfiles.Controls.Add(this.cmlaserfiles);
            this.grpboxlaserfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpboxlaserfiles.Location = new System.Drawing.Point(3, 117);
            this.grpboxlaserfiles.Name = "grpboxlaserfiles";
            this.grpboxlaserfiles.Size = new System.Drawing.Size(409, 107);
            this.grpboxlaserfiles.TabIndex = 2;
            this.grpboxlaserfiles.TabStop = false;
            this.grpboxlaserfiles.Text = "Laser Files";
            // 
            // cmlaserfiles
            // 
            this.cmlaserfiles.AllowDrop = true;
            this.cmlaserfiles.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmlaserfiles.BackColor = System.Drawing.Color.Transparent;
            this.cmlaserfiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmlaserfiles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmlaserfiles.CausesValidation = false;
            this.cmlaserfiles.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmlaserfiles.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmlaserfiles.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmlaserfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmlaserfiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmlaserfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmlaserfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmlaserfiles.FormattingEnabled = true;
            this.cmlaserfiles.IsDerivedStyle = true;
            this.cmlaserfiles.ItemHeight = 50;
            this.cmlaserfiles.Location = new System.Drawing.Point(3, 19);
            this.cmlaserfiles.Name = "cmlaserfiles";
            this.cmlaserfiles.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmlaserfiles.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmlaserfiles.Size = new System.Drawing.Size(403, 56);
            this.cmlaserfiles.Style = MetroSet_UI.Enums.Style.Light;
            this.cmlaserfiles.StyleManager = null;
            this.cmlaserfiles.TabIndex = 0;
            this.cmlaserfiles.ThemeAuthor = "Narwin";
            this.cmlaserfiles.ThemeName = "MetroLite";
            // 
            // grpboxcsvFiles
            // 
            this.grpboxcsvFiles.Controls.Add(this.cmbcsvfiles);
            this.grpboxcsvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpboxcsvFiles.Location = new System.Drawing.Point(418, 117);
            this.grpboxcsvFiles.Name = "grpboxcsvFiles";
            this.grpboxcsvFiles.Size = new System.Drawing.Size(406, 107);
            this.grpboxcsvFiles.TabIndex = 3;
            this.grpboxcsvFiles.TabStop = false;
            this.grpboxcsvFiles.Text = "CSV FILES";
            // 
            // btnexecutelasfile
            // 
            this.btnexecutelasfile.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnexecutelasfile.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnexecutelasfile.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnexecutelasfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnexecutelasfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnexecutelasfile.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnexecutelasfile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnexecutelasfile.HoverTextColor = System.Drawing.Color.White;
            this.btnexecutelasfile.IsDerivedStyle = true;
            this.btnexecutelasfile.Location = new System.Drawing.Point(3, 230);
            this.btnexecutelasfile.Name = "btnexecutelasfile";
            this.btnexecutelasfile.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnexecutelasfile.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnexecutelasfile.NormalTextColor = System.Drawing.Color.White;
            this.btnexecutelasfile.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnexecutelasfile.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnexecutelasfile.PressTextColor = System.Drawing.Color.White;
            this.btnexecutelasfile.Size = new System.Drawing.Size(409, 48);
            this.btnexecutelasfile.Style = MetroSet_UI.Enums.Style.Light;
            this.btnexecutelasfile.StyleManager = null;
            this.btnexecutelasfile.TabIndex = 4;
            this.btnexecutelasfile.Text = "Click To Execute Laser File";
            this.btnexecutelasfile.ThemeAuthor = "Narwin";
            this.btnexecutelasfile.ThemeName = "MetroLite";
            this.btnexecutelasfile.Click += new System.EventHandler(this.btnexecutelasfile_Click);
            // 
            // tbllayoutinneruser
            // 
            this.tbllayoutinneruser.ColumnCount = 2;
            this.tbllayoutinneruser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.00978F));
            this.tbllayoutinneruser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.99022F));
            this.tbllayoutinneruser.Controls.Add(this.btnsavecsv, 1, 3);
            this.tbllayoutinneruser.Controls.Add(this.btnincrement, 0, 3);
            this.tbllayoutinneruser.Controls.Add(this.metroLabel4, 0, 2);
            this.tbllayoutinneruser.Controls.Add(this.txtboxnewvaue, 1, 2);
            this.tbllayoutinneruser.Controls.Add(this.metroLabel3, 0, 0);
            this.tbllayoutinneruser.Controls.Add(this.txtboxMaxValue, 1, 0);
            this.tbllayoutinneruser.Controls.Add(this.txtBoxMinValue, 1, 1);
            this.tbllayoutinneruser.Controls.Add(this.metroLabel2, 0, 1);
            this.tbllayoutinneruser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbllayoutinneruser.Location = new System.Drawing.Point(3, 284);
            this.tbllayoutinneruser.Name = "tbllayoutinneruser";
            this.tbllayoutinneruser.RowCount = 5;
            this.tbllayoutinneruser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.16729F));
            this.tbllayoutinneruser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.44702F));
            this.tbllayoutinneruser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.16914F));
            this.tbllayoutinneruser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.21654F));
            this.tbllayoutinneruser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tbllayoutinneruser.Size = new System.Drawing.Size(409, 186);
            this.tbllayoutinneruser.TabIndex = 6;
            // 
            // btnsavecsv
            // 
            this.btnsavecsv.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnsavecsv.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnsavecsv.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnsavecsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsavecsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnsavecsv.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnsavecsv.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnsavecsv.HoverTextColor = System.Drawing.Color.White;
            this.btnsavecsv.IsDerivedStyle = true;
            this.btnsavecsv.Location = new System.Drawing.Point(183, 92);
            this.btnsavecsv.Name = "btnsavecsv";
            this.btnsavecsv.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnsavecsv.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnsavecsv.NormalTextColor = System.Drawing.Color.White;
            this.btnsavecsv.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnsavecsv.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnsavecsv.PressTextColor = System.Drawing.Color.White;
            this.btnsavecsv.Size = new System.Drawing.Size(223, 60);
            this.btnsavecsv.Style = MetroSet_UI.Enums.Style.Light;
            this.btnsavecsv.StyleManager = null;
            this.btnsavecsv.TabIndex = 11;
            this.btnsavecsv.Text = "Save To CSV";
            this.btnsavecsv.ThemeAuthor = "Narwin";
            this.btnsavecsv.ThemeName = "MetroLite";
            this.btnsavecsv.Click += new System.EventHandler(this.btnsavevalue_Click);
            // 
            // btnincrement
            // 
            this.btnincrement.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnincrement.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnincrement.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnincrement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnincrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnincrement.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnincrement.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnincrement.HoverTextColor = System.Drawing.Color.White;
            this.btnincrement.IsDerivedStyle = true;
            this.btnincrement.Location = new System.Drawing.Point(3, 92);
            this.btnincrement.Name = "btnincrement";
            this.btnincrement.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnincrement.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnincrement.NormalTextColor = System.Drawing.Color.White;
            this.btnincrement.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnincrement.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnincrement.PressTextColor = System.Drawing.Color.White;
            this.btnincrement.Size = new System.Drawing.Size(174, 60);
            this.btnincrement.Style = MetroSet_UI.Enums.Style.Light;
            this.btnincrement.StyleManager = null;
            this.btnincrement.TabIndex = 10;
            this.btnincrement.Text = "CLick To Increase Percentage";
            this.btnincrement.ThemeAuthor = "Narwin";
            this.btnincrement.ThemeName = "MetroLite";
            this.btnincrement.Click += new System.EventHandler(this.btnincrement_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel4.Location = new System.Drawing.Point(3, 61);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(174, 28);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "New Motor Value";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtboxnewvaue
            // 
            this.txtboxnewvaue.AutoCompleteCustomSource = null;
            this.txtboxnewvaue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtboxnewvaue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtboxnewvaue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtboxnewvaue.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtboxnewvaue.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtboxnewvaue.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtboxnewvaue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxnewvaue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtboxnewvaue.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtboxnewvaue.Image = null;
            this.txtboxnewvaue.IsDerivedStyle = true;
            this.txtboxnewvaue.Lines = null;
            this.txtboxnewvaue.Location = new System.Drawing.Point(183, 64);
            this.txtboxnewvaue.MaxLength = 32767;
            this.txtboxnewvaue.Multiline = false;
            this.txtboxnewvaue.Name = "txtboxnewvaue";
            this.txtboxnewvaue.ReadOnly = false;
            this.txtboxnewvaue.Size = new System.Drawing.Size(223, 22);
            this.txtboxnewvaue.Style = MetroSet_UI.Enums.Style.Light;
            this.txtboxnewvaue.StyleManager = null;
            this.txtboxnewvaue.TabIndex = 9;
            this.txtboxnewvaue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtboxnewvaue.ThemeAuthor = "Narwin";
            this.txtboxnewvaue.ThemeName = "MetroLite";
            this.txtboxnewvaue.UseSystemPasswordChar = false;
            this.txtboxnewvaue.WatermarkText = "";
            this.txtboxnewvaue.Click += new System.EventHandler(this.txtboxnewvaue_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel3.Location = new System.Drawing.Point(3, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(174, 31);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Max Motor Value";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtboxMaxValue
            // 
            this.txtboxMaxValue.AutoCompleteCustomSource = null;
            this.txtboxMaxValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtboxMaxValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtboxMaxValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtboxMaxValue.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtboxMaxValue.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtboxMaxValue.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtboxMaxValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxMaxValue.Enabled = false;
            this.txtboxMaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtboxMaxValue.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtboxMaxValue.Image = null;
            this.txtboxMaxValue.IsDerivedStyle = true;
            this.txtboxMaxValue.Lines = null;
            this.txtboxMaxValue.Location = new System.Drawing.Point(183, 3);
            this.txtboxMaxValue.MaxLength = 32767;
            this.txtboxMaxValue.Multiline = false;
            this.txtboxMaxValue.Name = "txtboxMaxValue";
            this.txtboxMaxValue.ReadOnly = false;
            this.txtboxMaxValue.Size = new System.Drawing.Size(223, 25);
            this.txtboxMaxValue.Style = MetroSet_UI.Enums.Style.Light;
            this.txtboxMaxValue.StyleManager = null;
            this.txtboxMaxValue.TabIndex = 4;
            this.txtboxMaxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtboxMaxValue.ThemeAuthor = "Narwin";
            this.txtboxMaxValue.ThemeName = "MetroLite";
            this.txtboxMaxValue.UseSystemPasswordChar = false;
            this.txtboxMaxValue.WatermarkText = "";
            // 
            // txtBoxMinValue
            // 
            this.txtBoxMinValue.AutoCompleteCustomSource = null;
            this.txtBoxMinValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBoxMinValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBoxMinValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtBoxMinValue.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBoxMinValue.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtBoxMinValue.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtBoxMinValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxMinValue.Enabled = false;
            this.txtBoxMinValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxMinValue.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtBoxMinValue.Image = null;
            this.txtBoxMinValue.IsDerivedStyle = true;
            this.txtBoxMinValue.Lines = null;
            this.txtBoxMinValue.Location = new System.Drawing.Point(183, 34);
            this.txtBoxMinValue.MaxLength = 32767;
            this.txtBoxMinValue.Multiline = false;
            this.txtBoxMinValue.Name = "txtBoxMinValue";
            this.txtBoxMinValue.ReadOnly = false;
            this.txtBoxMinValue.Size = new System.Drawing.Size(223, 24);
            this.txtBoxMinValue.Style = MetroSet_UI.Enums.Style.Light;
            this.txtBoxMinValue.StyleManager = null;
            this.txtBoxMinValue.TabIndex = 7;
            this.txtBoxMinValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxMinValue.ThemeAuthor = "Narwin";
            this.txtBoxMinValue.ThemeName = "MetroLite";
            this.txtBoxMinValue.UseSystemPasswordChar = false;
            this.txtBoxMinValue.WatermarkText = "";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel2.Location = new System.Drawing.Point(3, 31);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(174, 30);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Min Motor Value";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroSetSetTabPage1
            // 
            this.metroSetSetTabPage1.BaseColor = System.Drawing.Color.White;
            this.metroSetSetTabPage1.Controls.Add(this.metroSetPanel4);
            this.metroSetSetTabPage1.Font = null;
            this.metroSetSetTabPage1.ImageIndex = 0;
            this.metroSetSetTabPage1.ImageKey = null;
            this.metroSetSetTabPage1.IsDerivedStyle = true;
            this.metroSetSetTabPage1.Location = new System.Drawing.Point(4, 42);
            this.metroSetSetTabPage1.Name = "metroSetSetTabPage1";
            this.metroSetSetTabPage1.Size = new System.Drawing.Size(827, 473);
            this.metroSetSetTabPage1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetSetTabPage1.StyleManager = null;
            this.metroSetSetTabPage1.TabIndex = 2;
            this.metroSetSetTabPage1.Text = "System Settings";
            this.metroSetSetTabPage1.ThemeAuthor = "Narwin";
            this.metroSetSetTabPage1.ThemeName = "MetroLite";
            this.metroSetSetTabPage1.ToolTipText = null;
            // 
            // metroSetPanel4
            // 
            this.metroSetPanel4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetPanel4.BorderThickness = 1;
            this.metroSetPanel4.Controls.Add(this.tabControl1);
            this.metroSetPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetPanel4.IsDerivedStyle = true;
            this.metroSetPanel4.Location = new System.Drawing.Point(0, 0);
            this.metroSetPanel4.Name = "metroSetPanel4";
            this.metroSetPanel4.Size = new System.Drawing.Size(827, 473);
            this.metroSetPanel4.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetPanel4.StyleManager = null;
            this.metroSetPanel4.TabIndex = 0;
            this.metroSetPanel4.ThemeAuthor = "Narwin";
            this.metroSetPanel4.ThemeName = "MetroDark";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(827, 473);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.metroSetButton1);
            this.tabPage1.Controls.Add(this.metroSetLabel1);
            this.tabPage1.Controls.Add(this.txtfilepath);
            this.tabPage1.Location = new System.Drawing.Point(25, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(798, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "System Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // metroSetButton1
            // 
            this.metroSetButton1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton1.IsDerivedStyle = true;
            this.metroSetButton1.Location = new System.Drawing.Point(396, 40);
            this.metroSetButton1.Name = "metroSetButton1";
            this.metroSetButton1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Size = new System.Drawing.Size(131, 23);
            this.metroSetButton1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton1.StyleManager = null;
            this.metroSetButton1.TabIndex = 2;
            this.metroSetButton1.Text = "Browse";
            this.metroSetButton1.ThemeAuthor = "Narwin";
            this.metroSetButton1.ThemeName = "MetroLite";
            this.metroSetButton1.Click += new System.EventHandler(this.metroSetButton1_Click);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(6, 14);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 3;
            this.metroSetLabel1.Text = "Select Folder";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // txtfilepath
            // 
            this.txtfilepath.AutoCompleteCustomSource = null;
            this.txtfilepath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtfilepath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtfilepath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtfilepath.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtfilepath.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtfilepath.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtfilepath.Enabled = false;
            this.txtfilepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtfilepath.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtfilepath.Image = null;
            this.txtfilepath.IsDerivedStyle = true;
            this.txtfilepath.Lines = null;
            this.txtfilepath.Location = new System.Drawing.Point(6, 40);
            this.txtfilepath.MaxLength = 32767;
            this.txtfilepath.Multiline = false;
            this.txtfilepath.Name = "txtfilepath";
            this.txtfilepath.ReadOnly = false;
            this.txtfilepath.Size = new System.Drawing.Size(384, 23);
            this.txtfilepath.Style = MetroSet_UI.Enums.Style.Light;
            this.txtfilepath.StyleManager = null;
            this.txtfilepath.TabIndex = 1;
            this.txtfilepath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtfilepath.ThemeAuthor = "Narwin";
            this.txtfilepath.ThemeName = "MetroLite";
            this.txtfilepath.UseSystemPasswordChar = false;
            this.txtfilepath.WatermarkText = "No Folder Selected";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbllayoutpanelsysinfo);
            this.tabPage2.Location = new System.Drawing.Point(25, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(798, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "System Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbllayoutpanelsysinfo
            // 
            this.tbllayoutpanelsysinfo.ColumnCount = 2;
            this.tbllayoutpanelsysinfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.08586F));
            this.tbllayoutpanelsysinfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.91414F));
            this.tbllayoutpanelsysinfo.Controls.Add(this.metroSetLabel2, 0, 0);
            this.tbllayoutpanelsysinfo.Controls.Add(this.btnmotorlimt, 1, 1);
            this.tbllayoutpanelsysinfo.Controls.Add(this.nmrcmotorvalue, 0, 1);
            this.tbllayoutpanelsysinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbllayoutpanelsysinfo.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tbllayoutpanelsysinfo.Location = new System.Drawing.Point(3, 3);
            this.tbllayoutpanelsysinfo.Name = "tbllayoutpanelsysinfo";
            this.tbllayoutpanelsysinfo.RowCount = 3;
            this.tbllayoutpanelsysinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.27273F));
            this.tbllayoutpanelsysinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.72727F));
            this.tbllayoutpanelsysinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 378F));
            this.tbllayoutpanelsysinfo.Size = new System.Drawing.Size(792, 459);
            this.tbllayoutpanelsysinfo.TabIndex = 0;
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(3, 0);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(359, 38);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 1;
            this.metroSetLabel2.Text = "Motor Limit";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // btnmotorlimt
            // 
            this.btnmotorlimt.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnmotorlimt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnmotorlimt.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnmotorlimt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnmotorlimt.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnmotorlimt.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnmotorlimt.HoverTextColor = System.Drawing.Color.White;
            this.btnmotorlimt.IsDerivedStyle = true;
            this.btnmotorlimt.Location = new System.Drawing.Point(368, 41);
            this.btnmotorlimt.Name = "btnmotorlimt";
            this.btnmotorlimt.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnmotorlimt.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnmotorlimt.NormalTextColor = System.Drawing.Color.White;
            this.btnmotorlimt.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnmotorlimt.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnmotorlimt.PressTextColor = System.Drawing.Color.White;
            this.btnmotorlimt.Size = new System.Drawing.Size(131, 23);
            this.btnmotorlimt.Style = MetroSet_UI.Enums.Style.Light;
            this.btnmotorlimt.StyleManager = null;
            this.btnmotorlimt.TabIndex = 3;
            this.btnmotorlimt.Text = "Save";
            this.btnmotorlimt.ThemeAuthor = "Narwin";
            this.btnmotorlimt.ThemeName = "MetroLite";
            this.btnmotorlimt.Click += new System.EventHandler(this.btnmotorlimt_Click);
            // 
            // nmrcmotorvalue
            // 
            this.nmrcmotorvalue.DecimalPlaces = 2;
            this.nmrcmotorvalue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nmrcmotorvalue.Location = new System.Drawing.Point(3, 41);
            this.nmrcmotorvalue.Maximum = new decimal(new int[] {
            -469762048,
            -590869294,
            5421010,
            0});
            this.nmrcmotorvalue.Name = "nmrcmotorvalue";
            this.nmrcmotorvalue.Size = new System.Drawing.Size(359, 23);
            this.nmrcmotorvalue.TabIndex = 4;
            this.nmrcmotorvalue.ThousandsSeparator = true;
            // 
            // metroSetSetTabPage2
            // 
            this.metroSetSetTabPage2.BaseColor = System.Drawing.Color.White;
            this.metroSetSetTabPage2.Font = null;
            this.metroSetSetTabPage2.ImageIndex = 0;
            this.metroSetSetTabPage2.ImageKey = null;
            this.metroSetSetTabPage2.IsDerivedStyle = true;
            this.metroSetSetTabPage2.Location = new System.Drawing.Point(4, 42);
            this.metroSetSetTabPage2.Name = "metroSetSetTabPage2";
            this.metroSetSetTabPage2.Size = new System.Drawing.Size(827, 473);
            this.metroSetSetTabPage2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetSetTabPage2.StyleManager = null;
            this.metroSetSetTabPage2.TabIndex = 3;
            this.metroSetSetTabPage2.Text = "Accessories";
            this.metroSetSetTabPage2.ThemeAuthor = "Narwin";
            this.metroSetSetTabPage2.ThemeName = "MetroLite";
            this.metroSetSetTabPage2.ToolTipText = null;
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.Silver;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(757, 3);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 1;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroDark";
            // 
            // cmbcsvfiles
            // 
            this.cmbcsvfiles.AllowDrop = true;
            this.cmbcsvfiles.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbcsvfiles.BackColor = System.Drawing.Color.Transparent;
            this.cmbcsvfiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbcsvfiles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbcsvfiles.CausesValidation = false;
            this.cmbcsvfiles.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbcsvfiles.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbcsvfiles.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbcsvfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbcsvfiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbcsvfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcsvfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbcsvfiles.FormattingEnabled = true;
            this.cmbcsvfiles.IsDerivedStyle = true;
            this.cmbcsvfiles.ItemHeight = 50;
            this.cmbcsvfiles.Location = new System.Drawing.Point(3, 19);
            this.cmbcsvfiles.Name = "cmbcsvfiles";
            this.cmbcsvfiles.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbcsvfiles.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbcsvfiles.Size = new System.Drawing.Size(400, 56);
            this.cmbcsvfiles.Style = MetroSet_UI.Enums.Style.Light;
            this.cmbcsvfiles.StyleManager = null;
            this.cmbcsvfiles.TabIndex = 1;
            this.cmbcsvfiles.ThemeAuthor = "Narwin";
            this.cmbcsvfiles.ThemeName = "MetroLite";
            this.cmbcsvfiles.SelectedIndexChanged += new System.EventHandler(this.cmbcsvfiles_SelectedIndexChanged);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 601);
            this.ControlBox = false;
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.TbContrl);
            this.Moveable = false;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flex Mold App";
            this.TbContrl.ResumeLayout(false);
            this.tbhome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tbProject.ResumeLayout(false);
            this.tabllayoutmain.ResumeLayout(false);
            this.Parent.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpboxlaserfiles.ResumeLayout(false);
            this.grpboxcsvFiles.ResumeLayout(false);
            this.tbllayoutinneruser.ResumeLayout(false);
            this.tbllayoutinneruser.PerformLayout();
            this.metroSetSetTabPage1.ResumeLayout(false);
            this.metroSetPanel4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tbllayoutpanelsysinfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcmotorvalue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTabControl TbContrl;
        private MetroSet_UI.Child.MetroSetSetTabPage tbhome;
        private MetroSet_UI.Child.MetroSetSetTabPage tbProject;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.GroupBox Parent;
        private MetroSet_UI.Controls.MetroSetComboBox cmbparentfolder;
        private MetroSet_UI.Controls.MetroSetTile metroSetTile1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage1;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton1;
        private MetroSet_UI.Controls.MetroSetTextBox txtfilepath;
        private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroSet_UI.Controls.MetroSetTextBox txtboxMaxValue;
        private MetroSet_UI.Controls.MetroSetTextBox txtBoxMinValue;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroSet_UI.Controls.MetroSetTextBox txtboxnewvaue;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TableLayoutPanel tabllayoutmain;
        private System.Windows.Forms.GroupBox grpboxlaserfiles;
        private MetroSet_UI.Controls.MetroSetComboBox cmlaserfiles;
        private MetroSet_UI.Controls.MetroSetButton btnexecutelasfile;
        private MetroSet_UI.Controls.MetroSetButton btnexecutecsv;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroSet_UI.Controls.MetroSetComboBox cmbpanel;
        private System.Windows.Forms.GroupBox grpboxcsvFiles;
        private System.Windows.Forms.TableLayoutPanel tbllayoutinneruser;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroSet_UI.Controls.MetroSetButton btnsavecsv;
        private MetroSet_UI.Controls.MetroSetButton btnincrement;
        private System.Windows.Forms.TableLayoutPanel tbllayoutpanelsysinfo;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetButton btnmotorlimt;
        private System.Windows.Forms.NumericUpDown nmrcmotorvalue;
        private MetroSet_UI.Controls.MetroSetComboBox cmbcsvfiles;
        // private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}