namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editingButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.BDList = new System.Windows.Forms.ListBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BDOutputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вывод данных:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(391, 42);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(124, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавление";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(391, 82);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(124, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Удаление";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editingButton
            // 
            this.editingButton.Location = new System.Drawing.Point(391, 122);
            this.editingButton.Name = "editingButton";
            this.editingButton.Size = new System.Drawing.Size(124, 23);
            this.editingButton.TabIndex = 3;
            this.editingButton.Text = "Редактирование";
            this.editingButton.UseVisualStyleBackColor = true;
            this.editingButton.Click += new System.EventHandler(this.editingButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(391, 165);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(124, 23);
            this.sortButton.TabIndex = 4;
            this.sortButton.Text = "Сортировка";
            this.sortButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(391, 205);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(124, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // BDList
            // 
            this.BDList.FormattingEnabled = true;
            this.BDList.Items.AddRange(new object[] {
            "UDP",
            "TCP"});
            this.BDList.Location = new System.Drawing.Point(34, 42);
            this.BDList.Name = "BDList";
            this.BDList.Size = new System.Drawing.Size(306, 264);
            this.BDList.TabIndex = 6;
            this.BDList.SelectedIndexChanged += new System.EventHandler(this.BDList_SelectedIndexChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(391, 283);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(124, 23);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BDOutputButton
            // 
            this.BDOutputButton.Location = new System.Drawing.Point(391, 244);
            this.BDOutputButton.Name = "BDOutputButton";
            this.BDOutputButton.Size = new System.Drawing.Size(124, 23);
            this.BDOutputButton.TabIndex = 8;
            this.BDOutputButton.Text = "Вывод БД";
            this.BDOutputButton.UseVisualStyleBackColor = true;
            this.BDOutputButton.Click += new System.EventHandler(this.BDOutputButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 342);
            this.Controls.Add(this.BDOutputButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.BDList);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.editingButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Словарь терминов по модели OSI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editingButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox BDList;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button BDOutputButton;
    }
}

