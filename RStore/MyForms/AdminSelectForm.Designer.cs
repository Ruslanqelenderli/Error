namespace RStore.MyForms
{
    partial class AdminSelectForm
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
            this.btn_AllProductsAdmin = new System.Windows.Forms.Button();
            this.btn_OperationsByCategory = new System.Windows.Forms.Button();
            this.btn_AllReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AllProductsAdmin
            // 
            this.btn_AllProductsAdmin.Location = new System.Drawing.Point(34, 87);
            this.btn_AllProductsAdmin.Name = "btn_AllProductsAdmin";
            this.btn_AllProductsAdmin.Size = new System.Drawing.Size(103, 72);
            this.btn_AllProductsAdmin.TabIndex = 0;
            this.btn_AllProductsAdmin.Text = "All Products";
            this.btn_AllProductsAdmin.UseVisualStyleBackColor = true;
            // 
            // btn_OperationsByCategory
            // 
            this.btn_OperationsByCategory.Location = new System.Drawing.Point(153, 87);
            this.btn_OperationsByCategory.Name = "btn_OperationsByCategory";
            this.btn_OperationsByCategory.Size = new System.Drawing.Size(103, 72);
            this.btn_OperationsByCategory.TabIndex = 1;
            this.btn_OperationsByCategory.Text = "Operations By Category";
            this.btn_OperationsByCategory.UseVisualStyleBackColor = true;
            this.btn_OperationsByCategory.Click += new System.EventHandler(this.btn_OperationsByCategory_Click);
            // 
            // btn_AllReport
            // 
            this.btn_AllReport.Location = new System.Drawing.Point(273, 87);
            this.btn_AllReport.Name = "btn_AllReport";
            this.btn_AllReport.Size = new System.Drawing.Size(104, 72);
            this.btn_AllReport.TabIndex = 2;
            this.btn_AllReport.Text = "All Report";
            this.btn_AllReport.UseVisualStyleBackColor = true;
            
            // 
            // AdminSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 245);
            this.Controls.Add(this.btn_AllReport);
            this.Controls.Add(this.btn_OperationsByCategory);
            this.Controls.Add(this.btn_AllProductsAdmin);
            this.Name = "AdminSelectForm";
            this.Text = "AdminSelectForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AllProductsAdmin;
        private System.Windows.Forms.Button btn_OperationsByCategory;
        private System.Windows.Forms.Button btn_AllReport;
    }
}