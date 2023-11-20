using Core.IServices;
using DTO;
using System.Collections.Generic;

namespace Services.IServices
{
    public interface IOfferService : IService<OfferDTO>
    {
        void listOfferAdd(List<OfferDTO> offers);
        OfferDTO getLastOffer(int id);
    }
}
