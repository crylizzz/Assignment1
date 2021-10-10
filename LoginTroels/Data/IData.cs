using Models;

namespace LoginExample.Data
{
    public interface IData
    {
        Adult[] GetAdults();
        void AddAdult(Adult adult);
    }
}