using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UmutMutafBlog.Classes;

namespace UmutMutafBlog.Models
{
    public class CategoryModel
    {
        public string Id { get; set; }
        public string KategoriAdı { get; set; }

        public static List<CategoryModel> GetList()
        {
            var returnList = new List<CategoryModel>();
            foreach (var item in DbFactory.CategoryCrud.Records)
            {
                var currentItem = new CategoryModel();
                currentItem.Id = item.ID;
                currentItem.KategoriAdı = item.KategoriAdı;
                returnList.Add(currentItem);
            }
            return returnList;
        }
    }
}