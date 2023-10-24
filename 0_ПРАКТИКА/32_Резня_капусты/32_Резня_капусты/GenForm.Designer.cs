namespace _32_Резня_капусты
{
    partial class GenForm
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
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.genBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(720, 580);
            this.panel.TabIndex = 1;
            // 
            // textbox
            // 
            this.textbox.BackColor = System.Drawing.Color.White;
            this.textbox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textbox.Location = new System.Drawing.Point(742, 40);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(258, 33);
            this.textbox.TabIndex = 12;
            this.textbox.Text = "1";
            this.textbox.TextChanged += new System.EventHandler(this.speedValue_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(738, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Кол-во кротов";
            // 
            // genBtn
            // 
            this.genBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.genBtn.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.genBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genBtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.genBtn.Location = new System.Drawing.Point(742, 89);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(258, 59);
            this.genBtn.TabIndex = 14;
            this.genBtn.Text = "Сгенерировать";
            this.genBtn.UseVisualStyleBackColor = false;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.closeBtn.Location = new System.Drawing.Point(742, 220);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(258, 59);
            this.closeBtn.TabIndex = 15;
            this.closeBtn.Text = "Отмена";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.updateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.updateBtn.Location = new System.Drawing.Point(742, 155);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(258, 59);
            this.updateBtn.TabIndex = 16;
            this.updateBtn.Text = "Применить";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // GenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1008, 613);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.genBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.panel);
            this.Name = "GenForm";
            this.Text = "Заполнение";
            this.Shown += new System.EventHandler(this.GenForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button updateBtn;
    }
}