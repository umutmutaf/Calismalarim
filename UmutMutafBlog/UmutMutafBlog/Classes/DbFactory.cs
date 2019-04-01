using OhmCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UmutMutafBlog.Entities;

namespace UmutMutafBlog.Classes
{
    public class DbFactory
    {
        private static BlogModel _db = new BlogModel();
        private static volatile GenelCrud<User> _userCrud = null;
        public static GenelCrud<User> UserCrud
        {
            get
            {
                if (_userCrud == null)
                {
                    _userCrud = new GenelCrud<User>(_db, _db.Users);
                }
                return _userCrud;
            }
        }
        private static volatile GenelCrud<Category> _categoryCrud = null;

        public static GenelCrud<Category> CategoryCrud
        {
            get
            {
                if (_categoryCrud == null)
                {
                    _categoryCrud = new GenelCrud<Category>(_db, _db.Categories);
                }
                return _categoryCrud;
            }
        }

        private static volatile GenelCrud<Post> _postCrud = null;

        public static GenelCrud<Post> PostCrud
        {
            get
            {
                if (_postCrud == null)
                {
                    _postCrud = new GenelCrud<Post>(_db, _db.Posts);
                }
                return _postCrud;
            }
        }
        private static volatile GenelCrud<Comment> _commentCrud = null;

        public static GenelCrud<Comment> CommentCrud
        {
            get
            {
                if (_commentCrud == null)
                {
                    _commentCrud = new GenelCrud<Comment>(_db, _db.Comments);
                }
                return _commentCrud;
            }
        }
    }
}
