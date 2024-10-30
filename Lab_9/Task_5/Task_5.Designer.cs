namespace Lab_9
{
    partial class Task_5
    {
        private System.ComponentModel.IContainer components = null; // Компоненти
        private System.Windows.Forms.Label titleLabel; // Заголовок
        private System.Windows.Forms.CheckBox excursionCheckBox; // Екскурсії
        private System.Windows.Forms.CheckBox mealsCheckBox; // Харчування
        private System.Windows.Forms.CheckBox insuranceCheckBox; // Страхування
        private System.Windows.Forms.CheckBox transferCheckBox; // Трансфер
        private System.Windows.Forms.PictureBox tourPictureBox; // Зображення
        private System.Windows.Forms.Button calculateButton; // Кнопка
        private System.Windows.Forms.Label priceLabel; // Ціна
        private System.Windows.Forms.Label additionalLabel; // Додаткові витрати
        private System.Windows.Forms.Label discountLabel; // Знижка
        private System.Windows.Forms.Label totalLabel; // Загальна сума

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Вивільнення
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            titleLabel = new Label();
            excursionCheckBox = new CheckBox(); // Чекбокс екскурсій
            mealsCheckBox = new CheckBox(); // Чекбокс харчування
            insuranceCheckBox = new CheckBox(); // Чекбокс страхування
            transferCheckBox = new CheckBox(); // Чекбокс трансферу
            tourPictureBox = new PictureBox(); // Зображення туру
            calculateButton = new Button(); // Кнопка "OK"
            priceLabel = new Label(); // Мітка ціни
            additionalLabel = new Label(); // Мітка додаткових витрат
            discountLabel = new Label(); // Мітка знижки
            totalLabel = new Label(); // Мітка загальної суми

            ((System.ComponentModel.ISupportInitialize)tourPictureBox).BeginInit(); // Підготовка
            SuspendLayout(); // Призупинення

            // Заголовок
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            titleLabel.Location = new Point(30, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(243, 29);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Тур на відпочинок";

            // Чекбокс екскурсій
            excursionCheckBox.AutoSize = true;
            excursionCheckBox.Location = new Point(35, 60);
            excursionCheckBox.Name = "excursionCheckBox";
            excursionCheckBox.Size = new Size(129, 24);
            excursionCheckBox.TabIndex = 1;
            excursionCheckBox.Text = "Екскурсії (500)";
            excursionCheckBox.UseVisualStyleBackColor = true;

            // Чекбокс харчування
            mealsCheckBox.AutoSize = true;
            mealsCheckBox.Location = new Point(35, 90);
            mealsCheckBox.Name = "mealsCheckBox";
            mealsCheckBox.Size = new Size(152, 24);
            mealsCheckBox.TabIndex = 2;
            mealsCheckBox.Text = "Харчування (300)";
            mealsCheckBox.UseVisualStyleBackColor = true;

            // Чекбокс страхування
            insuranceCheckBox.AutoSize = true;
            insuranceCheckBox.Location = new Point(35, 120);
            insuranceCheckBox.Name = "insuranceCheckBox";
            insuranceCheckBox.Size = new Size(157, 24);
            insuranceCheckBox.TabIndex = 3;
            insuranceCheckBox.Text = "Страхування (150)";
            insuranceCheckBox.UseVisualStyleBackColor = true;

            // Чекбокс трансферу
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

            // Кнопка "OK"
            calculateButton.Location = new Point(35, 220);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(80, 28);
            calculateButton.TabIndex = 6;
            calculateButton.Text = "OK";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += (s, e) => calculateButton_Click(); // Обробка натискання

            // Мітка ціни
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(35, 260);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(210, 20);
            priceLabel.TabIndex = 7;
            priceLabel.Text = "Ціна базового туру: 2000 грн";

            // Мітка додаткових витрат
            additionalLabel.AutoSize = true;
            additionalLabel.Location = new Point(35, 280);
            additionalLabel.Name = "additionalLabel";
            additionalLabel.Size = new Size(0, 20);
            additionalLabel.TabIndex = 8;

            // Мітка знижки
            discountLabel.AutoSize = true;
            discountLabel.Location = new Point(35, 300);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(0, 20);
            discountLabel.TabIndex = 9;

            // Мітка загальної суми
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(35, 320);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(0, 20);
            totalLabel.TabIndex = 10;

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
            Name = "Form5";
            Text = "Task 5";
            ((System.ComponentModel.ISupportInitialize)tourPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout(); // Завершення
        }
    }
}
