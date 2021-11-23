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
            Telerik.Charting.Styles.ChartMarginsTitle chartMarginsTitle1 = new Telerik.Charting.Styles.ChartMarginsTitle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            Telerik.Charting.Styles.ChartMarginsLegend chartMarginsLegend1 = new Telerik.Charting.Styles.ChartMarginsLegend();
            Telerik.Charting.Styles.ChartMarginsPlotArea chartMarginsPlotArea1 = new Telerik.Charting.Styles.ChartMarginsPlotArea();
            Telerik.Charting.ChartSeries chartSeries1 = new Telerik.Charting.ChartSeries();
            Telerik.Charting.GradientElement gradientElement1 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement2 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement3 = new Telerik.Charting.GradientElement();
            Telerik.Charting.ChartSeries chartSeries2 = new Telerik.Charting.ChartSeries();
            Telerik.Charting.ChartSeriesItem chartSeriesItem1 = new Telerik.Charting.ChartSeriesItem();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.TbContrl = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tbhome = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.tbProject = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.metroSetPanel2 = new MetroSet_UI.Controls.MetroSetPanel();
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbpanel = new MetroSet_UI.Controls.MetroSetComboBox();
            this.Parent = new System.Windows.Forms.GroupBox();
            this.cmbparentfolder = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.listLaserFiles = new System.Windows.Forms.ListBox();
            this.metroSetPanel3 = new MetroSet_UI.Controls.MetroSetPanel();
            this.dgvcsvfiles = new System.Windows.Forms.DataGridView();
            this.radChart1 = new Telerik.WinControls.UI.RadChart();
            this.metroSetTile1 = new MetroSet_UI.Controls.MetroSetTile();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroSetTile2 = new MetroSet_UI.Controls.MetroSetTile();
            this.metroSetSetTabPage1 = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.metroSetPanel4 = new MetroSet_UI.Controls.MetroSetPanel();
            this.metroSetTile3 = new MetroSet_UI.Controls.MetroSetTile();
            this.metroSetTextBox1 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetSetTabPage2 = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.TbContrl.SuspendLayout();
            this.tbhome.SuspendLayout();
            this.tbProject.SuspendLayout();
            this.metroSetPanel2.SuspendLayout();
            this.metroSetPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Parent.SuspendLayout();
            this.metroSetPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcsvfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.metroSetSetTabPage1.SuspendLayout();
            this.metroSetPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbContrl
            // 
            this.TbContrl.AnimateEasingType = MetroSet_UI.Enums.EasingType.Linear;
            this.TbContrl.AnimateTime = 800;
            this.TbContrl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TbContrl.Controls.Add(this.tbhome);
            this.TbContrl.Controls.Add(this.tbProject);
            this.TbContrl.Controls.Add(this.metroSetSetTabPage1);
            this.TbContrl.Controls.Add(this.metroSetSetTabPage2);
            this.TbContrl.Cursor = System.Windows.Forms.Cursors.Default;
            this.TbContrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbContrl.IsDerivedStyle = true;
            this.TbContrl.ItemSize = new System.Drawing.Size(100, 38);
            this.TbContrl.Location = new System.Drawing.Point(12, 70);
            this.TbContrl.Name = "TbContrl";
            this.TbContrl.SelectedIndex = 1;
            this.TbContrl.SelectedTextColor = System.Drawing.Color.White;
            this.TbContrl.Size = new System.Drawing.Size(835, 519);
            this.TbContrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TbContrl.Speed = 100;
            this.TbContrl.Style = MetroSet_UI.Enums.Style.Dark;
            this.TbContrl.StyleManager = null;
            this.TbContrl.TabIndex = 0;
            this.TbContrl.ThemeAuthor = "Narwin";
            this.TbContrl.ThemeName = "MetroDark";
            this.TbContrl.UnselectedTextColor = System.Drawing.Color.Gray;
            // 
            // tbhome
            // 
            this.tbhome.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbhome.Controls.Add(this.chart1);
            this.tbhome.Controls.Add(this.metroSetTile1);
            this.tbhome.Font = null;
            this.tbhome.ImageIndex = 0;
            this.tbhome.ImageKey = null;
            this.tbhome.IsDerivedStyle = true;
            this.tbhome.Location = new System.Drawing.Point(4, 42);
            this.tbhome.Name = "tbhome";
            this.tbhome.Size = new System.Drawing.Size(827, 473);
            this.tbhome.Style = MetroSet_UI.Enums.Style.Dark;
            this.tbhome.StyleManager = null;
            this.tbhome.TabIndex = 0;
            this.tbhome.Text = "Home";
            this.tbhome.ThemeAuthor = "Narwin";
            this.tbhome.ThemeName = "MetroDark";
            this.tbhome.ToolTipText = null;
            // 
            // tbProject
            // 
            this.tbProject.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbProject.Controls.Add(this.metroSetPanel3);
            this.tbProject.Controls.Add(this.metroSetPanel2);
            this.tbProject.Controls.Add(this.metroSetPanel1);
            this.tbProject.Font = null;
            this.tbProject.ImageIndex = 0;
            this.tbProject.ImageKey = null;
            this.tbProject.IsDerivedStyle = true;
            this.tbProject.Location = new System.Drawing.Point(4, 42);
            this.tbProject.Name = "tbProject";
            this.tbProject.Size = new System.Drawing.Size(827, 473);
            this.tbProject.Style = MetroSet_UI.Enums.Style.Dark;
            this.tbProject.StyleManager = null;
            this.tbProject.TabIndex = 1;
            this.tbProject.Text = "Project";
            this.tbProject.ThemeAuthor = "Narwin";
            this.tbProject.ThemeName = "MetroDark";
            this.tbProject.ToolTipText = null;
            // 
            // metroSetPanel2
            // 
            this.metroSetPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetPanel2.BorderThickness = 1;
            this.metroSetPanel2.Controls.Add(this.listLaserFiles);
            this.metroSetPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroSetPanel2.IsDerivedStyle = true;
            this.metroSetPanel2.Location = new System.Drawing.Point(200, 0);
            this.metroSetPanel2.Name = "metroSetPanel2";
            this.metroSetPanel2.Size = new System.Drawing.Size(236, 473);
            this.metroSetPanel2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetPanel2.StyleManager = null;
            this.metroSetPanel2.TabIndex = 1;
            this.metroSetPanel2.ThemeAuthor = "Narwin";
            this.metroSetPanel2.ThemeName = "MetroDark";
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Controls.Add(this.groupBox1);
            this.metroSetPanel1.Controls.Add(this.Parent);
            this.metroSetPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroSetPanel1.IsDerivedStyle = true;
            this.metroSetPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(200, 473);
            this.metroSetPanel1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 0;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroDark";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbpanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(0, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 251);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel";
            // 
            // cmbpanel
            // 
            this.cmbpanel.AllowDrop = true;
            this.cmbpanel.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbpanel.BackColor = System.Drawing.Color.Transparent;
            this.cmbpanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbpanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbpanel.CausesValidation = false;
            this.cmbpanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbpanel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbpanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbpanel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbpanel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbpanel.FormattingEnabled = true;
            this.cmbpanel.IsDerivedStyle = true;
            this.cmbpanel.ItemHeight = 20;
            this.cmbpanel.Location = new System.Drawing.Point(3, 19);
            this.cmbpanel.Name = "cmbpanel";
            this.cmbpanel.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbpanel.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbpanel.Size = new System.Drawing.Size(194, 26);
            this.cmbpanel.Style = MetroSet_UI.Enums.Style.Dark;
            this.cmbpanel.StyleManager = null;
            this.cmbpanel.TabIndex = 1;
            this.cmbpanel.ThemeAuthor = "Narwin";
            this.cmbpanel.ThemeName = "MetroDark";
            this.cmbpanel.SelectedIndexChanged += new System.EventHandler(this.cmbpanel_SelectedIndexChanged);
            // 
            // Parent
            // 
            this.Parent.Controls.Add(this.cmbparentfolder);
            this.Parent.Dock = System.Windows.Forms.DockStyle.Top;
            this.Parent.ForeColor = System.Drawing.Color.LightGray;
            this.Parent.Location = new System.Drawing.Point(0, 0);
            this.Parent.Name = "Parent";
            this.Parent.Size = new System.Drawing.Size(200, 222);
            this.Parent.TabIndex = 0;
            this.Parent.TabStop = false;
            this.Parent.Text = "Project";
            // 
            // cmbparentfolder
            // 
            this.cmbparentfolder.AllowDrop = true;
            this.cmbparentfolder.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbparentfolder.BackColor = System.Drawing.Color.Transparent;
            this.cmbparentfolder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbparentfolder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.cmbparentfolder.CausesValidation = false;
            this.cmbparentfolder.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cmbparentfolder.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbparentfolder.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbparentfolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbparentfolder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbparentfolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbparentfolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbparentfolder.FormattingEnabled = true;
            this.cmbparentfolder.IsDerivedStyle = true;
            this.cmbparentfolder.ItemHeight = 20;
            this.cmbparentfolder.Location = new System.Drawing.Point(3, 19);
            this.cmbparentfolder.Name = "cmbparentfolder";
            this.cmbparentfolder.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbparentfolder.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbparentfolder.Size = new System.Drawing.Size(194, 26);
            this.cmbparentfolder.Style = MetroSet_UI.Enums.Style.Dark;
            this.cmbparentfolder.StyleManager = null;
            this.cmbparentfolder.TabIndex = 0;
            this.cmbparentfolder.ThemeAuthor = "Narwin";
            this.cmbparentfolder.ThemeName = "MetroDark";
            this.cmbparentfolder.SelectedIndexChanged += new System.EventHandler(this.cmbparentfolder_SelectedIndexChanged);
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
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 1;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroDark";
            // 
            // listLaserFiles
            // 
            this.listLaserFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listLaserFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLaserFiles.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.listLaserFiles.FormattingEnabled = true;
            this.listLaserFiles.ItemHeight = 16;
            this.listLaserFiles.Location = new System.Drawing.Point(0, 0);
            this.listLaserFiles.Name = "listLaserFiles";
            this.listLaserFiles.Size = new System.Drawing.Size(236, 473);
            this.listLaserFiles.TabIndex = 0;
            this.listLaserFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listLaserFiles_MouseDoubleClick);
            // 
            // metroSetPanel3
            // 
            this.metroSetPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroSetPanel3.BorderThickness = 1;
            this.metroSetPanel3.Controls.Add(this.metroSetTile2);
            this.metroSetPanel3.Controls.Add(this.radChart1);
            this.metroSetPanel3.Controls.Add(this.dgvcsvfiles);
            this.metroSetPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetPanel3.IsDerivedStyle = true;
            this.metroSetPanel3.Location = new System.Drawing.Point(436, 0);
            this.metroSetPanel3.Name = "metroSetPanel3";
            this.metroSetPanel3.Size = new System.Drawing.Size(391, 473);
            this.metroSetPanel3.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetPanel3.StyleManager = null;
            this.metroSetPanel3.TabIndex = 2;
            this.metroSetPanel3.ThemeAuthor = "Narwin";
            this.metroSetPanel3.ThemeName = "MetroDark";
            // 
            // dgvcsvfiles
            // 
            this.dgvcsvfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcsvfiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvcsvfiles.Location = new System.Drawing.Point(0, 220);
            this.dgvcsvfiles.Name = "dgvcsvfiles";
            this.dgvcsvfiles.Size = new System.Drawing.Size(387, 249);
            this.dgvcsvfiles.TabIndex = 0;
            // 
            // radChart1
            // 
            this.radChart1.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radChart1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.radChart1.ChartTitle.Appearance.Border.Color = System.Drawing.Color.Transparent;
            chartMarginsTitle1.Bottom = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMarginsTitle1.Bottom")));
            chartMarginsTitle1.Left = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMarginsTitle1.Left")));
            chartMarginsTitle1.Right = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMarginsTitle1.Right")));
            chartMarginsTitle1.Top = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMarginsTitle1.Top")));
            this.radChart1.ChartTitle.Appearance.Dimensions.Margins = chartMarginsTitle1;
            this.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Transparent;
            this.radChart1.ChartTitle.Appearance.Visible = false;
            this.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.White;
            this.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Arial", 18F);
            this.radChart1.ChartTitle.TextBlock.Text = "Motor Info Chart";
            this.radChart1.ChartTitle.Visible = false;
            this.radChart1.DefaultType = Telerik.Charting.ChartSeriesType.Pie;
            this.radChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.Transparent;
            chartMarginsLegend1.Bottom = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMarginsLegend1.Bottom")));
            this.radChart1.Legend.Appearance.Dimensions.Margins = chartMarginsLegend1;
            this.radChart1.Legend.Appearance.FillStyle.MainColor = System.Drawing.Color.Transparent;
            this.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Font = new System.Drawing.Font("Arial", 10F);
            this.radChart1.Legend.Appearance.Position.AlignedPosition = Telerik.Charting.Styles.AlignedPositions.BottomRight;
            this.radChart1.Location = new System.Drawing.Point(0, 0);
            this.radChart1.Name = "radChart1";
            this.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            chartMarginsPlotArea1.Left = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMarginsPlotArea1.Left")));
            chartMarginsPlotArea1.Right = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMarginsPlotArea1.Right")));
            this.radChart1.PlotArea.Appearance.Dimensions.Margins = chartMarginsPlotArea1;
            this.radChart1.PlotArea.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.Solid;
            this.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.radChart1.PlotArea.XAxis.MaxValue = 1D;
            this.radChart1.PlotArea.XAxis.MinValue = 1D;
            this.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            chartSeries1.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(149)))), ((int)(((byte)(58)))));
            gradientElement1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(202)))), ((int)(((byte)(152)))));
            gradientElement2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(185)))), ((int)(((byte)(123)))));
            gradientElement2.Position = 0.5F;
            gradientElement3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(154)))), ((int)(((byte)(84)))));
            gradientElement3.Position = 1F;
            chartSeries1.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(new Telerik.Charting.GradientElement[] {
            gradientElement1,
            gradientElement2,
            gradientElement3});
            chartSeries1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient;
            chartSeries1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(202)))), ((int)(((byte)(155)))));
            chartSeries1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            chartSeries1.DataLabelsColumn = "Motor Time";
            chartSeries1.DataXColumn = "1";
            chartSeries1.DataXColumn2 = "2";
            chartSeries1.DataYColumn = "1";
            chartSeries1.DataYColumn2 = "2";
            chartSeries1.DataYColumn3 = "2";
            chartSeries1.DataYColumn4 = "2";
            chartSeries1.Name = "Series 1";
            chartSeries1.Type = Telerik.Charting.ChartSeriesType.Pie;
            chartSeriesItem1.Name = "Item 1";
            chartSeries2.Items.AddRange(new Telerik.Charting.ChartSeriesItem[] {
            chartSeriesItem1});
            chartSeries2.Name = "Series 2";
            chartSeries2.Type = Telerik.Charting.ChartSeriesType.Pie;
            this.radChart1.Series.AddRange(new Telerik.Charting.ChartSeries[] {
            chartSeries1,
            chartSeries2});
            this.radChart1.Size = new System.Drawing.Size(387, 220);
            this.radChart1.Skin = "Black";
            this.radChart1.TabIndex = 1;
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 46);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Motor";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Laser";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Error";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Rotation";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(827, 341);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart";
            title1.Name = "Motor Info";
            title2.Name = "Machine Info";
            title3.Name = "Timer";
            title4.Name = "Cycles";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            this.chart1.Titles.Add(title3);
            this.chart1.Titles.Add(title4);
            // 
            // metroSetTile2
            // 
            this.metroSetTile2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetTile2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTile2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTile2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroSetTile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTile2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetTile2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.HoverTextColor = System.Drawing.Color.White;
            this.metroSetTile2.IsDerivedStyle = true;
            this.metroSetTile2.Location = new System.Drawing.Point(0, 0);
            this.metroSetTile2.Name = "metroSetTile2";
            this.metroSetTile2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.NormalTextColor = System.Drawing.Color.White;
            this.metroSetTile2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetTile2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.PressTextColor = System.Drawing.Color.White;
            this.metroSetTile2.Size = new System.Drawing.Size(387, 23);
            this.metroSetTile2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetTile2.StyleManager = null;
            this.metroSetTile2.TabIndex = 2;
            this.metroSetTile2.Text = "Motor & Sensor Chart Info";
            this.metroSetTile2.ThemeAuthor = "Narwin";
            this.metroSetTile2.ThemeName = "MetroDark";
            this.metroSetTile2.TileAlign = MetroSet_UI.Enums.TileAlign.BottomCenter;
            // 
            // metroSetSetTabPage1
            // 
            this.metroSetSetTabPage1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetSetTabPage1.Controls.Add(this.metroSetLabel1);
            this.metroSetSetTabPage1.Controls.Add(this.metroSetButton1);
            this.metroSetSetTabPage1.Controls.Add(this.metroSetTextBox1);
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
            this.metroSetPanel4.Controls.Add(this.metroSetTile3);
            this.metroSetPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroSetPanel4.IsDerivedStyle = true;
            this.metroSetPanel4.Location = new System.Drawing.Point(0, 0);
            this.metroSetPanel4.Name = "metroSetPanel4";
            this.metroSetPanel4.Size = new System.Drawing.Size(237, 473);
            this.metroSetPanel4.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetPanel4.StyleManager = null;
            this.metroSetPanel4.TabIndex = 0;
            this.metroSetPanel4.ThemeAuthor = "Narwin";
            this.metroSetPanel4.ThemeName = "MetroDark";
            // 
            // metroSetTile3
            // 
            this.metroSetTile3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTile3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTile3.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTile3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroSetTile3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTile3.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.metroSetTile3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile3.HoverTextColor = System.Drawing.Color.White;
            this.metroSetTile3.IsDerivedStyle = true;
            this.metroSetTile3.Location = new System.Drawing.Point(0, 0);
            this.metroSetTile3.Name = "metroSetTile3";
            this.metroSetTile3.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile3.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile3.NormalTextColor = System.Drawing.Color.White;
            this.metroSetTile3.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile3.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile3.PressTextColor = System.Drawing.Color.White;
            this.metroSetTile3.Size = new System.Drawing.Size(237, 70);
            this.metroSetTile3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTile3.StyleManager = null;
            this.metroSetTile3.TabIndex = 0;
            this.metroSetTile3.Text = "Project Folder Settings";
            this.metroSetTile3.ThemeAuthor = "Narwin";
            this.metroSetTile3.ThemeName = "MetroLite";
            this.metroSetTile3.TileAlign = MetroSet_UI.Enums.TileAlign.BottomCenter;
            // 
            // metroSetTextBox1
            // 
            this.metroSetTextBox1.AutoCompleteCustomSource = null;
            this.metroSetTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetTextBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetTextBox1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTextBox1.Image = null;
            this.metroSetTextBox1.IsDerivedStyle = true;
            this.metroSetTextBox1.Lines = null;
            this.metroSetTextBox1.Location = new System.Drawing.Point(359, 39);
            this.metroSetTextBox1.MaxLength = 32767;
            this.metroSetTextBox1.Multiline = false;
            this.metroSetTextBox1.Name = "metroSetTextBox1";
            this.metroSetTextBox1.ReadOnly = false;
            this.metroSetTextBox1.Size = new System.Drawing.Size(288, 23);
            this.metroSetTextBox1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetTextBox1.StyleManager = null;
            this.metroSetTextBox1.TabIndex = 1;
            this.metroSetTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox1.ThemeAuthor = "Narwin";
            this.metroSetTextBox1.ThemeName = "MetroDark";
            this.metroSetTextBox1.UseSystemPasswordChar = false;
            this.metroSetTextBox1.WatermarkText = "No Folder Selected";
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
            this.metroSetButton1.Location = new System.Drawing.Point(667, 39);
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
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(259, 38);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 3;
            this.metroSetLabel1.Text = "Select Folder";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroDark";
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
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(859, 601);
            this.ControlBox = false;
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.TbContrl);
            this.Moveable = false;
            this.Name = "FrmHome";
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "Flex Mold App";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.TbContrl.ResumeLayout(false);
            this.tbhome.ResumeLayout(false);
            this.tbProject.ResumeLayout(false);
            this.metroSetPanel2.ResumeLayout(false);
            this.metroSetPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Parent.ResumeLayout(false);
            this.metroSetPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcsvfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.metroSetSetTabPage1.ResumeLayout(false);
            this.metroSetPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTabControl TbContrl;
        private MetroSet_UI.Child.MetroSetSetTabPage tbhome;
        private MetroSet_UI.Child.MetroSetSetTabPage tbProject;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel2;
        private System.Windows.Forms.GroupBox Parent;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroSet_UI.Controls.MetroSetComboBox cmbparentfolder;
        private MetroSet_UI.Controls.MetroSetComboBox cmbpanel;
        private System.Windows.Forms.ListBox listLaserFiles;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel3;
        private System.Windows.Forms.DataGridView dgvcsvfiles;
        private Telerik.WinControls.UI.RadChart radChart1;
        private MetroSet_UI.Controls.MetroSetTile metroSetTile1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroSet_UI.Controls.MetroSetTile metroSetTile2;
        private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage1;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel4;
        private MetroSet_UI.Controls.MetroSetTile metroSetTile3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton1;
        private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox1;
        private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage2;
        // private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}