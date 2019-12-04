using System.Windows.Forms;

namespace CourseWork
{
    partial class AddForm
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VolumeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UploadDateTextBox = new System.Windows.Forms.TextBox();
            this.TrailerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LoadLocationTextBox = new System.Windows.Forms.TextBox();
            this.PlaceOfDischargeTextBox = new System.Windows.Forms.TextBox();
            this.DistanceTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(146, 4);
            this.NameTextBox.Name = "nameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(121, 22);
            this.NameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Стоимость";
            // 
            // costTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(146, 32);
            this.CostTextBox.Name = "costTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(121, 22);
            this.CostTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вес";
            // 
            // weightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(146, 60);
            this.WeightTextBox.Name = "weightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(121, 22);
            this.WeightTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Объём";
            // 
            // volumeTextBox
            // 
            this.VolumeTextBox.Location = new System.Drawing.Point(146, 88);
            this.VolumeTextBox.Name = "volumeTextBox";
            this.VolumeTextBox.Size = new System.Drawing.Size(121, 22);
            this.VolumeTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата загрузки";
            // 
            // uploadDateTextBox
            // 
            this.UploadDateTextBox.Location = new System.Drawing.Point(146, 116);
            this.UploadDateTextBox.Name = "uploadDateTextBox";
            this.UploadDateTextBox.Size = new System.Drawing.Size(121, 22);
            this.UploadDateTextBox.TabIndex = 8;
            // 
            // trailerTypeComboBox
            // 
            this.TrailerTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TrailerTypeComboBox.FormattingEnabled = true;
            this.TrailerTypeComboBox.Items.AddRange(new object[] {
            "Крытый",
            "Открытый",
            "Цистерна"});
            this.TrailerTypeComboBox.Location = new System.Drawing.Point(146, 144);
            this.TrailerTypeComboBox.Name = "trailerTypeComboBox";
            this.TrailerTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.TrailerTypeComboBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Тип кузова";
            // 
            // statusComboBox
            // 
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Доставлен",
            "Не доставлен"});
            this.StatusComboBox.Location = new System.Drawing.Point(146, 174);
            this.StatusComboBox.Name = "statusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 24);
            this.StatusComboBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Статус";
            // 
            // addButton
            // 
            this.AddButton.Location = new System.Drawing.Point(89, 288);
            this.AddButton.Name = "addButton";
            this.AddButton.Size = new System.Drawing.Size(99, 31);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.CargoAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Место загрузки";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Место разгрузки";
            // 
            // loadLocationTextBox
            // 
            this.LoadLocationTextBox.Location = new System.Drawing.Point(146, 204);
            this.LoadLocationTextBox.Name = "loadLocationTextBox";
            this.LoadLocationTextBox.Size = new System.Drawing.Size(121, 22);
            this.LoadLocationTextBox.TabIndex = 18;
            // 
            // placeOfDischargeTextBox
            // 
            this.PlaceOfDischargeTextBox.Location = new System.Drawing.Point(146, 232);
            this.PlaceOfDischargeTextBox.Name = "placeOfDischargeTextBox";
            this.PlaceOfDischargeTextBox.Size = new System.Drawing.Size(121, 22);
            this.PlaceOfDischargeTextBox.TabIndex = 19;
            // 
            // distanceTextBox
            // 
            this.DistanceTextBox.Location = new System.Drawing.Point(146, 260);
            this.DistanceTextBox.Name = "distanceTextBox";
            this.DistanceTextBox.Size = new System.Drawing.Size(121, 22);
            this.DistanceTextBox.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Расстояние";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(42, 325);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(186, 28);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "Вернуться на страницу администратора";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 357);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DistanceTextBox);
            this.Controls.Add(this.PlaceOfDischargeTextBox);
            this.Controls.Add(this.LoadLocationTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TrailerTypeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UploadDateTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VolumeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Name = "Add";
            this.Text = "Добавление груза";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_FormClosed);
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox volumeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uploadDateTextBox;
        private System.Windows.Forms.ComboBox trailerTypeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox loadLocationTextBox;
        private System.Windows.Forms.TextBox placeOfDischargeTextBox;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button exitButton;

        public Button AddButton { get => addButton; set => addButton = value; }
        public TextBox NameTextBox { get => nameTextBox; set => nameTextBox = value; }
        public TextBox CostTextBox { get => costTextBox; set => costTextBox = value; }
        public TextBox WeightTextBox { get => weightTextBox; set => weightTextBox = value; }
        public TextBox VolumeTextBox { get => volumeTextBox; set => volumeTextBox = value; }
        public TextBox UploadDateTextBox { get => uploadDateTextBox; set => uploadDateTextBox = value; }
        public ComboBox TrailerTypeComboBox { get => trailerTypeComboBox; set => trailerTypeComboBox = value; }
        public ComboBox StatusComboBox { get => statusComboBox; set => statusComboBox = value; }
        public TextBox LoadLocationTextBox { get => loadLocationTextBox; set => loadLocationTextBox = value; }
        public TextBox PlaceOfDischargeTextBox { get => placeOfDischargeTextBox; set => placeOfDischargeTextBox = value; }
        public TextBox DistanceTextBox { get => distanceTextBox; set => distanceTextBox = value; }
    }
}