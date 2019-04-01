using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using UmutMutafBlog.Classes;

namespace UmutMutafBlog.Models
{
    public interface IModel<T>
    {
        List<T> GetList();
    }
    public class PostModel
    {
        public string Id { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string KategoriAdı { get; set; }


        public static List<PostModel> GetList()
        {
            var returnList = new List<PostModel>();
            foreach (var item in DbFactory.PostCrud.Records)
            {
                var currentItem = new PostModel();
                currentItem.Id = item.ID;
                currentItem.Baslik = item.Baslik;
                currentItem.Icerik = item.Icerik;
                currentItem.KategoriAdı = item.Kategori.KategoriAdı;
                returnList.Add(currentItem);
            }
            return returnList;
        }
    }
}