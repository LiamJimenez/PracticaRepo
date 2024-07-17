using Practica.DataAccess.Data;
using Practica.DataAccess.Repository.IRepository;
using PracticaModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Practica.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db) 
        { 
            _db = db;
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj); 
        }
    }
}