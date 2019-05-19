namespace WindowsFormsApp3
{
    partial class DeleteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DeleteTermButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Term";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 8;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(203, 73);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(106, 22);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DeleteTermButton
            // 
            this.DeleteTermButton.Location = new System.Drawing.Point(45, 72);
            this.DeleteTermButton.Name = "DeleteTermButton";
            this.DeleteTermButton.Size = new System.Drawing.Size(101, 23);
            this.DeleteTermButton.TabIndex = 6;
            this.DeleteTermButton.Text = "Удалить";
            this.DeleteTermButton.UseVisualStyleBackColor = true;
            this.DeleteTermButton.Click += new System.EventHandler(this.DeleteTermButton_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 116);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DeleteTermButton);
            this.Name = "DeleteForm";
            this.Text = "Удаление термина";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button DeleteTermButton;
    }
}