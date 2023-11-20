using Core.IServices;
using DTO;
using Entity;
using System.Collections.Generic;

namespace Services.IServices
{
    public interface IMaterialService : IService<MaterialDTO>
    {
        void SaveCertificate(MaterialCertificatesDTO material);
        List<MaterialCertificatesDTO> getMaterialCertificate(int id);
        bool deleteCertificate(int id);
        List<MaterialExpertDeliverysDTO> GetExpertDelivery();
    }
}
