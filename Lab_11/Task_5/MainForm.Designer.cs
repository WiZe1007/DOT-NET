namespace Lab_11_Task_5
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBoxCities;
        private Label labelSelectCity;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.labelSelectCity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(30, 50);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(200, 24);
            this.comboBoxCities.TabIndex = 0;
            this.comboBoxCities.SelectedIndexChanged += new System.EventHandler(this.comboBoxCities_SelectedIndexChanged);
            // 
            // labelSelectCity
            // 
            this.labelSelectCity.AutoSize = true;
            this.labelSelectCity.Location = new System.Drawing.Point(27, 20);
            this.labelSelectCity.Name = "labelSelectCity";
            this.labelSelectCity.Size = new System.Drawing.Size(101, 17);
            this.labelSelectCity.TabIndex = 1;
            this.labelSelectCity.Text = "Виберіть місто:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.labelSelectCity);
            this.Controls.Add(this.comboBoxCities);
            this.Name = "Form1";
            this.Text = "Task 5";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
