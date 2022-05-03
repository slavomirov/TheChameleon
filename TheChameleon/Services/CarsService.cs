using System.Threading.Tasks;
using TheChameleon.Data;
using TheChameleon.ViewModels;

namespace TheChameleon.Services
{
    public class CarsService
    {
        private readonly string[] allowedExtensions = new[] { "jpg", "png", "gif", "jpeg" };
        private readonly ApplicationDbContext dbContext;

        public CarsService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddAsync(CarsAddViewModel input)
        {

        }

    }
}
