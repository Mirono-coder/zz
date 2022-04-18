
namespace zz
{
    partial class глав
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(глав));
            this.м = new System.Windows.Forms.Button();
            this.к = new System.Windows.Forms.Button();
            this.в = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // м
            // 
            this.м.Location = new System.Drawing.Point(38, 13);
            this.м.Name = "м";
            this.м.Size = new System.Drawing.Size(176, 49);
            this.м.TabIndex = 0;
            this.м.Text = "Магазин";
            this.м.UseVisualStyleBackColor = true;
            this.м.Click += new System.EventHandler(this.м_Click);
            // 
            // к
            // 
            this.к.Location = new System.Drawing.Point(256, 13);
            this.к.Name = "к";
            this.к.Size = new System.Drawing.Size(176, 48);
            this.к.TabIndex = 1;
            this.к.Text = "Корзина";
            this.к.UseVisualStyleBackColor = true;
            this.к.Click += new System.EventHandler(this.к_Click);
            // 
            // в
            // 
            this.в.Location = new System.Drawing.Point(38, 69);
            this.в.Name = "в";
            this.в.Size = new System.Drawing.Size(394, 23);
            this.в.TabIndex = 2;
            this.в.Text = "выход";
            this.в.UseVisualStyleBackColor = true;
            this.в.Click += new System.EventHandler(this.в_Click);
            // 
            // глав
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 119);
            this.Controls.Add(this.в);
            this.Controls.Add(this.к);
            this.Controls.Add(this.м);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "глав";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button м;
        private System.Windows.Forms.Button к;
        private System.Windows.Forms.Button в;
    }
}