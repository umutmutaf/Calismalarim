using DatabaseExample.Contexts;
using DatabaseExample.Entity;
using OhmCrud;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DatabaseExample.Classes
{
    public class DbFactory
    {
        private static volatile StoreContext _db = new StoreContext();

        private static volatile GenelCrud<User> _userCrud = null;
        public static GenelCrud<User> UserCrud
        {
            get
            {
                if (_userCrud==null)
                {
                    _userCrud = new GenelCrud<User>(_db, _db.Users);
                    _userCrud.CheckConnection();
                }
                return _userCrud;
            }
        }

        private static volatile GenelCrud<Product> _productCrud = null;
        public static GenelCrud<Product> ProductCrud
        {
            get
            {
                if (_productCrud == null)
                {
                    _productCrud = new GenelCrud<Product>(_db, _db.Products);
                    _productCrud.CheckConnection();
                }
                return _productCrud;
            }
        }

        private static volatile GenelCrud<Stock> _stockCrud = null;
        public static GenelCrud<Stock> StockCrud
        {
            get
            {
                if (_stockCrud == null)
                {
                    _stockCrud = new GenelCrud<Stock>(_db, _db.Stocks);
                    _stockCrud.CheckConnection();
                }
                return _stockCrud;
            }
        }

        private static volatile GenelCrud<Category> _CategoryCrud = null;
        public static GenelCrud<Category> CategoryCrud
        {
            get
            {
                if (_CategoryCrud == null)
                {
                    _CategoryCrud = new GenelCrud<Category>(_db, _db.Categories);
                    _CategoryCrud.CheckConnection();
                }
                return _CategoryCrud;
            }
        }

        private static volatile GenelCrud<CartItem> _CartItemCrud = null;
        public static GenelCrud<CartItem> CartItemCrud
        {
            get
            {
                if (_CartItemCrud == null)
                {
                    _CartItemCrud = new GenelCrud<CartItem>(_db, _db.CartItems);
                    _CartItemCrud.CheckConnection();
                }
                return _CartItemCrud;
            }
        }

        private static volatile GenelCrud<Transaction> _TransactionCrud = null;
        public static GenelCrud<Transaction> TransactionCrud
        {
            get
            {
                if (_TransactionCrud == null)
                {
                    _TransactionCrud = new GenelCrud<Transaction>(_db, _db.Transactions);
                    _TransactionCrud.CheckConnection();
                }
                return _TransactionCrud;
            }
        }
    }
}