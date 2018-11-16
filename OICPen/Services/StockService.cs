using OICPen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OICPen.Services
{
    class StockService
    {
        private OICPenDbContext context;

        public StockService(OICPenDbContext context)
        {
            this.context = context;
        }
        /*---------------------------------------------------------------
        [役割] 在庫情報一覧を表示する
        [引数] なし
        [返り値] 在庫情報一覧
        ---------------------------------------------------------------*/
        public List<StockT> GetAllStocks()
        {
            var stocks = from i in context.Stocks
                        orderby i.Date
                        select i;

            return stocks.ToList();
        }

        /*---------------------------------------------------------------
        [役割] 新たな在庫を追加する
        [引数] 新しく登録する在庫データ
        [返り値] 登録した在庫データ
        ---------------------------------------------------------------*/
        public StockT AddStock(StockT s)
        {
            var stock = context.Stocks.Add(s);
            context.SaveChanges();
            return stock;
        }

        /*---------------------------------------------------------------
        [役割] 最新の月の在庫情報一覧を取得する
        [引数] なし
        [返り値] 最新の月の在庫情報一覧
        ---------------------------------------------------------------*/
        public List<StockT> GetNowMonthStocks()
        {
            var nowStocks = (from i in context.Stocks
                          group i by i.Date).OrderByDescending(x => x.Key).First();
            return nowStocks.ToList();
        }

        /*---------------------------------------------------------------
        [役割] 商品IDから該当する在庫情報の一番新しいものを返す
        [引数] 商品ID
        [返り値] 商品IDに該当する一番新しい在庫情報
        ---------------------------------------------------------------*/
        public StockT NowFindByItemID(int id)
        {
            var nowStock = (from i in context.Stocks
                             group i by i.Date).OrderByDescending(x => x.Key).First()
                             .Single(x=>x.ItemTID==id);
            return nowStock;
        }

        /*---------------------------------------------------------------
        [役割] 商品名から該当する在庫情報の一番新しいもの一覧を返す
        [引数] 商品名
        [返り値] 商品名に該当する一番新しい在庫情報一覧
        ---------------------------------------------------------------*/
        public List<StockT> NowFindByName(string itemName)
        {
            var nowStocks = (from i in context.Stocks
                             group i by i.Date).OrderByDescending(x => x.Key).First()
                             .Where(x=>x.ItemT.Name.Contains(itemName) );
            return nowStocks.ToList();
        }
    }
}
