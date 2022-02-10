using System.Threading.Tasks;

namespace Furever.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IAnimalRepository Animal { get; }
        Task SaveAsync();
    }
}
