using System.Windows.Forms;

namespace TestTask
{
    partial class OutPutForm
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
            label2 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            OutPutTable = new TableLayoutPanel();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            LabelData = new Label();
            panel2 = new Panel();
            LabelSortType = new Label();
            LabelObrSum = new Label();
            LabelRKKSum = new Label();
            LabelTotalSum = new Label();
            label8 = new Label();
            SaveButton = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            OutPutTable.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(45, 1);
            label2.Name = "label2";
            label2.Size = new Size(32, 120);
            label2.TabIndex = 1;
            label2.Text = "Ответственный исполнитель";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 679);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(OutPutTable);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 192);
            panel4.Name = "panel4";
            panel4.Size = new Size(637, 387);
            panel4.TabIndex = 2;
            // 
            // OutPutTable
            // 
            OutPutTable.AutoScroll = true;
            OutPutTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            OutPutTable.ColumnCount = 5;
            OutPutTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            OutPutTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            OutPutTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            OutPutTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            OutPutTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            OutPutTable.Controls.Add(label1, 0, 0);
            OutPutTable.Controls.Add(label3, 1, 0);
            OutPutTable.Controls.Add(label4, 2, 0);
            OutPutTable.Controls.Add(label5, 4, 0);
            OutPutTable.Controls.Add(label6, 3, 0);
            OutPutTable.Dock = DockStyle.Fill;
            OutPutTable.Location = new Point(0, 0);
            OutPutTable.Name = "OutPutTable";
            OutPutTable.RowCount = 1;
            OutPutTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            OutPutTable.Size = new Size(637, 387);
            OutPutTable.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(4, 1);
            label1.Name = "label1";
            label1.Size = new Size(34, 385);
            label1.TabIndex = 0;
            label1.Text = "No\r\nп.п.\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(45, 1);
            label3.Name = "label3";
            label3.Size = new Size(141, 385);
            label3.TabIndex = 1;
            label3.Text = "Ответственный\r\nисполнитель";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(193, 1);
            label4.Name = "label4";
            label4.Size = new Size(141, 385);
            label4.TabIndex = 2;
            label4.Text = "Количество\r\nнеисполненных\r\nвходящих документов";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(489, 1);
            label5.Name = "label5";
            label5.Size = new Size(144, 385);
            label5.TabIndex = 3;
            label5.Text = "Общее количество\r\nдокументов и\r\nобращений";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(341, 1);
            label6.Name = "label6";
            label6.Size = new Size(141, 385);
            label6.TabIndex = 4;
            label6.Text = "Количество\r\nнеисполненных\r\nписьменных\r\nобращений граждан";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(SaveButton);
            panel3.Controls.Add(LabelData);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 579);
            panel3.Name = "panel3";
            panel3.Size = new Size(637, 100);
            panel3.TabIndex = 1;
            // 
            // LabelData
            // 
            LabelData.AutoSize = true;
            LabelData.Location = new Point(3, 3);
            LabelData.Name = "LabelData";
            LabelData.Size = new Size(163, 15);
            LabelData.TabIndex = 0;
            LabelData.Text = "Дата составления спарвки:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(LabelSortType);
            panel2.Controls.Add(LabelObrSum);
            panel2.Controls.Add(LabelRKKSum);
            panel2.Controls.Add(LabelTotalSum);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(637, 192);
            panel2.TabIndex = 0;
            // 
            // LabelSortType
            // 
            LabelSortType.AutoSize = true;
            LabelSortType.Location = new Point(3, 174);
            LabelSortType.Name = "LabelSortType";
            LabelSortType.Size = new Size(290, 15);
            LabelSortType.TabIndex = 4;
            LabelSortType.Text = "Сортировка: по общему количеству документов.";
            // 
            // LabelObrSum
            // 
            LabelObrSum.AutoSize = true;
            LabelObrSum.Location = new Point(3, 68);
            LabelObrSum.Name = "LabelObrSum";
            LabelObrSum.Size = new Size(396, 15);
            LabelObrSum.TabIndex = 3;
            LabelObrSum.Text = "- количество неисполненных письменных обращений граждан: 0.";
            // 
            // LabelRKKSum
            // 
            LabelRKKSum.AutoSize = true;
            LabelRKKSum.Location = new Point(3, 53);
            LabelRKKSum.Name = "LabelRKKSum";
            LabelRKKSum.Size = new Size(332, 15);
            LabelRKKSum.TabIndex = 2;
            LabelRKKSum.Text = "- количество неисполненных входящих документов: 0;";
            // 
            // LabelTotalSum
            // 
            LabelTotalSum.AutoSize = true;
            LabelTotalSum.Location = new Point(3, 38);
            LabelTotalSum.Name = "LabelTotalSum";
            LabelTotalSum.Size = new Size(259, 15);
            LabelTotalSum.TabIndex = 1;
            LabelTotalSum.Text = "Не исполнено в срок 0 документов, из них:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(133, 9);
            label8.Name = "label8";
            label8.Size = new Size(371, 15);
            label8.TabIndex = 0;
            label8.Text = "Спарвка о неисполненных документах и обращениях граждан";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = SystemColors.AppWorkspace;
            SaveButton.Location = new Point(12, 41);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(79, 23);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // OutPutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(637, 679);
            Controls.Add(panel1);
            Name = "OutPutForm";
            Text = "OutPutForm";
            Load += OutPutForm_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            OutPutTable.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Panel panel1;
        private Panel panel4;
        private TableLayoutPanel OutPutTable;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel3;
        private Panel panel2;
        private Label LabelData;
        private Label LabelTotalSum;
        private Label label8;
        private Label LabelSortType;
        private Label LabelObrSum;
        private Label LabelRKKSum;
        private Button SaveButton;
    }
}