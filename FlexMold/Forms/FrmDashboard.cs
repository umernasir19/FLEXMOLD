using Propert_Utility.Models;
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
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroSet_UI.Forms;

namespace FlexMold.Forms
{
    public partial class FrmDashboard : MetroSetForm
    {
        public FrmDashboard()
        {
            InitializeComponent();
            LoadParentFolder();
            
        }

        #region Project Tab Working

        public string[] GetFolderList(string path)
        {
          return Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);
            
        }



        public void LoadParentFolder()
        {
            string ParentFolder =  ConfigurationManager.AppSettings["ParentFolderPath"].ToString();

            string[] folderslist = GetFolderList(ParentFolder);
            List<ComboBoxItems> lstcmxitm = new List<ComboBoxItems>();
            for(int i = 0; i < folderslist.Length; i++)
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


        public void LoadChildFolder(ComboBoxItems folderpath)
        {
            
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


        #endregion

        private void cmbparentfolder_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbparentfolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cm = cmbparentfolder;
            ComboBoxItems selectedvalue = (ComboBoxItems)cm.SelectedItem;

            LoadChildFolder(selectedvalue);
            //MessageBox.Show(value);
        }

        private void cmbpanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cm = cmbpanel;
            ComboBoxItems selectedvalue = (ComboBoxItems)cm.SelectedItem;

            LoadFiles(selectedvalue);
        }

        public void LoadFiles(ComboBoxItems filespath)
        {
            string[] LaserFiles = Directory.GetFiles(filespath.Value, "*.las");
            //listLaserFiles.Items.Clear();
            List<ListBoxItems> listboxitm = new List<ListBoxItems>();
            ListBoxItems objlstboxitem = new ListBoxItems()
            {
                Text = "Double Click On File",
                Value = ""
            };
            listboxitm.Add(objlstboxitem);
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
            listLaserFiles.ScrollAlwaysVisible = true;
           // listLaserFiles.SelectionMode = SelectionMode.One;
           
            listLaserFiles.DataSource = listboxitm;// new BindingSource(listboxitm, null);
            listLaserFiles.ValueMember = "value";
            listLaserFiles.DisplayMember = "Text";


            //CSVFILELOADING


            string[] CSVFILES = Directory.GetFiles(filespath.Value, "*.csv");
            //listLaserFiles.Items.Clear();
            List<ListBoxItems> csvfilegrd = new List<ListBoxItems>();
            
            for (int i = 0; i < CSVFILES.Length; i++)
            {
                string FileName = CSVFILES[i].Substring(CSVFILES[i].LastIndexOf(@"\"));
                string text = FileName.Remove(0, 1);
                string value = CSVFILES[i];
                ListBoxItems csvfilelist = new ListBoxItems();
                csvfilelist.Text = text;
                csvfilelist.Value = value;
                csvfilegrd.Add(csvfilelist);
            }

            dgvcsvfiles.DataSource = csvfilegrd;
            


        }

        private void listLaserFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          
        }

        private void listLaserFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            ListBox lstbox = listLaserFiles;
            ListBoxItems selectedobjec = (ListBoxItems)lstbox.SelectedItem;
            if (selectedobjec.Value.Length > 1)
            {
                MessageBox.Show(selectedobjec.Text + " Selected For Execution");
            }
        }

        private void dgvcsvfiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvcsvfiles.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvcsvfiles.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvcsvfiles.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Text"].Value);
            }
        }
    }
}
