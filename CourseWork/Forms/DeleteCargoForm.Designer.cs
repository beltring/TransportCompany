namespace CourseWork
{
    partial class DeleteCargoForm
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
            this.informationGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trailerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.downloadLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeOfDischarge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteCargoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.informationGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // informationGridView
            // 
            this.informationGridView.AllowUserToAddRows = false;
            this.informationGridView.AllowUserToDeleteRows = false;
            this.informationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.cost,
            this.weight,
            this.volume,
            this.trailerType,
            this.uploadDate,
            this.status,
            this.downloadLocation,
            this.placeOfDischarge,
            this.distance});
            this.informationGridView.Location = new System.Drawing.Point(12, 12);
            this.informationGridView.Name = "informationGridView";
            this.informationGridView.RowHeadersWidth = 51;
            this.informationGridView.RowTemplate.Height = 24;
            this.informationGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.informationGridView.Size = new System.Drawing.Size(776, 374);
            this.informationGridView.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Название";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // cost
            // 
            this.cost.HeaderText = "Стоимость";
            this.cost.MinimumWidth = 6;
            this.cost.Name = "cost";
            this.cost.Width = 125;
            // 
            // weight
            // 
            this.weight.HeaderText = "Вес";
            this.weight.MinimumWidth = 6;
            this.weight.Name = "weight";
            this.weight.Width = 60;
            // 
            // volume
            // 
            this.volume.HeaderText = "Объём";
            this.volume.MinimumWidth = 6;
            this.volume.Name = "volume";
            this.volume.Width = 70;
            // 
            // trailerType
            // 
            this.trailerType.HeaderText = "Тип Кузова";
            this.trailerType.MinimumWidth = 6;
            this.trailerType.Name = "trailerType";
            this.trailerType.Width = 125;
            // 
            // uploadDate
            // 
            this.uploadDate.HeaderText = "Дата загрузки";
            this.uploadDate.MinimumWidth = 6;
            this.uploadDate.Name = "uploadDate";
            this.uploadDate.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "Статус";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 125;
            // 
            // downloadLocation
            // 
            this.downloadLocation.HeaderText = "Место загрузки";
            this.downloadLocation.MinimumWidth = 6;
            this.downloadLocation.Name = "downloadLocation";
            this.downloadLocation.Width = 125;
            // 
            // placeOfDischarge
            // 
            this.placeOfDischarge.HeaderText = "Место выгрузки";
            this.placeOfDischarge.MinimumWidth = 6;
            this.placeOfDischarge.Name = "placeOfDischarge";
            this.placeOfDischarge.Width = 125;
            // 
            // distance
            // 
            this.distance.HeaderText = "Расстояние";
            this.distance.MinimumWidth = 6;
            this.distance.Name = "distance";
            this.distance.Width = 125;
            // 
            // deleteCargoButton
            // 
            this.deleteCargoButton.Location = new System.Drawing.Point(288, 392);
            this.deleteCargoButton.Name = "deleteCargoButton";
            this.deleteCargoButton.Size = new System.Drawing.Size(191, 43);
            this.deleteCargoButton.TabIndex = 10;
            this.deleteCargoButton.Text = "Удалить";
            this.deleteCargoButton.UseVisualStyleBackColor = true;
            this.deleteCargoButton.Click += new System.EventHandler(this.DeleteCargoButton_Click);
            // 
            // DeleteCargoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.deleteCargoButton);
            this.Controls.Add(this.informationGridView);
            this.Name = "DeleteCargoForm";
            this.Text = "Удаление груза";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeleteCargoForm_FormClosed);
            this.Load += new System.EventHandler(this.DeleteCargoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informationGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView informationGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn trailerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn downloadLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeOfDischarge;
        private System.Windows.Forms.DataGridViewTextBoxColumn distance;
        private System.Windows.Forms.Button deleteCargoButton;
    }
}