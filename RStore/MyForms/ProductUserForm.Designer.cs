namespace RStore.MyForms
{
    partial class ProductUserForm
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
            this.lbl_AddName = new System.Windows.Forms.Label();
            this.lbl_AddPrice = new System.Windows.Forms.Label();
            this.lbl_AddCount = new System.Windows.Forms.Label();
            this.txb_AddName = new System.Windows.Forms.TextBox();
            this.txb_AddCount = new System.Windows.Forms.TextBox();
            this.txb_AddPrice = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_UserProducts = new System.Windows.Forms.DataGridView();
            this.lbl_Add = new System.Windows.Forms.Label();
            this.txb_NameSearch = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.lbl_NameUpdate = new System.Windows.Forms.Label();
            this.lbl_CountSearch = new System.Windows.Forms.Label();
            this.lbl_PriceSearch = new System.Windows.Forms.Label();
            this.lbl_Update = new System.Windows.Forms.Label();
            this.lbl_NameSearch = new System.Windows.Forms.Label();
            this.lbl_CountUpdate = new System.Windows.Forms.Label();
            this.lbl_PriceUpdate = new System.Windows.Forms.Label();
            this.txb_PriceSearch = new System.Windows.Forms.TextBox();
            this.txb_CountUpdate = new System.Windows.Forms.TextBox();
            this.txb_PriceUpdate = new System.Windows.Forms.TextBox();
            this.txb_NameUpdate = new System.Windows.Forms.TextBox();
            this.txb_CountSearch = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txb_CategorySearch = new System.Windows.Forms.TextBox();
            this.cmb_CategoryAdd = new System.Windows.Forms.ComboBox();
            this.cmb_CategoryUpdate = new System.Windows.Forms.ComboBox();
            this.lbl_CategoryAdd = new System.Windows.Forms.Label();
            this.lbl_CategoryUpdate = new System.Windows.Forms.Label();
            this.lbl_CategorySearch = new System.Windows.Forms.Label();
            this.btn_AllProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AddName
            // 
            this.lbl_AddName.AutoSize = true;
            this.lbl_AddName.Location = new System.Drawing.Point(30, 335);
            this.lbl_AddName.Name = "lbl_AddName";
            this.lbl_AddName.Size = new System.Drawing.Size(35, 13);
            this.lbl_AddName.TabIndex = 0;
            this.lbl_AddName.Text = "Name";
            // 
            // lbl_AddPrice
            // 
            this.lbl_AddPrice.AutoSize = true;
            this.lbl_AddPrice.Location = new System.Drawing.Point(30, 371);
            this.lbl_AddPrice.Name = "lbl_AddPrice";
            this.lbl_AddPrice.Size = new System.Drawing.Size(31, 13);
            this.lbl_AddPrice.TabIndex = 1;
            this.lbl_AddPrice.Text = "Price";
            // 
            // lbl_AddCount
            // 
            this.lbl_AddCount.AutoSize = true;
            this.lbl_AddCount.Location = new System.Drawing.Point(30, 410);
            this.lbl_AddCount.Name = "lbl_AddCount";
            this.lbl_AddCount.Size = new System.Drawing.Size(35, 13);
            this.lbl_AddCount.TabIndex = 2;
            this.lbl_AddCount.Text = "Count";
            // 
            // txb_AddName
            // 
            this.txb_AddName.Location = new System.Drawing.Point(33, 351);
            this.txb_AddName.Name = "txb_AddName";
            this.txb_AddName.Size = new System.Drawing.Size(100, 20);
            this.txb_AddName.TabIndex = 3;
            // 
            // txb_AddCount
            // 
            this.txb_AddCount.Location = new System.Drawing.Point(33, 426);
            this.txb_AddCount.Name = "txb_AddCount";
            this.txb_AddCount.Size = new System.Drawing.Size(100, 20);
            this.txb_AddCount.TabIndex = 4;
            // 
            // txb_AddPrice
            // 
            this.txb_AddPrice.Location = new System.Drawing.Point(33, 387);
            this.txb_AddPrice.Name = "txb_AddPrice";
            this.txb_AddPrice.Size = new System.Drawing.Size(100, 20);
            this.txb_AddPrice.TabIndex = 5;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(47, 490);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dgv_UserProducts
            // 
            this.dgv_UserProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserProducts.Location = new System.Drawing.Point(249, 12);
            this.dgv_UserProducts.Name = "dgv_UserProducts";
            this.dgv_UserProducts.Size = new System.Drawing.Size(477, 260);
            this.dgv_UserProducts.TabIndex = 7;
           
            // 
            // lbl_Add
            // 
            this.lbl_Add.AutoSize = true;
            this.lbl_Add.Location = new System.Drawing.Point(44, 291);
            this.lbl_Add.Name = "lbl_Add";
            this.lbl_Add.Size = new System.Drawing.Size(70, 13);
            this.lbl_Add.TabIndex = 8;
            this.lbl_Add.Text = "Add products";
            // 
            // txb_NameSearch
            // 
            this.txb_NameSearch.Location = new System.Drawing.Point(33, 71);
            this.txb_NameSearch.Name = "txb_NameSearch";
            this.txb_NameSearch.Size = new System.Drawing.Size(100, 20);
            this.txb_NameSearch.TabIndex = 9;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(538, 490);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(19, 12);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(41, 13);
            this.lbl_Search.TabIndex = 13;
            this.lbl_Search.Text = "Search";
            // 
            // lbl_NameUpdate
            // 
            this.lbl_NameUpdate.AutoSize = true;
            this.lbl_NameUpdate.Location = new System.Drawing.Point(517, 330);
            this.lbl_NameUpdate.Name = "lbl_NameUpdate";
            this.lbl_NameUpdate.Size = new System.Drawing.Size(35, 13);
            this.lbl_NameUpdate.TabIndex = 14;
            this.lbl_NameUpdate.Text = "Name";
            // 
            // lbl_CountSearch
            // 
            this.lbl_CountSearch.AutoSize = true;
            this.lbl_CountSearch.Location = new System.Drawing.Point(30, 152);
            this.lbl_CountSearch.Name = "lbl_CountSearch";
            this.lbl_CountSearch.Size = new System.Drawing.Size(35, 13);
            this.lbl_CountSearch.TabIndex = 15;
            this.lbl_CountSearch.Text = "Count";
            // 
            // lbl_PriceSearch
            // 
            this.lbl_PriceSearch.AutoSize = true;
            this.lbl_PriceSearch.Location = new System.Drawing.Point(30, 105);
            this.lbl_PriceSearch.Name = "lbl_PriceSearch";
            this.lbl_PriceSearch.Size = new System.Drawing.Size(31, 13);
            this.lbl_PriceSearch.TabIndex = 16;
            this.lbl_PriceSearch.Text = "Price";
            // 
            // lbl_Update
            // 
            this.lbl_Update.AutoSize = true;
            this.lbl_Update.Location = new System.Drawing.Point(535, 291);
            this.lbl_Update.Name = "lbl_Update";
            this.lbl_Update.Size = new System.Drawing.Size(42, 13);
            this.lbl_Update.TabIndex = 17;
            this.lbl_Update.Text = "Update";
            // 
            // lbl_NameSearch
            // 
            this.lbl_NameSearch.AutoSize = true;
            this.lbl_NameSearch.Location = new System.Drawing.Point(30, 55);
            this.lbl_NameSearch.Name = "lbl_NameSearch";
            this.lbl_NameSearch.Size = new System.Drawing.Size(35, 13);
            this.lbl_NameSearch.TabIndex = 18;
            this.lbl_NameSearch.Text = "Name";
            // 
            // lbl_CountUpdate
            // 
            this.lbl_CountUpdate.AutoSize = true;
            this.lbl_CountUpdate.Location = new System.Drawing.Point(517, 410);
            this.lbl_CountUpdate.Name = "lbl_CountUpdate";
            this.lbl_CountUpdate.Size = new System.Drawing.Size(35, 13);
            this.lbl_CountUpdate.TabIndex = 19;
            this.lbl_CountUpdate.Text = "Count";
            // 
            // lbl_PriceUpdate
            // 
            this.lbl_PriceUpdate.AutoSize = true;
            this.lbl_PriceUpdate.Location = new System.Drawing.Point(517, 371);
            this.lbl_PriceUpdate.Name = "lbl_PriceUpdate";
            this.lbl_PriceUpdate.Size = new System.Drawing.Size(31, 13);
            this.lbl_PriceUpdate.TabIndex = 20;
            this.lbl_PriceUpdate.Text = "Price";
            // 
            // txb_PriceSearch
            // 
            this.txb_PriceSearch.Location = new System.Drawing.Point(33, 121);
            this.txb_PriceSearch.Name = "txb_PriceSearch";
            this.txb_PriceSearch.Size = new System.Drawing.Size(100, 20);
            this.txb_PriceSearch.TabIndex = 21;
            // 
            // txb_CountUpdate
            // 
            this.txb_CountUpdate.Location = new System.Drawing.Point(520, 426);
            this.txb_CountUpdate.Name = "txb_CountUpdate";
            this.txb_CountUpdate.Size = new System.Drawing.Size(100, 20);
            this.txb_CountUpdate.TabIndex = 22;
            // 
            // txb_PriceUpdate
            // 
            this.txb_PriceUpdate.Location = new System.Drawing.Point(520, 387);
            this.txb_PriceUpdate.Name = "txb_PriceUpdate";
            this.txb_PriceUpdate.Size = new System.Drawing.Size(100, 20);
            this.txb_PriceUpdate.TabIndex = 23;
            // 
            // txb_NameUpdate
            // 
            this.txb_NameUpdate.Location = new System.Drawing.Point(520, 348);
            this.txb_NameUpdate.Name = "txb_NameUpdate";
            this.txb_NameUpdate.Size = new System.Drawing.Size(100, 20);
            this.txb_NameUpdate.TabIndex = 24;
            // 
            // txb_CountSearch
            // 
            this.txb_CountSearch.Location = new System.Drawing.Point(33, 168);
            this.txb_CountSearch.Name = "txb_CountSearch";
            this.txb_CountSearch.Size = new System.Drawing.Size(100, 20);
            this.txb_CountSearch.TabIndex = 25;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(152, 142);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 26;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // txb_CategorySearch
            // 
            this.txb_CategorySearch.Location = new System.Drawing.Point(33, 208);
            this.txb_CategorySearch.Name = "txb_CategorySearch";
            this.txb_CategorySearch.Size = new System.Drawing.Size(100, 20);
            this.txb_CategorySearch.TabIndex = 29;
            // 
            // cmb_CategoryAdd
            // 
            this.cmb_CategoryAdd.FormattingEnabled = true;
            this.cmb_CategoryAdd.Location = new System.Drawing.Point(33, 463);
            this.cmb_CategoryAdd.Name = "cmb_CategoryAdd";
            this.cmb_CategoryAdd.Size = new System.Drawing.Size(100, 21);
            this.cmb_CategoryAdd.TabIndex = 30;
            // 
            // cmb_CategoryUpdate
            // 
            this.cmb_CategoryUpdate.FormattingEnabled = true;
            this.cmb_CategoryUpdate.Location = new System.Drawing.Point(520, 463);
            this.cmb_CategoryUpdate.Name = "cmb_CategoryUpdate";
            this.cmb_CategoryUpdate.Size = new System.Drawing.Size(100, 21);
            this.cmb_CategoryUpdate.TabIndex = 31;
            // 
            // lbl_CategoryAdd
            // 
            this.lbl_CategoryAdd.AutoSize = true;
            this.lbl_CategoryAdd.Location = new System.Drawing.Point(30, 449);
            this.lbl_CategoryAdd.Name = "lbl_CategoryAdd";
            this.lbl_CategoryAdd.Size = new System.Drawing.Size(49, 13);
            this.lbl_CategoryAdd.TabIndex = 32;
            this.lbl_CategoryAdd.Text = "Category";
            // 
            // lbl_CategoryUpdate
            // 
            this.lbl_CategoryUpdate.AutoSize = true;
            this.lbl_CategoryUpdate.Location = new System.Drawing.Point(517, 447);
            this.lbl_CategoryUpdate.Name = "lbl_CategoryUpdate";
            this.lbl_CategoryUpdate.Size = new System.Drawing.Size(49, 13);
            this.lbl_CategoryUpdate.TabIndex = 33;
            this.lbl_CategoryUpdate.Text = "Category";
            // 
            // lbl_CategorySearch
            // 
            this.lbl_CategorySearch.AutoSize = true;
            this.lbl_CategorySearch.Location = new System.Drawing.Point(30, 191);
            this.lbl_CategorySearch.Name = "lbl_CategorySearch";
            this.lbl_CategorySearch.Size = new System.Drawing.Size(49, 13);
            this.lbl_CategorySearch.TabIndex = 34;
            this.lbl_CategorySearch.Text = "Category";
            // 
            // btn_AllProducts
            // 
            this.btn_AllProducts.Location = new System.Drawing.Point(249, 278);
            this.btn_AllProducts.Name = "btn_AllProducts";
            this.btn_AllProducts.Size = new System.Drawing.Size(141, 23);
            this.btn_AllProducts.TabIndex = 35;
            this.btn_AllProducts.Text = "Show All Product";
            this.btn_AllProducts.UseVisualStyleBackColor = true;
            
            // 
            // ProductUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 553);
            this.Controls.Add(this.btn_AllProducts);
            this.Controls.Add(this.lbl_CategorySearch);
            this.Controls.Add(this.lbl_CategoryUpdate);
            this.Controls.Add(this.lbl_CategoryAdd);
            this.Controls.Add(this.cmb_CategoryUpdate);
            this.Controls.Add(this.cmb_CategoryAdd);
            this.Controls.Add(this.txb_CategorySearch);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txb_CountSearch);
            this.Controls.Add(this.txb_NameUpdate);
            this.Controls.Add(this.txb_PriceUpdate);
            this.Controls.Add(this.txb_CountUpdate);
            this.Controls.Add(this.txb_PriceSearch);
            this.Controls.Add(this.lbl_PriceUpdate);
            this.Controls.Add(this.lbl_CountUpdate);
            this.Controls.Add(this.lbl_NameSearch);
            this.Controls.Add(this.lbl_Update);
            this.Controls.Add(this.lbl_PriceSearch);
            this.Controls.Add(this.lbl_CountSearch);
            this.Controls.Add(this.lbl_NameUpdate);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.txb_NameSearch);
            this.Controls.Add(this.lbl_Add);
            this.Controls.Add(this.dgv_UserProducts);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txb_AddPrice);
            this.Controls.Add(this.txb_AddCount);
            this.Controls.Add(this.txb_AddName);
            this.Controls.Add(this.lbl_AddCount);
            this.Controls.Add(this.lbl_AddPrice);
            this.Controls.Add(this.lbl_AddName);
            this.Name = "ProductUserForm";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AddName;
        private System.Windows.Forms.Label lbl_AddPrice;
        private System.Windows.Forms.Label lbl_AddCount;
        private System.Windows.Forms.TextBox txb_AddName;
        private System.Windows.Forms.TextBox txb_AddCount;
        private System.Windows.Forms.TextBox txb_AddPrice;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_UserProducts;
        private System.Windows.Forms.Label lbl_Add;
        private System.Windows.Forms.TextBox txb_NameSearch;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Label lbl_NameUpdate;
        private System.Windows.Forms.Label lbl_CountSearch;
        private System.Windows.Forms.Label lbl_PriceSearch;
        private System.Windows.Forms.Label lbl_Update;
        private System.Windows.Forms.Label lbl_NameSearch;
        private System.Windows.Forms.Label lbl_CountUpdate;
        private System.Windows.Forms.Label lbl_PriceUpdate;
        private System.Windows.Forms.TextBox txb_PriceSearch;
        private System.Windows.Forms.TextBox txb_CountUpdate;
        private System.Windows.Forms.TextBox txb_PriceUpdate;
        private System.Windows.Forms.TextBox txb_NameUpdate;
        private System.Windows.Forms.TextBox txb_CountSearch;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txb_CategorySearch;
        public System.Windows.Forms.ComboBox cmb_CategoryAdd;
        private System.Windows.Forms.ComboBox cmb_CategoryUpdate;
        private System.Windows.Forms.Label lbl_CategoryAdd;
        private System.Windows.Forms.Label lbl_CategoryUpdate;
        private System.Windows.Forms.Label lbl_CategorySearch;
        private System.Windows.Forms.Button btn_AllProducts;
    }
}