namespace Task_5 // Визначення простору імен Task_5
{
    partial class Form1 // Частина класу Form1
    {
        private System.ComponentModel.IContainer components = null; // Змінна для зберігання компонентів форми
        private System.Windows.Forms.Label labelTitle; // Мітка для заголовка
        private System.Windows.Forms.CheckBox checkBoxSports; // Чекбокс для вибору спорту
        private System.Windows.Forms.CheckBox checkBoxTravel; // Чекбокс для вибору мандрівок
        private System.Windows.Forms.CheckBox checkBoxCrafting; // Чекбокс для вибору майстрування
        private System.Windows.Forms.CheckBox checkBoxPainting; // Чекбокс для вибору малювання
        private System.Windows.Forms.Label labelSports; // Мітка для тексту "Спорт"
        private System.Windows.Forms.Label labelTravel; // Мітка для тексту "Мандрівки"
        private System.Windows.Forms.Label labelCrafting; // Мітка для тексту "Майстрування"
        private System.Windows.Forms.Label labelPainting; // Мітка для тексту "Малювання"
        private System.Windows.Forms.Button buttonChoose; // Кнопка для вибору інтересів
        private System.Windows.Forms.Button buttonRefuse; // Кнопка для відмови

        protected override void Dispose(bool disposing) // Метод для вивільнення ресурсів
        {
            if (disposing && (components != null)) // Перевірка, чи потрібно вивільнити компоненти
            {
                components.Dispose(); // Вивільнення компонентів
            }
            base.Dispose(disposing); // Виклик базового методу Dispose
        }

