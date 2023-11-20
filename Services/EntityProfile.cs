using AutoMapper;
using DTO;
using Entity;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class EntityProfile : Profile
    {
        public EntityProfile()
        {
            CreateMap<OrderProductDTO, OrderProducts>().ReverseMap();
            CreateMap<CategoryDTO, Categories>().ReverseMap().ForMember(d => d.CategoryLanguageDTOs, opt => opt.MapFrom(c => c.CategoriesLanguage));
            CreateMap<CategoryLanguageDTO, CategoriesLanguage>().ReverseMap();
            CreateMap<CityDTO, City>().ReverseMap();
            CreateMap<CityLanguageDTO, CityLanguage>().ReverseMap();
            CreateMap<CompanyAddressDTO, CompanyAddress>().ReverseMap();
            CreateMap<CompanyDTO, Companies>().ReverseMap().ForMember(d => d.CompanyAddressDTOs, opt => opt.MapFrom(c => c.CompanyAddress));
            CreateMap<ConsumptionMaterialDTO, ConsumptionMaterials>().ReverseMap();
            CreateMap<ConsumptionMaterialStockDTO, ConsumptionMaterialStock>().ReverseMap();
            CreateMap<ConsumptionMaterialSupplierDTO, ConsumptionMaterialSuppliers>().ReverseMap();
            CreateMap<CountryDTO, Country>().ReverseMap();
            CreateMap<CountryLanguageDTO, CountryLanguage>().ReverseMap();
            CreateMap<CurrenciesDTO, Currencies>().ReverseMap();
            CreateMap<DocumentDTO, Document>().ReverseMap();
            CreateMap<MaterialCertificatesDTO, MaterialCertificates>().ReverseMap();
            CreateMap<MaterialDTO, MaterialCertificates>().ReverseMap();
            CreateMap<MaterialDTO, Materials>().ReverseMap();
            CreateMap<MaterialRawMaterialDTO, MaterialRawMaterials>().ReverseMap();
            CreateMap<MaterialShapeDTO, MaterialShape>().ReverseMap();
            CreateMap<MaterialStockDTO, MaterialStock>().ReverseMap();
            CreateMap<MaterialSupplierDTO, MaterialSuppliers>().ReverseMap();
            CreateMap<MaterialUnitsOfMeasuresDTO, MaterialUnitsOfMeasures>().ReverseMap();
            CreateMap<MeetingRecordDTO, MeetingRecord>().ReverseMap();
            CreateMap<MaterialExpertDeliverysDTO, MaterialExpertDeliverys>().ReverseMap();

            CreateMap<OfferDTO, Offers>().ReverseMap();
            CreateMap<OrderChannelDTO, OrderChannel>().ReverseMap();
            CreateMap<OrderTypeDTO, OrderType>().ReverseMap();


            CreateMap<ProcessDTO, Process>().ReverseMap().ForMember(d => d.ProcessLanguage, opt => opt.MapFrom(c => c.ProcessLanguage));
            CreateMap<ProcessDTO, Process>().ReverseMap();
            CreateMap<ProcessLanguageDTO, ProcessLanguage>().ReverseMap();
            CreateMap<ProcessLanguageDTO, ProcessLanguage>().ReverseMap();
            CreateMap<ProductDocumentDTO, ProductDocument>().ReverseMap();
            CreateMap<ProductDTO, Products>().ReverseMap();
            CreateMap<ProductMaterialDTO, ProductMaterials>().ReverseMap();
            CreateMap<ProductProcessDTO, ProductProcess>().ReverseMap();
            CreateMap<ProductStockDTO, ProductStock>().ReverseMap();
            CreateMap<ProductStockDTO, ProductStockDTO>().ReverseMap();
            CreateMap<RawMaterialDTO, RawMaterials>().ReverseMap();
            CreateMap<RejectionDTO, Rejection>().ReverseMap();
            CreateMap<RolesDTO, Roles>().ReverseMap();
            CreateMap<SawdustStockDTO, SawdustStock>().ReverseMap();
            CreateMap<StaffDTO, Staffs>().ReverseMap();
            CreateMap<StaffProcessDTO, StaffProcess>().ReverseMap();
            CreateMap<StaffProcessPermisionsDTO, StaffProcessPermisions>().ForMember(x => x.Process, opt => opt.MapFrom(c => c.ProcessDTO)).ForPath(dest => dest.Process.ProcessLanguage, opt => opt.MapFrom(c => c.ProcessDTO.ProcessLanguage)).ReverseMap();
            CreateMap<StaffRolesDTO, StaffRoles>().ReverseMap();
            CreateMap<StandDTO, Stands>().ReverseMap();
            CreateMap<StandProccessDTO, StandProcess>().ReverseMap();
            CreateMap<StoreDTO, Stores>().ReverseMap();
            CreateMap<UnitsOfMeasureDTO, UnitsOfMeasure>().ReverseMap();
            CreateMap<HeightMeasureDTO, HeightMeasure>().ReverseMap();
            CreateMap<MaterialHeightMeasureDTO, MaterialHeightMeasure>().ReverseMap();
            CreateMap<OrderDTO, Orders>().ReverseMap();
            CreateMap<MaterialSupplyRequestsDTO, MaterialSupplyRequests>().ReverseMap();
            CreateMap<OrderProductDTO, OrderProducts>().ReverseMap();
            CreateMap<SpeacialProductDescriptionDTO, SpeacialProductDescription>().ReverseMap();
            CreateMap<MaterialSupplyStatuDTO, MaterialSupplyStatu>().ReverseMap();
            CreateMap<StatusDTO, Status>().ReverseMap();
            CreateMap<OrderMaterialDTO, OrderMaterial>().ReverseMap();
            CreateMap<TodoDto, TodoList>().ReverseMap();
            CreateMap<TodoMemberDto, TodoMember>().ReverseMap();
            CreateMap<OrderNeedsDto, OrderNeeds>().ReverseMap();
        }
    }
}
