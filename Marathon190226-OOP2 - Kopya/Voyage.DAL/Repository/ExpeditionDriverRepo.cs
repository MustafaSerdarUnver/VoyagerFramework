using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voyage.Entity;

namespace Voyage.DAL.Repository
{
    public class ExpeditionDriverRepo:RepoBase<ExpeditionDriverPoco>,IRepo<ExpeditionDriverPoco>
    {
        public ExpeditionDriverRepo(DbContext vygContext):base(vygContext)
        {

        }
    }
}
