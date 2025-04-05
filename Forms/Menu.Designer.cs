namespace WindowManager
{
    partial class Menu
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
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            button1 = new Button();
            label1 = new Label();
            button7 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.Cursor = Cursors.Hand;
            button6.Location = new Point(306, 280);
            button6.Name = "button6";
            button6.Size = new Size(182, 23);
            button6.TabIndex = 14;
            button6.Text = "Переменовать";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Cursor = Cursors.Hand;
            button5.Location = new Point(306, 241);
            button5.Name = "button5";
            button5.Size = new Size(182, 23);
            button5.TabIndex = 13;
            button5.Text = "Закрывать";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(306, 202);
            button3.Name = "button3";
            button3.Size = new Size(182, 23);
            button3.TabIndex = 11;
            button3.Text = "Развернуть";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(306, 124);
            button1.Name = "button1";
            button1.Size = new Size(182, 23);
            button1.TabIndex = 10;
            button1.Text = "Перемещать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(44, 86);
            label1.Name = "label1";
            label1.Size = new Size(712, 25);
            label1.TabIndex = 9;
            label1.Text = "Выберите действие окна:\r\n\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.Cursor = Cursors.Hand;
            button7.Location = new Point(306, 319);
            button7.Name = "button7";
            button7.Size = new Size(182, 23);
            button7.TabIndex = 15;
            button7.Text = "Вернуться назад";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(306, 163);
            button4.Name = "button4";
            button4.Size = new Size(182, 23);
            button4.TabIndex = 16;
            button4.Text = "Свернуть";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button6;
        private Button button5;
        private Button button3;
        private Button button1;
        private Label label1;
        private Button button7;
        private Button button4;
    }
}