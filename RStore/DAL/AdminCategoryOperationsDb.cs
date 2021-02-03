using RStore.DataContext;
using RStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RStore.DAL
{
    public class AdminCategoryOperationsDb
    {
        public  void AddCategoryName(Category category)
        {
            using(RStoreDataContext condext=new RStoreDataContext())
            {
                condext.Categories.Add(category);
                condext.SaveChanges();
            }
        }
        public void UpdateCategoryName(Category category)
        {
            using (RStoreDataContext condext = new RStoreDataContext())
            {
                condext.Categories.AddOrUpdate(category);
                condext.SaveChanges();
            }
        }
        public void DeleteCategoryName(int id)
        {
            using (RStoreDataContext condext = new RStoreDataContext())
            {
                var category = condext.Categories.Where(x => x.Id == id).FirstOrDefault();
                condext.Categories.Remove(category);
                condext.SaveChanges();
            }
        }
    }
}
