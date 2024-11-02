namespace Lab_10
{
    partial class Task_8
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox1; // Поле
        private System.Windows.Forms.StatusStrip statusStrip1; // Статус
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1; // Дата/час
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2; // Вирівн.
        private System.Windows.Forms.NotifyIcon notifyIcon1; // Іконка
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1; // Меню
        private System.Windows.Forms.ToolStripMenuItem showMenuItem; // Показати
        private System.Windows.Forms.ToolStripMenuItem hideMenuItem; // Приховати
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem; // Вихід

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task_8));
            textBox1 = new TextBox();
            statusStrip1 = new StatusStrip(); 
            toolStripStatusLabel1 = new ToolStripStatusLabel(); 
            toolStripStatusLabel2 = new ToolStripStatusLabel(); 
            notifyIcon1 = new NotifyIcon(components); 
            contextMenuStrip1 = new ContextMenuStrip(components); 
            showMenuItem = new ToolStripMenuItem(); 
            hideMenuItem = new ToolStripMenuItem(); 
            exitMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();


            // textBox1
            textBox1.Location = new Point(16, 18);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;


            // statusStrip1
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 377);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 19, 0);
            statusStrip1.Size = new Size(379, 26);
            statusStrip1.TabIndex = 1;


            // toolStripStatusLabel1
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(138, 20);
            toolStripStatusLabel1.Text = "Поточна дата і час";


            // toolStripStatusLabel2
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(221, 20);
            toolStripStatusLabel2.Spring = true;
            toolStripStatusLabel2.TextAlign = ContentAlignment.MiddleLeft;


            // notifyIcon1
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "StatusStrip Example";
            notifyIcon1.Visible = true;
            notifyIcon1.DoubleClick += NotifyIcon1_DoubleClick;


            // contextMenuStrip1
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showMenuItem, hideMenuItem, exitMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(155, 76);


            // showMenuItem
            showMenuItem.Name = "showMenuItem";
            showMenuItem.Size = new Size(154, 24);
            showMenuItem.Text = "Показати";
            showMenuItem.Click += ShowMenuItem_Click;


            // hideMenuItem
            hideMenuItem.Name = "hideMenuItem";
            hideMenuItem.Size = new Size(154, 24);
            hideMenuItem.Text = "Приховати";
            hideMenuItem.Click += HideMenuItem_Click;


            // exitMenuItem
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(154, 24);
            exitMenuItem.Text = "Вихід";
            exitMenuItem.Click += ExitMenuItem_Click;


            // Form8 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 403);
            Controls.Add(textBox1);
            Controls.Add(statusStrip1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form8";
            Text = "Task 8";
            FormClosing += Form8_FormClosing;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
