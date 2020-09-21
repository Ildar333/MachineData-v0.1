using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Core;
using System.IO;

namespace MachineData
{
    public partial class Form1 : Form
    {
        List<string> cpuList { get; set; }
        CPU cpu { get; set; }

        HDD hdd { get; set; }

        GPU gpu { get; set; }

        OS os { get; set; }

        bool isActiveDrivers = false;

        public Form1()
        {
            InitializeComponent();
            
            comboBox1.DataSource = DriveInfo.GetDrives();
        }

        #region CPU

        private void btnCPU_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            comboBox1.Visible = false;
            cpuList = new List<string>();
            cpu = new CPU();
            pictureBox1.Image = new Bitmap(Environment.CurrentDirectory + "/Source/Images/cpu.png");
            SetControlCPU();
        }

        private List<string> SetCPUdata()
        {
            var result = new List<string>();
            result.Add("Name : ");
            result.Add("Device ID : ");
            result.Add("Manufacturer : ");
            result.Add("CurrentClockSpeed : ");
            result.Add("Caption : ");
            result.Add("Number of Cores : ");
            result.Add("Number of enable cores : ");
            result.Add("Architecture : ");
            result.Add("Family : ");
            result.Add("Processor type : ");
            result.Add("Characteristics : ");
            result.Add("AddresWidth : ");
            return result;
        }

