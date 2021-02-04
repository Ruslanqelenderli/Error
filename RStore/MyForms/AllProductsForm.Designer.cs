namespace RStore.MyForms
{
    partial class AllProductsForm
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
            this.dgv_AllProductView = new System.Windows.Forms.DataGridView();
            this.txb_SearchPName = new System.Windows.Forms.TextBox();
            this.lbl_SearchByPName = new System.Windows.Forms.Label();
            this.cmb_SearchCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_SearchCount = new System.Windows.Forms.TextBox();
            this.txb_SearchPrice = new System.Windows.Forms.TextBox();
            this.txb_SearchUserName = new System.Windows.Forms.TextBox();
            this.lbl_SearchCount = new System.Windows.Forms.Label();
            this.lbl_SearchPrice = new System.Windows.Forms.Label();
            this.lbl_SearchUserName = new System.Windows.Forms.Label();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.btn_AllProducts = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllProductView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_AllProductView
            // 
            this.dgv_AllProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllProductView.Location = new System.Drawing.Point(32, 38);
            this.dgv_AllProductView.Name = "dgv_AllProductView";
            this.dgv_AllProductView.Size = new System.Drawing.Size(593, 150);
            this.dgv_AllProductView.TabIndex = 0;
            this.dgv_AllProductView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txb_SearchPName
            // 
            this.txb_SearchPName.Location = new System.Drawing.Point(643, 38);
            this.txb_SearchPName.Name = "txb_SearchPName";
            this.txb_SearchPName.Size = new System.Drawing.Size(100, 20);
            this.txb_SearchPName.TabIndex = 1;
            this.txb_SearchPName.TextChanged += new System.EventHandler(this.txb_SearchPName_TextChanged);
            // 
            // lbl_SearchByPName
            // 
            this.lbl_SearchByPName.AutoSize = true;
            this.lbl_SearchByPName.Location = new System.Drawing.Point(631, 9);
            this.lbl_SearchByPName.Name = "lbl_SearchByPName";
            this.lbl_SearchByPName.Size = new System.Drawing.Size(123, 13);
            this.lbl_SearchByPName.TabIndex = 2;
            this.lbl_SearchByPName.Text = "Search by product name";
            // 
            // cmb_SearchCategory
            // 
            this.cmb_SearchCategory.FormattingEnabled = true;
            this.cmb_SearchCategory.Location = new System.Drawing.Point(643, 94);
            this.cmb_SearchCategory.Name = "cmb_SearchCategory";
            this.cmb_SearchCategory.Size = new System.Drawing.Size(100, 21);
            this.cmb_SearchCategory.TabIndex = 3;
            this.cmb_SearchCategory.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search by product category";
            // 
            // txb_SearchCount
            // 
            this.txb_SearchCount.Location = new System.Drawing.Point(32, 350);
            this.txb_SearchCount.Name = "txb_SearchCount";
            this.txb_SearchCount.Size = new System.Drawing.Size(100, 20);
            this.txb_SearchCount.TabIndex = 5;
            this.txb_SearchCount.TextChanged += new System.EventHandler(this.txb_SearchCount_TextChanged);
            // 
            // txb_SearchPrice
            // 
            this.txb_SearchPrice.Location = new System.Drawing.Point(32, 314);
            this.txb_SearchPrice.Name = "txb_SearchPrice";
            this.txb_SearchPrice.Size = new System.Drawing.Size(100, 20);
            this.txb_SearchPrice.TabIndex = 6;
            // 
            // txb_SearchUserName
            // 
            this.txb_SearchUserName.Location = new System.Drawing.Point(32, 276);
            this.txb_SearchUserName.Name = "txb_SearchUserName";
            this.txb_SearchUserName.Size = new System.Drawing.Size(100, 20);
            this.txb_SearchUserName.TabIndex = 7;
            // 
            // lbl_SearchCount
            // 
            this.lbl_SearchCount.AutoSize = true;
            this.lbl_SearchCount.Location = new System.Drawing.Point(29, 337);
            this.lbl_SearchCount.Name = "lbl_SearchCount";
            this.lbl_SearchCount.Size = new System.Drawing.Size(35, 13);
            this.lbl_SearchCount.TabIndex = 8;
            this.lbl_SearchCount.Text = "Count";
            // 
            // lbl_SearchPrice
            // 
            this.lbl_SearchPrice.AutoSize = true;
            this.lbl_SearchPrice.Location = new System.Drawing.Point(29, 299);
            this.lbl_SearchPrice.Name = "lbl_SearchPrice";
            this.lbl_SearchPrice.Size = new System.Drawing.Size(31, 13);
            this.lbl_SearchPrice.TabIndex = 9;
            this.lbl_SearchPrice.Text = "Price";
            // 
            // lbl_SearchUserName
            // 
            this.lbl_SearchUserName.AutoSize = true;
            this.lbl_SearchUserName.Location = new System.Drawing.Point(29, 260);
            this.lbl_SearchUserName.Name = "lbl_SearchUserName";
            this.lbl_SearchUserName.Size = new System.Drawing.Size(60, 13);
            this.lbl_SearchUserName.TabIndex = 10;
            this.lbl_SearchUserName.Text = "User Name";
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(29, 230);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(41, 13);
            this.lbl_Search.TabIndex = 11;
            this.lbl_Search.Text = "Search";
            // 
            // btn_AllProducts
            // 
            this.btn_AllProducts.Location = new System.Drawing.Point(521, 194);
            this.btn_AllProducts.Name = "btn_AllProducts";
            this.btn_AllProducts.Size = new System.Drawing.Size(104, 23);
            this.btn_AllProducts.TabIndex = 13;
            this.btn_AllProducts.Text = "All Products";
            this.btn_AllProducts.UseVisualStyleBackColor = true;
            this.btn_AllProducts.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(46, 376);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 14;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // AllProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 484);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_AllProducts);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.lbl_SearchUserName);
            this.Controls.Add(this.lbl_SearchPrice);
            this.Controls.Add(this.lbl_SearchCount);
            this.Controls.Add(this.txb_SearchUserName);
            this.Controls.Add(this.txb_SearchPrice);
            this.Controls.Add(this.txb_SearchCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_SearchCategory);
            this.Controls.Add(this.lbl_SearchByPName);
            this.Controls.Add(this.txb_SearchPName);
            this.Controls.Add(this.dgv_AllProductView);
            this.Name = "AllProductsForm";
            this.Text = "AllProductsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllProductView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_AllProductView;
        private System.Windows.Forms.TextBox txb_SearchPName;
        private System.Windows.Forms.Label lbl_SearchByPName;
        private System.Windows.Forms.ComboBox cmb_SearchCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_SearchCount;
        private System.Windows.Forms.TextBox txb_SearchPrice;
        private System.Windows.Forms.TextBox txb_SearchUserName;
        private System.Windows.Forms.Label lbl_SearchCount;
        private System.Windows.Forms.Label lbl_SearchPrice;
        private System.Windows.Forms.Label lbl_SearchUserName;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Button btn_AllProducts;
        private System.Windows.Forms.Button btn_Search;
    }
}