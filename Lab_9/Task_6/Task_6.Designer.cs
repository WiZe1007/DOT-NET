namespace Lab_9
{
    partial class Task_6
    {
        private System.ComponentModel.IContainer components = null; 
        private System.Windows.Forms.Label titleLabel; 
        private System.Windows.Forms.CheckBox excursionCheckBox; // Чекбокс екскурсій
        private System.Windows.Forms.CheckBox mealsCheckBox; // Чекбокс харчування
        private System.Windows.Forms.CheckBox insuranceCheckBox; // Чекбокс страхування
        private System.Windows.Forms.CheckBox transferCheckBox; // Чекбокс трансферу
        private System.Windows.Forms.PictureBox tourPictureBox; // Зображення туру
        private System.Windows.Forms.Button calculateButton; // Кнопка обчислення
        private System.Windows.Forms.Label priceLabel; // Лейбл ціни
        private System.Windows.Forms.Label additionalLabel; // Додаткова інформація
        private System.Windows.Forms.Label discountLabel; // Лейбл знижки
        private System.Windows.Forms.Label totalLabel; // Лейбл загальної суми
        private System.Windows.Forms.ComboBox currencyComboBox; // Комбо-бокс валюти
        private System.Windows.Forms.Label convertedPriceLabel; // Лейбл конвертованої ціни

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Звільнення ресурсів
            }
            base.Dispose(disposing); // Основне завершення
        }

        // Ініціалізація компонентів
        private void InitializeComponent()
        {
            titleLabel = new Label(); 
            excursionCheckBox = new CheckBox();
            mealsCheckBox = new CheckBox(); 
            insuranceCheckBox = new CheckBox(); 
            transferCheckBox = new CheckBox(); 
            tourPictureBox = new PictureBox(); 
            calculateButton = new Button(); 
            priceLabel = new Label(); 
            additionalLabel = new Label(); 
            discountLabel = new Label(); 
            totalLabel = new Label(); 
            currencyComboBox = new ComboBox(); 
            convertedPriceLabel = new Label(); 
            ((System.ComponentModel.ISupportInitialize)tourPictureBox).BeginInit();
            SuspendLayout();

            // Заголовок
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            titleLabel.Location = new Point(30, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(243, 29);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Тур на відпочинок";

            // Чекбокси
            excursionCheckBox.AutoSize = true;
            excursionCheckBox.Location = new Point(35, 60);
            excursionCheckBox.Name = "excursionCheckBox";
            excursionCheckBox.Size = new Size(129, 24);
            excursionCheckBox.TabIndex = 1;
            excursionCheckBox.Text = "Екскурсії (500)";
            excursionCheckBox.UseVisualStyleBackColor = true;

            mealsCheckBox.AutoSize = true;
            mealsCheckBox.Location = new Point(35, 90);
            mealsCheckBox.Name = "mealsCheckBox";
            mealsCheckBox.Size = new Size(152, 24);
            mealsCheckBox.TabIndex = 2;
            mealsCheckBox.Text = "Харчування (300)";
            mealsCheckBox.UseVisualStyleBackColor = true;

            insuranceCheckBox.AutoSize = true;
            insuranceCheckBox.Location = new Point(35, 120);
            insuranceCheckBox.Name = "insuranceCheckBox";
            insuranceCheckBox.Size = new Size(157, 24);
            insuranceCheckBox.TabIndex = 3;
            insuranceCheckBox.Text = "Страхування (150)";
            insuranceCheckBox.UseVisualStyleBackColor = true;

            transferCheckBox.AutoSize = true;
            transferCheckBox.Location = new Point(35, 150);
            transferCheckBox.Name = "transferCheckBox";
            transferCheckBox.Size = new Size(137, 24);
            transferCheckBox.TabIndex = 4;
            transferCheckBox.Text = "Трансфер (200)";
            transferCheckBox.UseVisualStyleBackColor = true;

            // Зображення туру
            tourPictureBox.Image = Properties.Resources.Main_pic__1__2_;
            tourPictureBox.Location = new Point(279, 60);
            tourPictureBox.Name = "tourPictureBox";
            tourPictureBox.Size = new Size(270, 173);
            tourPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            tourPictureBox.TabIndex = 5;
            tourPictureBox.TabStop = false;

            // Кнопка обчислення
            calculateButton.Location = new Point(35, 220);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(80, 28);
            calculateButton.TabIndex = 6;
            calculateButton.Text = "OK";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;

            // Лейбли для ціни
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(35, 260);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(210, 20);
            priceLabel.TabIndex = 7;
            priceLabel.Text = "Ціна базового туру: 2000 грн";

            additionalLabel.AutoSize = true;
            additionalLabel.Location = new Point(35, 280);
            additionalLabel.Name = "additionalLabel";
            additionalLabel.Size = new Size(0, 20);
            additionalLabel.TabIndex = 8;

            discountLabel.AutoSize = true;
            discountLabel.Location = new Point(35, 300);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(0, 20);
            discountLabel.TabIndex = 9;

            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(35, 320);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(0, 20);
            totalLabel.TabIndex = 10;

            // Комбо-бокс для валюти
            currencyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            currencyComboBox.Items.AddRange(new object[] { "Гривня (UAH)", "Долар (USD)", "Євро (EUR)" });
            currencyComboBox.Location = new Point(35, 350);
            currencyComboBox.Name = "currencyComboBox";
            currencyComboBox.Size = new Size(121, 24);
            currencyComboBox.TabIndex = 11;

            // Лейбл для конвертованої ціни
            convertedPriceLabel.AutoSize = true;
            convertedPriceLabel.Location = new Point(35, 380);
            convertedPriceLabel.Name = "convertedPriceLabel";
            convertedPriceLabel.Size = new Size(0, 20);
            convertedPriceLabel.TabIndex = 12;

            // Налаштування форми
            ClientSize = new Size(600, 450);
            Controls.Add(titleLabel);
            Controls.Add(excursionCheckBox);
            Controls.Add(mealsCheckBox);
            Controls.Add(insuranceCheckBox);
            Controls.Add(transferCheckBox);
            Controls.Add(tourPictureBox);
            Controls.Add(calculateButton);
            Controls.Add(priceLabel);
            Controls.Add(additionalLabel);
            Controls.Add(discountLabel);
            Controls.Add(totalLabel);
            Controls.Add(currencyComboBox);
            Controls.Add(convertedPriceLabel);
            Name = "Form6";
            Text = "Task 6";
            ((System.ComponentModel.ISupportInitialize)tourPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
