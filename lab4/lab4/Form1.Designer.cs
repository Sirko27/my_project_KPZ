namespace lab4
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
            this.rbBurger2 = new System.Windows.Forms.RadioButton();
            this.rbBurger1 = new System.Windows.Forms.RadioButton();
            this.Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbBurger2
            // 
            this.rbBurger2.AutoSize = true;
            this.rbBurger2.Location = new System.Drawing.Point(299, 18);
            this.rbBurger2.Name = "rbBurger2";
            this.rbBurger2.Size = new System.Drawing.Size(62, 17);
            this.rbBurger2.TabIndex = 8;
            this.rbBurger2.TabStop = true;
            this.rbBurger2.Text = "Burger2";
            this.rbBurger2.UseVisualStyleBackColor = true;
            this.rbBurger2.CheckedChanged += new System.EventHandler(this.rbBurger2_CheckedChanged);
            // 
            // rbBurger1
            // 
            this.rbBurger1.AutoSize = true;
            this.rbBurger1.Location = new System.Drawing.Point(216, 18);
            this.rbBurger1.Name = "rbBurger1";
            this.rbBurger1.Size = new System.Drawing.Size(62, 17);
            this.rbBurger1.TabIndex = 7;
            this.rbBurger1.TabStop = true;
            this.rbBurger1.Text = "Burger1";
            this.rbBurger1.UseVisualStyleBackColor = true;
            this.rbBurger1.CheckedChanged += new System.EventHandler(this.rbBurger1_CheckedChanged);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(67, 12);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 6;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbBurger2);
            this.Controls.Add(this.rbBurger1);
            this.Controls.Add(this.Create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbBurger2;
        private System.Windows.Forms.RadioButton rbBurger1;
        private System.Windows.Forms.Button Create;
    }
}

