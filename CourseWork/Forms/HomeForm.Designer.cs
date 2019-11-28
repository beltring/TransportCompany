namespace CourseWork
{
    partial class HomeForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Authorization);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "Зарегистрироваться";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Registration);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(359, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "Войти как администратор";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.LogInAsAdministrator);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(120, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Close);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(27, 127);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(359, 24);
            this.button5.TabIndex = 4;
            this.button5.Text = "Просмотреть список грузов";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ViewCatalog);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 230);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "HomeForm";
            this.Text = "Транспортная компания";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

