using System.Linq;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    partial class Systemsetting
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
       /* public void systemsetting_load() {
            using (var db = new Systemsetting())
            {
                var query = db.systemsettings.Count();
               // if()
        }
            
        }*/
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.printinterval = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.paperdpi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lightcheckdelay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codewheeldiameter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(615, 624);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.printinterval);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.paperdpi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lightcheckdelay);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.codewheeldiameter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 96);
            this.panel1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(554, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "mm";
            // 
            // printinterval
            // 
            this.printinterval.Location = new System.Drawing.Point(456, 59);
            this.printinterval.Name = "printinterval";
            this.printinterval.Size = new System.Drawing.Size(83, 22);
            this.printinterval.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "自触发打印间隔：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "dpi";
            // 
            // paperdpi
            // 
            this.paperdpi.Location = new System.Drawing.Point(471, 16);
            this.paperdpi.Name = "paperdpi";
            this.paperdpi.Size = new System.Drawing.Size(83, 22);
            this.paperdpi.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "走纸分辨率(200~2400)：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "0.1mm";
            // 
            // lightcheckdelay
            // 
            this.lightcheckdelay.Location = new System.Drawing.Point(97, 59);
            this.lightcheckdelay.Name = "lightcheckdelay";
            this.lightcheckdelay.Size = new System.Drawing.Size(83, 22);
            this.lightcheckdelay.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "光检延时：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "(单位：0.1mm)";
            // 
            // codewheeldiameter
            // 
            this.codewheeldiameter.Location = new System.Drawing.Point(97, 16);
            this.codewheeldiameter.Name = "codewheeldiameter";
            this.codewheeldiameter.Size = new System.Drawing.Size(83, 22);
            this.codewheeldiameter.TabIndex = 13;
            this.codewheeldiameter.Text = "s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "码盘轮直径：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.textBox12);
            this.groupBox3.Controls.Add(this.textBox13);
            this.groupBox3.Controls.Add(this.textBox14);
            this.groupBox3.Controls.Add(this.textBox15);
            this.groupBox3.Controls.Add(this.textBox16);
            this.groupBox3.Controls.Add(this.textBox17);
            this.groupBox3.Controls.Add(this.textBox18);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Location = new System.Drawing.Point(3, 376);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 115);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "模组配置";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(532, 41);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(26, 17);
            this.label26.TabIndex = 54;
            this.label26.Text = "U7";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(468, 41);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(26, 17);
            this.label27.TabIndex = 53;
            this.label27.Text = "U6";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(393, 41);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(26, 17);
            this.label28.TabIndex = 52;
            this.label28.Text = "U5";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(330, 41);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(26, 17);
            this.label29.TabIndex = 51;
            this.label29.Text = "U4";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(262, 41);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(26, 17);
            this.label30.TabIndex = 50;
            this.label30.Text = "U3";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(193, 41);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(26, 17);
            this.label31.TabIndex = 49;
            this.label31.Text = "U2";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(121, 41);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(26, 17);
            this.label32.TabIndex = 48;
            this.label32.Text = "U1";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(528, 70);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(44, 22);
            this.textBox12.TabIndex = 47;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(465, 70);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(44, 22);
            this.textBox13.TabIndex = 46;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(389, 70);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(44, 22);
            this.textBox14.TabIndex = 45;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(325, 70);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(44, 22);
            this.textBox15.TabIndex = 44;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(257, 70);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(44, 22);
            this.textBox16.TabIndex = 43;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(186, 70);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(44, 22);
            this.textBox17.TabIndex = 42;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(110, 70);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(44, 22);
            this.textBox18.TabIndex = 41;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(12, 71);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(54, 17);
            this.label33.TabIndex = 12;
            this.label33.Text = "label33";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dropDownButton1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(3, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 131);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "模组配置";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(522, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "U7";
            // 
            // checkBox7
            // 
            this.checkBox7.Location = new System.Drawing.Point(528, 92);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(30, 24);
            this.checkBox7.TabIndex = 25;
            this.checkBox7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.Location = new System.Drawing.Point(456, 92);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(30, 24);
            this.checkBox6.TabIndex = 24;
            this.checkBox6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.Location = new System.Drawing.Point(389, 92);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(30, 24);
            this.checkBox5.TabIndex = 23;
            this.checkBox5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Location = new System.Drawing.Point(322, 92);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(30, 24);
            this.checkBox4.TabIndex = 22;
            this.checkBox4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(256, 92);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(30, 24);
            this.checkBox3.TabIndex = 21;
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(189, 92);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(30, 24);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(124, 92);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(30, 24);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(453, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 17);
            this.label17.TabIndex = 18;
            this.label17.Text = "U6";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(386, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 17);
            this.label16.TabIndex = 17;
            this.label16.Text = "U5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(319, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 17);
            this.label15.TabIndex = 16;
            this.label15.Text = "U4";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(254, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "U3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(186, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "U2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(121, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "U1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "label11";
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Location = new System.Drawing.Point(90, 31);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(74, 23);
            this.dropDownButton1.TabIndex = 11;
            this.dropDownButton1.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "label10";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Location = new System.Drawing.Point(3, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 115);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "模组配置";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(532, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 17);
            this.label18.TabIndex = 40;
            this.label18.Text = "U7";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(468, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 17);
            this.label19.TabIndex = 39;
            this.label19.Text = "U6";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(393, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 17);
            this.label20.TabIndex = 38;
            this.label20.Text = "U5";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(330, 42);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 17);
            this.label21.TabIndex = 37;
            this.label21.Text = "U4";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(262, 42);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(26, 17);
            this.label22.TabIndex = 36;
            this.label22.Text = "U3";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(193, 42);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(26, 17);
            this.label23.TabIndex = 35;
            this.label23.Text = "U2";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(121, 42);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(26, 17);
            this.label24.TabIndex = 34;
            this.label24.Text = "U1";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(528, 71);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(44, 22);
            this.textBox11.TabIndex = 33;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(465, 71);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(44, 22);
            this.textBox10.TabIndex = 32;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(389, 71);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(44, 22);
            this.textBox9.TabIndex = 31;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(325, 71);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(44, 22);
            this.textBox8.TabIndex = 30;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(257, 71);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(44, 22);
            this.textBox7.TabIndex = 29;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(186, 71);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(44, 22);
            this.textBox6.TabIndex = 28;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(110, 71);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(44, 22);
            this.textBox5.TabIndex = 27;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(12, 71);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 17);
            this.label25.TabIndex = 12;
            this.label25.Text = "label25";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 108);
            this.panel2.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(405, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 31);
            this.button4.TabIndex = 3;
            this.button4.Text = "取消";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(90, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "导入参数文件";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "确定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "保存参数文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Systemsetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(637, 623);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Systemsetting";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "系统配置";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox printinterval;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox paperdpi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lightcheckdelay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codewheeldiameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
    }

    
}