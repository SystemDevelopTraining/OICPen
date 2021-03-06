﻿using OICPen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICPen.Services
{
    class GiveOrderDetailService
    {
        private OICPenDbContext context;

        public GiveOrderDetailService(OICPenDbContext context)
        {
            this.context = context;
        }


        /*---------------------------------------------------------------
         [役割] 発注明細の登録
         [引数] item: 登録する商品
                quantity: 数量
                order: 登録したい注文
         [返り値] なし
         ---------------------------------------------------------------*/
        public void AddGiveOrderDetail(ItemT item, int quantity, int giveOrderTID)
        {
            var orderDetails = new GiveOrderDetailT { ItemTID = item.ItemTID, Quantity = (int)quantity, GiveOrderTID = giveOrderTID, GiveOrderPurchasePrice = item.PurchasePrice };
            context.GiveOrderDetails.Add(orderDetails);
            context.SaveChanges();
        }

        public void AddGiveOrderDetail(Models.GiveOrderDetailT orderDetail)
        {
            var item = context.Items.Single(x => x.ItemTID == orderDetail.ItemTID && x.IsDeleted == false);
            AddGiveOrderDetail(item, orderDetail.Quantity, orderDetail.GiveOrderTID);
        }
    }
}