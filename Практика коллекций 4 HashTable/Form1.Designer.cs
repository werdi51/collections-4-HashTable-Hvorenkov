
namespace Практика_коллекций_4_HashTable
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new System.Windows.Forms.ListBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            textBox2 = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            button5 = new System.Windows.Forms.Button();
            textBox3 = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new System.Drawing.Point(84, 203);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(316, 349);
            listBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(30, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(128, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(75, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(192, 15);
            label1.TabIndex = 3;
            label1.Text = "сколько хотите создать подборок";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(110, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(100, 110);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(120, 27);
            button1.TabIndex = 5;
            button1.Text = "создать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(73, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(345, 161);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new System.Drawing.Point(30, 31);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(453, 162);
            panel2.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(230, 99);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(158, 29);
            button4.TabIndex = 4;
            button4.Text = "удалить песню";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(33, 99);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(158, 29);
            button3.TabIndex = 4;
            button3.Text = "добавить песню";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(28, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(397, 23);
            textBox2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(224, 16);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(201, 23);
            button2.TabIndex = 2;
            button2.Text = "поменять название плейлиста";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button5);
            panel3.Controls.Add(textBox3);
            panel3.Location = new System.Drawing.Point(84, 12);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(316, 154);
            panel3.TabIndex = 8;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(107, 86);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(101, 26);
            button5.TabIndex = 1;
            button5.Text = "применить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(50, 38);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "введите новое название плейлиста";
            textBox3.Size = new System.Drawing.Size(206, 23);
            textBox3.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(530, 774);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
    }
}

