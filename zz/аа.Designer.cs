
namespace zz
{
    partial class аа
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(аа));
            this.ии = new System.Windows.Forms.Label();
            this.шг = new System.Windows.Forms.Label();
            this.ро = new System.Windows.Forms.Label();
            this.тт = new System.Windows.Forms.TextBox();
            this.т = new System.Windows.Forms.TextBox();
            this.е = new System.Windows.Forms.Button();
            this.к = new System.Windows.Forms.Button();
            this.п = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ии
            // 
            this.ии.AutoSize = true;
            this.ии.Location = new System.Drawing.Point(128, 19);
            this.ии.Name = "ии";
            this.ии.Size = new System.Drawing.Size(73, 13);
            this.ии.TabIndex = 0;
            this.ии.Text = "Авторизация";
            // 
            // шг
            // 
            this.шг.AutoSize = true;
            this.шг.Location = new System.Drawing.Point(12, 72);
            this.шг.Name = "шг";
            this.шг.Size = new System.Drawing.Size(38, 13);
            this.шг.TabIndex = 1;
            this.шг.Text = "Логин";
            // 
            // ро
            // 
            this.ро.AutoSize = true;
            this.ро.Location = new System.Drawing.Point(12, 107);
            this.ро.Name = "ро";
            this.ро.Size = new System.Drawing.Size(45, 13);
            this.ро.TabIndex = 2;
            this.ро.Text = "Пароль";
            // 
            // тт
            // 
            this.тт.Location = new System.Drawing.Point(98, 69);
            this.тт.Name = "тт";
            this.тт.Size = new System.Drawing.Size(176, 20);
            this.тт.TabIndex = 3;
            // 
            // т
            // 
            this.т.Location = new System.Drawing.Point(98, 104);
            this.т.Name = "т";
            this.т.Size = new System.Drawing.Size(176, 20);
            this.т.TabIndex = 4;
            // 
            // е
            // 
            this.е.Location = new System.Drawing.Point(98, 153);
            this.е.Name = "е";
            this.е.Size = new System.Drawing.Size(75, 23);
            this.е.TabIndex = 5;
            this.е.Text = "Вход";
            this.е.UseVisualStyleBackColor = true;
            this.е.Click += new System.EventHandler(this.е_Click);
            // 
            // к
            // 
            this.к.Location = new System.Drawing.Point(199, 153);
            this.к.Name = "к";
            this.к.Size = new System.Drawing.Size(75, 23);
            this.к.TabIndex = 6;
            this.к.Text = "Регистрация";
            this.к.UseVisualStyleBackColor = true;
            // 
            // п
            // 
            this.п.AutoSize = true;
            this.п.Location = new System.Drawing.Point(139, 179);
            this.п.Name = "п";
            this.п.Size = new System.Drawing.Size(97, 13);
            this.п.TabIndex = 7;
            this.п.TabStop = true;
            this.п.Text = "Не помню пароль";
            // 
            // аа
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 229);
            this.Controls.Add(this.п);
            this.Controls.Add(this.к);
            this.Controls.Add(this.е);
            this.Controls.Add(this.т);
            this.Controls.Add(this.тт);
            this.Controls.Add(this.ро);
            this.Controls.Add(this.шг);
            this.Controls.Add(this.ии);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "аа";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ии;
        private System.Windows.Forms.Label шг;
        private System.Windows.Forms.Label ро;
        private System.Windows.Forms.TextBox тт;
        private System.Windows.Forms.TextBox т;
        private System.Windows.Forms.Button е;
        private System.Windows.Forms.Button к;
        private System.Windows.Forms.LinkLabel п;
    }
}

