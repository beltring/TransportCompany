namespace CourseWork
{
    partial class AdminForm
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
            this.addCargoButton = new System.Windows.Forms.Button();
            this.editCargoButton = new System.Windows.Forms.Button();
            this.deleteCargoButton = new System.Windows.Forms.Button();
            this.editStatusButton = new System.Windows.Forms.Button();
            this.viewCargoButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addCargoButton
            // 
            this.addCargoButton.Location = new System.Drawing.Point(53, 19);
            this.addCargoButton.Name = "addCargoButton";
            this.addCargoButton.Size = new System.Drawing.Size(260, 34);
            this.addCargoButton.TabIndex = 0;
            this.addCargoButton.Text = "Добавить новый груз";
            this.addCargoButton.UseVisualStyleBackColor = true;
            this.addCargoButton.Click += new System.EventHandler(this.AddCargo);
            // 
            // editCargoButton
            // 
            this.editCargoButton.Location = new System.Drawing.Point(53, 85);
            this.editCargoButton.Name = "editCargoButton";
            this.editCargoButton.Size = new System.Drawing.Size(260, 34);
            this.editCargoButton.TabIndex = 1;
            this.editCargoButton.Text = "Редактировать груз";
            this.editCargoButton.UseVisualStyleBackColor = true;
            this.editCargoButton.Click += new System.EventHandler(this.EditCargo);
            // 
            // deleteCargoButton
            // 
            this.deleteCargoButton.Location = new System.Drawing.Point(53, 154);
            this.deleteCargoButton.Name = "deleteCargoButton";
            this.deleteCargoButton.Size = new System.Drawing.Size(260, 34);
            this.deleteCargoButton.TabIndex = 2;
            this.deleteCargoButton.Text = "Удалить груз";
            this.deleteCargoButton.UseVisualStyleBackColor = true;
            this.deleteCargoButton.Click += new System.EventHandler(this.DeleteCargo);
            // 
            // editStatusButton
            // 
            this.editStatusButton.Location = new System.Drawing.Point(53, 214);
            this.editStatusButton.Name = "editStatusButton";
            this.editStatusButton.Size = new System.Drawing.Size(260, 34);
            this.editStatusButton.TabIndex = 3;
            this.editStatusButton.Text = "Изменить статус груза";
            this.editStatusButton.UseVisualStyleBackColor = true;
            this.editStatusButton.Click += new System.EventHandler(this.EditStatusButton_Click);
            // 
            // viewCargoButton
            // 
            this.viewCargoButton.Location = new System.Drawing.Point(53, 268);
            this.viewCargoButton.Name = "viewCargoButton";
            this.viewCargoButton.Size = new System.Drawing.Size(260, 34);
            this.viewCargoButton.TabIndex = 4;
            this.viewCargoButton.Text = "Посмотреть список грузов";
            this.viewCargoButton.UseVisualStyleBackColor = true;
            this.viewCargoButton.Click += new System.EventHandler(this.ViewTheListOfCargos);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(53, 331);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(260, 34);
            this.button6.TabIndex = 5;
            this.button6.Text = "Выйти";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ExitToHomeForm);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 373);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.viewCargoButton);
            this.Controls.Add(this.editStatusButton);
            this.Controls.Add(this.deleteCargoButton);
            this.Controls.Add(this.editCargoButton);
            this.Controls.Add(this.addCargoButton);
            this.Name = "AdminForm";
            this.Text = "Администратор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addCargoButton;
        private System.Windows.Forms.Button editCargoButton;
        private System.Windows.Forms.Button deleteCargoButton;
        private System.Windows.Forms.Button editStatusButton;
        private System.Windows.Forms.Button viewCargoButton;
        private System.Windows.Forms.Button button6;
    }
}