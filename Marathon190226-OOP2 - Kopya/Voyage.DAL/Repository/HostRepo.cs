using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voyage.Entity;

namespace Voyage.DAL.Repository
{
    public class HostRepo:RepoBase<HostPoco>,IRepo<HostPoco>
    {
        public HostRepo(DbContext vygContext):base(vygContext)
        {

        }
    }
}
