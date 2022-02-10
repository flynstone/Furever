using System.Threading.Tasks;
using Furever.Entities;
using Furever.Repositories.Interfaces;

namespace Furever.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private IAnimalRepository _animalRepository;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public IAnimalRepository Animal
        {
            get
            {
                if (_animalRepository == null)
                    _animalRepository = new AnimalRepository(_context);
                return _animalRepository;
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
