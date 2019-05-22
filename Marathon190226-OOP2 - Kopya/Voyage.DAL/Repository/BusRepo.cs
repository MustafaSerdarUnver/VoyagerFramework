using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voyage.Entity;

namespace Voyage.DAL.Repository
{
    public class BusRepo:RepoBase<BusPoco>,IRepo<BusPoco>
    {
        public BusRepo(DbContext vygContext):base(vygContext)
        {

        }
    }
}
