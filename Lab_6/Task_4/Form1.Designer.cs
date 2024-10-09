namespace Task_4
{
    // Частковий клас Form1, що є формою для GUI
    partial class Form1
    {
        // Компоненти форми
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBoxCity;     // Група для вибору міста
        private System.Windows.Forms.GroupBox groupBoxTransport; // Група для вибору транспорту
        private System.Windows.Forms.RadioButton radioButtonKharkiv;   // Кнопка вибору міста Харків
        private System.Windows.Forms.RadioButton radioButtonKyiv;      // Кнопка вибору міста Київ
        private System.Windows.Forms.RadioButton radioButtonOdesa;     // Кнопка вибору міста Одеса
        private System.Windows.Forms.RadioButton radioButtonZaporizhzhia;  // Кнопка вибору міста Запоріжжя
        private System.Windows.Forms.RadioButton radioButtonBus;       // Кнопка вибору автобуса
        private System.Windows.Forms.RadioButton radioButtonTrain;     // Кнопка вибору потяга
        private System.Windows.Forms.RadioButton radioButtonPlane;     // Кнопка вибору літака
        private System.Windows.Forms.Button buttonSelect;  // Кнопка "Вибрати"
        private System.Windows.Forms.Button buttonCancel;  // Кнопка "Відмовитися"

        // Метод для очищення компонентів, якщо це необхідно
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();  // Звільнення ресурсів
            }
            base.Dispose(disposing);    // Виклик базового методу для завершення очищення
        }

        // Метод для ініціалізації компонентів форми
        private void InitializeComponent()
        {
            // Ініціалізація компонентів вибору міста
            this.groupBoxCity = new System.Windows.Forms.GroupBox();
            this.radioButtonKharkiv = new System.Windows.Forms.RadioButton();
            this.radioButtonKyiv = new System.Windows.Forms.RadioButton();
            this.radioButtonOdesa = new System.Windows.Forms.RadioButton();
            this.radioButtonZaporizhzhia = new System.Windows.Forms.RadioButton();

            // Ініціалізація компонентів вибору транспорту
            this.groupBoxTransport = new System.Windows.Forms.GroupBox();
            this.radioButtonBus = new System.Windows.Forms.RadioButton();
            this.radioButtonTrain = new System.Windows.Forms.RadioButton();
            this.radioButtonPlane = new System.Windows.Forms.RadioButton();

            // Ініціалізація кнопок "Вибрати" та "Відмовитися"
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();

            // Налаштування групи для вибору міста
            this.groupBoxCity.SuspendLayout();
            this.groupBoxTransport.SuspendLayout();
            this.SuspendLayout();

            // Налаштування компонентів у GroupBox для вибору міста
            this.groupBoxCity.Controls.Add(this.radioButtonKharkiv);
            this.groupBoxCity.Controls.Add(this.radioButtonKyiv);
            this.groupBoxCity.Controls.Add(this.radioButtonOdesa);
            this.groupBoxCity.Controls.Add(this.radioButtonZaporizhzhia);
            this.groupBoxCity.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCity.Name = "groupBoxCity";
            this.groupBoxCity.Size = new System.Drawing.Size(200, 150);
            this.groupBoxCity.TabIndex = 0;
            this.groupBoxCity.TabStop = false;
            this.groupBoxCity.Text = "Вибрати місто:";

            // Налаштування RadioButtons для вибору міста
            this.radioButtonKharkiv.AutoSize = true;
            this.radioButtonKharkiv.Location = new System.Drawing.Point(6, 19);
            this.radioButtonKharkiv.Name = "radioButtonKharkiv";
            this.radioButtonKharkiv.Size = new System.Drawing.Size(58, 17);
            this.radioButtonKharkiv.TabIndex = 0;
            this.radioButtonKharkiv.TabStop = true;
            this.radioButtonKharkiv.Text = "Харків";
            this.radioButtonKharkiv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonKharkiv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonKharkiv.UseVisualStyleBackColor = true;

            // Налаштування RadioButton для вибору міста Київ
            this.radioButtonKyiv.AutoSize = true;
            this.radioButtonKyiv.Location = new System.Drawing.Point(6, 42);
            this.radioButtonKyiv.Name = "radioButtonKyiv";
            this.radioButtonKyiv.Size = new System.Drawing.Size(46, 17);
            this.radioButtonKyiv.TabIndex = 1;
            this.radioButtonKyiv.TabStop = true;
            this.radioButtonKyiv.Text = "Київ";
            this.radioButtonKyiv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonKyiv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonKyiv.UseVisualStyleBackColor = true;

            // Налаштування RadioButton для вибору міста Одеса
            this.radioButtonOdesa.AutoSize = true;
            this.radioButtonOdesa.Location = new System.Drawing.Point(6, 65);
            this.radioButtonOdesa.Name = "radioButtonOdesa";
            this.radioButtonOdesa.Size = new System.Drawing.Size(57, 17);
            this.radioButtonOdesa.TabIndex = 2;
            this.radioButtonOdesa.TabStop = true;
            this.radioButtonOdesa.Text = "Одеса";
            this.radioButtonOdesa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonOdesa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonOdesa.UseVisualStyleBackColor = true;

            // Налаштування RadioButton для вибору міста Запоріжжя
            this.radioButtonZaporizhzhia.AutoSize = true;
            this.radioButtonZaporizhzhia.Location = new System.Drawing.Point(6, 88);
            this.radioButtonZaporizhzhia.Name = "radioButtonZaporizhzhia";
            this.radioButtonZaporizhzhia.Size = new System.Drawing.Size(75, 17);
            this.radioButtonZaporizhzhia.TabIndex = 3;
            this.radioButtonZaporizhzhia.TabStop = true;
            this.radioButtonZaporizhzhia.Text = "Запоріжжя";
            this.radioButtonZaporizhzhia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonZaporizhzhia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonZaporizhzhia.UseVisualStyleBackColor = true;

            // Налаштування групи для вибору транспорту
            this.groupBoxTransport.Controls.Add(this.radioButtonBus);
            this.groupBoxTransport.Controls.Add(this.radioButtonTrain);
            this.groupBoxTransport.Controls.Add(this.radioButtonPlane);
            this.groupBoxTransport.Location = new System.Drawing.Point(218, 12);
            this.groupBoxTransport.Name = "groupBoxTransport";
            this.groupBoxTransport.Size = new System.Drawing.Size(200, 150);
            this.groupBoxTransport.TabIndex = 1;
            this.groupBoxTransport.TabStop = false;
            this.groupBoxTransport.Text = "Вибрати транспорт:";

            // Налаштування RadioButton для вибору автобуса
            this.radioButtonBus.AutoSize = true;
            this.radioButtonBus.Location = new System.Drawing.Point(6, 19);
            this.radioButtonBus.Name = "radioButtonBus";
            this.radioButtonBus.Size = new System.Drawing.Size(65, 17);
            this.radioButtonBus.TabIndex = 0;
            this.radioButtonBus.TabStop = true;
            this.radioButtonBus.Text = "Автобус";
            this.radioButtonBus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonBus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonBus.UseVisualStyleBackColor = true;

            // Налаштування RadioButton для вибору потяга
            this.radioButtonTrain.AutoSize = true;
            this.radioButtonTrain.Location = new System.Drawing.Point(6, 42);
            this.radioButtonTrain.Name = "radioButtonTrain";
            this.radioButtonTrain.Size = new System.Drawing.Size(54, 17);
            this.radioButtonTrain.TabIndex = 1;
            this.radioButtonTrain.TabStop = true;
            this.radioButtonTrain.Text = "Потяг";
            this.radioButtonTrain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonTrain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonTrain.UseVisualStyleBackColor = true;

            // Налаштування RadioButton для вибору літака
            this.radioButtonPlane.AutoSize = true;
            this.radioButtonPlane.Location = new System.Drawing.Point(6, 65);
            this.radioButtonPlane.Name = "radioButtonPlane";
            this.radioButtonPlane.Size = new System.Drawing.Size(50, 17);
            this.radioButtonPlane.TabIndex = 2;
            this.radioButtonPlane.TabStop = true;
            this.radioButtonPlane.Text = "Літак";
            this.radioButtonPlane.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonPlane.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonPlane.UseVisualStyleBackColor = true;

            // Налаштування кнопки "Вибрати"
            this.buttonSelect.Location = new System.Drawing.Point(12, 168);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(90, 30);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.Text = "Вибрати";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);  // Подія кліку для вибору

            // Налаштування кнопки "Відмовитися"
            this.buttonCancel.Location = new System.Drawing.Point(310, 168);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 30);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Відмовитися";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);  // Подія кліку для відмови

            // Властивості форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 203);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.groupBoxTransport);
            this.Controls.Add(this.groupBoxCity);
            this.Name = "Form1";
            this.Text = "Task 4";  // Назва форми
            this.groupBoxCity.ResumeLayout(false);
            this.groupBoxCity.PerformLayout();
            this.groupBoxTransport.ResumeLayout(false);
            this.groupBoxTransport.PerformLayout();
            this.ResumeLayout(false);  // Завершення компонування форми
        }
    }
}
