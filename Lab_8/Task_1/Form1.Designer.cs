namespace Task_01
{
    partial class Form1
    {
        // Компоненти форми
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelName;      // Ім'я
        private System.Windows.Forms.Label labelPhone;     // Телефон
        private System.Windows.Forms.Label labelEmail;     // Пошта
        private System.Windows.Forms.Label labelDOB;       // Дата народження
        private System.Windows.Forms.TextBox textBoxName;  // Поле для імені
        private System.Windows.Forms.TextBox textBoxPhone; // Поле для телефону
        private System.Windows.Forms.TextBox textBoxEmail; // Поле для електронної пошти
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB; // Вибір дати
        private System.Windows.Forms.Button buttonSubmit;   // Кнопка "Відіслати"
        private System.Windows.Forms.Button buttonReset;    // Кнопка "Скинути"

        // Звільнення ресурсів
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Звільняємо компоненти
            }
            base.Dispose(disposing); // Виклик базового методу
        }

        // Ініціалізація компонентів
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout(); // Початок розташування

            // labelName
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(20, 20); // Позиція
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13); //Розмір
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Ім'я:";

            // textBoxName
            this.textBoxName.Location = new System.Drawing.Point(250, 20);  // Позиція
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);  //Розмір
            this.textBoxName.TabIndex = 1;

            // labelPhone
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(20, 60);  // Позиція
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 13);  //Розмір
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Телефон:";

            // textBoxPhone
            this.textBoxPhone.Location = new System.Drawing.Point(250, 60);  // Позиція
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(200, 20);  //Розмір
            this.textBoxPhone.TabIndex = 3;

            // labelEmail
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(45, 100);  // Позиція
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(97, 13);  //Розмір
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Поштова скринька:";

            // textBoxEmail
            this.textBoxEmail.Location = new System.Drawing.Point(250, 100);  // Позиція
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 20);  //Розмір
            this.textBoxEmail.TabIndex = 5;

            // labelDOB
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(50, 140);  // Позиція
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(89, 13);  //Розмір
            this.labelDOB.TabIndex = 6;
            this.labelDOB.Text = "Дата народження:";

            // dateTimePickerDOB
            this.dateTimePickerDOB.Location = new System.Drawing.Point(250, 140);  // Позиція
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(200, 20);  //Розмір
            this.dateTimePickerDOB.TabIndex = 7;

            // buttonSubmit
            this.buttonSubmit.Location = new System.Drawing.Point(150, 20);  // Позиція
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);  //Розмір
            this.buttonSubmit.TabIndex = 8;
            this.buttonSubmit.Text = "Відіслати";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click); // Подія

            // buttonReset
            this.buttonReset.Location = new System.Drawing.Point(230, 180);  // Позиція
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);  //Розмір
            this.buttonReset.TabIndex = 9;
            this.buttonReset.Text = "Скинути";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click); // Подія

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // Масштаб
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Режим
            this.ClientSize = new System.Drawing.Size(484, 261); // Розмір
            this.Controls.Add(this.buttonReset); // Додавання кнопки скидання
            this.Controls.Add(this.buttonSubmit); // Додавання кнопки відправлення
            this.Controls.Add(this.dateTimePickerDOB); // Додавання вибору дати
            this.Controls.Add(this.labelDOB); // Додавання позначку
            this.Controls.Add(this.textBoxEmail); // Додавання поля
            this.Controls.Add(this.labelEmail); // Додавання позначки
            this.Controls.Add(this.textBoxPhone); // Додавання поля
            this.Controls.Add(this.labelPhone); // Додавання позначки
            this.Controls.Add(this.textBoxName); // Додавання поля
            this.Controls.Add(this.labelName); // Додавання позначки
            this.Name = "Form1"; 
            this.Text = "Task 1"; 
            this.ResumeLayout(false); // Завершення
            this.PerformLayout(); // Оновлення
        }
    }
}
