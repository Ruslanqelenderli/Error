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
    public partial class OperationsByCategoryForm : Form
    {
        public OperationsByCategoryForm()
        {
            InitializeComponent();
            GetAllCategories();
        }
        AdminCategoryOperationsDb adminOperationsDb = new AdminCategoryOperationsDb();
        private void btn_AddCategoryName_Click(object sender, EventArgs e)
        {
            Category category = new Category()
            {
                Name = txb_CategoryName.Text
            };
            adminOperationsDb.AddCategoryName(category);
            MessageBox.Show("Added");
            GetAllCategories();

        }

        private void GetAllCategories()
        {
            using (RStoreDataContext condext = new RStoreDataContext())
            {
                var categories = condext.Categories.ToList();
                dgv_CategoryName.DataSource = categories;

            }
        }

      

        private void dgv_CategoryName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_CategoryName.Text = dgv_CategoryName.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_UpdateCategoryName_Click(object sender, EventArgs e)
        {

            Category category = new Category()
            {
                Id=Convert.ToInt32(dgv_CategoryName.CurrentRow.Cells[0].Value),
                Name = txb_CategoryName.Text
            };
            adminOperationsDb.UpdateCategoryName(category);
            MessageBox.Show("Updated");
            GetAllCategories();
        }

        private void btn_DeleteCategoryName_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgv_CategoryName.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                adminOperationsDb.DeleteCategoryName(id);
                MessageBox.Show("Deleted");
                GetAllCategories();
            }
            else
            {
                GetAllCategories();
            }
        }
            
        
    }
}
