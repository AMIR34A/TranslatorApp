namespace TranslatorApp
{
    partial class TranslatorApp
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            ToComboBox = new ComboBox();
            label1 = new Label();
            FromComboBox = new ComboBox();
            ContentTextBox = new TextBox();
            groupBox2 = new GroupBox();
            TranslateButton = new Button();
            TranslateGroupBox = new GroupBox();
            ResultTextBox = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            TranslateGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ToComboBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(FromComboBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(497, 71);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Languages";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 29);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 2;
            label2.Text = "To";
            // 
            // ToComboBox
            // 
            ToComboBox.FormattingEnabled = true;
            ToComboBox.Location = new Point(297, 26);
            ToComboBox.Name = "ToComboBox";
            ToComboBox.Size = new Size(189, 28);
            ToComboBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 1;
            label1.Text = "From";
            // 
            // FromComboBox
            // 
            FromComboBox.FormattingEnabled = true;
            FromComboBox.Location = new Point(55, 26);
            FromComboBox.Name = "FromComboBox";
            FromComboBox.Size = new Size(189, 28);
            FromComboBox.TabIndex = 1;
            // 
            // ContentTextBox
            // 
            ContentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ContentTextBox.Location = new Point(6, 41);
            ContentTextBox.Multiline = true;
            ContentTextBox.Name = "ContentTextBox";
            ContentTextBox.Size = new Size(480, 159);
            ContentTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(TranslateButton);
            groupBox2.Controls.Add(ContentTextBox);
            groupBox2.Location = new Point(12, 102);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(497, 246);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Translate";
            // 
            // TranslateButton
            // 
            TranslateButton.Location = new Point(6, 206);
            TranslateButton.Name = "TranslateButton";
            TranslateButton.Size = new Size(94, 29);
            TranslateButton.TabIndex = 4;
            TranslateButton.Text = "Translate";
            TranslateButton.UseVisualStyleBackColor = true;
            TranslateButton.Click += TranslateButton_Click;
            // 
            // TranslateGroupBox
            // 
            TranslateGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TranslateGroupBox.Controls.Add(ResultTextBox);
            TranslateGroupBox.Location = new Point(12, 368);
            TranslateGroupBox.Name = "TranslateGroupBox";
            TranslateGroupBox.Size = new Size(497, 252);
            TranslateGroupBox.TabIndex = 3;
            TranslateGroupBox.TabStop = false;
            TranslateGroupBox.Text = "Result";
            // 
            // ResultTextBox
            // 
            ResultTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ResultTextBox.Location = new Point(6, 32);
            ResultTextBox.Multiline = true;
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.ReadOnly = true;
            ResultTextBox.ScrollBars = ScrollBars.Horizontal;
            ResultTextBox.Size = new Size(480, 214);
            ResultTextBox.TabIndex = 1;
            // 
            // TranslatorApp
            // 
            AcceptButton = TranslateButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 636);
            Controls.Add(TranslateGroupBox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TranslatorApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Translator App";
            Load += TranslatorApp_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            TranslateGroupBox.ResumeLayout(false);
            TranslateGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private ComboBox ToComboBox;
        private Label label1;
        private ComboBox FromComboBox;
        private TextBox ContentTextBox;
        private GroupBox groupBox2;
        private Button TranslateButton;
        private GroupBox TranslateGroupBox;
        private TextBox ResultTextBox;
    }
}