        private void SetControlCPU()
        {
            cpuList = cpu.result;

            // 
            // textBox1
            //
            var textBox1 = new TextBox();
            textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox1.Location = new System.Drawing.Point(95, 39);
            textBox1.Name = new Core.Core.CPU().ReturnCPU()[0];
            textBox1.Size = new System.Drawing.Size(360, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = cpuList[0];
            textBox1.ReadOnly = true;
            panel3.Controls.Add(textBox1);


            // 
            // label1
            // 
            var label1 = new Label();
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(24, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 16);
            label1.TabIndex = 0;
            label1.Text = SetCPUdata()[0];
            panel3.Controls.Add(label1);


            // 
            // textBox2
            // 
            var textBox2 = new TextBox();
            textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox2.Location = new System.Drawing.Point(120, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.Text = cpuList[1];
            textBox2.ReadOnly = true;
            panel3.Controls.Add(textBox2);


            // 
            // label2
            // 
            var label2 = new Label();
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.ForeColor = System.Drawing.SystemColors.ControlText;
            label2.Location = new System.Drawing.Point(24, 72);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 16);
            label2.TabIndex = 2;
            label2.Text = SetCPUdata()[1];
            panel3.Controls.Add(label2);


            // 
            // textBox3
            // 
            var textBox3 = new TextBox();
            textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox3.Location = new System.Drawing.Point(135, 97);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(100, 23);
            textBox3.TabIndex = 5;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.Text = cpuList[2];
            textBox3.ReadOnly = true;
            panel3.Controls.Add(textBox3);


            // 
            // label3
            // 
            var label3 = new Label();
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.ForeColor = System.Drawing.SystemColors.ControlText;
            label3.Location = new System.Drawing.Point(24, 101);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 16);
            label3.TabIndex = 4;
            label3.Text = SetCPUdata()[2];
            panel3.Controls.Add(label3);


            // 
            // textBox4
            // 
            var textBox4 = new TextBox();
            textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox4.Location = new System.Drawing.Point(175, 184);
            textBox4.Name = "textBox4";
            textBox4.TabIndex = 11;
            textBox4.Size = new System.Drawing.Size(50, 23);
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.ReadOnly = true;
            textBox4.Text = cpuList[3];
            panel3.Controls.Add(textBox4);


            // 
            // label4
            //
            var label4 = new Label();
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.ForeColor = System.Drawing.SystemColors.ControlText;
            label4.Location = new System.Drawing.Point(24, 188);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(51, 16);
            label4.TabIndex = 10;
            label4.Text = SetCPUdata()[3];
            panel3.Controls.Add(label4);


            // 
            // textBox5
            // 
            var textBox5 = new TextBox();
            textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox5.Location = new System.Drawing.Point(95, 155);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(250, 23);
            textBox5.TabIndex = 9;
            textBox5.ReadOnly = true;
            textBox5.Text = cpuList[4];
            panel3.Controls.Add(textBox5);


            // 
            // label5
            // 
            var label5 = new Label();
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.ForeColor = System.Drawing.SystemColors.ControlText;
            label5.Location = new System.Drawing.Point(24, 159);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(51, 16);
            label5.TabIndex = 8;
            label5.Text = SetCPUdata()[4];
            panel3.Controls.Add(label5);


            // 
            // textBox6
            // 
            var textBox6 = new TextBox();
            textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox6.Location = new System.Drawing.Point(165, 126);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(25, 23);
            textBox6.TabIndex = 7;
            textBox6.TextAlign = HorizontalAlignment.Center;
            textBox6.ReadOnly = true;
            textBox6.Text = cpuList[5];
            panel3.Controls.Add(textBox6);


            // 
            // label6
            // 
            var label6 = new Label();
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label6.ForeColor = System.Drawing.SystemColors.ControlText;
            label6.Location = new System.Drawing.Point(24, 130);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(51, 16);
            label6.TabIndex = 6;
            label6.Text = SetCPUdata()[5];
            panel3.Controls.Add(label6);


            // 
            // textBox8
            // 
            var textBox8 = new TextBox();
            textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox8.Location = new System.Drawing.Point(450, 150);
            textBox8.Name = "textBox8";
            textBox8.Size = new System.Drawing.Size(25, 23);
            textBox8.TabIndex = 21;
            textBox8.Text = cpuList[7];
            textBox8.TextAlign = HorizontalAlignment.Center;
            panel3.Controls.Add(textBox8);


            // 
            // label8
            // 
            var label8 = new Label();
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label8.ForeColor = System.Drawing.SystemColors.ControlText;
            label8.Location = new System.Drawing.Point(352, 154);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(51, 16);
            label8.TabIndex = 20;
            textBox8.ReadOnly = true;
            label8.Text = SetCPUdata()[7];
            panel3.Controls.Add(label8);


            // 
            // textBox9
            // 
            var textBox9 = new TextBox();
            textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox9.Location = new System.Drawing.Point(423, 121);
            textBox9.Name = "textBox9";
            textBox9.Size = new System.Drawing.Size(25, 23);
            textBox9.TabIndex = 19;
            textBox9.ReadOnly = true;
            textBox9.Text = cpuList[8];
            textBox9.TextAlign = HorizontalAlignment.Center;
            panel3.Controls.Add(textBox9);


            // 
            // label9
            // 
            var label9 = new Label();
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label9.ForeColor = System.Drawing.SystemColors.ControlText;
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(352, 125);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(51, 16);
            label9.TabIndex = 18;
            label9.Text = SetCPUdata()[8];
            panel3.Controls.Add(label9);


            // 
            // textBox10
            // 
            var textBox10 = new TextBox();
            textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox10.Location = new System.Drawing.Point(473, 92);
            textBox10.Name = "textBox10";
            textBox10.Size = new System.Drawing.Size(25, 23);
            textBox10.TabIndex = 17;
            textBox10.ReadOnly = true;
            textBox10.Text = cpuList[9];
            textBox10.TextAlign = HorizontalAlignment.Center;
            panel3.Controls.Add(textBox10);


            // 
            // label10
            // 
            var label10 = new Label();
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label10.ForeColor = System.Drawing.SystemColors.ControlText;
            label10.Location = new System.Drawing.Point(352, 96);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(59, 16);
            label10.TabIndex = 16;
            label10.Text = SetCPUdata()[9];
            panel3.Controls.Add(label10);

            // 
            // textBox12
            // 
            var textBox12 = new TextBox();
            textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox12.Location = new System.Drawing.Point(460, 64);
            textBox12.Name = "textBox12";
            textBox12.Size = new System.Drawing.Size(25, 23);
            textBox12.TabIndex = 13;
            textBox12.Text = cpuList[11];
            textBox12.TextAlign = HorizontalAlignment.Center;
            textBox12.ReadOnly = true;
            panel3.Controls.Add(textBox12);


            // 
            // label12
            // 
            var label12 = new Label();
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label12.ForeColor = System.Drawing.SystemColors.ControlText;
            label12.Location = new System.Drawing.Point(352, 68);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(59, 16);
            label12.TabIndex = 12;
            label12.Text = SetCPUdata()[11];
            panel3.Controls.Add(label12);
        }

