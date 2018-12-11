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

        /*---------------------------------------------------------------
         [役割] すべての商品情報をItem型のListにして返す
         [引数] なし
         [返り値] すべての商品情報
         ---------------------------------------------------------------*/
        public List<ItemT> GetAllItems()
        {
            var items = from i in context.Items
                        orderby i.ItemTID
                        select i;

            return items.ToList();
        }

        /*---------------------------------------------------------------
         [役割] 削除されていない商品情報をItem型のListにして返す
         [引数] なし
         [返り値] 削除されていない商品情報
         ---------------------------------------------------------------*/
        public List<ItemT> GetItems()
        {
            var items = from i in context.Items
                        orderby i.ItemTID
                        where i.IsDeleted == false
                        select i;

            return items.ToList();
        }

        /*---------------------------------------------------------------
         [役割] 商品を追加する
         [引数] i: 追加したい商品情報
         [返り値] 追加した商品情報
         ---------------------------------------------------------------*/
        public ItemT AddItem(ItemT i)
        {
            var item = context.Items.Add(i);
            context.SaveChanges();

            return item;
        }

        /*---------------------------------------------------------------
         [役割] 商品情報の更新
         [引数] i: 更新したい商品情報
         [返り値] 更新した商品情報
         ---------------------------------------------------------------*/
        public ItemT UpdateItem(ItemT i)
        {
            var item = context.Items.Single(x => x.ItemTID == i.ItemTID);
            item.Name = i.Name;
            item.Hurigana = i.Hurigana;
            item.JAN = i.JAN;
            item.PurchasePrice = i.PurchasePrice;
            item.SafetyStock = i.SafetyStock;
            item.Note = i.Note;
            context.SaveChanges();

            return item;
            
        }
         /*---------------------------------------------------------------
         [役割] 商品を削除する
         [引数] i: 削除する商品ID
         [返り値] 削除した商品情報
         ---------------------------------------------------------------*/
        public ItemT DeleteItem(int id)
        {
            var item = context.Items.Single(x => x.ItemTID == id);
            item.IsDeleted = true;
            context.SaveChanges();
            return item;
        }
        /*---------------------------------------------------------------
         [役割] 名前で商品を検索
         [引数] i: 商品名
         [返り値] 一致する商品情報一覧
         ---------------------------------------------------------------*/
        public List<ItemT> FindByName(string name)
        {
            var items = context.Items.Where(x=> x.Name.Contains(name) && x.IsDeleted == false);
            return items.ToList();
        }
        /*---------------------------------------------------------------
         [役割] IDで商品を検索
         [引数] i: 更新したい商品情報
         [返り値] 更新した商品情報
         ---------------------------------------------------------------*/
        public ItemT FindByID(int id)
        {
            var item = context.Items.Single(x => x.ItemTID == id && x.IsDeleted == false);
            return item;
        }
        /*---------------------------------------------------------------
         [役割] JANで商品を検索
         [引数] i: JAN
         [返り値] JANと一致する商品
         ---------------------------------------------------------------*/
        public ItemT FindByJAN(string jan)
        {
            var item = context.Items
                .Single(x => x.JAN== jan&&x.IsDeleted==false);
            return item;
        }

        /*---------------------------------------------------------------
         [役割] 商品に対応した在庫数を返す
         [引数] id: itemID
         [返り値] 在庫数
         ---------------------------------------------------------------*/
         public int NowStock(ItemT item)
        {
            var giveOrders = context.GiveOrderDetails.Where(x => x.ItemTID == item.ItemTID && x.GiveOrderT.CompleteDate != null).ToList();
            var takeOrders = context.TakeOrderDetails.Where(x => x.ItemTID == item.ItemTID).ToList();
            return giveOrders.Aggregate(0,(acc,x) => acc + x.Quantity) - takeOrders.Aggregate(0, (acc, x) => acc + x.Quantity);
        }
    }
}
