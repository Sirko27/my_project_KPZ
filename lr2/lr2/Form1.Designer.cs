namespace lr2
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
            this.Baroque = new System.Windows.Forms.RadioButton();
            this.Create = new System.Windows.Forms.Button();
            this.rbClassic = new System.Windows.Forms.RadioButton();
            this.rbRomanesque = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Baroque
            // 
            this.Baroque.AutoSize = true;
            this.Baroque.Location = new System.Drawing.Point(161, 18);
            this.Baroque.Name = "Baroque";
            this.Baroque.Size = new System.Drawing.Size(65, 17);
            this.Baroque.TabIndex = 3;
            this.Baroque.TabStop = true;
            this.Baroque.Text = "Baroque";
            this.Baroque.UseVisualStyleBackColor = true;
            this.Baroque.CheckedChanged += new System.EventHandler(this.Baroque_CheckedChanged);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(12, 12);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 2;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // rbClassic
            // 
            this.rbClassic.AutoSize = true;
            this.rbClassic.Location = new System.Drawing.Point(244, 18);
            this.rbClassic.Name = "rbClassic";
            this.rbClassic.Size = new System.Drawing.Size(58, 17);
            this.rbClassic.TabIndex = 4;
            this.rbClassic.TabStop = true;
            this.rbClassic.Text = "Classic";
            this.rbClassic.UseVisualStyleBackColor = true;
            this.rbClassic.CheckedChanged += new System.EventHandler(this.rbClassic_CheckedChanged);
            // 
            // rbRomanesque
            // 
            this.rbRomanesque.AutoSize = true;
            this.rbRomanesque.Location = new System.Drawing.Point(308, 18);
            this.rbRomanesque.Name = "rbRomanesque";
            this.rbRomanesque.Size = new System.Drawing.Size(88, 17);
            this.rbRomanesque.TabIndex = 5;
            this.rbRomanesque.TabStop = true;
            this.rbRomanesque.Text = "Romanesque";
            this.rbRomanesque.UseVisualStyleBackColor = true;
            this.rbRomanesque.CheckedChanged += new System.EventHandler(this.rbRomanesque_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbRomanesque);
            this.Controls.Add(this.rbClassic);
            this.Controls.Add(this.Baroque);
            this.Controls.Add(this.Create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Baroque;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.RadioButton rbClassic;
        private System.Windows.Forms.RadioButton rbRomanesque;
    }
}

