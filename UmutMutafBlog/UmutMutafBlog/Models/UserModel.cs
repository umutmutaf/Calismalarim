using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UmutMutafBlog.Classes;

namespace UmutMutafBlog.Models
{
    public class UserModel
    {
        public string Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullanıcıAdı { get; set; }
        public string Sifre { get; set; }
        public string Email { get; set; }
        public DateTime DogumTarihi { get; set; }


        public static List<UserModel> GetList()
        {
            var returnList = new List<UserModel>();
            foreach (var item in DbFactory.UserCrud.Records)
            {
                var currentItem = new UserModel();
                currentItem.Id = item.ID;
                currentItem.KullanıcıAdı = item.KullanıcıAdı;
                currentItem.Sifre = item.Sifre;
                currentItem.Ad = item.Ad;
                currentItem.Soyad = item.Soyad;
                currentItem.Email = item.Email;
                currentItem.DogumTarihi = item.DogumTarihi;
                returnList.Add(currentItem);
            }
            return returnList;
        }
    }
}