namespace Task_2 // Оголошення простору імен Task_2
{
    partial class Form1 // Оголошення часткового класу Form1
    {
        private System.ComponentModel.IContainer components = null; // Поле для зберігання компонентів форми
        private System.Windows.Forms.ComboBox comboBoxCities; // Комбінований елемент для вибору міст
        private System.Windows.Forms.ListBox listBoxCities; // Список для відображення міст

        protected override void Dispose(bool disposing) // Метод для звільнення ресурсів
        {
            if (disposing && (components != null)) // Якщо ресурси потрібно звільнити
            {
                components.Dispose(); // Звільняємо компоненти
            }
            base.Dispose(disposing); // Викликаємо базовий клас для звільнення ресурсів
        }

        private void InitializeComponent() // Метод для ініціалізації компонентів форми
        {
            this.comboBoxCities = new System.Windows.Forms.ComboBox(); // Ініціалізація комбінованого елемента
            this.listBoxCities = new System.Windows.Forms.ListBox(); // Ініціалізація списку

            this.SuspendLayout(); // Початок змін у розміщенні компонентів

            // 
            // comboBoxCities
            // 
            this.comboBoxCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; // Встановлюємо стиль випадаючого списку
            this.comboBoxCities.FormattingEnabled = true; // Дозволяємо форматування елементів
            this.comboBoxCities.Location = new System.Drawing.Point(20, 20); // Встановлюємо положення комбінованого елемента
            this.comboBoxCities.Name = "comboBoxCities"; // Присвоюємо ім'я комбінованому елементу
            this.comboBoxCities.Size = new System.Drawing.Size(121, 21); // Встановлюємо розміри комбінованого елемента
            this.comboBoxCities.TabIndex = 0; // Встановлюємо порядковий номер для фокусу

            // 
            // listBoxCities
            // 
            this.listBoxCities.FormattingEnabled = true; // Дозволяємо форматування елементів списку
            this.listBoxCities.Location = new System.Drawing.Point(20, 60); // Встановлюємо положення списку
            this.listBoxCities.Name = "listBoxCities"; // Присвоюємо ім'я списку
            this.listBoxCities.Size = new System.Drawing.Size(120, 95); // Встановлюємо розміри списку
            this.listBoxCities.TabIndex = 1; // Встановлюємо порядковий номер для фокусу

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // Встановлюємо розміри для автоматичного масштабування
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Встановлюємо режим автоматичного масштабування
            this.ClientSize = new System.Drawing.Size(284, 261); // Встановлюємо розміри вікна форми
            this.Controls.Add(this.listBoxCities); // Додаємо список до елементів форми
            this.Controls.Add(this.comboBoxCities); // Додаємо комбінований елемент до елементів форми
            this.Name = "Form1"; // Присвоюємо ім'я формі
            this.Text = "Task 2"; // Встановлюємо заголовок форми
            this.ResumeLayout(false); // Завершуємо зміни у розміщенні компонентів
        }
    }
}
