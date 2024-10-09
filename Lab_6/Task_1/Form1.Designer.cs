namespace Task_1 // Оголошення простору імен для проекту Task_1
{
    partial class Form1 // Часткова клас-форма Form1
    {
        private System.ComponentModel.IContainer components = null; // Змінна для компонентів форми
        private System.Windows.Forms.ComboBox comboBoxCities; // Оголошення комбобоксу для вибору міст
        private System.Windows.Forms.ListBox listBoxCities; // Оголошення спискового боксу для відображення міст

        // Метод, що викликається для очищення ресурсів, пов'язаних з формою
        protected override void Dispose(bool disposing)
        {
            // Якщо треба звільнити ресурси і компоненти не є null
            if (disposing && (components != null))
            {
                components.Dispose(); // Звільнення ресурсів компонентів
            }
            base.Dispose(disposing); // Виклик базового методу для завершення звільнення ресурсів
        }

        private void InitializeComponent() // Метод для ініціалізації компонентів форми
        {
            this.comboBoxCities = new System.Windows.Forms.ComboBox(); // Ініціалізація комбобоксу
            this.listBoxCities = new System.Windows.Forms.ListBox(); // Ініціалізація спискового боксу
            this.SuspendLayout(); // Пауза в оновленні форми

            // 
            // comboBoxCities
            // 
            this.comboBoxCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; // Встановлення стилю для комбобоксу, щоб користувач не міг вводити текст
            this.comboBoxCities.FormattingEnabled = true; // Увімкнення форматування комбобоксу
            this.comboBoxCities.Items.AddRange(new object[] { // Додавання міст до комбобоксу
            "Каїр",
            "Александрія",
            "Гіза",
            "Луксор",
            "Асуан"});
            this.comboBoxCities.Location = new System.Drawing.Point(20, 20); // Встановлення позиції комбобоксу на формі
            this.comboBoxCities.Name = "comboBoxCities"; // Встановлення імені комбобоксу
            this.comboBoxCities.Size = new System.Drawing.Size(121, 21); // Встановлення розміру комбобоксу
            this.comboBoxCities.TabIndex = 0; // Встановлення порядкового номера для навігації між елементами форми

            // 
            // listBoxCities
            // 
            this.listBoxCities.FormattingEnabled = true; // Увімкнення форматування спискового боксу
            this.listBoxCities.Items.AddRange(new object[] { // Додавання міст до спискового боксу
            "Каїр",
            "Александрія",
            "Гіза",
            "Луксор",
            "Асуан"});
            this.listBoxCities.Location = new System.Drawing.Point(20, 60); // Встановлення позиції спискового боксу на формі
            this.listBoxCities.Name = "listBoxCities"; // Встановлення імені спискового боксу
            this.listBoxCities.Size = new System.Drawing.Size(120, 95); // Встановлення розміру спискового боксу
            this.listBoxCities.TabIndex = 1; // Встановлення порядкового номера для навігації між елементами форми

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // Встановлення масштабування елементів форми
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Увімкнення автоматичного масштабування форми
            this.ClientSize = new System.Drawing.Size(284, 261); // Встановлення розміру клієнтської області форми
            this.Controls.Add(this.listBoxCities); // Додавання спискового боксу до контролів форми
            this.Controls.Add(this.comboBoxCities); // Додавання комбобоксу до контролів форми
            this.Name = "Form1"; // Встановлення імені форми
            this.Text = "Task 1"; // Встановлення заголовка форми
            this.ResumeLayout(false); // Завершення паузи в оновленні форми
        }
    }
}
