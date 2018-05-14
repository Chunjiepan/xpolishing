using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class nozzlecalibration : Form
    {
        string currentcfgfile = "";
        
        public nozzlecalibration()
        {
            //配置文件路径
            string rootpath = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\"));
            rootpath = rootpath.Substring(0, rootpath.LastIndexOf("\\")) + "\\" + "nozzlecalibration.config";
            //string rootpath = System.IO.Directory.GetCurrentDirectory() + "\\nozzlecalibration.config";
            currentcfgfile = rootpath;
            InitializeComponent();        
            load_form();
        }
        //取消按钮
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        //载入配置文件
        private void load_form()
        {

            //找节点
            System.Xml.XmlDocument xDoc = new System.Xml.XmlDocument();
            xDoc.Load(currentcfgfile);
            System.Xml.XmlNode xNode;
            xNode = xDoc.SelectSingleNode("//appSettings");
            //遍历所有domainupdown控件， 并赋值
            foreach (Control control in Controls) {
                foreach (Control soncontrol in control.Controls) {
                    switch (soncontrol.GetType().ToString()) {
                        case "System.Windows.Forms.NumericUpDown":
                            getcfgvalue(xNode, soncontrol);
                            break;
                        case "System.Windows.Forms.TextBox":
                            getcfgvalue(xNode, soncontrol);
                            break;
                    }
               }
            }
         }
        
   

        //保存配置文件
        private void save_form() {
            //找节点
            System.Xml.XmlDocument xDoc = new System.Xml.XmlDocument();
            xDoc.Load(currentcfgfile);
            System.Xml.XmlNode xNode;           
            xNode = xDoc.SelectSingleNode("//appSettings");
            //储存所有domainupdownd的值在配置文件
            //遍历所有domainupdown控件， 并赋值
            foreach (Control control in Controls)
            {
                foreach (Control soncontrol in control.Controls)
                {
                    switch (soncontrol.GetType().ToString())
                    {
                        case "System.Windows.Forms.NumericUpDown":
                            savecfgvalue(xNode, soncontrol);
                            break;
                        case "System.Windows.Forms.TextBox":
                            savecfgvalue(xNode, soncontrol);
                            break;
                    }
                }
            }
            xDoc.Save(currentcfgfile);
        }
        //从cfg取值
        private void getcfgvalue(System.Xml.XmlNode xNode, Control control)
        {
            System.Xml.XmlElement xElem1 = (System.Xml.XmlElement)xNode.SelectSingleNode("//add[@key='" + control.Name + "']");
            if (xElem1 != null && control is NumericUpDown)
            {
                NumericUpDown num = control as NumericUpDown;
                num.Value = decimal.Parse(xElem1.GetAttribute("value"));
            }
            else if (xElem1 != null) {
                control.Text = xElem1.GetAttribute("value");
            }
        }

        //保存到cfg      
        private void savecfgvalue(System.Xml.XmlNode xNode, Control control)
        {
            System.Xml.XmlElement xElem1 = (System.Xml.XmlElement)xNode.SelectSingleNode("//add[@key='" + control.Name + "']");
            if (xElem1 != null && control is NumericUpDown)
            {
                NumericUpDown num = control as NumericUpDown;
                xElem1.SetAttribute("value", num.Value.ToString());
            }
            if (xElem1 != null)
            {
                xElem1.SetAttribute("value", control.Text);
            }
        }

        //确定按钮
        private void button3_Click(object sender, EventArgs e)
        {
            save_form();


        }

        //保存参数文件按钮
        private void button1_Click(object sender, EventArgs e)
        {          
            save_form(); //先保存当前cfg文件     
            string localFilePath = "";//保存路径          
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "X-Polishing Files|*.psf";//过滤
            file.RestoreDirectory = true;//上次保存路径           
            if (file.ShowDialog() == DialogResult.OK)
            {
                localFilePath = file.FileName.ToString(); //获得要保存的文件路径和文件名             
                System.IO.File.Copy(currentcfgfile, file.FileName, true);
                //获取文件路径，不带文件名 
                //string fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //获取文件名，不带路径
                //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));                               
            }

        }

        //导入参数文件按钮
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "X-Polishing Files|*.psf";
            file.RestoreDirectory = true; // 
            if(file.ShowDialog() == DialogResult.OK)
            {
                string filepath = file.FileName;//返回文件的完整路径     
                load_form();           
            }
        }
    }
}
