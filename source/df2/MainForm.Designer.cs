﻿namespace argt
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        	this.BitVal = new System.Windows.Forms.TextBox();
        	this.LoLiScale = new System.Windows.Forms.TextBox();
        	this.UpLiScale = new System.Windows.Forms.TextBox();
        	this.qvant = new System.Windows.Forms.TextBox();
        	this.Resultt = new System.Windows.Forms.TextBox();
        	this.Calc = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.label6 = new System.Windows.Forms.Label();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.button1 = new System.Windows.Forms.Button();
        	this.button2 = new System.Windows.Forms.Button();
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.label7 = new System.Windows.Forms.Label();
        	this.textBox2 = new System.Windows.Forms.TextBox();
        	this.label8 = new System.Windows.Forms.Label();
        	this.textBox3 = new System.Windows.Forms.TextBox();
        	this.textBox4 = new System.Windows.Forms.TextBox();
        	this.panel1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// BitVal
        	// 
        	this.BitVal.Location = new System.Drawing.Point(12, 59);
        	this.BitVal.Name = "BitVal";
        	this.BitVal.Size = new System.Drawing.Size(209, 20);
        	this.BitVal.TabIndex = 0;
        	this.BitVal.TextChanged += new System.EventHandler(this.label1_Click);
        	this.BitVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
        	// 
        	// LoLiScale
        	// 
        	this.LoLiScale.Location = new System.Drawing.Point(10, 98);
        	this.LoLiScale.Name = "LoLiScale";
        	this.LoLiScale.Size = new System.Drawing.Size(209, 20);
        	this.LoLiScale.TabIndex = 1;
        	this.LoLiScale.TextChanged += new System.EventHandler(this.dfg);
        	this.LoLiScale.Leave += new System.EventHandler(this.erte);
        	// 
        	// UpLiScale
        	// 
        	this.UpLiScale.Location = new System.Drawing.Point(10, 137);
        	this.UpLiScale.Name = "UpLiScale";
        	this.UpLiScale.Size = new System.Drawing.Size(209, 20);
        	this.UpLiScale.TabIndex = 2;
        	this.UpLiScale.Leave += new System.EventHandler(this.sgdh);
        	// 
        	// qvant
        	// 
        	this.qvant.Location = new System.Drawing.Point(10, 176);
        	this.qvant.Name = "qvant";
        	this.qvant.Size = new System.Drawing.Size(209, 20);
        	this.qvant.TabIndex = 3;
        	this.qvant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
        	// 
        	// Resultt
        	// 
        	this.Resultt.Location = new System.Drawing.Point(10, 215);
        	this.Resultt.Name = "Resultt";
        	this.Resultt.Size = new System.Drawing.Size(209, 20);
        	this.Resultt.TabIndex = 4;
        	// 
        	// Calc
        	// 
        	this.Calc.Location = new System.Drawing.Point(10, 254);
        	this.Calc.Name = "Calc";
        	this.Calc.Size = new System.Drawing.Size(100, 23);
        	this.Calc.TabIndex = 5;
        	this.Calc.Text = "Рассчитать";
        	this.Calc.UseVisualStyleBackColor = true;
        	this.Calc.Click += new System.EventHandler(this.button1_Click);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(10, 82);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(96, 13);
        	this.label1.TabIndex = 6;
        	this.label1.Text = "Значение в кодах";
        	this.label1.Click += new System.EventHandler(this.label1_Click);
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(12, 121);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(207, 13);
        	this.label2.TabIndex = 7;
        	this.label2.Text = "Нижняя граница диапазона измерений";
        	this.label2.Click += new System.EventHandler(this.label2_Click);
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(10, 160);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(209, 13);
        	this.label3.TabIndex = 8;
        	this.label3.Text = "Верхняя граница диапазона измерений";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(10, 199);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(73, 13);
        	this.label4.TabIndex = 9;
        	this.label4.Text = "Разрядность";
        	this.label4.Click += new System.EventHandler(this.label4_Click);
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Location = new System.Drawing.Point(10, 238);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(121, 13);
        	this.label5.TabIndex = 10;
        	this.label5.Text = "Физическое значение";
        	this.label5.Click += new System.EventHandler(this.label5_Click);
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        	this.label6.Location = new System.Drawing.Point(15, 7);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(35, 13);
        	this.label6.TabIndex = 0;
        	this.label6.Text = "label6";
        	this.label6.Click += new System.EventHandler(this.label6_Click);
        	// 
        	// panel1
        	// 
        	this.panel1.Controls.Add(this.label6);
        	this.panel1.Location = new System.Drawing.Point(10, 283);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(209, 35);
        	this.panel1.TabIndex = 11;
        	// 
        	// button1
        	// 
        	this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
        	this.button1.Location = new System.Drawing.Point(12, 12);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(23, 23);
        	this.button1.TabIndex = 13;
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.Button1Click);
        	// 
        	// button2
        	// 
        	this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
        	this.button2.Location = new System.Drawing.Point(41, 12);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(23, 23);
        	this.button2.TabIndex = 12;
        	this.button2.UseVisualStyleBackColor = true;
        	// 
        	// textBox1
        	// 
        	this.textBox1.Location = new System.Drawing.Point(240, 215);
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(155, 20);
        	this.textBox1.TabIndex = 14;
        	// 
        	// label7
        	// 
        	this.label7.Location = new System.Drawing.Point(240, 238);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(155, 23);
        	this.label7.TabIndex = 15;
        	this.label7.Text = "Ожидаемое значение";
        	this.label7.Click += new System.EventHandler(this.Label7Click);
        	// 
        	// textBox2
        	// 
        	this.textBox2.Location = new System.Drawing.Point(415, 215);
        	this.textBox2.Name = "textBox2";
        	this.textBox2.Size = new System.Drawing.Size(100, 20);
        	this.textBox2.TabIndex = 16;
        	// 
        	// label8
        	// 
        	this.label8.Location = new System.Drawing.Point(415, 238);
        	this.label8.Name = "label8";
        	this.label8.Size = new System.Drawing.Size(100, 23);
        	this.label8.TabIndex = 17;
        	this.label8.Text = "label8";
        	// 
        	// textBox3
        	// 
        	this.textBox3.Location = new System.Drawing.Point(415, 137);
        	this.textBox3.Name = "textBox3";
        	this.textBox3.Size = new System.Drawing.Size(100, 20);
        	this.textBox3.TabIndex = 18;
        	// 
        	// textBox4
        	// 
        	this.textBox4.Location = new System.Drawing.Point(415, 176);
        	this.textBox4.Name = "textBox4";
        	this.textBox4.Size = new System.Drawing.Size(100, 20);
        	this.textBox4.TabIndex = 19;
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        	this.ClientSize = new System.Drawing.Size(652, 326);
        	this.Controls.Add(this.textBox4);
        	this.Controls.Add(this.textBox3);
        	this.Controls.Add(this.label8);
        	this.Controls.Add(this.textBox2);
        	this.Controls.Add(this.label7);
        	this.Controls.Add(this.textBox1);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.panel1);
        	this.Controls.Add(this.label5);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.Calc);
        	this.Controls.Add(this.Resultt);
        	this.Controls.Add(this.qvant);
        	this.Controls.Add(this.UpLiScale);
        	this.Controls.Add(this.LoLiScale);
        	this.Controls.Add(this.BitVal);
        	this.MaximizeBox = false;
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Code Format";
        	this.Load += new System.EventHandler(this.MainForm_Load);
        	this.panel1.ResumeLayout(false);
        	this.panel1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;

        #endregion

        private System.Windows.Forms.TextBox BitVal;
        private System.Windows.Forms.TextBox LoLiScale;
        private System.Windows.Forms.TextBox UpLiScale;
        private System.Windows.Forms.TextBox qvant;
        private System.Windows.Forms.TextBox Resultt;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}

