namespace Task_04
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;  
        private System.Windows.Forms.Label labelTitle; 
        private System.Windows.Forms.GroupBox groupBoxContactInfo; 
        private System.Windows.Forms.Label labelName; 
        private System.Windows.Forms.TextBox textBoxName; 
        private System.Windows.Forms.Label labelEmail; 
        private System.Windows.Forms.TextBox textBoxEmail; 
        private System.Windows.Forms.Label labelPhone; 
        private System.Windows.Forms.TextBox textBoxPhone; 
        private System.Windows.Forms.Label labelDate; 
        private System.Windows.Forms.DateTimePicker dateTimePickerVisit; 
        private System.Windows.Forms.GroupBox groupBoxPersonalInfo;
        private System.Windows.Forms.Label labelAge; 
        private System.Windows.Forms.ComboBox comboBoxAge; 
        private System.Windows.Forms.Label labelCuisine; 
        private System.Windows.Forms.ComboBox comboBoxCuisine; 
        private System.Windows.Forms.Label labelDishes; 
        private System.Windows.Forms.TextBox textBoxDishes; 
        private System.Windows.Forms.GroupBox groupBoxEvaluation; 
        private System.Windows.Forms.Label labelReason; 
        private System.Windows.Forms.RadioButton radioButtonReason1; 
        private System.Windows.Forms.RadioButton radioButtonReason2; 
        private System.Windows.Forms.RadioButton radioButtonReason3; 
        private System.Windows.Forms.RadioButton radioButtonReason4; 
        private System.Windows.Forms.Label labelRecommend; 
        private System.Windows.Forms.RadioButton radioButtonYes; 
        private System.Windows.Forms.RadioButton radioButtonNo; 
        private System.Windows.Forms.Button buttonSubmit; 
        private System.Windows.Forms.Button buttonClear; 
        private System.Windows.Forms.GroupBox groupBoxReason; 
        private System.Windows.Forms.GroupBox groupBoxRecommend; 


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
            this.groupBoxEvaluation = new System.Windows.Forms.GroupBox(); 
            this.groupBoxReason = new System.Windows.Forms.GroupBox(); 
            this.groupBoxRecommend = new System.Windows.Forms.GroupBox(); 
            this.labelTitle = new System.Windows.Forms.Label(); 
            this.groupBoxContactInfo = new System.Windows.Forms.GroupBox(); 
            this.labelName = new System.Windows.Forms.Label(); 
            this.textBoxName = new System.Windows.Forms.TextBox(); 
            this.labelEmail = new System.Windows.Forms.Label(); 
            this.textBoxEmail = new System.Windows.Forms.TextBox(); 
            this.labelPhone = new System.Windows.Forms.Label(); 
            this.textBoxPhone = new System.Windows.Forms.TextBox(); 
            this.labelDate = new System.Windows.Forms.Label(); 
            this.dateTimePickerVisit = new System.Windows.Forms.DateTimePicker(); 
            this.groupBoxPersonalInfo = new System.Windows.Forms.GroupBox(); 
            this.labelAge = new System.Windows.Forms.Label(); 
            this.comboBoxAge = new System.Windows.Forms.ComboBox(); 
            this.labelCuisine = new System.Windows.Forms.Label(); 
            this.comboBoxCuisine = new System.Windows.Forms.ComboBox();
            this.labelDishes = new System.Windows.Forms.Label(); 
            this.textBoxDishes = new System.Windows.Forms.TextBox(); 
            this.groupBoxEvaluation = new System.Windows.Forms.GroupBox(); 
            this.labelReason = new System.Windows.Forms.Label(); 
            this.radioButtonReason1 = new System.Windows.Forms.RadioButton(); 
            this.radioButtonReason2 = new System.Windows.Forms.RadioButton(); 
            this.radioButtonReason3 = new System.Windows.Forms.RadioButton(); 
            this.radioButtonReason4 = new System.Windows.Forms.RadioButton(); 
            this.labelRecommend = new System.Windows.Forms.Label(); 
            this.radioButtonYes = new System.Windows.Forms.RadioButton(); 
            this.radioButtonNo = new System.Windows.Forms.RadioButton(); 
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button(); 
            this.groupBoxContactInfo.SuspendLayout(); 
            this.groupBoxPersonalInfo.SuspendLayout(); 
            this.groupBoxEvaluation.SuspendLayout(); 
            this.SuspendLayout(); 

            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true; 
            this.labelTitle.Location = new System.Drawing.Point(60, 20); 
            this.labelTitle.Name = "labelTitle"; 
            this.labelTitle.Size = new System.Drawing.Size(150, 13); 
            this.labelTitle.TabIndex = 0; 
            this.labelTitle.Text = "Анкета відвідувача ресторана:"; 

            // 
            // groupBoxContactInfo
            // 
            this.groupBoxContactInfo.Controls.Add(this.labelName); 
            this.groupBoxContactInfo.Controls.Add(this.textBoxName); 
            this.groupBoxContactInfo.Controls.Add(this.labelEmail); 
            this.groupBoxContactInfo.Controls.Add(this.textBoxEmail); 
            this.groupBoxContactInfo.Controls.Add(this.labelPhone); 
            this.groupBoxContactInfo.Controls.Add(this.textBoxPhone); 
            this.groupBoxContactInfo.Controls.Add(this.labelDate); 
            this.groupBoxContactInfo.Controls.Add(this.dateTimePickerVisit); 
            this.groupBoxContactInfo.Location = new System.Drawing.Point(20, 50);
            this.groupBoxContactInfo.Name = "groupBoxContactInfo"; 
            this.groupBoxContactInfo.Size = new System.Drawing.Size(550, 170); 
            this.groupBoxContactInfo.TabIndex = 1; 
            this.groupBoxContactInfo.TabStop = false; 
            this.groupBoxContactInfo.Text = "Контактна інформація"; 

            // 
            // labelName
            // 
            this.labelName.AutoSize = true; 
            this.labelName.Location = new System.Drawing.Point(20, 30); 
            this.labelName.Name = "labelName"; 
            this.labelName.Size = new System.Drawing.Size(26, 13); 
            this.labelName.TabIndex = 1; 
            this.labelName.Text = "Ім'я"; 

            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(200, 30); 
            this.textBoxName.Name = "textBoxName"; 
            this.textBoxName.Size = new System.Drawing.Size(230, 20); 
            this.textBoxName.TabIndex = 2; 

            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true; 
            this.labelEmail.Location = new System.Drawing.Point(20, 110); 
            this.labelEmail.Name = "labelEmail"; 
            this.labelEmail.Size = new System.Drawing.Size(38, 13); 
            this.labelEmail.TabIndex = 3; 
            this.labelEmail.Text = "Пошта"; 

            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(200, 110); 
            this.textBoxEmail.Name = "textBoxEmail"; 
            this.textBoxEmail.Size = new System.Drawing.Size(230, 20); 
            this.textBoxEmail.TabIndex = 4; 

            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true; 
            this.labelPhone.Location = new System.Drawing.Point(20, 70); 
            this.labelPhone.Name = "labelPhone"; 
            this.labelPhone.Size = new System.Drawing.Size(55, 13); 
            this.labelPhone.TabIndex = 5; 
            this.labelPhone.Text = "Телефон"; 

            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(200, 70); 
            this.textBoxPhone.Name = "textBoxPhone"; 
            this.textBoxPhone.Size = new System.Drawing.Size(230, 20); 
            this.textBoxPhone.TabIndex = 6; 

            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true; 
            this.labelDate.Location = new System.Drawing.Point(20, 140); 
            this.labelDate.Name = "labelDate"; 
            this.labelDate.Size = new System.Drawing.Size(100, 13); 
            this.labelDate.TabIndex = 7; 
            this.labelDate.Text = "Дата відвідування"; 

            // 
            // dateTimePickerVisit
            // 
            this.dateTimePickerVisit.Location = new System.Drawing.Point(200, 140); 
            this.dateTimePickerVisit.Name = "dateTimePickerVisit"; 
            this.dateTimePickerVisit.Size = new System.Drawing.Size(230, 20); 
            this.dateTimePickerVisit.TabIndex = 8; 

            // 
            // groupBoxPersonalInfo
            // 
            this.groupBoxPersonalInfo.Controls.Add(this.labelAge); 
            this.groupBoxPersonalInfo.Controls.Add(this.comboBoxAge); 
            this.groupBoxPersonalInfo.Controls.Add(this.labelCuisine); 
            this.groupBoxPersonalInfo.Controls.Add(this.comboBoxCuisine); 
            this.groupBoxPersonalInfo.Controls.Add(this.labelDishes); 
            this.groupBoxPersonalInfo.Controls.Add(this.textBoxDishes); 
            this.groupBoxPersonalInfo.Location = new System.Drawing.Point(20, 230); 
            this.groupBoxPersonalInfo.Name = "groupBoxPersonalInfo"; 
            this.groupBoxPersonalInfo.Size = new System.Drawing.Size(550, 160); 
            this.groupBoxPersonalInfo.TabIndex = 9; 
            this.groupBoxPersonalInfo.TabStop = false; 
            this.groupBoxPersonalInfo.Text = "Персональна інформація"; 

            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true; 
            this.labelAge.Location = new System.Drawing.Point(20, 30); 
            this.labelAge.Name = "labelAge"; 
            this.labelAge.Size = new System.Drawing.Size(26, 13); 
            this.labelAge.TabIndex = 9;
            this.labelAge.Text = "Вік"; 

            // 
            // comboBoxAge
            // 
            this.comboBoxAge.FormattingEnabled = true; 
            this.comboBoxAge.Items.AddRange(new object[] { 
                "18-25",
                "26-35",
                "36-45",
                "46-55",
                "56+"
            });
            this.comboBoxAge.Location = new System.Drawing.Point(200, 30); 
            this.comboBoxAge.Name = "comboBoxAge"; 
            this.comboBoxAge.Size = new System.Drawing.Size(230, 21); 
            this.comboBoxAge.TabIndex = 10; 

            // 
            // labelCuisine
            // 
            this.labelCuisine.AutoSize = true; 
            this.labelCuisine.Location = new System.Drawing.Point(20, 70);
            this.labelCuisine.Name = "labelCuisine"; 
            this.labelCuisine.Size = new System.Drawing.Size(62, 13); 
            this.labelCuisine.TabIndex = 11; 
            this.labelCuisine.Text = "Улюблена кухня"; 

            // 
            // comboBoxCuisine
            // 
            this.comboBoxCuisine.FormattingEnabled = true; 
            this.comboBoxCuisine.Items.AddRange(new object[] { 
                "Українська",
                "Італійська",
                "Французька",
                "Японська",
                "Інша"
            });
            this.comboBoxCuisine.Location = new System.Drawing.Point(200, 70); 
            this.comboBoxCuisine.Name = "comboBoxCuisine"; 
            this.comboBoxCuisine.Size = new System.Drawing.Size(100, 21); 
            this.comboBoxCuisine.TabIndex = 12; 

            // 
            // labelDishes
            //                                     
            this.labelDishes.AutoSize = true; 
            this.labelDishes.Location = new System.Drawing.Point(20, 110); 
            this.labelDishes.Name = "labelDishes"; 
            this.labelDishes.Size = new System.Drawing.Size(85, 13); 
            this.labelDishes.TabIndex = 13; 
            this.labelDishes.Text = "Які страви Ви б хотіли\nбачити в меню?"; 

            // 
            // textBoxDishes
            // 
            this.textBoxDishes.Location = new System.Drawing.Point(200, 110); 
            this.textBoxDishes.Multiline = true; 
            this.textBoxDishes.Name = "textBoxDishes"; 
            this.textBoxDishes.Size = new System.Drawing.Size(230, 40); 
            this.textBoxDishes.TabIndex = 14; 
                                            
            // groupBoxEvaluation
            // 
            // Створення групи для оцінки установи
            this.groupBoxEvaluation.Controls.Add(this.groupBoxReason); 
            this.groupBoxEvaluation.Controls.Add(this.groupBoxRecommend); 
            this.groupBoxEvaluation.Location = new System.Drawing.Point(20, 400); 
            this.groupBoxEvaluation.Name = "groupBoxEvaluation"; 
            this.groupBoxEvaluation.Size = new System.Drawing.Size(550, 350); 
            this.groupBoxEvaluation.TabIndex = 15; 
            this.groupBoxEvaluation.TabStop = false; 
            this.groupBoxEvaluation.Text = "Оцінка нашої установи"; 

            // 
            // groupBoxReason
            // 
            // Створення групи для вибору причини відвідування
            this.groupBoxReason.Controls.Add(this.labelReason); 
            this.groupBoxReason.Controls.Add(this.radioButtonReason1); 
            this.groupBoxReason.Controls.Add(this.radioButtonReason2); 
            this.groupBoxReason.Controls.Add(this.radioButtonReason3); 
            this.groupBoxReason.Controls.Add(this.radioButtonReason4);
            this.groupBoxReason.Location = new System.Drawing.Point(10, 20); 
            this.groupBoxReason.Name = "groupBoxReason"; 
            this.groupBoxReason.Size = new System.Drawing.Size(520, 180); 
            this.groupBoxReason.TabIndex = 0; 
            this.groupBoxReason.TabStop = false; 
            this.groupBoxReason.Text = "Чому обрали нашу установу?"; 

            // 
            // groupBoxRecommend
            // 
            // Створення групи для запитання про рекомендації
            this.groupBoxRecommend.Controls.Add(this.labelRecommend); 
            this.groupBoxRecommend.Controls.Add(this.radioButtonYes); 
            this.groupBoxRecommend.Controls.Add(this.radioButtonNo); 
            this.groupBoxRecommend.Location = new System.Drawing.Point(10, 210);
            this.groupBoxRecommend.Name = "groupBoxRecommend"; 
            this.groupBoxRecommend.Size = new System.Drawing.Size(520, 120); 
            this.groupBoxRecommend.TabIndex = 1; 
            this.groupBoxRecommend.TabStop = false; 
            this.groupBoxRecommend.Text = "Чи будете рекомендувати нашу установу друзям та знайомим?"; 

            // 
            // labelReason
            // 
            // Мітка для запитання про причину вибору установи
            this.labelReason.AutoSize = true; 
            this.labelReason.Location = new System.Drawing.Point(20, 30); 
            this.labelReason.Name = "labelReason"; 
            this.labelReason.Size = new System.Drawing.Size(150, 13); 
            this.labelReason.TabIndex = 0; 
            this.labelReason.Text = "Чому обрали нашу установу?"; 

            // 
            // radioButtonReason1
            // 
            // Кнопка для вибору першої причини
            this.radioButtonReason1.AutoSize = true; 
            this.radioButtonReason1.Location = new System.Drawing.Point(20, 50); 
            this.radioButtonReason1.Name = "radioButtonReason1"; 
            this.radioButtonReason1.Size = new System.Drawing.Size(90, 17); 
            this.radioButtonReason1.TabIndex = 1; 
            this.radioButtonReason1.TabStop = true; 
            this.radioButtonReason1.Text = "Недалеко від роботи/дому"; 
            this.radioButtonReason1.UseVisualStyleBackColor = true; 

            // 
            // radioButtonReason2
            // 
            // Кнопка для вибору другої причини
            this.radioButtonReason2.AutoSize = true; 
            this.radioButtonReason2.Location = new System.Drawing.Point(20, 80); 
            this.radioButtonReason2.Name = "radioButtonReason2"; 
            this.radioButtonReason2.Size = new System.Drawing.Size(100, 17);
            this.radioButtonReason2.TabIndex = 2; 
            this.radioButtonReason2.TabStop = true; 
            this.radioButtonReason2.Text = "Побачив рекламу"; 
            this.radioButtonReason2.UseVisualStyleBackColor = true; 

            // 
            // radioButtonReason3
            // 
            // Кнопка для вибору третьої причини
            this.radioButtonReason3.AutoSize = true; 
            this.radioButtonReason3.Location = new System.Drawing.Point(20, 110); 
            this.radioButtonReason3.Name = "radioButtonReason3"; 
            this.radioButtonReason3.Size = new System.Drawing.Size(76, 17); 
            this.radioButtonReason3.TabIndex = 3; 
            this.radioButtonReason3.TabStop = true; 
            this.radioButtonReason3.Text = "Порадили"; 
            this.radioButtonReason3.UseVisualStyleBackColor = true; 

            // 
            // radioButtonReason4
            // 
            // Кнопка для вибору четвертої причини
            this.radioButtonReason4.AutoSize = true;
            this.radioButtonReason4.Location = new System.Drawing.Point(20, 140); 
            this.radioButtonReason4.Name = "radioButtonReason4"; 
            this.radioButtonReason4.Size = new System.Drawing.Size(70, 17); 
            this.radioButtonReason4.TabIndex = 4; 
            this.radioButtonReason4.TabStop = true; 
            this.radioButtonReason4.Text = "Оптимальне співвідношення ціни та якості"; 
            this.radioButtonReason4.UseVisualStyleBackColor = true; 


            // labelRecommend
            // Створенння мітки для запитання рекомендпції користувачу установи 
            this.labelRecommend.AutoSize = true; 
            this.labelRecommend.Location = new System.Drawing.Point(20, 30); 
            this.labelRecommend.Name = "labelRecommend"; 
            this.labelRecommend.Size = new System.Drawing.Size(170, 13); 
            this.labelRecommend.TabIndex = 5; 
            this.labelRecommend.Text = "Чи будете рекомендувати нашу установу друзям та знайомим?"; 

            // radioButtonYes
            // Створення радіокнопки для відповіді "Так"
            this.radioButtonYes.AutoSize = true; 
            this.radioButtonYes.Location = new System.Drawing.Point(20, 50); 
            this.radioButtonYes.Name = "radioButtonYes"; 
            this.radioButtonYes.Size = new System.Drawing.Size(43, 17); 
            this.radioButtonYes.TabIndex = 6; 
            this.radioButtonYes.TabStop = true; 
            this.radioButtonYes.Text = "Так"; 
            this.radioButtonYes.UseVisualStyleBackColor = true; 

            // radioButtonNo
            // Створенння радіокнопки для відповіді "Ні"
            this.radioButtonNo.AutoSize = true; 
            this.radioButtonNo.Location = new System.Drawing.Point(20, 80); 
            this.radioButtonNo.Name = "radioButtonNo"; 
            this.radioButtonNo.Size = new System.Drawing.Size(44, 17); 
            this.radioButtonNo.TabIndex = 7; 
            this.radioButtonNo.TabStop = true; 
            this.radioButtonNo.Text = "Ні"; 
            this.radioButtonNo.UseVisualStyleBackColor = true; 

            // buttonSubmit
            // Створення кнопку "Відправити" для підтвердження заповненої анкети
            this.buttonSubmit.Location = new System.Drawing.Point(20, 770); 
            this.buttonSubmit.Name = "buttonSubmit"; 
            this.buttonSubmit.Size = new System.Drawing.Size(100, 40); 
            this.buttonSubmit.TabIndex = 16; 
            this.buttonSubmit.Text = "Відправити"; 
            this.buttonSubmit.UseVisualStyleBackColor = true; 
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click); 

            // buttonClear
            // Створює кнопку "Очистити" для скидання заповненої анкети
            this.buttonClear.Location = new System.Drawing.Point(140, 770); 
            this.buttonClear.Name = "buttonClear"; 
            this.buttonClear.Size = new System.Drawing.Size(100, 40); 
            this.buttonClear.TabIndex = 17; 
            this.buttonClear.Text = "Очистити"; 
            this.buttonClear.UseVisualStyleBackColor = true; 
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click); 

            // Form1
            // Налаштовує основну форму анкети
            this.ClientSize = new System.Drawing.Size(800, 850); 
            this.Controls.Add(this.buttonClear); 
            this.Controls.Add(this.buttonSubmit); 
            this.Controls.Add(this.groupBoxEvaluation); 
            this.Controls.Add(this.groupBoxPersonalInfo); 
            this.Controls.Add(this.groupBoxContactInfo); 
            this.Controls.Add(this.labelTitle); 
            this.Name = "Form1"; 
            this.Text = "Task 4"; 
            this.groupBoxContactInfo.ResumeLayout(false); 
            this.groupBoxContactInfo.PerformLayout(); 
            this.groupBoxPersonalInfo.ResumeLayout(false); 
            this.groupBoxPersonalInfo.PerformLayout(); 
            this.groupBoxEvaluation.ResumeLayout(false); 
            this.groupBoxEvaluation.PerformLayout(); 
            this.ResumeLayout(false); 
            this.PerformLayout(); 
        }

        private void buttonSubmit_Click(object sender, System.EventArgs e)
        {
            // Перевірка на заповненість обов'язкових полів
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || 
                string.IsNullOrWhiteSpace(textBoxEmail.Text) || 
                string.IsNullOrWhiteSpace(textBoxPhone.Text) || 
                comboBoxAge.SelectedIndex == -1 || 
                comboBoxCuisine.SelectedIndex == -1 || 
                (!radioButtonReason1.Checked && !radioButtonReason2.Checked && !radioButtonReason3.Checked && !radioButtonReason4.Checked) || // Перевірка на вибір причини
                (!radioButtonYes.Checked && !radioButtonNo.Checked)) 
            {
                // Виведення повідомлення про помилку якщо є незаповнені поля
                MessageBox.Show("Будь ласка, заповніть усі обов'язкові поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            // Збір та зберігання даних з форми
            string name = textBoxName.Text; 
            string email = textBoxEmail.Text; 
            string phone = textBoxPhone.Text; 
            DateTime visitDate = dateTimePickerVisit.Value; 
            string age = comboBoxAge.SelectedItem.ToString(); 
            string cuisine = comboBoxCuisine.SelectedItem.ToString(); 
            string dishes = textBoxDishes.Text; 

            // Визначення причини вибору ресторану на основі вибраної радіокнопки
            string reason = radioButtonReason1.Checked ? radioButtonReason1.Text :
                            radioButtonReason2.Checked ? radioButtonReason2.Text :
                            radioButtonReason3.Checked ? radioButtonReason3.Text :
                            radioButtonReason4.Checked ? radioButtonReason4.Text : "";

            // Визначення рекомендації на основі вибору
            string recommend = radioButtonYes.Checked ? "Так" : "Ні";

            // Виведення даних для перевірки
            MessageBox.Show($"Ім'я: {name}\n" +
                            $"Пошта: {email}\n" +
                            $"Телефон: {phone}\n" +
                            $"Дата відвідування: {visitDate.ToShortDateString()}\n" +
                            $"Вік: {age}\n" +
                            $"Улюблена кухня: {cuisine}\n" +
                            $"Страви в меню: {dishes}\n" +
                            $"Чому обрали наш ресторан: {reason}\n" +
                            $"Чи порекомендуєте ресторан: {recommend}",
                            "Відправка даних", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonClear_Click(object sender, System.EventArgs e)
        {
            // Очищення всіх полів форми
            textBoxName.Clear(); 
            textBoxEmail.Clear(); 
            textBoxPhone.Clear(); 
            dateTimePickerVisit.Value = DateTime.Today; 
            comboBoxAge.SelectedIndex = -1; 
            comboBoxCuisine.SelectedIndex = -1; 
            textBoxDishes.Clear(); 
            radioButtonReason1.Checked = false; 
            radioButtonReason2.Checked = false; 
            radioButtonReason3.Checked = false; 
            radioButtonReason4.Checked = false; 
            radioButtonYes.Checked = false; 
            radioButtonNo.Checked = false; 
        }
    }
}