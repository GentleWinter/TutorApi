using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Tutor.Domain.Entities;
using Tutor.Infra.Contexts;
using Tutor.Infra.Repositories.Interfaces;

namespace Tutor.Infra.Repositories
{
    public class TutorRepository : ITutorRepository
    {
        private readonly DbSet<TutorEntity> _dbSet;
        private readonly TutorContext _dbContext;

        public TutorRepository(TutorContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TutorEntity>();
        }
        public async Task<TutorEntity?> FirstOrDefault(Expression<Func<TutorEntity, bool>> predicate)
            => await _dbSet.FirstOrDefaultAsync(predicate);
        public async Task Add(TutorEntity tutor)
            => await _dbSet.AddAsync(tutor);
        public TutorEntity Update(TutorEntity tutor)
            => _dbSet.Update(tutor).Entity;
        public void SaveChanges()
            =>_dbContext.SaveChanges();
    }
}
