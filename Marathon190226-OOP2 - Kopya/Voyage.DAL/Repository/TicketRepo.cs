using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voyage.Entity;

namespace Voyage.DAL.Repository
{
    public class TicketRepo:RepoBase<TicketPoco>,IRepo<TicketPoco>
    {
        public TicketRepo(DbContext vygContext):base(vygContext)
        {

        }
    }
}
