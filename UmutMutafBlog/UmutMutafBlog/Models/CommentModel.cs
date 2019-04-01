using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UmutMutafBlog.Classes;

namespace UmutMutafBlog.Models
{
    public class CommentModel
    {
        public string Id { get; set; }
        public DateTime YorumTarihi { get; set; }
        public string YorumYapanUserName { get; set; }
        public string Icerik { get; set; }
        public bool GecerliMi { get; set; }


        public static List<CommentModel> GetList()
        {
            var returnList = new List<CommentModel>();
            foreach (var item in DbFactory.CommentCrud.Records)
            {
                var currentItem = new CommentModel();
                currentItem.Id = item.ID;
                currentItem.YorumTarihi = item.OlusturmaTarihi;
                currentItem.YorumYapanUserName = item.YorumYapanKisi.KullanıcıAdı;
                currentItem.Icerik = item.Icerik;
                currentItem.GecerliMi = item.GecerliMi;
                returnList.Add(currentItem);
            }
            return returnList;

        }
    }
}