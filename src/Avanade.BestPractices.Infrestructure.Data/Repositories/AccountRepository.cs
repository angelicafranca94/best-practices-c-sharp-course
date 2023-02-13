using Avanade.BestPractices.Domain.Entities;
using Avanade.BestPractices.Domain.Interfaces.Repositories;
using Avanade.BestPractices.Infrestructure.Data.Contexts;
using Avanade.BestPractices.Infrestructure.Data.Repositories.Core;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;
using Avanade.BestPractices.Domain.QueryContext;

namespace Avanade.BestPractices.Infrestructure.Data.Repositories
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(EntityContext db) : base(db)
        {

        }

        public new Task<Account> GetByIdAsync(Guid id, int queryContext = default)
        {
            return queryContext switch
            {
                (int)AccountQueryContext.GetById.StartRideValidation => 
                    _db.Accounts
                        .FirstOrDefaultAsync(x => x.Id == id),

                (int)AccountQueryContext.GetById.Details => 
                    _db.Accounts
                        .Include(x => x.Documents)
                        .FirstOrDefaultAsync(x => x.Id == id),

                _ => _db.Accounts
                        .Include(x => x.Documents)
                        .ThenInclude(x => x.DocumentParameters)
                        .FirstOrDefaultAsync(x => x.Id == id),
            };
        }
    }
}