        private void InitializeComponent() // Метод для ініціалізації компонентів форми
        {
            this.labelTitle = new System.Windows.Forms.Label(); // Ініціалізація заголовка
            this.checkBoxSports = new System.Windows.Forms.CheckBox(); // Ініціалізація чекбокса для спорту
            this.checkBoxTravel = new System.Windows.Forms.CheckBox(); // Ініціалізація чекбокса для мандрівок
            this.checkBoxCrafting = new System.Windows.Forms.CheckBox(); // Ініціалізація чекбокса для майстрування
            this.checkBoxPainting = new System.Windows.Forms.CheckBox(); // Ініціалізація чекбокса для малювання
            this.labelSports = new System.Windows.Forms.Label(); // Ініціалізація мітки для спорту
            this.labelTravel = new System.Windows.Forms.Label(); // Ініціалізація мітки для мандрівок
            this.labelCrafting = new System.Windows.Forms.Label(); // Ініціалізація мітки для майстрування
            this.labelPainting = new System.Windows.Forms.Label(); // Ініціалізація мітки для малювання
            this.buttonChoose = new System.Windows.Forms.Button(); // Ініціалізація кнопки "Вибрати"
            this.buttonRefuse = new System.Windows.Forms.Button(); // Ініціалізація кнопки "Відмовитися"
            this.SuspendLayout(); // Призупинити розташування контролів

            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true; // Автоматичне підлаштування розміру мітки
            this.labelTitle.Location = new System.Drawing.Point(120, 20); // Встановлення позиції мітки
            this.labelTitle.Name = "labelTitle"; // Встановлення імені мітки
            this.labelTitle.Size = new System.Drawing.Size(130, 13); // Встановлення розміру мітки
            this.labelTitle.TabIndex = 0; // Встановлення порядкового номера мітки
            this.labelTitle.Text = "Виберіть ваші інтереси:"; // Текст мітки

            // 
            // checkBoxSports
            // 
            this.checkBoxSports.AutoSize = true; // Автоматичне підлаштування розміру чекбокса
            this.checkBoxSports.Location = new System.Drawing.Point(330, 50); // Встановлення позиції чекбокса для спорту
            this.checkBoxSports.Name = "checkBoxSports"; // Встановлення імені чекбокса
            this.checkBoxSports.Size = new System.Drawing.Size(15, 14); // Встановлення розміру чекбокса
            this.checkBoxSports.TabIndex = 1; // Встановлення порядкового номера чекбокса
            this.checkBoxSports.UseVisualStyleBackColor = true; // Використання стандартного стилю
            this.checkBoxSports.Checked = true; // Вибір за замовчанням

            // 
            // labelSports
            // 
            this.labelSports.AutoSize = true; // Автоматичне підлаштування розміру мітки
            this.labelSports.Location = new System.Drawing.Point(245, 50); // Встановлення позиції мітки для спорту
            this.labelSports.Name = "labelSports"; // Встановлення імені мітки
            this.labelSports.Size = new System.Drawing.Size(35, 13); // Встановлення розміру мітки
            this.labelSports.TabIndex = 2; // Встановлення порядкового номера мітки
            this.labelSports.Text = "Спорт"; // Текст мітки

            // 
            // checkBoxTravel
            // 
            this.checkBoxTravel.AutoSize = true; // Автоматичне підлаштування розміру чекбокса
            this.checkBoxTravel.Location = new System.Drawing.Point(289, 80); // Встановлення позиції чекбокса для мандрівок
            this.checkBoxTravel.Name = "checkBoxTravel"; // Встановлення імені чекбокса
            this.checkBoxTravel.Size = new System.Drawing.Size(15, 14); // Встановлення розміру чекбокса
            this.checkBoxTravel.TabIndex = 3; // Встановлення порядкового номера чекбокса
            this.checkBoxTravel.UseVisualStyleBackColor = true; // Використання стандартного стилю

            // 
            // labelTravel
            // 
            this.labelTravel.AutoSize = true; // Автоматичне підлаштування розміру мітки
            this.labelTravel.Location = new System.Drawing.Point(150, 80); // Встановлення позиції мітки для мандрівок
            this.labelTravel.Name = "labelTravel"; // Встановлення імені мітки
            this.labelTravel.Size = new System.Drawing.Size(55, 13); // Встановлення розміру мітки
            this.labelTravel.TabIndex = 4; // Встановлення порядкового номера мітки
            this.labelTravel.Text = "Мандрівки"; // Текст мітки

            // 
            // checkBoxCrafting
            // 
            this.checkBoxCrafting.AutoSize = true; // Автоматичне підлаштування розміру чекбокса
            this.checkBoxCrafting.Location = new System.Drawing.Point(291, 110); // Встановлення позиції чекбокса для майстрування
            this.checkBoxCrafting.Name = "checkBoxCrafting"; // Встановлення імені чекбокса
            this.checkBoxCrafting.Size = new System.Drawing.Size(15, 14); // Встановлення розміру чекбокса
            this.checkBoxCrafting.TabIndex = 5; // Встановлення порядкового номера чекбокса
            this.checkBoxCrafting.UseVisualStyleBackColor = true; // Використання стандартного стилю
            this.checkBoxCrafting.Checked = true; // Вибір за замовчанням

            // 
            // labelCrafting
            // 
            this.labelCrafting.AutoSize = true; // Автоматичне підлаштування розміру мітки
            this.labelCrafting.Location = new System.Drawing.Point(95, 110); // Встановлення позиції мітки для майстрування
            this.labelCrafting.Name = "labelCrafting"; // Встановлення імені мітки
            this.labelCrafting.Size = new System.Drawing.Size(75, 13); // Встановлення розміру мітки
            this.labelCrafting.TabIndex = 6; // Встановлення порядкового номера мітки
            this.labelCrafting.Text = "Майстрування"; // Текст мітки

            // 
            // checkBoxPainting
            // 
            this.checkBoxPainting.AutoSize = true; // Автоматичне підлаштування розміру чекбокса
            this.checkBoxPainting.Location = new System.Drawing.Point(332, 140); // Встановлення позиції чекбокса для малювання
            this.checkBoxPainting.Name = "checkBoxPainting"; // Встановлення імені чекбокса
            this.checkBoxPainting.Size = new System.Drawing.Size(15, 14); // Встановлення розміру чекбокса
            this.checkBoxPainting.TabIndex = 7; // Встановлення порядкового номера чекбокса
            this.checkBoxPainting.UseVisualStyleBackColor = true; // Використання стандартного стилю

            // 
            // labelPainting
            // 
            this.labelPainting.AutoSize = true; // Автоматичне підлаштування розміру мітки
            this.labelPainting.Location = new System.Drawing.Point(150, 140); // Встановлення позиції мітки для малювання
            this.labelPainting.Name = "labelPainting"; // Встановлення імені мітки
            this.labelPainting.Size = new System.Drawing.Size(65, 13); // Встановлення розміру мітки
            this.labelPainting.TabIndex = 8; // Встановлення порядкового номера мітки
            this.labelPainting.Text = "Малювання"; // Текст мітки

            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(165, 110); // Встановлення позиції кнопки "Вибрати"
            this.buttonChoose.Name = "buttonChoose"; // Встановлення імені кнопки
            this.buttonChoose.Size = new System.Drawing.Size(75, 23); // Встановлення розміру кнопки
            this.buttonChoose.TabIndex = 9; // Встановлення порядкового номера кнопки
            this.buttonChoose.Text = "Вибрати"; // Текст кнопки
            this.buttonChoose.UseVisualStyleBackColor = true; // Використання стандартного стилю
            this.buttonChoose.Click += new System.EventHandler(this.ButtonChoose_Click); // Обробник події для кнопки "Вибрати"

            // 
            // buttonRefuse
            // 
            this.buttonRefuse.Location = new System.Drawing.Point(230, 112); // Встановлення позиції кнопки "Відмовитися"
            this.buttonRefuse.Name = "buttonRefuse"; // Встановлення імені кнопки
            this.buttonRefuse.Size = new System.Drawing.Size(80, 23); // Встановлення розміру кнопки
            this.buttonRefuse.TabIndex = 10; // Встановлення порядкового номера кнопки
            this.buttonRefuse.Text = "Відмовитися"; // Текст кнопки
            this.buttonRefuse.UseVisualStyleBackColor = true; // Використання стандартного стилю
            this.buttonRefuse.Click += new System.EventHandler(this.ButtonRefuse_Click); // Обробник події для кнопки "Відмовитися"

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // Встановлення масштабування для форми
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Встановлення режиму масштабування
            this.ClientSize = new System.Drawing.Size(400, 400); // Встановлення розміру клієнтської області форми
            this.Controls.Add(this.buttonRefuse); // Додавання кнопки "Відмовитися" на форму
            this.Controls.Add(this.buttonChoose); // Додавання кнопки "Вибрати" на форму
            this.Controls.Add(this.labelPainting); // Додавання мітки для малювання на форму
            this.Controls.Add(this.checkBoxPainting); // Додавання чекбокса для малювання на форму
            this.Controls.Add(this.labelCrafting); // Додавання мітки для майстрування на форму
            this.Controls.Add(this.checkBoxCrafting); // Додавання чекбокса для майстрування на форму
            this.Controls.Add(this.labelTravel); // Додавання мітки для мандрівок на форму
            this.Controls.Add(this.checkBoxTravel); // Додавання чекбокса для мандрівок на форму
            this.Controls.Add(this.labelSports); // Додавання мітки для спорту на форму
            this.Controls.Add(this.checkBoxSports); // Додавання чекбокса для спорту на форму
            this.Controls.Add(this.labelTitle); // Додавання заголовка на форму
            this.Name = "Form1"; // Встановлення імені форми
            this.Text = "Task 5"; // Встановлення тексту заголовка вікна
            this.ResumeLayout(false); // Продовження розташування контролів
            this.PerformLayout(); // Завершення розташування контролів
        }
    }
}
