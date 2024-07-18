using System.Linq.Expressions;
using Tutor.Domain.Entities;

namespace Tutor.Infra.Repositories.Interfaces
{
    public interface ITutorRepository
    {
        Task<TutorEntity?> FirstOrDefault(Expression<Func<TutorEntity, bool>> predicate);
        Task Add(TutorEntity tutor);
        TutorEntity Update(TutorEntity tutor);
        Task<TutorEntity?> Get(TutorEntity entity);
        void SaveChanges();
    }
}
