using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace Model.Dao
{
    public class ProductDao
    {
        private OnlineShoeDbContext db = null;

        public ProductDao()
        {
            db = new OnlineShoeDbContext();
        }

        public long insert(Product entity)
        {

            if (isProductExist(entity))
            {
                return -1;
            }
            else
            {
                db.Product.Add(entity);
                db.SaveChanges();
                return entity.id;
            }
        }

        public bool isProductExist(Product entity)
        {
            if((from x in db.Product where x.code == entity.code select x.code) != null)
            {
                return true;
            }

            return false;
        }

        public IEnumerable<Product> listAllProduct(int pageNumber, int pageSize)
        {
            return db.Product.OrderByDescending(x => x.id).ToPagedList(pageNumber, pageSize);
        }

        public bool update(Product entity)
        {
            try
            {
                var product = db.Product.Find(entity.id);
                product.code = entity.code;
                product.description = entity.description;
                product.detail = entity.detail;
                product.images = entity.images;
                product.modifiedDate = DateTime.Now;
                product.name = entity.name;
                product.price = entity.price;
                product.promotionPrice = entity.promotionPrice;
                product.quantity = entity.quantity;
                product.status = entity.status;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool delete(Product entity)
        {
            try
            {
                var product = db.User.Find(entity.id);
                db.User.Remove(product);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public Product getProductByName(string name)
        {
            return db.Product.SingleOrDefault(x => x.name == name);
        }

        public Product getProductById(long id)
        {
            return db.Product.Find(id);
        }
    }
}