        #endregion

        #region HDD
        private List<string> SetHddData()
        {
            var result = new List<string>();

            result.Add("Name : ");
            result.Add("Drive type : ");
            result.Add("Volume label : ");
            result.Add("Drive format : ");
            result.Add("Available free space : ");
            result.Add("Total free space : ");
            result.Add("Total size : ");
            result.Add("Root directory : ");

            return result;
        }

        private void SetDriverArea(string[] labelTextArray, string[] textBoxTextArray)
        {
            // 
            // label1
            // 
            var label1 = new Label();

            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(37, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 17);
            label1.TabIndex = 0;
            label1.Text = labelTextArray[0];
            panel3.Controls.Add(label1);

            // 
            // textBox1
            // 
            var textBox1 = new TextBox();

            textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(124, 20);
            textBox1.Location = new System.Drawing.Point(155, 42);
            textBox1.TabIndex = 1;
            textBox1.ReadOnly = true;
            textBox1.Text = textBoxTextArray[0];
            panel3.Controls.Add(textBox1);

            // 
            // textBox2
            // 
            var textBox2 = new TextBox();

            textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox2.Location = new System.Drawing.Point(155, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(124, 20);
            textBox2.TabIndex = 3;
            textBox2.ReadOnly = true;
            textBox2.Text = textBoxTextArray[1];
            panel3.Controls.Add(textBox2);

            // 
            // label2
            // 
            var label2 = new Label();

            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(37, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 17);
            label2.TabIndex = 2;
            label2.Text = labelTextArray[1];
            panel3.Controls.Add(label2);

            // 
            // textBox3
            // 
            var textBox3 = new TextBox();

            textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox3.Location = new System.Drawing.Point(155, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(124, 20);
            textBox3.TabIndex = 5;
            textBox3.ReadOnly = true;
            textBox3.Text = textBoxTextArray[2];
            panel3.Controls.Add(textBox3);

            // 
            // label3
            // 
            var label3 = new Label();
            
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(37, 97);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 17);
            label3.TabIndex = 4;
            label3.Text = labelTextArray[2];
            panel3.Controls.Add(label3);

            // 
            // textBox4
            // 
            var textBox4 = new TextBox();

            textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox4.Location = new System.Drawing.Point(155, 120);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(124, 20);
            textBox4.TabIndex = 7;
            textBox4.ReadOnly = true;
            textBox4.Text = textBoxTextArray[3];
            panel3.Controls.Add(textBox4);

            // 
            // label4
            // 
            var label4 = new Label();

            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(37, 123);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(52, 17);
            label4.TabIndex = 6;
            label4.Text = labelTextArray[3];
            panel3.Controls.Add(label4);

            // 
            // textBox5
            // 
            var textBox5 = new TextBox();

            textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox5.Location = new System.Drawing.Point(470, 42);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(124, 20);
            textBox5.TabIndex = 15;
            textBox5.ReadOnly = true;
            textBox5.Text = labelTextArray[4];
            panel3.Controls.Add(textBox5);

            // 
            // label5
            // 
            var label5 = new Label();
            
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(300, 47);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 17);
            label5.TabIndex = 14;
            label5.Text = labelTextArray[4];
            panel3.Controls.Add(label5);

            // 
            // textBox6
            // 
            var textBox6 = new TextBox();

            textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox6.Location = new System.Drawing.Point(470, 68);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(124, 20);
            textBox6.TabIndex = 13;
            textBox6.ReadOnly = true;
            textBox6.Text = labelTextArray[5];
            panel3.Controls.Add(textBox6);

            // 
            // label6
            // 
            var label6 = new Label();
            
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(300, 73);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(52, 17);
            label6.TabIndex = 12;
            label6.Text = labelTextArray[5];
            panel3.Controls.Add(label6);

            // 
            // textBox7
            // 
            var textBox7 = new TextBox();

            textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox7.Location = new System.Drawing.Point(470, 94);
            textBox7.Name = "textBox7";
            textBox7.Size = new System.Drawing.Size(124, 20);
            textBox7.TabIndex = 11;
            textBox7.ReadOnly = true;
            textBox7.Text = textBoxTextArray[6];
            panel3.Controls.Add(textBox7);

            // 
            // label7
            // 
            var label7 = new Label();

            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(300, 97);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(52, 17);
            label7.TabIndex = 10;
            label7.Text = labelTextArray[6];
            panel3.Controls.Add(label7);

            // 
            // textBox8
            // 
            var textBox8 = new TextBox();

            textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox8.Location = new System.Drawing.Point(470, 120);
            textBox8.Name = "textBox8";
            textBox8.Size = new System.Drawing.Size(124, 20);
            textBox8.TabIndex = 9;
            textBox8.ReadOnly = true;
            textBox8.Text = textBoxTextArray[7];
            panel3.Controls.Add(textBox8);

            // 
            // label8
            // 
            var label8 = new Label();
            
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label8.ForeColor = System.Drawing.Color.Black;
            label8.Location = new System.Drawing.Point(300, 123);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(52, 17);
            label8.TabIndex = 8;
            label8.Text = labelTextArray[7];
            panel3.Controls.Add(label8);
        }


