using Microsoft.EntityFrameworkCore;

using SiteYonetimData_Access.Abstract;
using SiteYonetimData_Access.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimData_Access.Repostories
{
    public class GenericRepostory<T> : IRepostory<T> where T : class
    {
        SiteYonetimDbContext DbContext = new SiteYonetimDbContext();
        DbSet<T> _object;
        public GenericRepostory()
        {
            _object = DbContext.Set<T>();
        }
        public void Delete(T p)
        {
            _object.Remove(p);  
            DbContext.SaveChanges();    
        }

        public void Insert(T p)
        {
           _object.Add(p);
            DbContext.SaveChanges();
        }
        public void Update(T p)
        {
            DbContext.SaveChanges();
        }
        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

    }
}
