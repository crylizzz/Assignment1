using System.Linq;
using LoginTroels.Persistence;
using Models;

namespace LoginExample.Data
{
    public class JSONData
    {
        private readonly FileContext _fileContext;
        public Adult[] getAdults()
        {
            return _fileContext.Adults.ToArray();
        }

        public void addAdult(Adult adult)
        {
            _fileContext.Adults.Add(adult);
            _fileContext.SaveChanges();
        }
    }
}