using Entity;
using System.Collections.Generic;

namespace Core
{
    public interface IOffersRepository : IRepository<Offers>
    {
        List<Offers> GetAllOffer();
        Offers getLastOffers(int id);
        List<Offers> getLastAllOffers(int id);
        //Offers getByIdOffer(int id);
    }
}
