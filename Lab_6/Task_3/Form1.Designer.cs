namespace Task_3 // Оголошення простору імен для організації коду
{
    partial class Form1 // Частина класу Form1, що містить код для графічного інтерфейсу
    {
        private System.ComponentModel.IContainer components = null; // Контейнер для компонентів форми
        private System.Windows.Forms.Label labelName; // Мітка для імені
        private System.Windows.Forms.Label labelPhone; // Мітка для телефону
        private System.Windows.Forms.Label labelEmail; // Мітка для електронної пошти
        private System.Windows.Forms.Label labelDOB; // Мітка для дати народження
        private System.Windows.Forms.TextBox textBoxName; // Текстове поле для введення імені
        private System.Windows.Forms.TextBox textBoxPhone; // Текстове поле для введення телефону
        private System.Windows.Forms.TextBox textBoxEmail; // Текстове поле для введення електронної пошти
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB; // Контроль для вибору дати народження
        private System.Windows.Forms.Button buttonSubmit; // Кнопка для відправки даних
        private System.Windows.Forms.Button buttonReset; // Кнопка для скидання даних

        protected override void Dispose(bool disposing) // Метод для очищення ресурсів
        {
            if (disposing && (components != null)) // Перевірка наявності компонентів
            {
                components.Dispose(); // Вивільнення ресурсів компонентів
            }
            base.Dispose(disposing); // Виклик базового методу для звільнення ресурсів
        }

        private void InitializeComponent() // Метод для ініціалізації компонентів
        {
            this.labelName = new System.Windows.Forms.Label(); // Ініціалізація мітки для імені
            this.labelPhone = new System.Windows.Forms.Label(); // Ініціалізація мітки для телефону
            this.labelEmail = new System.Windows.Forms.Label(); // Ініціалізація мітки для електронної пошти
            this.labelDOB = new System.Windows.Forms.Label(); // Ініціалізація мітки для дати народження
            this.textBoxName = new System.Windows.Forms.TextBox(); // Ініціалізація текстового поля для імені
            this.textBoxPhone = new System.Windows.Forms.TextBox(); // Ініціалізація текстового поля для телефону
            this.textBoxEmail = new System.Windows.Forms.TextBox(); // Ініціалізація текстового поля для електронної пошти
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker(); // Ініціалізація контролю для вибору дати
            this.buttonSubmit = new System.Windows.Forms.Button(); // Ініціалізація кнопки для відправки
            this.buttonReset = new System.Windows.Forms.Button(); // Ініціалізація кнопки для скидання
            this.SuspendLayout(); // Пауза для подальшого налаштування компонента

            // 
            // labelName
            // 
            this.labelName.AutoSize = true; // Автоматичне налаштування розміру мітки
            this.labelName.Location = new System.Drawing.Point(20, 20); // Встановлення позиції мітки
            this.labelName.Name = "labelName"; // Встановлення імені мітки
            this.labelName.Size = new System.Drawing.Size(29, 13); // Встановлення розміру мітки
            this.labelName.TabIndex = 0; // Встановлення порядкового номера мітки
            this.labelName.Text = "Ім'я:"; // Текст, який відображається на мітці

            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(250, 20); // Встановлення позиції текстового поля
            this.textBoxName.Name = "textBoxName"; // Встановлення імені текстового поля
            this.textBoxName.Size = new System.Drawing.Size(200, 20); // Встановлення розміру текстового поля
            this.textBoxName.TabIndex = 1; // Встановлення порядкового номера текстового поля

            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true; // Автоматичне налаштування розміру мітки
            this.labelPhone.Location = new System.Drawing.Point(20, 60); // Встановлення позиції мітки
            this.labelPhone.Name = "labelPhone"; // Встановлення імені мітки
            this.labelPhone.Size = new System.Drawing.Size(55, 13); // Встановлення розміру мітки
            this.labelPhone.TabIndex = 2; // Встановлення порядкового номера мітки
            this.labelPhone.Text = "Телефон:"; // Текст, який відображається на мітці

            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(250, 60); // Встановлення позиції текстового поля
            this.textBoxPhone.Name = "textBoxPhone"; // Встановлення імені текстового поля
            this.textBoxPhone.Size = new System.Drawing.Size(200, 20); // Встановлення розміру текстового поля
            this.textBoxPhone.TabIndex = 3; // Встановлення порядкового номера текстового поля

            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true; // Автоматичне налаштування розміру мітки
            this.labelEmail.Location = new System.Drawing.Point(45, 100); // Встановлення позиції мітки
            this.labelEmail.Name = "labelEmail"; // Встановлення імені мітки
            this.labelEmail.Size = new System.Drawing.Size(97, 13); // Встановлення розміру мітки
            this.labelEmail.TabIndex = 4; // Встановлення порядкового номера мітки
            this.labelEmail.Text = "Поштова скринька:"; // Текст, який відображається на мітці

            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(250, 100); // Встановлення позиції текстового поля
            this.textBoxEmail.Name = "textBoxEmail"; // Встановлення імені текстового поля
            this.textBoxEmail.Size = new System.Drawing.Size(200, 20); // Встановлення розміру текстового поля
            this.textBoxEmail.TabIndex = 5; // Встановлення порядкового номера текстового поля

            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true; // Автоматичне налаштування розміру мітки
            this.labelDOB.Location = new System.Drawing.Point(50, 140); // Встановлення позиції мітки
            this.labelDOB.Name = "labelDOB"; // Встановлення імені мітки
            this.labelDOB.Size = new System.Drawing.Size(89, 13); // Встановлення розміру мітки
            this.labelDOB.TabIndex = 6; // Встановлення порядкового номера мітки
            this.labelDOB.Text = "Дата народження:"; // Текст, який відображається на мітці

            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(250, 140); // Встановлення позиції контролю вибору дати
            this.dateTimePickerDOB.Name = "dateTimePickerDOB"; // Встановлення імені контролю вибору дати
            this.dateTimePickerDOB.Size = new System.Drawing.Size(200, 20); // Встановлення розміру контролю вибору дати
            this.dateTimePickerDOB.TabIndex = 7; // Встановлення порядкового номера контролю вибору дати

            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(150, 20); // Встановлення позиції кнопки "Відправити"
            this.buttonSubmit.Name = "buttonSubmit"; // Встановлення імені кнопки
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23); // Встановлення розміру кнопки
            this.buttonSubmit.TabIndex = 8; // Встановлення порядкового номера кнопки
            this.buttonSubmit.Text = "Відправити"; // Текст на кнопці
            this.buttonSubmit.UseVisualStyleBackColor = true; // Використання стандартного стилю кнопки
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click); // Додавання обробника події на натискання кнопки

            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(230, 180); // Встановлення позиції кнопки "Скинути"
            this.buttonReset.Name = "buttonReset"; // Встановлення імені кнопки
            this.buttonReset.Size = new System.Drawing.Size(75, 23); // Встановлення розміру кнопки
            this.buttonReset.TabIndex = 9; // Встановлення порядкового номера кнопки
            this.buttonReset.Text = "Скинути"; // Текст на кнопці
            this.buttonReset.UseVisualStyleBackColor = true; // Використання стандартного стилю кнопки
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click); // Додавання обробника події на натискання кнопки

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // Встановлення масштабування форми
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Автоматичне масштабування шрифтів
            this.ClientSize = new System.Drawing.Size(500, 500); // Встановлення розміру форми
            this.Controls.Add(this.buttonReset); // Додавання кнопки "Скинути" до форми
            this.Controls.Add(this.buttonSubmit); // Додавання кнопки "Відправити" до форми
            this.Controls.Add(this.dateTimePickerDOB); // Додавання контролю вибору дати до форми
            this.Controls.Add(this.labelDOB); // Додавання мітки дати народження до форми
            this.Controls.Add(this.textBoxEmail); // Додавання текстового поля електронної пошти до форми
            this.Controls.Add(this.labelEmail); // Додавання мітки електронної пошти до форми
            this.Controls.Add(this.textBoxPhone); // Додавання текстового поля телефону до форми
            this.Controls.Add(this.labelPhone); // Додавання мітки телефону до форми
            this.Controls.Add(this.textBoxName); // Додавання текстового поля імені до форми
            this.Controls.Add(this.labelName); // Додавання мітки імені до форми
            this.Name = "Form1"; // Встановлення імені форми
            this.Text = "Task 3"; // Встановлення заголовка форми
            this.ResumeLayout(false); // Продовження макета
            this.PerformLayout(); // Виконання всіх налаштувань розмітки
        }
    }
}
