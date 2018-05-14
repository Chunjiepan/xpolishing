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

namespace WindowsFormsApplication1
{
    public partial class Systemsetting : Form
    {
        string currentcfgfile = "";
        public Systemsetting()
        {
            //配置文件路径
            string rootpath = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\"));
            rootpath = rootpath.Substring(0, rootpath.LastIndexOf("\\")) + "\\" + "systemsetting.config";
            //string rootpath = Application.CommonAppDataPath + "\\systemsetting.config";
            //string rootpath = Directory.GetCurrentDirectory()+"\\systemsetting.config";
            currentcfgfile = rootpath;
            InitializeComponent();
            load_form();
        }
        //取消按钮
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        //确定按钮
        private void button2_Click(object sender, EventArgs e)
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
        //导入参数文件
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "X-Polishing Files|*.psf";
            file.RestoreDirectory = true; // 
            if (file.ShowDialog() == DialogResult.OK)
            {
                string filepath = file.FileName;//返回文件的完整路径     
                load_form();
            }
        }

        //从cfg取值
        private void getcfgvalue(System.Xml.XmlNode xNode, Control control)
        {
            System.Xml.XmlElement xElem1 = (System.Xml.XmlElement)xNode.SelectSingleNode("//add[@key='" + control.Name + "']");
            if (xElem1 != null && control.GetType().ToString() == "System.Windows.Forms.CheckBox")
            {
                CheckBox ck = control as CheckBox;
                if (xElem1.GetAttribute("value") == "True")
                {
                    ck.Checked = true;
                }
                else {
                    ck.Checked = false;
                }
            }
            else if (xElem1 != null && control is TextBox){
                control.Text = xElem1.GetAttribute("value");
            }
        }

        //保存到cfg      
        private void savecfgvalue(System.Xml.XmlNode xNode, Control control)
        {
            System.Xml.XmlElement xElem1 = (System.Xml.XmlElement)xNode.SelectSingleNode("//add[@key='" + control.Name + "']");
            if (xElem1 != null && control.GetType().ToString() == "System.Windows.Forms.CheckBox")
            {
                CheckBox ck = control as CheckBox;
                if (ck.Checked == true)
                {
                    xElem1.SetAttribute("value","True");
                    
                }
                else {
                    xElem1.SetAttribute("value", "false");
                }
            }
            else if (xElem1 != null && control is TextBox)
            {
                 xElem1.SetAttribute("value", control.Text);
            }
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
            foreach (Control control in this.panel1.Controls)
            {
                getcfgvalue(xNode, control);
            }
            foreach (Control control in this.groupBox1.Controls)
            {
                getcfgvalue(xNode, control);
            }
            foreach (Control control in this.groupBox2.Controls)
            {
                getcfgvalue(xNode, control);
            }
            foreach (Control control in this.groupBox3.Controls)
            {
                getcfgvalue(xNode, control);
            }         

        }
        //保存配置文件
        private void save_form()
        {
            //找节点
            System.Xml.XmlDocument xDoc = new System.Xml.XmlDocument();
            xDoc.Load(currentcfgfile);
            System.Xml.XmlNode xNode;
            xNode = xDoc.SelectSingleNode("//appSettings");
            //储存所有domainupdownd的值在配置文件
            //遍历所有domainupdown控件， 并保存
            
            foreach (Control control in this.panel1.Controls)
            {
                savecfgvalue(xNode, control);
            }
            foreach (Control control in this.groupBox1.Controls)
            {
                savecfgvalue(xNode, control);
            }
            foreach (Control control in this.groupBox2.Controls)
            {
                savecfgvalue(xNode, control);
            }
            foreach (Control control in this.groupBox3.Controls)
            {
                savecfgvalue(xNode, control);
            }
            xDoc.Save(currentcfgfile);
        }
       
    }
}
