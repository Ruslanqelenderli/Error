using RStore.DataContext;
using RStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RStore.MyForms
{
    public partial class AllProductsForm : Form
    {
        public AllProductsForm()
        {
            InitializeComponent();
            GetAllProducts();
            GetAllCategory();
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Button button = new Button();
            button.Text = "Buy";
            button.Location = new Point(32, 13);
            button.Size = new Size(75, 23);
            Controls.Add(button);

            button.Click += new EventHandler(button_Click);
            
        }
        private void button_Click(object sender, EventArgs e)
        {
            int _count = Convert.ToInt32(dgv_AllProductView.CurrentRow.Cells[6].Value);
            _count--;
            int _boughtcount = Convert.ToInt32(dgv_AllProductView.CurrentRow.Cells[7].Value);
            _boughtcount++;
            Product product = new Product()
            {
                Id = Convert.ToInt32(dgv_AllProductView.CurrentRow.Cells[0].Value),
                Name = dgv_AllProductView.CurrentRow.Cells[1].Value.ToString(),
                Price = Convert.ToInt32(dgv_AllProductView.CurrentRow.Cells[2].Value),
                UserId= Convert.ToInt32(dgv_AllProductView.CurrentRow.Cells[3].Value),
                CategoryId= Convert.ToInt32(dgv_AllProductView.CurrentRow.Cells[4].Value),
                Status= dgv_AllProductView.CurrentRow.Cells[5].Value.ToString(),
                Count=_count,
                BoughtCount=_boughtcount
                
            };
            using(RStoreDataContext rStore=new RStoreDataContext())
            {
                rStore.Products.AddOrUpdate(product);
                rStore.SaveChanges();
            };
            if (_count == 0)
            {
                Product product1 = new Product()
                {
                    Id = Convert.ToInt32(dgv_AllProductView.CurrentRow.Cells[0].Value),
                    Name = dgv_AllProductView.CurrentRow.Cells[1].Value.ToString(),
                    Price = Convert.ToInt32(dgv_AllProductView.CurrentRow.Cells[2].Value),
                    UserId = Convert.ToInt32(dgv_AllProductView.CurrentRow.Cells[3].Value),
                    CategoryId = Convert.ToInt32(dgv_AllProductView.CurrentRow.Cells[4].Value),
                    Status = "Deactive",
                    Count = _count,
                    BoughtCount = _boughtcount
                };
                using (RStoreDataContext rStore = new RStoreDataContext())
                {
                    rStore.Products.AddOrUpdate(product1);
                    rStore.SaveChanges();
                };
            }

            MessageBox.Show("Thanks");
            
                GetAllProducts();
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetAllProducts();
        }

        public void GetAllCategory()
        {
            using(RStoreDataContext rStore=new RStoreDataContext())
            {
                var categories = rStore.Categories.ToList();
                cmb_SearchCategory.DisplayMember = "Name";
                cmb_SearchCategory.ValueMember = "Id";
                cmb_SearchCategory.DataSource = categories;
                
                
            }
        }
        public void SearchForCategory(int id)
        {
            using (RStoreDataContext rStore = new RStoreDataContext())
            {


                var products = rStore.Products.
                   Select(product => new
                   {
                       product.Id,
                       product.Name,
                       product.Price,
                       product.Status,
                       product.UserId,
                       product.CategoryId,
                       product.Count,
                       product.BoughtCount
                   }).Where(x => x.CategoryId == id).Where(x => x.Count > 0).ToList();
                 
                dgv_AllProductView.DataSource = products;
            }
        }
        public void SearchForName(string key)
        {
            using (RStoreDataContext rStore = new RStoreDataContext())
            {


                var products = rStore.Products.
                   Select(product => new
                   {
                       product.Id,
                       product.Name,
                       product.Price,
                       product.Status,
                       product.UserId,
                       product.CategoryId,
                       product.Count,
                       product.BoughtCount
                   }).Where(x => x.Name.Contains(key)).Where(x=>x.Count>0).ToList();

                dgv_AllProductView.DataSource = products;
            }
        }
        public void SearchForCount()
        {
            using (RStoreDataContext rStore = new RStoreDataContext())
            {


                var products = rStore.Products.
                   Select(product => new
                   {
                       product.Id,
                       product.Name,
                       product.Price,
                       product.Status,
                       product.UserId,
                       product.CategoryId,
                       product.Count,
                       product.BoughtCount
                   }).Where(x => x.Count==Convert.ToInt32(txb_SearchCount.Text)).Where(x => x.Count > 0).ToList();

                dgv_AllProductView.DataSource = products;
            }
        }

        public void GetAllProducts()
        {
            using(RStoreDataContext rStore=new RStoreDataContext())
            {
                var products = rStore.Products.Where(x => x.Count > 0).ToList();
                dgv_AllProductView.DataSource = products;
            };
        }

        private void cmb_SearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchForCategory(Convert.ToInt32(cmb_SearchCategory.SelectedValue));
        }

        private void txb_SearchPName_TextChanged(object sender, EventArgs e)
        {
            SearchForName(txb_SearchPName.Text);
        }

        private void txb_SearchCount_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchForCount();
        }
    }
}
