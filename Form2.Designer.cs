namespace WindowManager
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(308, 136);
            button2.Name = "button2";
            button2.Size = new Size(182, 23);
            button2.TabIndex = 1;
            button2.Text = "Искать\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(45, 71);
            label1.Name = "label1";
            label1.Size = new Size(712, 25);
            label1.TabIndex = 2;
            label1.Text = "Выберите действие окна:\r\n\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(308, 175);
            button1.Name = "button1";
            button1.Size = new Size(182, 23);
            button1.TabIndex = 3;
            button1.Text = "Перемещать";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(308, 214);
            button3.Name = "button3";
            button3.Size = new Size(182, 23);
            button3.TabIndex = 4;
            button3.Text = "Скрывать";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(308, 253);
            button4.Name = "button4";
            button4.Size = new Size(182, 23);
            button4.TabIndex = 5;
            button4.Text = "Сворачивать в панель задач";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Cursor = Cursors.Hand;
            button5.Location = new Point(308, 292);
            button5.Name = "button5";
            button5.Size = new Size(182, 23);
            button5.TabIndex = 6;
            button5.Text = "Закрывать";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.Cursor = Cursors.Hand;
            button6.Location = new Point(308, 331);
            button6.Name = "button6";
            button6.Size = new Size(182, 23);
            button6.TabIndex = 7;
            button6.Text = "Переменовать окна верхнего уровня";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button2);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Label label1;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}