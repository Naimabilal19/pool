
namespace WindowsFormsApp_21._04._2023_HM
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 102);
            this.button1.TabIndex = 0;
            this.button1.Text = "Введите название улицы, для определения фамилии и улицы сотрудника";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 120);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 48);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Location = new System.Drawing.Point(404, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(344, 102);
            this.button2.TabIndex = 0;
            this.button2.Text = "Введите год рождения сотрудника чтобы определить рожден ли он в год быка(1901 г)";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(404, 120);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(344, 48);
            this.textBox2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Location = new System.Drawing.Point(813, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(331, 102);
            this.button3.TabIndex = 0;
            this.button3.Text = "Введите средний бал студента чтобы определить ФИО по группам";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(813, 120);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(331, 48);
            this.textBox3.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.Location = new System.Drawing.Point(124, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(331, 102);
            this.button4.TabIndex = 0;
            this.button4.Text = "Введите дату и срок дней для определения информации о книгах ";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(124, 309);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(331, 48);
            this.textBox4.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button5.Location = new System.Drawing.Point(629, 201);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(331, 102);
            this.button5.TabIndex = 0;
            this.button5.Text = "Введите дату определения информации о товаре  ";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(629, 309);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(331, 48);
            this.textBox5.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 399);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1132, 204);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 635);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ListBox listBox1;
    }
}

