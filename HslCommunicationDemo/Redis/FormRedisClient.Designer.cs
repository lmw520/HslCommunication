﻿namespace HslCommunicationDemo
{
    partial class FormRedisClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
			this.panel1 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button12 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.userControlHead1 = new HslCommunicationDemo.DemoControl.UserControlHead();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(15, 38);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(978, 83);
			this.panel1.TabIndex = 7;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(798, 45);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(168, 28);
			this.button6.TabIndex = 9;
			this.button6.Text = "压力测试";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(798, 11);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(168, 28);
			this.button5.TabIndex = 8;
			this.button5.Text = "启动短连接";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(81, 47);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(384, 23);
			this.textBox3.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 17);
			this.label6.TabIndex = 6;
			this.label6.Text = "pwd:";
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(584, 11);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(91, 28);
			this.button2.TabIndex = 5;
			this.button2.Text = "disconnect";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(477, 11);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(91, 28);
			this.button1.TabIndex = 4;
			this.button1.Text = "connect";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(305, 14);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(141, 23);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "6379";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(251, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "port:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(81, 14);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(141, 23);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "127.0.0.1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ip addr:";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.button12);
			this.panel2.Controls.Add(this.button11);
			this.panel2.Controls.Add(this.button10);
			this.panel2.Controls.Add(this.button9);
			this.panel2.Controls.Add(this.button8);
			this.panel2.Controls.Add(this.button7);
			this.panel2.Controls.Add(this.textBox8);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.textBox9);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.button4);
			this.panel2.Controls.Add(this.textBox10);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.textBox11);
			this.panel2.Controls.Add(this.label14);
			this.panel2.Controls.Add(this.textBox7);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.textBox6);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.textBox4);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.textBox5);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Location = new System.Drawing.Point(15, 126);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(977, 518);
			this.panel2.TabIndex = 13;
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(328, 180);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(91, 28);
			this.button12.TabIndex = 31;
			this.button12.Text = "publish key";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.button12_Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(825, 180);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(91, 28);
			this.button11.TabIndex = 30;
			this.button11.Text = "list length";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(728, 180);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(91, 28);
			this.button10.TabIndex = 29;
			this.button10.Text = "list shrink";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(631, 180);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(91, 28);
			this.button9.TabIndex = 28;
			this.button9.Text = "list add";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(367, 234);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(110, 28);
			this.button8.TabIndex = 27;
			this.button8.Text = "customer";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(863, 234);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(91, 28);
			this.button7.TabIndex = 26;
			this.button7.Text = "clear";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(769, 237);
			this.textBox8.Name = "textBox8";
			this.textBox8.ReadOnly = true;
			this.textBox8.Size = new System.Drawing.Size(88, 23);
			this.textBox8.TabIndex = 25;
			this.textBox8.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(719, 241);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(47, 17);
			this.label8.TabIndex = 24;
			this.label8.Text = "spend:";
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(633, 238);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(80, 23);
			this.textBox9.TabIndex = 23;
			this.textBox9.Text = "1";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(583, 241);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(51, 17);
			this.label12.TabIndex = 22;
			this.label12.Text = "times：";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(270, 235);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(91, 28);
			this.button4.TabIndex = 21;
			this.button4.Text = "request";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click_1);
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(62, 266);
			this.textBox10.Multiline = true;
			this.textBox10.Name = "textBox10";
			this.textBox10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox10.Size = new System.Drawing.Size(892, 244);
			this.textBox10.TabIndex = 18;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(8, 269);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(41, 17);
			this.label13.TabIndex = 20;
			this.label13.Text = "text：";
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(62, 237);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(202, 23);
			this.textBox11.TabIndex = 19;
			this.textBox11.Text = "A";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(8, 241);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(40, 17);
			this.label14.TabIndex = 17;
			this.label14.Text = "key：";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(544, 183);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(66, 23);
			this.textBox7.TabIndex = 16;
			this.textBox7.Text = "0";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(494, 186);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(44, 17);
			this.label11.TabIndex = 15;
			this.label11.Text = "耗时：";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(220, 183);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(76, 23);
			this.textBox6.TabIndex = 14;
			this.textBox6.Text = "1";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(173, 186);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(51, 17);
			this.label10.TabIndex = 13;
			this.label10.Text = "times：";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(62, 180);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(91, 28);
			this.button3.TabIndex = 12;
			this.button3.Text = "write key";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(62, 36);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox4.Size = new System.Drawing.Size(892, 138);
			this.textBox4.TabIndex = 8;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(8, 39);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(41, 17);
			this.label9.TabIndex = 11;
			this.label9.Text = "text：";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(62, 7);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(141, 23);
			this.textBox5.TabIndex = 9;
			this.textBox5.Text = "A";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(8, 11);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 17);
			this.label7.TabIndex = 7;
			this.label7.Text = "key：";
			// 
			// userControlHead1
			// 
			this.userControlHead1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.userControlHead1.Dock = System.Windows.Forms.DockStyle.Top;
			this.userControlHead1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.userControlHead1.HelpLink = "http://www.cnblogs.com/dathlin/p/7697782.html";
			this.userControlHead1.Location = new System.Drawing.Point(0, 0);
			this.userControlHead1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.userControlHead1.MinimumSize = new System.Drawing.Size(800, 32);
			this.userControlHead1.Name = "userControlHead1";
			this.userControlHead1.ProtocolInfo = "Redis";
			this.userControlHead1.Size = new System.Drawing.Size(1004, 32);
			this.userControlHead1.TabIndex = 14;
			// 
			// FormRedisClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1004, 645);
			this.Controls.Add(this.userControlHead1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormRedisClient";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Redis Client Test";
			this.Load += new System.EventHandler(this.FormClient_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private DemoControl.UserControlHead userControlHead1;
    }
}