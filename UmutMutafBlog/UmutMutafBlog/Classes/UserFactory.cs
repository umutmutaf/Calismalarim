﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UmutMutafBlog.Entities;

namespace UmutMutafBlog.Classes
{
    public class UserFactory
    {
        public static String SuperSecretKey = "u1m2u3t4";
        public static User GetCurrentUser(string cookieValue)
        {
            string decryptedId = OhmCryptor.OhmCryptor.Decrypt(cookieValue, SuperSecretKey);
            return DbFactory.UserCrud.Find(decryptedId);
        }
    }
}