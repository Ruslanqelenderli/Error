namespace RStore.MyForms
{
    partial class OperationsByCategoryForm
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
            this.dgv_CategoryName = new System.Windows.Forms.DataGridView();
            this.lbl_AddCategoryForm = new System.Windows.Forms.Label();
            this.btn_AddCategoryName = new System.Windows.Forms.Button();
            this.txb_CategoryName = new System.Windows.Forms.TextBox();
            this.lbl_AddCategoryName = new System.Windows.Forms.Label();
            this.btn_UpdateCategoryName = new System.Windows.Forms.Button();
            this.btn_DeleteCategoryName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CategoryName)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_CategoryName
            // 
            this.dgv_CategoryName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CategoryName.Location = new System.Drawing.Point(222, 52);
            this.dgv_CategoryName.Name = "dgv_CategoryName";
            this.dgv_CategoryName.Size = new System.Drawing.Size(240, 150);
            this.dgv_CategoryName.TabIndex = 0;
            this.dgv_CategoryName.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CategoryName_CellClick);
            // 
            // lbl_AddCategoryForm
            // 
            this.lbl_AddCategoryForm.AutoSize = true;
            this.lbl_AddCategoryForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_AddCategoryForm.Location = new System.Drawing.Point(39, 53);
            this.lbl_AddCategoryForm.Name = "lbl_AddCategoryForm";
            this.lbl_AddCategoryForm.Size = new System.Drawing.Size(33, 18);
            this.lbl_AddCategoryForm.TabIndex = 1;
            this.lbl_AddCategoryForm.Text = "Add";
            // 
            // btn_AddCategoryName
            // 
            this.btn_AddCategoryName.Location = new System.Drawing.Point(12, 133);
            this.btn_AddCategoryName.Name = "btn_AddCategoryName";
            this.btn_AddCategoryName.Size = new System.Drawing.Size(60, 23);
            this.btn_AddCategoryName.TabIndex = 2;
            this.btn_AddCategoryName.Text = "Add";
            this.btn_AddCategoryName.UseVisualStyleBackColor = true;
            this.btn_AddCategoryName.Click += new System.EventHandler(this.btn_AddCategoryName_Click);
            // 
            // txb_CategoryName
            // 
            this.txb_CategoryName.Location = new System.Drawing.Point(12, 107);
            this.txb_CategoryName.Name = "txb_CategoryName";
            this.txb_CategoryName.Size = new System.Drawing.Size(126, 20);
            this.txb_CategoryName.TabIndex = 3;
            // 
            // lbl_AddCategoryName
            // 
            this.lbl_AddCategoryName.AutoSize = true;
            this.lbl_AddCategoryName.Location = new System.Drawing.Point(21, 82);
            this.lbl_AddCategoryName.Name = "lbl_AddCategoryName";
            this.lbl_AddCategoryName.Size = new System.Drawing.Size(80, 13);
            this.lbl_AddCategoryName.TabIndex = 5;
            this.lbl_AddCategoryName.Text = "Category Name";
            // 
            // btn_UpdateCategoryName
            // 
            this.btn_UpdateCategoryName.Location = new System.Drawing.Point(80, 133);
            this.btn_UpdateCategoryName.Name = "btn_UpdateCategoryName";
            this.btn_UpdateCategoryName.Size = new System.Drawing.Size(58, 23);
            this.btn_UpdateCategoryName.TabIndex = 8;
            this.btn_UpdateCategoryName.Text = "Update";
            this.btn_UpdateCategoryName.UseVisualStyleBackColor = true;
            this.btn_UpdateCategoryName.Click += new System.EventHandler(this.btn_UpdateCategoryName_Click);
            // 
            // btn_DeleteCategoryName
            // 
            this.btn_DeleteCategoryName.Location = new System.Drawing.Point(222, 208);
            this.btn_DeleteCategoryName.Name = "btn_DeleteCategoryName";
            this.btn_DeleteCategoryName.Size = new System.Drawing.Size(58, 23);
            this.btn_DeleteCategoryName.TabIndex = 9;
            this.btn_DeleteCategoryName.Text = "Delete";
            this.btn_DeleteCategoryName.UseVisualStyleBackColor = true;
            this.btn_DeleteCategoryName.Click += new System.EventHandler(this.btn_DeleteCategoryName_Click);
            // 
            // OperationsByCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 275);
            this.Controls.Add(this.btn_DeleteCategoryName);
            this.Controls.Add(this.btn_UpdateCategoryName);
            this.Controls.Add(this.lbl_AddCategoryName);
            this.Controls.Add(this.txb_CategoryName);
            this.Controls.Add(this.btn_AddCategoryName);
            this.Controls.Add(this.lbl_AddCategoryForm);
            this.Controls.Add(this.dgv_CategoryName);
            this.Name = "OperationsByCategoryForm";
            this.Text = "OperationsByCategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CategoryName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_CategoryName;
        private System.Windows.Forms.Label lbl_AddCategoryForm;
        private System.Windows.Forms.Button btn_AddCategoryName;
        private System.Windows.Forms.TextBox txb_CategoryName;
        private System.Windows.Forms.Label lbl_AddCategoryName;
        private System.Windows.Forms.Button btn_UpdateCategoryName;
        private System.Windows.Forms.Button btn_DeleteCategoryName;
    }
}