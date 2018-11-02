using OICPen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICPen.Services
{
    public class ItemService
    {
        private OICPenDbContext context;
        public ItemService(OICPenDbContext context)
        {
            this.context = context;
        }

        
        public List<Item> GetAllItems()
        {
            var query = from i in context.Items
                        orderby i.Id
                        select i;

            return query.ToList();
        }

        public Item AddItem(Item i)
        {
            var item = context.Items.Add(i);
            context.SaveChanges();

            return item;
        }

        public Item UpdateItem(Item i)
        {
            var item = context.Items.Single(x => x.Id == i.Id);
            item.Name = i.Name;
            item.Hurigana = i.Hurigana;
            item.JAN = i.JAN;
            item.PurchasePrice = i.PurchasePrice;
            item.SafetyStock = i.SafetyStock;
            item.Note = i.Note;
            context.SaveChanges();

            return item;
            
        }
    }
}
