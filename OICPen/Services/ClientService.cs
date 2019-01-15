using OICPen.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICPen.Services
{
    public class ClientService
    {
        private OICPenDbContext context;

        public ClientService(OICPenDbContext context)
        {
            this.context = context;
        }

        /*---------------------------------------------------------------
         [役割] すべての会員情報をClient型のListにして返す
         [引数] なし
         [返り値] すべての会員情報
         ---------------------------------------------------------------*/
        public List<ClientT> GetClients()
        {
            var clients = from c in context.Clients
                          orderby c.ClientTID
                          select c;

            return clients.ToList();
        }

        /*---------------------------------------------------------------
         [役割] 受け取った会員情報をDBに登録する
         [引数] g: 追加する会員情報
         [返り値] 追加した情報
         ---------------------------------------------------------------*/
        public ClientT AddClient(ClientT c)
        {
            var client = context.Clients.Add(c);
            context.SaveChanges();

            return client;
        }

        /*---------------------------------------------------------------
         [役割] 会員情報の更新
         [引数] c: 更新したい会員情報
         [返り値] 更新した商品情報
         ---------------------------------------------------------------*/
        public ClientT UpdateItem(ClientT c)
        {
            var client = context.Clients.Single(x => x.ClientTID == c.ClientTID);
            client.Name = c.Name;
            client.Hurigana = c.Hurigana;
            client.Address = c.Address;
            client.PostNum = c.PostNum;
            client.PhoneNum = c.PhoneNum;

            context.SaveChanges();

            return client;

        }
        /*---------------------------------------------------------------
         [役割] IDから会員情報を検索
         [引数] id: 会員情報のID
         [返り値] IDと一致する会員情報
         ---------------------------------------------------------------*/
        public ClientT FindByID(int id)
        {
            var client = context.Clients.Single(x =>  x.ClientTID == id);
            return client;
        }

         /*---------------------------------------------------------------
         [役割] 名前から会員情報を検索
         [引数] id: 会員情報のID
         [返り値] 名前と一致する会員情報
         ---------------------------------------------------------------*/
        public List<ClientT> FindByName(string name)
        {
            var clients = context.Clients.Where(x => x.Name.Contains(name) );
            return clients.ToList();
        }
        /*---------------------------------------------------------------
         [役割] ふりがなから会員情報を検索
         [引数] id: 会員情報のID
         [返り値] ふりがなと一致する会員情報
         ---------------------------------------------------------------*/
        public List<ClientT> FindByHurigana(string hurigana)
        {
            var clients = context.Clients.Where(x => x.Hurigana.Contains(hurigana));
            return clients.ToList();
        }

    }
}
