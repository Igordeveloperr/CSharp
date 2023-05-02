namespace POST_MACHINE
{
    partial class MainWindow
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
            codeField = new RichTextBox();
            CompileBtn = new Button();
            tape = new FlowLayoutPanel();
            clearTapeBtn = new Button();
            cursorIndex = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // codeField
            // 
            codeField.Location = new Point(12, 280);
            codeField.Name = "codeField";
            codeField.Size = new Size(797, 276);
            codeField.TabIndex = 0;
            codeField.Text = "";
            // 
            // CompileBtn
            // 
            CompileBtn.Location = new Point(12, 12);
            CompileBtn.Name = "CompileBtn";
            CompileBtn.Size = new Size(152, 38);
            CompileBtn.TabIndex = 1;
            CompileBtn.Text = "Запуск";
            CompileBtn.UseVisualStyleBackColor = true;
            CompileBtn.Click += CompileBtn_Click;
            // 
            // tape
            // 
            tape.AutoScroll = true;
            tape.Location = new Point(12, 70);
            tape.Name = "tape";
            tape.Size = new Size(797, 159);
            tape.TabIndex = 2;
            tape.WrapContents = false;
            // 
            // clearTapeBtn
            // 
            clearTapeBtn.Location = new Point(170, 12);
            clearTapeBtn.Name = "clearTapeBtn";
            clearTapeBtn.Size = new Size(172, 38);
            clearTapeBtn.TabIndex = 3;
            clearTapeBtn.Text = "Очистить ленту";
            clearTapeBtn.UseVisualStyleBackColor = true;
            clearTapeBtn.Click += СlearTapeBtn_Click;
            // 
            // cursorIndex
            // 
            cursorIndex.Location = new Point(241, 246);
            cursorIndex.Name = "cursorIndex";
            cursorIndex.Size = new Size(150, 25);
            cursorIndex.TabIndex = 4;
            cursorIndex.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 249);
            label1.Name = "label1";
            label1.Size = new Size(223, 17);
            label1.TabIndex = 5;
            label1.Text = "Положение курсора(индекс ячейки)";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 568);
            Controls.Add(label1);
            Controls.Add(cursorIndex);
            Controls.Add(clearTapeBtn);
            Controls.Add(tape);
            Controls.Add(CompileBtn);
            Controls.Add(codeField);
            Name = "MainWindow";
            Text = "Form1";
            Load += OnMainWindowLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox codeField;
        private Button CompileBtn;
        private FlowLayoutPanel tape;
        private Button clearTapeBtn;
        private TextBox cursorIndex;
        private Label label1;
    }
}