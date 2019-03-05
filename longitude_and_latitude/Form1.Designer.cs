namespace longitude_and_latitude
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_open_xlsx = new System.Windows.Forms.Button();
            this.button_save_xlsx = new System.Windows.Forms.Button();
            this.button_year_by_address = new System.Windows.Forms.Button();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(3, 62);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(146, 35);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Пуск широта и долгота";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Обработано строк:";
            // 
            // button_open_xlsx
            // 
            this.button_open_xlsx.Location = new System.Drawing.Point(2, 3);
            this.button_open_xlsx.Name = "button_open_xlsx";
            this.button_open_xlsx.Size = new System.Drawing.Size(63, 39);
            this.button_open_xlsx.TabIndex = 3;
            this.button_open_xlsx.Text = "выбрать excel-файл";
            this.button_open_xlsx.UseVisualStyleBackColor = true;
            this.button_open_xlsx.Click += new System.EventHandler(this.button_open_xlsx_Click);
            // 
            // button_save_xlsx
            // 
            this.button_save_xlsx.Location = new System.Drawing.Point(84, 3);
            this.button_save_xlsx.Name = "button_save_xlsx";
            this.button_save_xlsx.Size = new System.Drawing.Size(174, 39);
            this.button_save_xlsx.TabIndex = 4;
            this.button_save_xlsx.Text = "выбрать путь для сохранения нового excel-файла";
            this.button_save_xlsx.UseVisualStyleBackColor = true;
            this.button_save_xlsx.Click += new System.EventHandler(this.button_save_xlsx_Click);
            // 
            // button_year_by_address
            // 
            this.button_year_by_address.Location = new System.Drawing.Point(3, 103);
            this.button_year_by_address.Name = "button_year_by_address";
            this.button_year_by_address.Size = new System.Drawing.Size(147, 37);
            this.button_year_by_address.TabIndex = 5;
            this.button_year_by_address.Text = "Год по адресу";
            this.button_year_by_address.UseVisualStyleBackColor = true;
            this.button_year_by_address.Click += new System.EventHandler(this.button_year_by_address_Click);
            // 
            // textBox_year
            // 
            this.textBox_year.Location = new System.Drawing.Point(155, 115);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(100, 20);
            this.textBox_year.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 147);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.button_year_by_address);
            this.Controls.Add(this.button_save_xlsx);
            this.Controls.Add(this.button_open_xlsx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Шир и долг по адресу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_open_xlsx;
        private System.Windows.Forms.Button button_save_xlsx;
        private System.Windows.Forms.Button button_year_by_address;
        private System.Windows.Forms.TextBox textBox_year;
    }
}

