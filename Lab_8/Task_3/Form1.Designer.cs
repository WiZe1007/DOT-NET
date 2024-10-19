namespace Task_003 
{
    partial class Form1 
    {
        private System.ComponentModel.IContainer components = null; 
        private System.Windows.Forms.Label labelTitle; 
        private System.Windows.Forms.CheckBox checkBoxSports; // Чекбокс спорту
        private System.Windows.Forms.CheckBox checkBoxTravel; // Чекбокс мандрівок
        private System.Windows.Forms.CheckBox checkBoxCrafting; // Чекбокс майстрування
        private System.Windows.Forms.CheckBox checkBoxPainting; // Чекбокс малювання
        private System.Windows.Forms.Label labelSports; // Мітка "Спорт"
        private System.Windows.Forms.Label labelTravel; // Мітка "Мандрівки"
        private System.Windows.Forms.Label labelCrafting; // Мітка "Майстрування"
        private System.Windows.Forms.Label labelPainting; // Мітка "Малювання"
        private System.Windows.Forms.Button buttonSend; // Кнопка "Відіслати"
        private System.Windows.Forms.Button buttonReset; // Кнопка "Скинути"

        protected override void Dispose(bool disposing) 
        {
            if (disposing && (components != null)) 
            {
                components.Dispose(); 
            }
            base.Dispose(disposing); 
        }

        private void InitializeComponent() // Ініціалізація компонентів
        {
            this.labelTitle = new System.Windows.Forms.Label(); 
            this.checkBoxSports = new System.Windows.Forms.CheckBox(); 
            this.checkBoxTravel = new System.Windows.Forms.CheckBox(); 
            this.checkBoxCrafting = new System.Windows.Forms.CheckBox(); 
            this.checkBoxPainting = new System.Windows.Forms.CheckBox(); 
            this.labelSports = new System.Windows.Forms.Label(); 
            this.labelTravel = new System.Windows.Forms.Label(); 
            this.labelCrafting = new System.Windows.Forms.Label(); 
            this.labelPainting = new System.Windows.Forms.Label(); 
            this.buttonSend = new System.Windows.Forms.Button(); 
            this.buttonReset = new System.Windows.Forms.Button(); 
            this.SuspendLayout(); // Призупинити розташування

            // Налаштування заголовка
            this.labelTitle.AutoSize = true; 
            this.labelTitle.Location = new System.Drawing.Point(120, 20); 
            this.labelTitle.Name = "labelTitle"; 
            this.labelTitle.Size = new System.Drawing.Size(130, 13); 
            this.labelTitle.TabIndex = 0; 
            this.labelTitle.Text = "Виберіть ваші інтереси:"; 

            // Налаштування чекбокса спорту
            this.checkBoxSports.AutoSize = true;
            this.checkBoxSports.Location = new System.Drawing.Point(330, 50);
            this.checkBoxSports.Name = "checkBoxSports";
            this.checkBoxSports.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSports.TabIndex = 1;
            this.checkBoxSports.UseVisualStyleBackColor = true;
            this.checkBoxSports.Checked = true;

            // Налаштування мітки "Спорт"
            this.labelSports.AutoSize = true;
            this.labelSports.Location = new System.Drawing.Point(245, 50);
            this.labelSports.Name = "labelSports";
            this.labelSports.Size = new System.Drawing.Size(35, 13);
            this.labelSports.TabIndex = 2;
            this.labelSports.Text = "Спорт";

            // Налаштування чекбокса мандрівок
            this.checkBoxTravel.AutoSize = true;
            this.checkBoxTravel.Location = new System.Drawing.Point(289, 80);
            this.checkBoxTravel.Name = "checkBoxTravel";
            this.checkBoxTravel.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTravel.TabIndex = 3;
            this.checkBoxTravel.UseVisualStyleBackColor = true;

            // Налаштування мітки "Мандрівки"
            this.labelTravel.AutoSize = true;
            this.labelTravel.Location = new System.Drawing.Point(150, 80);
            this.labelTravel.Name = "labelTravel";
            this.labelTravel.Size = new System.Drawing.Size(55, 13);
            this.labelTravel.TabIndex = 4;
            this.labelTravel.Text = "Мандрівки";

            // Налаштування чекбокса майстрування
            this.checkBoxCrafting.AutoSize = true;
            this.checkBoxCrafting.Location = new System.Drawing.Point(291, 110);
            this.checkBoxCrafting.Name = "checkBoxCrafting";
            this.checkBoxCrafting.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCrafting.TabIndex = 5;
            this.checkBoxCrafting.UseVisualStyleBackColor = true;
            this.checkBoxCrafting.Checked = true;

            // Налаштування мітки "Майстрування"
            this.labelCrafting.AutoSize = true;
            this.labelCrafting.Location = new System.Drawing.Point(95, 110);
            this.labelCrafting.Name = "labelCrafting";
            this.labelCrafting.Size = new System.Drawing.Size(75, 13);
            this.labelCrafting.TabIndex = 6;
            this.labelCrafting.Text = "Майстрування";

            // Налаштування чекбокса малювання
            this.checkBoxPainting.AutoSize = true;
            this.checkBoxPainting.Location = new System.Drawing.Point(332, 140);
            this.checkBoxPainting.Name = "checkBoxPainting";
            this.checkBoxPainting.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPainting.TabIndex = 7;
            this.checkBoxPainting.UseVisualStyleBackColor = true;

            // Налаштування мітки "Малювання"
            this.labelPainting.AutoSize = true;
            this.labelPainting.Location = new System.Drawing.Point(250, 140);
            this.labelPainting.Name = "labelPainting";
            this.labelPainting.Size = new System.Drawing.Size(52, 13);
            this.labelPainting.TabIndex = 8;
            this.labelPainting.Text = "Малювання";

            // Налаштування кнопки "Відіслати"
            this.buttonSend.Location = new System.Drawing.Point(120, 180);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Відіслати";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click); // Подія

            // Налаштування кнопки "Скинути"
            this.buttonReset.Location = new System.Drawing.Point(220, 180);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Скинути";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click); // Подія

            // Налаштування форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.labelPainting);
            this.Controls.Add(this.checkBoxPainting);
            this.Controls.Add(this.labelCrafting);
            this.Controls.Add(this.checkBoxCrafting);
            this.Controls.Add(this.labelTravel);
            this.Controls.Add(this.checkBoxTravel);
            this.Controls.Add(this.labelSports);
            this.Controls.Add(this.checkBoxSports);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Task 3";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
