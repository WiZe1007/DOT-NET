namespace Lab_10
{
    partial class Task_4
    {
        private System.ComponentModel.IContainer components = null;

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
            // Ініціалізація елементів
            this.labelAmount = new System.Windows.Forms.Label(); // Мітка суми
            this.labelTerm = new System.Windows.Forms.Label(); // Мітка терміну
            this.labelInterestRate = new System.Windows.Forms.Label(); // Мітка ставки
            this.txtAmount = new System.Windows.Forms.TextBox(); // Поле суми
            this.txtTerm = new System.Windows.Forms.TextBox(); // Поле терміну
            this.txtInterestRate = new System.Windows.Forms.TextBox(); // Поле ставки
            this.btnCalculate = new System.Windows.Forms.Button(); // Кнопка
            this.listViewSchedule = new System.Windows.Forms.ListView(); // Список
            this.columnMonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader())); // Заголовок місяця
            this.columnDebt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader())); // Заголовок боргу
            this.columnInterest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader())); // Заголовок відсотка
            this.columnPayment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader())); // Заголовок платежу

            this.SuspendLayout(); // Підготовка

            // labelAmount
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(100, 18); 
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(37, 13);
            this.labelAmount.TabIndex = 0;
            this.labelAmount.Text = "Сума:";

            // txtAmount
            this.txtAmount.Location = new System.Drawing.Point(150, 12); 
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(162, 20);
            this.txtAmount.TabIndex = 1; 

            // labelTerm
            this.labelTerm.AutoSize = true;
            this.labelTerm.Location = new System.Drawing.Point(50, 51); 
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(68, 13);
            this.labelTerm.TabIndex = 2;
            this.labelTerm.Text = "Термін (міс):";

            // txtTerm
            this.txtTerm.Location = new System.Drawing.Point(150, 45); 
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(162, 20);
            this.txtTerm.TabIndex = 3; 

            // labelInterestRate
            this.labelInterestRate.AutoSize = true;
            this.labelInterestRate.Location = new System.Drawing.Point(12, 85); 
            this.labelInterestRate.Name = "labelInterestRate";
            this.labelInterestRate.Size = new System.Drawing.Size(92, 13);
            this.labelInterestRate.TabIndex = 4;
            this.labelInterestRate.Text = "Відсоткова ставка:"; 

            // txtInterestRate
            this.txtInterestRate.Location = new System.Drawing.Point(150, 80); 
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(162, 20);
            this.txtInterestRate.TabIndex = 5; 

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(150, 115);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 28);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "OK"; 
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click); 

            // listViewSchedule
            this.listViewSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMonth,
            this.columnDebt,
            this.columnInterest,
            this.columnPayment});
            this.listViewSchedule.HideSelection = false;
            this.listViewSchedule.Location = new System.Drawing.Point(15, 160); 
            this.listViewSchedule.Name = "listViewSchedule";
            this.listViewSchedule.Size = new System.Drawing.Size(410, 200);
            this.listViewSchedule.TabIndex = 7;
            this.listViewSchedule.UseCompatibleStateImageBehavior = false;
            this.listViewSchedule.View = System.Windows.Forms.View.Details; 

            // columnMonth
            this.columnMonth.Text = "Місяць";
            this.columnMonth.Width = 80;

            // columnDebt
            this.columnDebt.Text = "Борг";
            this.columnDebt.Width = 100;

            // columnInterest
            this.columnInterest.Text = "Відсоток";
            this.columnInterest.Width = 100;

            // columnPayment
            this.columnPayment.Text = "Платіж";
            this.columnPayment.Width = 100;

            // Form4
            this.ClientSize = new System.Drawing.Size(437, 380);
            this.Controls.Add(this.listViewSchedule);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.labelInterestRate);
            this.Controls.Add(this.labelTerm);
            this.Controls.Add(this.labelAmount);
            this.Name = "Form4";
            this.Text = "Task 4"; 
            this.ResumeLayout(false);
            this.PerformLayout(); 
        }

        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelTerm;
        private System.Windows.Forms.Label labelInterestRate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListView listViewSchedule;
        private System.Windows.Forms.ColumnHeader columnMonth;
        private System.Windows.Forms.ColumnHeader columnDebt;
        private System.Windows.Forms.ColumnHeader columnInterest;
        private System.Windows.Forms.ColumnHeader columnPayment;
    }
}
