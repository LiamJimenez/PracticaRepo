using Practica.DataAccess.Data;
using Practica.DataAccess.Repository.IRepository;
using Practica.Models;
using PracticaModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Practica.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db) 
        { 
            _db = db;
        }
    }
}