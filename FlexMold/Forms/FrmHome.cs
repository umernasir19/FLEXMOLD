using FlexMold.Models;
using MetroSet_UI.Forms;
using Propert_Utility.Models;
using Propert_Utility.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Telerik.Charting;

namespace FlexMold.Forms
{
    public partial class FrmHome : MetroSet_UI.Forms.MetroSetForm
    {
        decimal MotorValue =0.00m;
        public FrmHome()
        {
            InitializeComponent();

            //this code is written for horizantal tabcontrol in 3rd tabpage
            tabControl1.DrawItem += new DrawItemEventHandler(tab3sidebar_DrawItem);
            // .DrawMode += new DrawItemEventHandler(tabControl1_DrawItem);

            //getting XML files where project/panel folders paths are saved
            XDocument xml = XDocument.Load(SystemConfig.XmlFilePath);
            //checking if project folder is defined or not
            if (Utility.GetFilePath(xml).Length > 0) 
            {
                LoadParentFolder();
                TbContrl.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show(this, "Folder Path Not Defined Or Not Correct", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TbContrl.SelectedIndex = 2;
            }


        }
       
    

    #region Project Tab Working

        public string[] GetFolderList(string path)
        {
            return Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);

        }

        public void LoadParentFolder()
        {
            XDocument xml= XDocument.Load(SystemConfig.XmlFilePath);
            string ParentFolder = Utility.GetFilePath(xml); //ConfigurationManager.AppSettings["ParentFolderPath"].ToString();
            MotorValue = Utility.GetMotorLimit(xml);
            if (MotorValue > -1)
            {
                nmrcmotorvalue.Value = Convert.ToDecimal(MotorValue);
            }
            else
            {
                nmrcmotorvalue.Value = 0.00m;
            }
            txtfilepath.Text = ParentFolder;
            string[] folderslist = GetFolderList(ParentFolder);
            List<ComboBoxItems> lstcmxitm = new List<ComboBoxItems>();

            for (int i = 0; i < folderslist.Length; i++)
            {
                string foldername = folderslist[i].Substring(folderslist[i].LastIndexOf(@"\"));
                string text = foldername.Remove(0, 1);
                string value = folderslist[i];
                ComboBoxItems objitems = new ComboBoxItems();
                objitems.Text = text;
                objitems.Value = value;
                lstcmxitm.Add(objitems);
            }
            
            cmbparentfolder.DataSource = lstcmxitm;
            cmbparentfolder.DisplayMember = "Text";
            cmbparentfolder.ValueMember = "Value";
        }

        private void cmbparentfolder_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            ComboBox cm = cmbparentfolder;
            ComboBoxItems selectedvalue = (ComboBoxItems)cm.SelectedItem;
            cmlaserfiles.DataSource = null;
        //    cmbcsvfiles.Items.Clear();// = null;
            LoadChildFolder(selectedvalue);
        }
        public void LoadChildFolder(ComboBoxItems folderpath)
        {
           
               
            
            
           // cmbcsvfiles.Items.Clear();
            string[] folderslist = GetFolderList(folderpath.Value);
            List<ComboBoxItems> lstcmxitm = new List<ComboBoxItems>();
            for (int i = 0; i < folderslist.Length; i++)
            {
                string foldername = folderslist[i].Substring(folderslist[i].LastIndexOf(@"\"));
                string text = foldername.Remove(0, 1);
                string value = folderslist[i];
                ComboBoxItems objitems = new ComboBoxItems();
                objitems.Text = text;
                objitems.Value = value;
                lstcmxitm.Add(objitems);
            }

            cmbpanel.DataSource = lstcmxitm;
            cmbpanel.DisplayMember = "Text";
            cmbpanel.ValueMember = "Value";
        }
        private void cmbpanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ComboBox cm = cmbpanel;
            ComboBoxItems selectedvalue = (ComboBoxItems)cm.SelectedItem;
            cmlaserfiles.DataSource = null;
            LoadFiles(selectedvalue);
        }
        public void LoadFiles(ComboBoxItems filespath)
        {
            string[] LaserFiles = Directory.GetFiles(filespath.Value, "*.las");
            //listLaserFiles.Items.Clear();
            List<ListBoxItems> listboxitm = new List<ListBoxItems>();
            ListBoxItems objlstboxitem = new ListBoxItems()
            {
                Text = "Please Select File",
                Value = ""
            };
            //listboxitm.Add(objlstboxitem);
            //cmlaserfiles.DataSource = listboxitm;
            //cmlaserfiles.ValueMember = "Value";
            //cmlaserfiles.DisplayMember = "Text";
            for (int i = 0; i < LaserFiles.Length; i++)
            {
                string FileName = LaserFiles[i].Substring(LaserFiles[i].LastIndexOf(@"\"));
                string text = FileName.Remove(0, 1);
                string value = LaserFiles[i];
                objlstboxitem = new ListBoxItems();
                objlstboxitem.Text = text;
                objlstboxitem.Value = value;
                listboxitm.Add(objlstboxitem);

                


            }

            cmlaserfiles.DataSource = listboxitm;
            cmlaserfiles.ValueMember = "Value";
            cmlaserfiles.DisplayMember = "Text";
            //CSVFILELOADING


            string[] CSVFILES = Directory.GetFiles(filespath.Value, "*.csv");
            //listLaserFiles.Items.Clear();
            List<ListBoxItems> csvfilegrd = new List<ListBoxItems>();

           // Dictionary<string, string> comboSource = new Dictionary<string, string>();
            for (int i = 0; i < CSVFILES.Length; i++)
            {
                string FileName = CSVFILES[i].Substring(CSVFILES[i].LastIndexOf(@"\"));
                string text = FileName.Remove(0, 1);
                string value = CSVFILES[i];
                ListBoxItems csvfilelist = new ListBoxItems();
                csvfilelist.Text = text;
                csvfilelist.Value = value;
                csvfilegrd.Add(csvfilelist);

             //   csvfilegrd
             //   comboSource.Add(value, text);
               // comboSource.Add("2", "Monday");
                //cmbcsvfiles.Items.Add(csvfilelist);

               
            }
            cmbcsvfiles.DataSource = new BindingSource(csvfilegrd, null);
            cmbcsvfiles.ValueMember = "Value";
            cmbcsvfiles.DisplayMember = "Text";
            // dgvcsvfiles.DataSource = csvfilegrd;
            if (csvfilegrd.Count > 0)
            {
            //    ReadCSVFile(csvfilegrd[0].Value);
            }
            else
            {
                
                cmbcsvfiles.DataSource = null; 
                txtBoxMinValue.Text = "";
                txtboxMaxValue.Text = "";
                MessageBox.Show("No CSV File is Available In This Panel");
            }

        }



        private void listLaserFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //ListBox lstbox = listLaserFiles;
            //ListBoxItems selectedobjec = (ListBoxItems)lstbox.SelectedItem;
            //if (selectedobjec.Value.Length > 1)
            //{
            //    MetroSetMessageBox.Show(this, selectedobjec.Text + " Selected For Execution", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //   // radChart1.ChartTitle.TextBlock = 
            //}
        }

        public void ReadCSVFile(string path)
        {
            try
            {
                var lines = File.ReadAllLines(path).Select(a => a.Split(',')).ToList();

                decimal[] csvvalues = new decimal[lines[0].Length];

                for(int i = 0; i < lines[0].Length; i++)
                {
                    csvvalues[i] = Convert.ToDecimal(lines[0][i].ToString());
                }



                txtboxMaxValue.ForeColor = Color.White;
                txtBoxMinValue.Text = lines[0].Min();
                txtboxMaxValue.Text = Convert.ToDecimal(csvvalues.Max()).ToString();

             
            }
            catch(Exception ex)
            {

            }

        }
        private void btnsavevalue_Click(object sender, EventArgs e)
        {
            decimal NewMotorValue =Convert.ToDecimal(txtboxnewvaue.Text.ToString());
            if (NewMotorValue > MotorValue)
            {
                MessageBox.Show("Motor Value is Greater Than Max Motor Limit");
            }
            else
            {
                //New CSV File Will be created with calculation
                // (Previous csv values*100)/New Motor Value

                ComboBox cm = cmbcsvfiles;
                ListBoxItems selectedvalue = (ListBoxItems)cm.SelectedItem;
                if (selectedvalue != null)
                {
                    string CSVFilePath = selectedvalue.Value;
                    
                    var lines = File.ReadAllLines(CSVFilePath).Select(a => a.Split(',')).ToList();
                    IList<string> lstnewcsvvalues = new List<string>();
                    string objNewCsvCompleteValues = "";
                    for (int i = 0; i < lines[0].Length; i++)
                    {
                        var oldcsvvalue =Convert.ToDecimal(lines[0][i].ToString());
                        var newcsvvalue = (oldcsvvalue * NewMotorValue ) / 100;
                        lstnewcsvvalues.Add(newcsvvalue.ToString());
                         

                    }
                    objNewCsvCompleteValues = string.Join(",", lstnewcsvvalues);
                    string newcsvfilename= Path.GetFileName(CSVFilePath)+"_FlexMold";
                   string dir = Path.GetDirectoryName(CSVFilePath);
                   string NewPath= Path.Combine(dir, newcsvfilename + ".csv");
                    File.WriteAllText(NewPath, objNewCsvCompleteValues.ToString());

                }

            }
            //MessageBox.Show("Saved");
        }

        private void btnincrement_Click(object sender, EventArgs e)
        {
            if (txtboxnewvaue.Text.Length > 0)
            {
                double val = Convert.ToDouble(txtboxnewvaue.Text);
                val = val + 10;

                txtboxnewvaue.Text = val.ToString();
            }
            else
            {
                MessageBox.Show("Please enter Value");
            }
        }
        #endregion

        #region System Settings Tab


        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string path = fbd.SelectedPath;
                    //string[] s = { "\\bin" };
                    //string xmlpath = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + ConfigurationManager.AppSettings["ConfigXml"].ToString();

                   bool flag= Utility.SetFilePath(path, SystemConfig.XmlFilePath);

                    if (flag)
                    {
                        MessageBox.Show("Updated Successfully");
                        LoadParentFolder();
                    }
                    else
                    {
                        MessageBox.Show("Update Failed");
                    }

                }
            }
        }

        #endregion

      

        private void tab3sidebar_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Red);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 10.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void btnexecutelasfile_Click(object sender, EventArgs e)
        {
            if (cmlaserfiles.Items.Count > 0)
            {
             
                ComboBox cm = cmlaserfiles;
                ListBoxItems selectedvalue = (ListBoxItems)cm.SelectedItem;
                string Path = selectedvalue.Value;
                if (Path.Length > 1)
                {
                    MessageBox.Show("Laser File Executed");
                }
            }
            else
            {
                MessageBox.Show("No Laser File Available");
            }
        }

        private void btncsvfile_Click(object sender, EventArgs e)
        {
            ComboBox cm = cmbcsvfiles;
            ListBoxItems selectedvalue = (ListBoxItems)cm.SelectedItem;
            if (selectedvalue!= null )
            {
                //string Path = selectedvalue.Value;
                //ReadCSVFile(Path);
                MessageBox.Show("CSV Executed On Server");
            }
            else
            {
                MessageBox.Show("NO CSV SELECTED");
            }

        }

        private void metroSetTile2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void cmbcsvfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cm = cmbcsvfiles;
            ListBoxItems selectedvalue = (ListBoxItems)cm.SelectedItem;
            if (selectedvalue != null)
            {
                
                string Path = selectedvalue.Value;
                ReadCSVFile(Path);
            }
            else
            {
                //MessageBox.Show("NO CSV Found");
            }



        }

        private void btnmotorlimt_Click(object sender, EventArgs e)
        {
            decimal motorlimt =Convert.ToDecimal(nmrcmotorvalue.Value.ToString());
            if (motorlimt > 0)
            {
               
              bool flag=  Utility.SetMotorLimit(motorlimt, SystemConfig.XmlFilePath);
                if (flag)
                {
                    MessageBox.Show("Motor Limit Updated");
                }
                else
                {
                    MessageBox.Show("Failed! Something Went Into Error");
                }

            }
            
        }

        private void txtboxnewvaue_Click(object sender, EventArgs e)
        {

        }
    }
}
