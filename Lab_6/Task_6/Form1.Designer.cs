namespace Task__6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null; // Змінна для зберігання компонентів форми
        private System.Windows.Forms.Label labelTitle; // Назва для заголовка форми
        private System.Windows.Forms.GroupBox groupBoxContactInfo; // Група для контактної інформації
        private System.Windows.Forms.Label labelName; // Назва для введення імені
        private System.Windows.Forms.TextBox textBoxName; // Поле введення для імені
        private System.Windows.Forms.Label labelEmail; // Назва для введення електронної пошти
        private System.Windows.Forms.TextBox textBoxEmail; // Поле введення для електронної пошти
        private System.Windows.Forms.Label labelPhone; // Назва для введення телефону
        private System.Windows.Forms.TextBox textBoxPhone; // Поле введення для телефону
        private System.Windows.Forms.Label labelDate; // Назва для вибору дати візиту
        private System.Windows.Forms.DateTimePicker dateTimePickerVisit; // Віджет для вибору дати візиту
        private System.Windows.Forms.GroupBox groupBoxPersonalInfo; // Група для особистої інформації
        private System.Windows.Forms.Label labelAge; // Назва для введення віку
        private System.Windows.Forms.ComboBox comboBoxAge; // Комбобокс для вибору віку
        private System.Windows.Forms.Label labelCuisine; // Назва для вибору кухні
        private System.Windows.Forms.ComboBox comboBoxCuisine; // Комбобокс для вибору кухні
        private System.Windows.Forms.Label labelDishes; // Назва для введення страв
        private System.Windows.Forms.TextBox textBoxDishes; // Поле введення для страв
        private System.Windows.Forms.GroupBox groupBoxEvaluation; // Група для оцінки
        private System.Windows.Forms.Label labelReason; // Назва для вибору причини візиту
        private System.Windows.Forms.RadioButton radioButtonReason1; // Радіокнопка для вибору причини 1
        private System.Windows.Forms.RadioButton radioButtonReason2; // Радіокнопка для вибору причини 2
        private System.Windows.Forms.RadioButton radioButtonReason3; // Радіокнопка для вибору причини 3
        private System.Windows.Forms.RadioButton radioButtonReason4; // Радіокнопка для вибору причини 4
        private System.Windows.Forms.Label labelRecommend; // Назва для питання про рекомендації
        private System.Windows.Forms.RadioButton radioButtonYes; // Радіокнопка для відповіді "Так" на питання про рекомендації
        private System.Windows.Forms.RadioButton radioButtonNo; // Радіокнопка для відповіді "Ні" на питання про рекомендації
        private System.Windows.Forms.Button buttonSubmit; // Кнопка для відправки форми
        private System.Windows.Forms.Button buttonClear; // Кнопка для очищення полів форми
        private System.Windows.Forms.GroupBox groupBoxReason; // Група для вибору причини візиту
        private System.Windows.Forms.GroupBox groupBoxRecommend; // Група для вибору рекомендацій


        protected override void Dispose(bool disposing)
        {
            // Перевірка наявності компонентів для звільнення ресурсів
            if (disposing && (components != null))
            {
                components.Dispose(); // Звільнення ресурсів, якщо компоненти існують
            }
            base.Dispose(disposing); // Виклик базового методу для подальшого звільнення ресурсів
        }

        private void InitializeComponent()
        {
            this.groupBoxEvaluation = new System.Windows.Forms.GroupBox(); // Група для оцінки
            this.groupBoxReason = new System.Windows.Forms.GroupBox(); // Група для вибору причини
            this.groupBoxRecommend = new System.Windows.Forms.GroupBox(); // Група для вибору рекомендацій
            this.labelTitle = new System.Windows.Forms.Label(); // Заголовок форми
            this.groupBoxContactInfo = new System.Windows.Forms.GroupBox(); // Група для контактної інформації
            this.labelName = new System.Windows.Forms.Label(); // Назва для введення імені
            this.textBoxName = new System.Windows.Forms.TextBox(); // Поле введення для імені
            this.labelEmail = new System.Windows.Forms.Label(); // Назва для введення електронної пошти
            this.textBoxEmail = new System.Windows.Forms.TextBox(); // Поле введення для електронної пошти
            this.labelPhone = new System.Windows.Forms.Label(); // Назва для введення телефону
            this.textBoxPhone = new System.Windows.Forms.TextBox(); // Поле введення для телефону
            this.labelDate = new System.Windows.Forms.Label(); // Назва для вибору дати візиту
            this.dateTimePickerVisit = new System.Windows.Forms.DateTimePicker(); // Віджет для вибору дати візиту
            this.groupBoxPersonalInfo = new System.Windows.Forms.GroupBox(); // Група для особистої інформації
            this.labelAge = new System.Windows.Forms.Label(); // Назва для введення віку
            this.comboBoxAge = new System.Windows.Forms.ComboBox(); // Комбобокс для вибору віку
            this.labelCuisine = new System.Windows.Forms.Label(); // Назва для вибору кухні
            this.comboBoxCuisine = new System.Windows.Forms.ComboBox(); // Комбобокс для вибору кухні
            this.labelDishes = new System.Windows.Forms.Label(); // Назва для введення страв
            this.textBoxDishes = new System.Windows.Forms.TextBox(); // Поле введення для страв
            this.groupBoxEvaluation = new System.Windows.Forms.GroupBox(); // Група для оцінки (повторно)
            this.labelReason = new System.Windows.Forms.Label(); // Назва для вибору причини візиту
            this.radioButtonReason1 = new System.Windows.Forms.RadioButton(); // Радіокнопка для вибору причини 1
            this.radioButtonReason2 = new System.Windows.Forms.RadioButton(); // Радіокнопка для вибору причини 2
            this.radioButtonReason3 = new System.Windows.Forms.RadioButton(); // Радіокнопка для вибору причини 3
            this.radioButtonReason4 = new System.Windows.Forms.RadioButton(); // Радіокнопка для вибору причини 4
            this.labelRecommend = new System.Windows.Forms.Label(); // Назва для питання про рекомендації
            this.radioButtonYes = new System.Windows.Forms.RadioButton(); // Радіокнопка для відповіді "Так" на питання про рекомендації
            this.radioButtonNo = new System.Windows.Forms.RadioButton(); // Радіокнопка для відповіді "Ні" на питання про рекомендації
            this.buttonSubmit = new System.Windows.Forms.Button(); // Кнопка для відправки форми
            this.buttonClear = new System.Windows.Forms.Button(); // Кнопка для очищення полів форми
            this.groupBoxContactInfo.SuspendLayout(); // Підготовка групи контактної інформації
            this.groupBoxPersonalInfo.SuspendLayout(); // Підготовка групи особистої інформації
            this.groupBoxEvaluation.SuspendLayout(); // Підготовка групи оцінки
            this.SuspendLayout(); // Підготовка до ініціалізації компонента
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true; // Автоматичне визначення розміру для мітки
            this.labelTitle.Location = new System.Drawing.Point(60, 20); // Встановлення позиції мітки на формі
            this.labelTitle.Name = "labelTitle"; // Присвоєння імені мітці
            this.labelTitle.Size = new System.Drawing.Size(150, 13); // Встановлення розміру мітки
            this.labelTitle.TabIndex = 0; // Встановлення порядкового номера для табуляції
            this.labelTitle.Text = "Анкета відвідувача ресторана:"; // Текст, що відображається на мітці
            // 
            // groupBoxContactInfo
            // 
            this.groupBoxContactInfo.Controls.Add(this.labelName); // Додавання мітки імені до групи
            this.groupBoxContactInfo.Controls.Add(this.textBoxName); // Додавання поля введення імені до групи
            this.groupBoxContactInfo.Controls.Add(this.labelEmail); // Додавання мітки електронної пошти до групи
            this.groupBoxContactInfo.Controls.Add(this.textBoxEmail); // Додавання поля введення електронної пошти до групи
            this.groupBoxContactInfo.Controls.Add(this.labelPhone); // Додавання мітки телефону до групи
            this.groupBoxContactInfo.Controls.Add(this.textBoxPhone); // Додавання поля введення телефону до групи
            this.groupBoxContactInfo.Controls.Add(this.labelDate); // Додавання мітки дати візиту до групи
            this.groupBoxContactInfo.Controls.Add(this.dateTimePickerVisit); // Додавання віджета вибору дати до групи
            this.groupBoxContactInfo.Location = new System.Drawing.Point(20, 50); // Встановлення позиції групи на формі
            this.groupBoxContactInfo.Name = "groupBoxContactInfo"; // Присвоєння імені групі
            this.groupBoxContactInfo.Size = new System.Drawing.Size(550, 170); // Встановлення розміру групи
            this.groupBoxContactInfo.TabIndex = 1; // Встановлення порядкового номера для табуляції
            this.groupBoxContactInfo.TabStop = false; // Зазначає, що група не може отримати фокус
            this.groupBoxContactInfo.Text = "Контактна інформація"; // Текст заголовка групи
            // 
            // labelName
            // 
            this.labelName.AutoSize = true; // Автоматичне визначення розміру для мітки
            this.labelName.Location = new System.Drawing.Point(20, 30); // Встановлення позиції мітки на групі
            this.labelName.Name = "labelName"; // Присвоєння імені мітці
            this.labelName.Size = new System.Drawing.Size(26, 13); // Встановлення розміру мітки
            this.labelName.TabIndex = 1; // Встановлення порядкового номера для табуляції
            this.labelName.Text = "Ім'я"; // Текст, що відображається на мітці
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(200, 30); // Встановлення позиції поля введення на групі
            this.textBoxName.Name = "textBoxName"; // Присвоєння імені полю введення
            this.textBoxName.Size = new System.Drawing.Size(230, 20); // Встановлення розміру поля введення
            this.textBoxName.TabIndex = 2; // Встановлення порядкового номера для табуляції
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true; // Автоматичне визначення розміру для мітки
            this.labelEmail.Location = new System.Drawing.Point(20, 110); // Встановлення позиції мітки на формі
            this.labelEmail.Name = "labelEmail"; // Присвоєння імені мітці
            this.labelEmail.Size = new System.Drawing.Size(38, 13); // Встановлення розміру мітки
            this.labelEmail.TabIndex = 3; // Встановлення порядкового номера для табуляції
            this.labelEmail.Text = "Пошта"; // Текст, що відображається на мітці
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(200, 110); // Встановлення позиції поля введення на формі
            this.textBoxEmail.Name = "textBoxEmail"; // Присвоєння імені полю введення
            this.textBoxEmail.Size = new System.Drawing.Size(230, 20); // Встановлення розміру поля введення
            this.textBoxEmail.TabIndex = 4; // Встановлення порядкового номера для табуляції
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true; // Автоматичне визначення розміру для мітки
            this.labelPhone.Location = new System.Drawing.Point(20, 70); // Встановлення позиції мітки на формі
            this.labelPhone.Name = "labelPhone"; // Присвоєння імені мітці
            this.labelPhone.Size = new System.Drawing.Size(55, 13); // Встановлення розміру мітки
            this.labelPhone.TabIndex = 5; // Встановлення порядкового номера для табуляції
            this.labelPhone.Text = "Телефон"; // Текст, що відображається на мітці
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(200, 70); // Встановлення позиції поля введення на формі
            this.textBoxPhone.Name = "textBoxPhone"; // Присвоєння імені полю введення
            this.textBoxPhone.Size = new System.Drawing.Size(230, 20); // Встановлення розміру поля введення
            this.textBoxPhone.TabIndex = 6; // Встановлення порядкового номера для табуляції
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true; // Автоматичне визначення розміру для мітки
            this.labelDate.Location = new System.Drawing.Point(20, 140); // Встановлення позиції мітки на формі
            this.labelDate.Name = "labelDate"; // Присвоєння імені мітці
            this.labelDate.Size = new System.Drawing.Size(100, 13); // Встановлення розміру мітки
            this.labelDate.TabIndex = 7; // Встановлення порядкового номера для табуляції
            this.labelDate.Text = "Дата відвідування"; // Текст, що відображається на мітці
            // 
            // dateTimePickerVisit
            // 
            this.dateTimePickerVisit.Location = new System.Drawing.Point(200, 140); // Встановлення позиції віджета вибору дати на формі
            this.dateTimePickerVisit.Name = "dateTimePickerVisit"; // Присвоєння імені віджету
            this.dateTimePickerVisit.Size = new System.Drawing.Size(230, 20); // Встановлення розміру віджету вибору дати
            this.dateTimePickerVisit.TabIndex = 8; // Встановлення порядкового номера для табуляції
            // 
            // groupBoxPersonalInfo
            // 
            this.groupBoxPersonalInfo.Controls.Add(this.labelAge); // Додавання мітки для віку
            this.groupBoxPersonalInfo.Controls.Add(this.comboBoxAge); // Додавання комбінованого поля для вибору віку
            this.groupBoxPersonalInfo.Controls.Add(this.labelCuisine); // Додавання мітки для улюбленої кухні
            this.groupBoxPersonalInfo.Controls.Add(this.comboBoxCuisine); // Додавання комбінованого поля для вибору улюбленої кухні
            this.groupBoxPersonalInfo.Controls.Add(this.labelDishes); // Додавання мітки для страв
            this.groupBoxPersonalInfo.Controls.Add(this.textBoxDishes); // Додавання поля введення для страв
            this.groupBoxPersonalInfo.Location = new System.Drawing.Point(20, 230); // Встановлення позиції групи на формі
            this.groupBoxPersonalInfo.Name = "groupBoxPersonalInfo"; // Присвоєння імені групі
            this.groupBoxPersonalInfo.Size = new System.Drawing.Size(550, 160); // Встановлення розміру групи
            this.groupBoxPersonalInfo.TabIndex = 9; // Встановлення порядкового номера для табуляції
            this.groupBoxPersonalInfo.TabStop = false; // Вимкнення можливості фокусування на групі
            this.groupBoxPersonalInfo.Text = "Персональна інформація"; // Текст, що відображається на групі
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true; // Автоматичне визначення розміру для мітки
            this.labelAge.Location = new System.Drawing.Point(20, 30); // Встановлення позиції мітки на формі
            this.labelAge.Name = "labelAge"; // Присвоєння імені мітці
            this.labelAge.Size = new System.Drawing.Size(26, 13); // Встановлення розміру мітки
            this.labelAge.TabIndex = 9; // Встановлення порядкового номера для табуляції
            this.labelAge.Text = "Вік"; // Текст, що відображається на мітці
            // 
            // comboBoxAge
            // 
            this.comboBoxAge.FormattingEnabled = true; // Увімкнення можливості форматування
            this.comboBoxAge.Items.AddRange(new object[] { // Додавання можливих варіантів вибору віку
                "18-25",
                "26-35",
                "36-45",
                "46-55",
                "56+"
            });
            this.comboBoxAge.Location = new System.Drawing.Point(200, 30); // Встановлення позиції комбінованого поля на формі
            this.comboBoxAge.Name = "comboBoxAge"; // Присвоєння імені комбінованому полю
            this.comboBoxAge.Size = new System.Drawing.Size(230, 21); // Встановлення розміру комбінованого поля
            this.comboBoxAge.TabIndex = 10; // Встановлення порядкового номера для табуляції
            // 
            // labelCuisine
            // 
            this.labelCuisine.AutoSize = true; // Автоматичне визначення розміру для мітки
            this.labelCuisine.Location = new System.Drawing.Point(20, 70); // Встановлення позиції мітки на формі
            this.labelCuisine.Name = "labelCuisine"; // Присвоєння імені мітці
            this.labelCuisine.Size = new System.Drawing.Size(62, 13); // Встановлення розміру мітки
            this.labelCuisine.TabIndex = 11; // Встановлення порядкового номера для табуляції
            this.labelCuisine.Text = "Улюблена кухня"; // Текст, що відображається на мітці
            // 
            // comboBoxCuisine
            // 
            this.comboBoxCuisine.FormattingEnabled = true; // Увімкнення можливості форматування
            this.comboBoxCuisine.Items.AddRange(new object[] { // Додавання можливих варіантів вибору кухні
                "Українська",
                "Італійська",
                "Французька",
                "Японська",
                "Інша"
            });
            this.comboBoxCuisine.Location = new System.Drawing.Point(200, 70); // Встановлення позиції комбінованого поля на формі
            this.comboBoxCuisine.Name = "comboBoxCuisine"; // Присвоєння імені комбінованому полю
            this.comboBoxCuisine.Size = new System.Drawing.Size(100, 21); // Встановлення розміру комбінованого поля
            this.comboBoxCuisine.TabIndex = 12; // Встановлення порядкового номера для табуляції
            // 
            // labelDishes
            //                                     
            this.labelDishes.AutoSize = true; // Автоматичне визначення розміру для мітки
            this.labelDishes.Location = new System.Drawing.Point(20, 110); // Встановлення позиції мітки на формі
            this.labelDishes.Name = "labelDishes"; // Присвоєння імені мітці
            this.labelDishes.Size = new System.Drawing.Size(85, 13); // Встановлення розміру мітки
            this.labelDishes.TabIndex = 13; // Встановлення порядкового номера для табуляції
            this.labelDishes.Text = "Які страви Ви б хотіли\nбачити в меню?"; // Текст, що відображається на мітці
            // 
            // textBoxDishes
            // 
            this.textBoxDishes.Location = new System.Drawing.Point(200, 110); // Встановлення позиції поля введення на формі
            this.textBoxDishes.Multiline = true; // Увімкнення можливості введення кількох рядків
            this.textBoxDishes.Name = "textBoxDishes"; // Присвоєння імені полю введення
            this.textBoxDishes.Size = new System.Drawing.Size(230, 40); // Встановлення розміру поля введення
            this.textBoxDishes.TabIndex = 14; // Встановлення порядкового номера для табуляції
                                              // 
                                              // groupBoxEvaluation
                                              // 
                                              // Створення групи для оцінки установи
            this.groupBoxEvaluation.Controls.Add(this.groupBoxReason); // Додаємо групу з причинами
            this.groupBoxEvaluation.Controls.Add(this.groupBoxRecommend); // Додаємо групу з рекомендаціями
            this.groupBoxEvaluation.Location = new System.Drawing.Point(20, 400); // Встановлюємо позицію групи
            this.groupBoxEvaluation.Name = "groupBoxEvaluation"; // Присвоюємо ім'я групі
            this.groupBoxEvaluation.Size = new System.Drawing.Size(550, 350); // Встановлюємо розміри групи
            this.groupBoxEvaluation.TabIndex = 15; // Встановлюємо порядковий номер вкладки
            this.groupBoxEvaluation.TabStop = false; // Дозволяємо вказувати, що група не є активною
            this.groupBoxEvaluation.Text = "Оцінка нашої установи"; // Текст заголовка групи

            // 
            // groupBoxReason
            // 
            // Створення групи для вибору причини відвідування
            this.groupBoxReason.Controls.Add(this.labelReason); // Додаємо мітку для заголовка
            this.groupBoxReason.Controls.Add(this.radioButtonReason1); // Додаємо перший варіант відповіді
            this.groupBoxReason.Controls.Add(this.radioButtonReason2); // Додаємо другий варіант відповіді
            this.groupBoxReason.Controls.Add(this.radioButtonReason3); // Додаємо третій варіант відповіді
            this.groupBoxReason.Controls.Add(this.radioButtonReason4); // Додаємо четвертий варіант відповіді
            this.groupBoxReason.Location = new System.Drawing.Point(10, 20); // Встановлюємо позицію групи
            this.groupBoxReason.Name = "groupBoxReason"; // Присвоюємо ім'я групі
            this.groupBoxReason.Size = new System.Drawing.Size(520, 180); // Встановлюємо розміри групи
            this.groupBoxReason.TabIndex = 0; // Встановлюємо порядковий номер вкладки
            this.groupBoxReason.TabStop = false; // Дозволяємо вказувати, що група не є активною
            this.groupBoxReason.Text = "Чому обрали нашу установу?"; // Текст заголовка групи

            // 
            // groupBoxRecommend
            // 
            // Створення групи для запитання про рекомендації
            this.groupBoxRecommend.Controls.Add(this.labelRecommend); // Додаємо мітку для заголовка
            this.groupBoxRecommend.Controls.Add(this.radioButtonYes); // Додаємо кнопку "Так"
            this.groupBoxRecommend.Controls.Add(this.radioButtonNo); // Додаємо кнопку "Ні"
            this.groupBoxRecommend.Location = new System.Drawing.Point(10, 210); // Встановлюємо позицію групи
            this.groupBoxRecommend.Name = "groupBoxRecommend"; // Присвоюємо ім'я групі
            this.groupBoxRecommend.Size = new System.Drawing.Size(520, 120); // Встановлюємо розміри групи
            this.groupBoxRecommend.TabIndex = 1; // Встановлюємо порядковий номер вкладки
            this.groupBoxRecommend.TabStop = false; // Дозволяємо вказувати, що група не є активною
            this.groupBoxRecommend.Text = "Чи будете рекомендувати нашу установу друзям та знайомим?"; // Текст заголовка групи

            // 
            // labelReason
            // 
            // Мітка для запитання про причину вибору установи
            this.labelReason.AutoSize = true; // Дозволяємо автоматичне налаштування розміру
            this.labelReason.Location = new System.Drawing.Point(20, 30); // Встановлюємо позицію мітки
            this.labelReason.Name = "labelReason"; // Присвоюємо ім'я мітці
            this.labelReason.Size = new System.Drawing.Size(150, 13); // Встановлюємо розміри мітки
            this.labelReason.TabIndex = 0; // Встановлюємо порядковий номер вкладки
            this.labelReason.Text = "Чому обрали нашу установу?"; // Текст мітки

            // 
            // radioButtonReason1
            // 
            // Кнопка для вибору першої причини
            this.radioButtonReason1.AutoSize = true; // Дозволяємо автоматичне налаштування розміру
            this.radioButtonReason1.Location = new System.Drawing.Point(20, 50); // Встановлюємо позицію кнопки
            this.radioButtonReason1.Name = "radioButtonReason1"; // Присвоюємо ім'я кнопці
            this.radioButtonReason1.Size = new System.Drawing.Size(90, 17); // Встановлюємо розміри кнопки
            this.radioButtonReason1.TabIndex = 1; // Встановлюємо порядковий номер вкладки
            this.radioButtonReason1.TabStop = true; // Вказуємо, що це активна кнопка
            this.radioButtonReason1.Text = "Недалеко від роботи/дому"; // Текст кнопки
            this.radioButtonReason1.UseVisualStyleBackColor = true; // Використовуємо стиль за замовчуванням

            // 
            // radioButtonReason2
            // 
            // Кнопка для вибору другої причини
            this.radioButtonReason2.AutoSize = true; // Дозволяємо автоматичне налаштування розміру
            this.radioButtonReason2.Location = new System.Drawing.Point(20, 80); // Встановлюємо позицію кнопки
            this.radioButtonReason2.Name = "radioButtonReason2"; // Присвоюємо ім'я кнопці
            this.radioButtonReason2.Size = new System.Drawing.Size(100, 17); // Встановлюємо розміри кнопки
            this.radioButtonReason2.TabIndex = 2; // Встановлюємо порядковий номер вкладки
            this.radioButtonReason2.TabStop = true; // Вказуємо, що це активна кнопка
            this.radioButtonReason2.Text = "Побачив рекламу"; // Текст кнопки
            this.radioButtonReason2.UseVisualStyleBackColor = true; // Використовуємо стиль за замовчуванням

            // 
            // radioButtonReason3
            // 
            // Кнопка для вибору третьої причини
            this.radioButtonReason3.AutoSize = true; // Дозволяємо автоматичне налаштування розміру
            this.radioButtonReason3.Location = new System.Drawing.Point(20, 110); // Встановлюємо позицію кнопки
            this.radioButtonReason3.Name = "radioButtonReason3"; // Присвоюємо ім'я кнопці
            this.radioButtonReason3.Size = new System.Drawing.Size(76, 17); // Встановлюємо розміри кнопки
            this.radioButtonReason3.TabIndex = 3; // Встановлюємо порядковий номер вкладки
            this.radioButtonReason3.TabStop = true; // Вказуємо, що це активна кнопка
            this.radioButtonReason3.Text = "Порадили"; // Текст кнопки
            this.radioButtonReason3.UseVisualStyleBackColor = true; // Використовуємо стиль за замовчуванням

            // 
            // radioButtonReason4
            // 
            // Кнопка для вибору четвертої причини
            this.radioButtonReason4.AutoSize = true; // Дозволяємо автоматичне налаштування розміру
            this.radioButtonReason4.Location = new System.Drawing.Point(20, 140); // Встановлюємо позицію кнопки
            this.radioButtonReason4.Name = "radioButtonReason4"; // Присвоюємо ім'я кнопці
            this.radioButtonReason4.Size = new System.Drawing.Size(70, 17); // Встановлюємо розміри кнопки
            this.radioButtonReason4.TabIndex = 4; // Встановлюємо порядковий номер вкладки
            this.radioButtonReason4.TabStop = true; // Вказуємо, що це активна кнопка
            this.radioButtonReason4.Text = "Оптимальне співвідношення ціни та якості"; // Текст кнопки
            this.radioButtonReason4.UseVisualStyleBackColor = true; // Використовуємо стиль за замовчуванням


            // labelRecommend
            // Створює мітку для запитання, чи рекомендуватимуть користувачі установу
            this.labelRecommend.AutoSize = true; // Автоматичний розмір мітки
            this.labelRecommend.Location = new System.Drawing.Point(20, 30); // Встановлює позицію мітки
            this.labelRecommend.Name = "labelRecommend"; // Призначає ім'я мітки
            this.labelRecommend.Size = new System.Drawing.Size(170, 13); // Встановлює розмір мітки
            this.labelRecommend.TabIndex = 5; // Встановлює порядковий номер мітки
            this.labelRecommend.Text = "Чи будете рекомендувати нашу установу друзям та знайомим?"; // Текст мітки

            // radioButtonYes
            // Створює радіокнопку для відповіді "Так"
            this.radioButtonYes.AutoSize = true; // Автоматичний розмір радіокнопки
            this.radioButtonYes.Location = new System.Drawing.Point(20, 50); // Встановлює позицію радіокнопки
            this.radioButtonYes.Name = "radioButtonYes"; // Призначає ім'я радіокнопці
            this.radioButtonYes.Size = new System.Drawing.Size(43, 17); // Встановлює розмір радіокнопки
            this.radioButtonYes.TabIndex = 6; // Встановлює порядковий номер радіокнопки
            this.radioButtonYes.TabStop = true; // Дозволяє вибір цієї радіокнопки
            this.radioButtonYes.Text = "Так"; // Текст радіокнопки
            this.radioButtonYes.UseVisualStyleBackColor = true; // Використовує стандартний стиль для кнопки

            // radioButtonNo
            // Створює радіокнопку для відповіді "Ні"
            this.radioButtonNo.AutoSize = true; // Автоматичний розмір радіокнопки
            this.radioButtonNo.Location = new System.Drawing.Point(20, 80); // Встановлює позицію радіокнопки
            this.radioButtonNo.Name = "radioButtonNo"; // Призначає ім'я радіокнопці
            this.radioButtonNo.Size = new System.Drawing.Size(44, 17); // Встановлює розмір радіокнопки
            this.radioButtonNo.TabIndex = 7; // Встановлює порядковий номер радіокнопки
            this.radioButtonNo.TabStop = true; // Дозволяє вибір цієї радіокнопки
            this.radioButtonNo.Text = "Ні"; // Текст радіокнопки
            this.radioButtonNo.UseVisualStyleBackColor = true; // Використовує стандартний стиль для кнопки

            // buttonSubmit
            // Створює кнопку "Відправити" для підтвердження заповненої анкети
            this.buttonSubmit.Location = new System.Drawing.Point(20, 770); // Встановлює позицію кнопки
            this.buttonSubmit.Name = "buttonSubmit"; // Призначає ім'я кнопці
            this.buttonSubmit.Size = new System.Drawing.Size(100, 40); // Встановлює розмір кнопки
            this.buttonSubmit.TabIndex = 16; // Встановлює порядковий номер кнопки
            this.buttonSubmit.Text = "Відправити"; // Текст кнопки
            this.buttonSubmit.UseVisualStyleBackColor = true; // Використовує стандартний стиль для кнопки
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click); // Додає обробник події для натискання кнопки

            // buttonClear
            // Створює кнопку "Очистити" для скидання заповненої анкети
            this.buttonClear.Location = new System.Drawing.Point(140, 770); // Встановлює позицію кнопки
            this.buttonClear.Name = "buttonClear"; // Призначає ім'я кнопці
            this.buttonClear.Size = new System.Drawing.Size(100, 40); // Встановлює розмір кнопки
            this.buttonClear.TabIndex = 17; // Встановлює порядковий номер кнопки
            this.buttonClear.Text = "Очистити"; // Текст кнопки
            this.buttonClear.UseVisualStyleBackColor = true; // Використовує стандартний стиль для кнопки
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click); // Додає обробник події для натискання кнопки

            // Form1
            // Налаштовує основну форму анкети
            this.ClientSize = new System.Drawing.Size(800, 850); // Встановлює розмір форми
            this.Controls.Add(this.buttonClear); // Додає кнопку очищення до форми
            this.Controls.Add(this.buttonSubmit); // Додає кнопку відправлення до форми
            this.Controls.Add(this.groupBoxEvaluation); // Додає групу оцінки до форми
            this.Controls.Add(this.groupBoxPersonalInfo); // Додає групу персональної інформації до форми
            this.Controls.Add(this.groupBoxContactInfo); // Додає групу контактної інформації до форми
            this.Controls.Add(this.labelTitle); // Додає заголовок до форми
            this.Name = "Form1"; // Призначає ім'я формі
            this.Text = "Task 6"; // Встановлює заголовок форми
            this.groupBoxContactInfo.ResumeLayout(false); // Відновлює макет для групи контактної інформації
            this.groupBoxContactInfo.PerformLayout(); // Оновлює макет для групи контактної інформації
            this.groupBoxPersonalInfo.ResumeLayout(false); // Відновлює макет для групи персональної інформації
            this.groupBoxPersonalInfo.PerformLayout(); // Оновлює макет для групи персональної інформації
            this.groupBoxEvaluation.ResumeLayout(false); // Відновлює макет для групи оцінки
            this.groupBoxEvaluation.PerformLayout(); // Оновлює макет для групи оцінки
            this.ResumeLayout(false); // Завершує налаштування макету
            this.PerformLayout(); // Оновлює макет
        }

        private void buttonSubmit_Click(object sender, System.EventArgs e)
        {
            // Перевірка на заповненість обов'язкових полів
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || // Перевірка на заповненість поля імені
                string.IsNullOrWhiteSpace(textBoxEmail.Text) || // Перевірка на заповненість поля електронної пошти
                string.IsNullOrWhiteSpace(textBoxPhone.Text) || // Перевірка на заповненість поля телефону
                comboBoxAge.SelectedIndex == -1 || // Перевірка на вибір віку
                comboBoxCuisine.SelectedIndex == -1 || // Перевірка на вибір улюбленої кухні
                (!radioButtonReason1.Checked && !radioButtonReason2.Checked && !radioButtonReason3.Checked && !radioButtonReason4.Checked) || // Перевірка на вибір причини
                (!radioButtonYes.Checked && !radioButtonNo.Checked)) // Перевірка на вибір рекомендації
            {
                // Виведення повідомлення про помилку, якщо є незаповнені поля
                MessageBox.Show("Будь ласка, заповніть усі обов'язкові поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Вихід з методу, якщо поля не заповнені
            }

            // Збір даних з форми
            string name = textBoxName.Text; // Зберігає ім'я
            string email = textBoxEmail.Text; // Зберігає електронну пошту
            string phone = textBoxPhone.Text; // Зберігає телефон
            DateTime visitDate = dateTimePickerVisit.Value; // Зберігає дату відвідування
            string age = comboBoxAge.SelectedItem.ToString(); // Зберігає вибраний вік
            string cuisine = comboBoxCuisine.SelectedItem.ToString(); // Зберігає вибрану кухню
            string dishes = textBoxDishes.Text; // Зберігає страви в меню

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
            textBoxName.Clear(); // Очищення поля імені
            textBoxEmail.Clear(); // Очищення поля електронної пошти
            textBoxPhone.Clear(); // Очищення поля телефону
            dateTimePickerVisit.Value = DateTime.Today; // Скидання дати відвідування на сьогодні
            comboBoxAge.SelectedIndex = -1; // Скидання вибору віку
            comboBoxCuisine.SelectedIndex = -1; // Скидання вибору улюбленої кухні
            textBoxDishes.Clear(); // Очищення поля страв в меню
            radioButtonReason1.Checked = false; // Скидання вибору першої радіокнопки
            radioButtonReason2.Checked = false; // Скидання вибору другої радіокнопки
            radioButtonReason3.Checked = false; // Скидання вибору третьої радіокнопки
            radioButtonReason4.Checked = false; // Скидання вибору четвертої радіокнопки
            radioButtonYes.Checked = false; // Скидання вибору радіокнопки "Так"
            radioButtonNo.Checked = false; // Скидання вибору радіокнопки "Ні"
        }
    }
}