        private void btnHDD_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            hdd = new HDD();
            isActiveDrivers = true;


            pictureBox1.Image = new Bitmap(Environment.CurrentDirectory + "/Source/Images/hdd.jpg");

            comboBox1.Visible = true;
            SetDriverArea(SetHddData().ToArray(), hdd.collection[0].ToArray());
            SelectDrive();

        }

        private void SelectDrive()
        {
            if (isActiveDrivers) 
            {
                var index = comboBox1.SelectedIndex;
                SetDriverArea(SetHddData().ToArray(), hdd.collection[index].ToArray());
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isActiveDrivers)
            {
                panel3.Controls.Clear();
                SetDriverArea(SetHddData().ToArray(), hdd.collection[comboBox1.SelectedIndex].ToArray());
                panel3.Refresh();
            }
        }
        #endregion

        #region GPU
        private List<string> SetGPU()
        {
            var result = new List<string>();
            result.Add("Name : ");
            result.Add("Status : ");
            result.Add("Caption : ");
            result.Add("Device ID : ");
            result.Add("AdapterRAM :");
            result.Add("AdapterDACType : ");
            result.Add("Monochrome : ");
            result.Add("InstalledDisplayDrivers : ");
            result.Add("DriverVersion : ");
            result.Add("VideoProcessor : ");
            result.Add("VideoArchitecture : ");
            result.Add("VideoMemoryType : ");
            return result;
        }

        private void SetControlGPU(string[] labelText, string[] txtText)
        {
            // 
            // textBox1
            //
            var textBox1 = new TextBox();
            textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox1.Location = new System.Drawing.Point(24, 39);
            textBox1.Name = new Core.Core.CPU().ReturnCPU()[0];
            textBox1.Size = new System.Drawing.Size(550, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = txtText[0];
            textBox1.ReadOnly = true;
            textBox1.TextAlign = HorizontalAlignment.Center;
            panel3.Controls.Add(textBox1);

            //ntel(R) G33/G31 Express Chipset Family (Microsoft Corporation - WDDM 1.0)
            // nternal
            // 
            // label1
            // 
            var label1 = new Label();
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(24, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 16);
            label1.TabIndex = 0;
            label1.Text = labelText[0];
            panel3.Controls.Add(label1);


            // 
            // textBox2
            // 
            var textBox2 = new TextBox();
            textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox2.Location = new System.Drawing.Point(95, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.Text = txtText[1];
            textBox2.ReadOnly = true;
            panel3.Controls.Add(textBox2);


            // 
            // label2
            // 
            var label2 = new Label();
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.ForeColor = System.Drawing.SystemColors.ControlText;
            label2.Location = new System.Drawing.Point(24, 130);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 16);
            label2.TabIndex = 2;
            label2.Text = labelText[1];
            panel3.Controls.Add(label2);


            // 
            // textBox3
            // 
            var textBox3 = new TextBox();
            textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox3.Location = new System.Drawing.Point(25, 97);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(550, 23);
            textBox3.TabIndex = 5;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.Text = txtText[2];
            textBox3.ReadOnly = true;
            panel3.Controls.Add(textBox3);


            // 
            // label3
            // 
            var label3 = new Label();
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.ForeColor = System.Drawing.SystemColors.ControlText;
            label3.Location = new System.Drawing.Point(24, 75);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 16);
            label3.TabIndex = 4;
            label3.Text = labelText[2];
            panel3.Controls.Add(label3);


            // 
            // textBox4
            // 
            var textBox4 = new TextBox();
            textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox4.Location = new System.Drawing.Point(115, 151);
            textBox4.Name = "textBox4";
            textBox4.TabIndex = 11;
            textBox4.Size = new System.Drawing.Size(125, 23);
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.ReadOnly = true;
            textBox4.Text = txtText[3];
            panel3.Controls.Add(textBox4);


            // 
            // label4
            //
            var label4 = new Label();
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.ForeColor = System.Drawing.SystemColors.ControlText;
            label4.Location = new System.Drawing.Point(24, 155);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(51, 16);
            label4.TabIndex = 10;
            label4.Text = labelText[3];
            panel3.Controls.Add(label4);


            // 
            // textBox5
            // 
            var textBox5 = new TextBox();
            textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox5.Location = new System.Drawing.Point(135, 176);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(135, 23);
            textBox5.TabIndex = 9;
            textBox5.ReadOnly = true;
            textBox5.Text = txtText[4];
            textBox5.TextAlign = HorizontalAlignment.Center;
            panel3.Controls.Add(textBox5);


            // 
            // label5
            // 
            var label5 = new Label();
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.ForeColor = System.Drawing.SystemColors.ControlText;
            label5.Location = new System.Drawing.Point(24, 180);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(51, 16);
            label5.TabIndex = 8;
            label5.Text = labelText[4];
            panel3.Controls.Add(label5);


            // 
            // textBox6
            // 
            var textBox6 = new TextBox();
            textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox6.Location = new System.Drawing.Point(165, 201);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(105, 23);
            textBox6.TabIndex = 7;
            textBox6.TextAlign = HorizontalAlignment.Center;
            textBox6.ReadOnly = true;
            textBox6.Text = txtText[5];
            panel3.Controls.Add(textBox6);


            // 
            // label6
            // 
            var label6 = new Label();
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label6.ForeColor = System.Drawing.SystemColors.ControlText;
            label6.Location = new System.Drawing.Point(24, 205);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(51, 16);
            label6.TabIndex = 6;
            label6.Text = labelText[5];
            panel3.Controls.Add(label6);


            // 
            // textBox8
            // 
            var textBox8 = new TextBox();
            textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox8.Location = new System.Drawing.Point(435, 126);
            textBox8.Name = "textBox8";
            textBox8.Size = new System.Drawing.Size(105, 23);
            textBox8.TabIndex = 21;
            textBox8.Text = txtText[7];
            textBox8.TextAlign = HorizontalAlignment.Center;
            panel3.Controls.Add(textBox8);


            // 
            // label8
            // 
            var label8 = new Label();
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label8.ForeColor = System.Drawing.SystemColors.ControlText;
            label8.Location = new System.Drawing.Point(252, 130);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(51, 16);
            label8.TabIndex = 20;
            textBox8.ReadOnly = true;
            label8.Text = labelText[7];
            panel3.Controls.Add(label8);


            // 
            // textBox9
            // 
            var textBox9 = new TextBox();
            textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox9.Location = new System.Drawing.Point(365, 151);
            textBox9.Name = "textBox9";
            textBox9.Size = new System.Drawing.Size(105, 23);
            textBox9.TabIndex = 19;
            textBox9.ReadOnly = true;
            textBox9.Text = txtText[8];
            textBox9.TextAlign = HorizontalAlignment.Center;
            panel3.Controls.Add(textBox9);


            // 
            // label9
            // 
            var label9 = new Label();
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label9.ForeColor = System.Drawing.SystemColors.ControlText;
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(252, 155);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(51, 16);
            label9.TabIndex = 18;
            label9.Text = labelText[8];
            panel3.Controls.Add(label9);


            // 
            // textBox10
            // 
            var textBox10 = new TextBox();
            textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox10.Location = new System.Drawing.Point(415, 201);
            textBox10.Name = "textBox10";
            textBox10.Size = new System.Drawing.Size(135, 23);
            textBox10.TabIndex = 17;
            textBox10.ReadOnly = true;
            textBox10.Text = txtText[9];
            textBox10.TextAlign = HorizontalAlignment.Center;
            panel3.Controls.Add(textBox10);


            // 
            // label10
            // 
            var label10 = new Label();
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label10.ForeColor = System.Drawing.SystemColors.ControlText;
            label10.Location = new System.Drawing.Point(282, 205);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(59, 16);
            label10.TabIndex = 16;
            label10.Text = labelText[9];
            panel3.Controls.Add(label10);

            // 
            // textBox12
            // 
            var textBox12 = new TextBox();
            textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox12.Location = new System.Drawing.Point(435, 176);
            textBox12.Name = "textBox12";
            textBox12.Size = new System.Drawing.Size(55, 23);
            textBox12.TabIndex = 13;
            textBox12.Text = txtText[11];
            textBox12.TextAlign = HorizontalAlignment.Center;
            textBox12.ReadOnly = true;
            panel3.Controls.Add(textBox12);


            // 
            // label12
            // 
            var label12 = new Label();
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label12.ForeColor = System.Drawing.SystemColors.ControlText;
            label12.Location = new System.Drawing.Point(282, 180);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(59, 16);
            label12.TabIndex = 12;
            label12.Text = labelText[11];
            panel3.Controls.Add(label12);
        }

        private void btnGPU_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            panel3.Controls.Clear();
            gpu = new GPU();
            pictureBox1.Image = new Bitmap(Environment.CurrentDirectory + "/Source/Images/gpu.png");
            SetControlGPU(SetGPU().ToArray(), gpu.collection.ToArray());
        }
        #endregion

        #region OS
        private void SetSystemArea(string[] arrayText) 
        {
            // 
            // textBox1
            // 
            var textBox1 = new TextBox();
            textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox1.Location = new System.Drawing.Point(128, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(276, 23);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.ReadOnly = true;
            textBox1.Text = arrayText[0];
            panel3.Controls.Add(textBox1);

            // 
            // label1
            // 
            var label1 = new Label();
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(49, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 17);
            label1.TabIndex = 1;
            label1.Text = "Caption :";
            panel3.Controls.Add(label1);

            // 
            // label2
            // 
            var label2 = new Label();
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(49, 63);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(160, 17);
            label2.TabIndex = 3;
            label2.Text = "Windows directory :  ";
            label2.Click += new System.EventHandler(this.label2_Click);
            panel3.Controls.Add(label2);

            // 
            // textBox2
            // 
            var textBox2 = new TextBox();
            textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox2.Location = new System.Drawing.Point(215, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(189, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.ReadOnly = true;
            textBox2.Text = arrayText[1];
            panel3.Controls.Add(textBox2);

            // 
            // label3
            // 
            var label3 = new Label();
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(49, 92);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(110, 17);
            label3.TabIndex = 5;
            label3.Text = "Product type :";
            panel3.Controls.Add(label3);

            // 
            // textBox3
            // 
            var textBox3 = new TextBox(); 
            textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox3.Location = new System.Drawing.Point(165, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(76, 23);
            textBox3.TabIndex = 4;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.ReadOnly = true;
            textBox3.Text = arrayText[2];
            panel3.Controls.Add(textBox3);

            // 
            // label4
            // 
            var label4 = new Label();
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.Location = new System.Drawing.Point(49, 121);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(119, 17);
            label4.TabIndex = 7;
            label4.Text = "Serial number :";
            panel3.Controls.Add(label4);

            // 
            // textBox4
            // 
            var textBox4 = new TextBox();
            textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox4.Location = new System.Drawing.Point(174, 118);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(230, 23);
            textBox4.TabIndex = 6;
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.ReadOnly = true;
            textBox4.Text = arrayText[3];
            panel3.Controls.Add(textBox4);

            // 
            // label5
            // 
            var label5 = new Label();
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.Location = new System.Drawing.Point(49, 150);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(139, 17);
            label5.TabIndex = 9;
            label5.Text = "System directory :";
            panel3.Controls.Add(label5);

            // 
            // textBox5
            // 
            var textBox5 = new TextBox();
            textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox5.Location = new System.Drawing.Point(194, 147);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(210, 23);
            textBox5.TabIndex = 8;
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.ReadOnly = true;
            textBox5.Text = arrayText[4];
            panel3.Controls.Add(textBox5);

            // 
            // label6
            // 
            var label6 = new Label();
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label6.Location = new System.Drawing.Point(49, 179);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(114, 17);
            label6.TabIndex = 19;
            label6.Text = "Country code :";
            panel3.Controls.Add(label6);

            // 
            // textBox6
            // 
            var textBox6 = new TextBox();
            textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox6.Location = new System.Drawing.Point(169, 176);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(63, 23);
            textBox6.TabIndex = 18;
            textBox6.TextAlign = HorizontalAlignment.Center;
            textBox6.ReadOnly = true;
            textBox6.Text = arrayText[5];
            panel3.Controls.Add(textBox6);

            // 
            // label7
            // 
            var label7 = new Label();
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label7.Location = new System.Drawing.Point(49, 208);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(142, 17);
            label7.TabIndex = 17;
            label7.Text = "Current timezone :";
            panel3.Controls.Add(label7);

            // 
            // textBox7
            // 
            var textBox7 = new TextBox();
            textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox7.Location = new System.Drawing.Point(197, 205);
            textBox7.Name = "textBox7";
            textBox7.Size = new System.Drawing.Size(68, 23);
            textBox7.TabIndex = 16;
            textBox7.TextAlign = HorizontalAlignment.Center;
            textBox7.ReadOnly = true;
            textBox7.Text = arrayText[6];
            panel3.Controls.Add(textBox7);

            // 
            // label8
            // 
            var label8 = new Label();
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label8.Location = new System.Drawing.Point(49, 237);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(134, 17);
            label8.TabIndex = 15;
            label8.Text = "Encryption level :";
            panel3.Controls.Add(label8);

            // 
            // textBox8
            // 
            var textBox8 = new TextBox();
            textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox8.Location = new System.Drawing.Point(189, 234);
            textBox8.Name = "textBox8";
            textBox8.Size = new System.Drawing.Size(76, 23);
            textBox8.TabIndex = 14;
            textBox8.TextAlign = HorizontalAlignment.Center;
            textBox8.ReadOnly = true;
            textBox8.Text = arrayText[7];
            panel3.Controls.Add(textBox8);

            // 
            // label9
            // 
            var label9 = new Label();
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label9.Location = new System.Drawing.Point(49, 266);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(183, 17);
            label9.TabIndex = 13;
            label9.Text = "Operating System type :";
            panel3.Controls.Add(label9);

            // 
            // textBox9
            // 
            var textBox9 = new TextBox();
            textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox9.Location = new System.Drawing.Point(238, 263);
            textBox9.Name = "textBox9";
            textBox9.Size = new System.Drawing.Size(59, 23);
            textBox9.TabIndex = 12;
            textBox9.TextAlign = HorizontalAlignment.Center;
            textBox9.ReadOnly = true;
            textBox9.Text = arrayText[8];
            panel3.Controls.Add(textBox9);

            // 
            // label10
            // 
            var label10 = new Label();
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label10.Location = new System.Drawing.Point(49, 295);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(73, 17);
            label10.TabIndex = 11;
            label10.Text = "Version :";
            panel3.Controls.Add(label10);

            // 
            // textBox10
            // 
            var textBox10 = new TextBox();
            textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            textBox10.Location = new System.Drawing.Point(128, 292);
            textBox10.Name = "textBox10";
            textBox10.Size = new System.Drawing.Size(161, 23);
            textBox10.TabIndex = 10;
            textBox10.TextAlign = HorizontalAlignment.Center;
            textBox10.ReadOnly = true;
            textBox10.Text = arrayText[9];
            panel3.Controls.Add(textBox10);
        }

        #endregion

        #region Excess
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnSystem_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            os = new OS();
            SetSystemArea(os.collection.ToArray());
            pictureBox1.Image = new Bitmap(Environment.CurrentDirectory + "/Source/Images/os.png");
            comboBox1.Visible = false;
        }
    }
}
