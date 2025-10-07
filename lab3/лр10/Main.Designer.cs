namespace лр10
{
    partial class Main
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
            this.btnMySQL_connect = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnList_product = new System.Windows.Forms.Button();
            this.btnAdditional_items = new System.Windows.Forms.Button();
            this.btnType_product = new System.Windows.Forms.Button();
            this.btnTarget_user = new System.Windows.Forms.Button();
            this.btnProduct_Package = new System.Windows.Forms.Button();
            this.btnAllCreateTable = new System.Windows.Forms.Button();
            this.btnAllDropTable = new System.Windows.Forms.Button();
            this.btnAllDropConstraint = new System.Windows.Forms.Button();
            this.btnAllCreateConstraint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMySQL_connect
            // 
            this.btnMySQL_connect.Location = new System.Drawing.Point(12, 323);
            this.btnMySQL_connect.Name = "btnMySQL_connect";
            this.btnMySQL_connect.Size = new System.Drawing.Size(75, 23);
            this.btnMySQL_connect.TabIndex = 0;
            this.btnMySQL_connect.Text = "MySQL connect";
            this.btnMySQL_connect.UseVisualStyleBackColor = true;
            this.btnMySQL_connect.Click += new System.EventHandler(this.btnMySQL_connect_Click);
            // 
            // btnItems
            // 
            this.btnItems.AutoSize = true;
            this.btnItems.Location = new System.Drawing.Point(12, 294);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(42, 23);
            this.btnItems.TabIndex = 1;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnList_product
            // 
            this.btnList_product.AutoSize = true;
            this.btnList_product.Location = new System.Drawing.Point(60, 294);
            this.btnList_product.Name = "btnList_product";
            this.btnList_product.Size = new System.Drawing.Size(72, 23);
            this.btnList_product.TabIndex = 2;
            this.btnList_product.Text = "List product";
            this.btnList_product.UseVisualStyleBackColor = true;
            this.btnList_product.Click += new System.EventHandler(this.btnList_product_Click);
            // 
            // btnAdditional_items
            // 
            this.btnAdditional_items.AutoSize = true;
            this.btnAdditional_items.Location = new System.Drawing.Point(138, 294);
            this.btnAdditional_items.Name = "btnAdditional_items";
            this.btnAdditional_items.Size = new System.Drawing.Size(90, 23);
            this.btnAdditional_items.TabIndex = 3;
            this.btnAdditional_items.Text = "Additional items";
            this.btnAdditional_items.UseVisualStyleBackColor = true;
            this.btnAdditional_items.Click += new System.EventHandler(this.btnAdditional_items_Click);
            // 
            // btnType_product
            // 
            this.btnType_product.AutoSize = true;
            this.btnType_product.Location = new System.Drawing.Point(419, 294);
            this.btnType_product.Name = "btnType_product";
            this.btnType_product.Size = new System.Drawing.Size(83, 23);
            this.btnType_product.TabIndex = 6;
            this.btnType_product.Text = "Type_product";
            this.btnType_product.UseVisualStyleBackColor = true;
            this.btnType_product.Click += new System.EventHandler(this.btnType_product_Click);
            // 
            // btnTarget_user
            // 
            this.btnTarget_user.AutoSize = true;
            this.btnTarget_user.Location = new System.Drawing.Point(339, 294);
            this.btnTarget_user.Name = "btnTarget_user";
            this.btnTarget_user.Size = new System.Drawing.Size(74, 23);
            this.btnTarget_user.TabIndex = 5;
            this.btnTarget_user.Text = "Target_user";
            this.btnTarget_user.UseVisualStyleBackColor = true;
            this.btnTarget_user.Click += new System.EventHandler(this.btnTarget_user_Click);
            // 
            // btnProduct_Package
            // 
            this.btnProduct_Package.AutoSize = true;
            this.btnProduct_Package.Location = new System.Drawing.Point(234, 294);
            this.btnProduct_Package.Name = "btnProduct_Package";
            this.btnProduct_Package.Size = new System.Drawing.Size(99, 23);
            this.btnProduct_Package.TabIndex = 4;
            this.btnProduct_Package.Text = "Product package";
            this.btnProduct_Package.UseVisualStyleBackColor = true;
            this.btnProduct_Package.Click += new System.EventHandler(this.btnProduct_Package_Click);
            // 
            // btnAllCreateTable
            // 
            this.btnAllCreateTable.AutoSize = true;
            this.btnAllCreateTable.Location = new System.Drawing.Point(12, 12);
            this.btnAllCreateTable.Name = "btnAllCreateTable";
            this.btnAllCreateTable.Size = new System.Drawing.Size(87, 23);
            this.btnAllCreateTable.TabIndex = 7;
            this.btnAllCreateTable.Text = "All create table";
            this.btnAllCreateTable.UseVisualStyleBackColor = true;
            this.btnAllCreateTable.Click += new System.EventHandler(this.btnAllCreateTable_Click);
            // 
            // btnAllDropTable
            // 
            this.btnAllDropTable.AutoSize = true;
            this.btnAllDropTable.Location = new System.Drawing.Point(12, 41);
            this.btnAllDropTable.Name = "btnAllDropTable";
            this.btnAllDropTable.Size = new System.Drawing.Size(87, 23);
            this.btnAllDropTable.TabIndex = 8;
            this.btnAllDropTable.Text = "All drop table";
            this.btnAllDropTable.UseVisualStyleBackColor = true;
            this.btnAllDropTable.Click += new System.EventHandler(this.btnAllDropTable_Click);
            // 
            // btnAllDropConstraint
            // 
            this.btnAllDropConstraint.AutoSize = true;
            this.btnAllDropConstraint.Location = new System.Drawing.Point(110, 41);
            this.btnAllDropConstraint.Name = "btnAllDropConstraint";
            this.btnAllDropConstraint.Size = new System.Drawing.Size(110, 23);
            this.btnAllDropConstraint.TabIndex = 10;
            this.btnAllDropConstraint.Text = "All drop constraint";
            this.btnAllDropConstraint.UseVisualStyleBackColor = true;
            this.btnAllDropConstraint.Click += new System.EventHandler(this.btnAllDropConstraint_Click);
            // 
            // btnAllCreateConstraint
            // 
            this.btnAllCreateConstraint.AutoSize = true;
            this.btnAllCreateConstraint.Location = new System.Drawing.Point(110, 12);
            this.btnAllCreateConstraint.Name = "btnAllCreateConstraint";
            this.btnAllCreateConstraint.Size = new System.Drawing.Size(110, 23);
            this.btnAllCreateConstraint.TabIndex = 9;
            this.btnAllCreateConstraint.Text = "All create constraint";
            this.btnAllCreateConstraint.UseVisualStyleBackColor = true;
            this.btnAllCreateConstraint.Click += new System.EventHandler(this.btnAllCreateConstraint_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAllDropConstraint);
            this.Controls.Add(this.btnAllCreateConstraint);
            this.Controls.Add(this.btnAllDropTable);
            this.Controls.Add(this.btnAllCreateTable);
            this.Controls.Add(this.btnType_product);
            this.Controls.Add(this.btnTarget_user);
            this.Controls.Add(this.btnProduct_Package);
            this.Controls.Add(this.btnAdditional_items);
            this.Controls.Add(this.btnList_product);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnMySQL_connect);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMySQL_connect;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnList_product;
        private System.Windows.Forms.Button btnAdditional_items;
        private System.Windows.Forms.Button btnType_product;
        private System.Windows.Forms.Button btnTarget_user;
        private System.Windows.Forms.Button btnProduct_Package;
        private System.Windows.Forms.Button btnAllCreateTable;
        private System.Windows.Forms.Button btnAllDropTable;
        private System.Windows.Forms.Button btnAllDropConstraint;
        private System.Windows.Forms.Button btnAllCreateConstraint;
    }
}

