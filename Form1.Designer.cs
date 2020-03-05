namespace MetroFramework
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(182, 134);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(65, 34);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "+";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(79, 174);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(86, 40);
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.Text = "0";
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(265, 174);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(85, 40);
            this.metroTextBox2.TabIndex = 2;
            this.metroTextBox2.Text = "0";
            this.metroTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Location = new System.Drawing.Point(425, 174);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.Size = new System.Drawing.Size(100, 41);
            this.metroTextBox3.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTextBox3.TabIndex = 3;
            this.metroTextBox3.Text = "0";
            this.metroTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(182, 174);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(65, 40);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "-";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(182, 220);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(65, 41);
            this.metroButton3.TabIndex = 5;
            this.metroButton3.Text = "*";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroTextBox4
            // 
            this.metroTextBox4.Location = new System.Drawing.Point(366, 174);
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.Size = new System.Drawing.Size(53, 40);
            this.metroTextBox4.TabIndex = 8;
            this.metroTextBox4.Text = "=";
            this.metroTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(559, 282);
            this.Controls.Add(this.metroTextBox4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroButton1);
            this.Name = "Form1";
            this.Text = "Простенький калькулятор by Matthew Golovtsov";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MetroButton metroButton1;
        private Controls.MetroTextBox metroTextBox1;
        private Controls.MetroTextBox metroTextBox2;
        private Controls.MetroTextBox metroTextBox3;
        private Controls.MetroButton metroButton2;
        private Controls.MetroButton metroButton3;
        private Controls.MetroTextBox metroTextBox4;
    }
}

