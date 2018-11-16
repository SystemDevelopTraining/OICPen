﻿using OICPen.Models;
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
         [役割] IDから会員情報を検索
         [引数] id: 会員情報のID
         [返り値] IDと一致する会員情報
         ---------------------------------------------------------------*/
        public ItemT FindByID(int id)
        {
            var item = context.Items.Single(x => x.ItemTID == id);
            return item;
        }

        /*---------------------------------------------------------------
        [役割] 名前から会員情報を検索
        [引数] id: 会員情報のID
        [返り値] 名前と一致する会員情報
        ---------------------------------------------------------------*/
        public List<ItemT> FindByName(string name)
        {
            var items = context.Items.Where(x => x.Name.Contains(name));
            return items.ToList();
        }
        /*---------------------------------------------------------------
         [役割] ふりがなから会員情報を検索
         [引数] id: 会員情報のID
         [返り値] ふりがなと一致する会員情報
         ---------------------------------------------------------------*/
        public ItemT FindByJAN(string jan)
        {
            var item = context.Items.Single(x => x.JAN == jan);
            return item;
        }
    }
}
