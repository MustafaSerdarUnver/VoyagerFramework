using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voyage.Entity;

namespace Voyage.DAL.Repository
{
    public class ExpeditionHostRepo:RepoBase<ExpeditionHostPoco>,IRepo<ExpeditionHostPoco>
    {
        public ExpeditionHostRepo(DbContext vygContext):base(vygContext)
        {
            
        }
    }
}
