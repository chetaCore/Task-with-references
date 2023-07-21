namespace TestTask
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RKKPath = new TextBox();
            ObrPath = new TextBox();
            StartButton = new Button();
            panel2 = new Panel();
            SelectPathObrButton = new Button();
            SelectRKKPathButton = new Button();
            RadioTotal = new RadioButton();
            RadioObr = new RadioButton();
            RadioRkk = new RadioButton();
            RadioName = new RadioButton();
            label7 = new Label();
            label6 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // RKKPath
            // 
            RKKPath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RKKPath.Location = new Point(34, 42);
            RKKPath.Name = "RKKPath";
            RKKPath.Size = new Size(184, 23);
            RKKPath.TabIndex = 0;
            // 
            // ObrPath
            // 
            ObrPath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ObrPath.Location = new Point(34, 112);
            ObrPath.Name = "ObrPath";
            ObrPath.Size = new Size(184, 23);
            ObrPath.TabIndex = 1;
            // 
            // StartButton
            // 
            StartButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StartButton.Location = new Point(34, 150);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(80, 23);
            StartButton.TabIndex = 2;
            StartButton.Text = "Показать";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(SelectPathObrButton);
            panel2.Controls.Add(SelectRKKPathButton);
            panel2.Controls.Add(RadioTotal);
            panel2.Controls.Add(RadioObr);
            panel2.Controls.Add(RadioRkk);
            panel2.Controls.Add(RadioName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(ObrPath);
            panel2.Controls.Add(StartButton);
            panel2.Controls.Add(RKKPath);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(593, 198);
            panel2.TabIndex = 4;
            // 
            // SelectPathObrButton
            // 
            SelectPathObrButton.ImageAlign = ContentAlignment.MiddleRight;
            SelectPathObrButton.Location = new Point(6, 111);
            SelectPathObrButton.Name = "SelectPathObrButton";
            SelectPathObrButton.Size = new Size(22, 23);
            SelectPathObrButton.TabIndex = 10;
            SelectPathObrButton.Text = "...";
            SelectPathObrButton.UseVisualStyleBackColor = true;
            SelectPathObrButton.Click += SelectPathObrButton_Click;
            // 
            // SelectRKKPathButton
            // 
            SelectRKKPathButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SelectRKKPathButton.ImageAlign = ContentAlignment.MiddleRight;
            SelectRKKPathButton.Location = new Point(6, 42);
            SelectRKKPathButton.Name = "SelectRKKPathButton";
            SelectRKKPathButton.Size = new Size(22, 23);
            SelectRKKPathButton.TabIndex = 9;
            SelectRKKPathButton.Text = "...";
            SelectRKKPathButton.UseVisualStyleBackColor = true;
            SelectRKKPathButton.Click += SelectRKKPathButton_Click;
            // 
            // RadioTotal
            // 
            RadioTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RadioTotal.AutoSize = true;
            RadioTotal.Location = new Point(224, 112);
            RadioTotal.Name = "RadioTotal";
            RadioTotal.Size = new Size(302, 19);
            RadioTotal.TabIndex = 8;
            RadioTotal.Text = "Сортировка по общему количеству документов";
            RadioTotal.UseVisualStyleBackColor = true;
            // 
            // RadioObr
            // 
            RadioObr.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RadioObr.AutoSize = true;
            RadioObr.Location = new Point(224, 90);
            RadioObr.Name = "RadioObr";
            RadioObr.Size = new Size(251, 19);
            RadioObr.TabIndex = 7;
            RadioObr.Text = "Сортировка по количеству обращений";
            RadioObr.UseVisualStyleBackColor = true;
            // 
            // RadioRkk
            // 
            RadioRkk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RadioRkk.AutoSize = true;
            RadioRkk.Location = new Point(224, 67);
            RadioRkk.Name = "RadioRkk";
            RadioRkk.Size = new Size(206, 19);
            RadioRkk.TabIndex = 6;
            RadioRkk.Text = "Сортировка по количеству РКК";
            RadioRkk.UseVisualStyleBackColor = true;
            // 
            // RadioName
            // 
            RadioName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RadioName.AutoSize = true;
            RadioName.Checked = true;
            RadioName.Location = new Point(224, 42);
            RadioName.Name = "RadioName";
            RadioName.Size = new Size(339, 19);
            RadioName.TabIndex = 5;
            RadioName.TabStop = true;
            RadioName.Text = "Сортировка по фамилии ответственного исполнителя";
            RadioName.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(45, 79);
            label7.Name = "label7";
            label7.Size = new Size(158, 30);
            label7.TabIndex = 4;
            label7.Text = "Введите путь к документу\r\nс обращениями";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(34, 17);
            label6.Name = "label6";
            label6.Size = new Size(184, 15);
            label6.TabIndex = 3;
            label6.Text = "Введите путь к РКК документу";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 198);
            Controls.Add(panel2);
            Name = "StartForm";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RKKPath;
        private TextBox ObrPath;
        private Button StartButton;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private RadioButton RadioObr;
        private RadioButton RadioRkk;
        private RadioButton RadioName;
        private RadioButton RadioTotal;
        private Button SelectPathObrButton;
        private Button SelectRKKPathButton;
    }
}