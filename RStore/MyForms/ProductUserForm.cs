using RStore.DAL;
using RStore.DataContext;
using RStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RStore.MyForms
{
    public partial class ProductUserForm : Form
    {
        MyDatabase myDatabase = new MyDatabase();
        public ProductUserForm()
        {
            InitializeComponent();
            GetAllUserProduct(myDatabase.userId);



            SetCategory();
        }
        CrudDb crud = new CrudDb();
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Name = txb_AddName.Text,
                Price = Convert.ToDouble(txb_AddPrice.Text),
                CategoryId=Convert.ToInt32(cmb_CategoryAdd.Text.Split('-')[0]),
                UserId=myDatabase.userId,
                Count=Convert.ToInt32(txb_AddCount.Text),
                BoughtCount=0,
                Status="Active"
            };
            crud.AddProduct(product);
            MessageBox.Show("Product Added");

        }
        
        public void SetCategory()
        {
            using (RStoreDataContext rStore = new RStoreDataContext())
            {
                foreach (Category category in rStore.Categories.ToList())
                {
                    cmb_CategoryAdd.Items.Add(category.Id + "-" + category.Name);
                }
            }
        }

        public void GetAllUserProduct(int id)
        {
            using(RStoreDataContext context=new RStoreDataContext())
            {
                var userproducts = context.Products.Where(x => x.UserId == id).ToList();
                dgv_UserProducts.DataSource = userproducts;
            }
        }

       

        
    }
}
