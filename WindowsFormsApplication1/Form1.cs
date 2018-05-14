using DevExpress.XtraBars.Alerter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public partial class polishing : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public polishing()
        {
            InitializeComponent();
            InitTask();
        }

        private void InitTask() {
            Tasks task = new WindowsFormsApplication1.Tasks();
            propertyGrid1.SelectedObject = task;
            task.Maximumprintimagewidth = 7168;
            task.Name = "default";
            task.Targettimes = 6;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.defaultLookAndFeel1.LookAndFeel.SkinMaskColor = System.Drawing.Color.SkyBlue;
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.defaultLookAndFeel1.LookAndFeel.SkinMaskColor = Color.DarkSlateGray;
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.defaultLookAndFeel1.LookAndFeel.SkinMaskColor = Color.Gray;
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.defaultLookAndFeel1.LookAndFeel.SkinMaskColor = Color.LawnGreen;
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AboutBox1 aboutbox = new AboutBox1();
            aboutbox.ShowDialog();
            
        }

        private void propertyGridDockPanel2_Click(object sender, EventArgs e)
        {

        }

        //新建按钮
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        //打开按钮
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "X-Polishing Files|*.psf";
            file.RestoreDirectory = true; // 上次打开目录
            file.ShowDialog();
            /*if (file.ShowDialog() == DialogResult.OK)
            {
                string filepath = file.FileName;//返回文件的完整路径                
            }*/
        }

        //保存按钮
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //string localFilePath = "";          
            SaveFileDialog file = new SaveFileDialog();         
            file.Filter = "X-Polishing Files|*.psf";//过滤
            file.RestoreDirectory = true;//上次保存路径
            file.ShowDialog();
            /*if (file.ShowDialog() == DialogResult.OK)
            {
                localFilePath = file.FileName.ToString(); //获得文件路径 
                string fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //获取文件名，不带路径

                //获取文件路径，不带文件名 
                //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));                               
            }
            return localFilePath;*/
        }

        private void barCheckItem3_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barCheckItem3.Checked)
            {
                ribbonStatusBar1.Visible = true;
            }
            else {
                ribbonStatusBar1.Visible = false;
            }
        }

        private void barCheckItem5_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barCheckItem5.Checked)
            {
                dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            }
            else {
                dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            }
            
        }

        //打开系统配置
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Systemsetting system = new Systemsetting();
            system.ShowDialog();
        }

        //打开喷头校准
        private void pentouxiaozhu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nozzlecalibration nozzle = new nozzlecalibration();
            nozzle.ShowDialog();
        }
    }
}
