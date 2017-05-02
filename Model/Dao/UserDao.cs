using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace Model.Dao
{
    public class UserDao
    {
        OnlineShoeDbContext db = null;

        public UserDao()
        {
            db = new OnlineShoeDbContext();

        }

        public long insert(User entity)
        {
            db.User.Add(entity);
            db.SaveChanges();
            return entity.id;
        }

        public IEnumerable<User> listAllPaging(int page, int pageSize)
        {
            return db.User.OrderByDescending(x=>x.id).ToPagedList(page, pageSize);
        }

        public User getById(string username)
        {
            return db.User.SingleOrDefault(x => x.username == username);
        }

        public int login(string username, string password)
        {
            var result = db.User.SingleOrDefault(x => x.username == username && x.password == password);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (result.status == false)
                {
                    return -1;
                }
                else
                {
                    if (result.password == password)
                    {
                        return 1;
                    }
                    else
                    {
                        return -2;
                    }
                }
            }
        }
    }
}
