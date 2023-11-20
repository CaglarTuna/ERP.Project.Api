using AutoMapper;
using Core;
using Core.IRepository;
using Core.IUnitOfWork;
using Data;
using Data.Repository;
using Data.UnitOfWork;
using DTO;
using DTO.DTOValidators;
using Entity;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.IServices;
using Services.Profiles;
using Services.Service;

namespace Services
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Erp_Context>(opt =>
            {
                opt.UseSqlServer(configuration.GetSection("Logging").GetSection("ConnectionStrings")["local"]);
            });
            var profiles = ProfileHelper.GetProfiles();

            var configurations = new MapperConfiguration(opt =>
            {
                opt.AddProfiles(profiles);
            });

            var mapper = configurations.CreateMapper();
            services.AddSingleton(mapper);
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            ///// Validasyonlar
            services.AddSingleton<IValidator<CategoryDTO>, CategoryDTOValidator>();
            services.AddSingleton<IValidator<CompanyAddressDTO>, CompanyAddressDTOValidator>();
            services.AddSingleton<IValidator<CompanyDTO>, CompanyDTOValidator>();
            services.AddSingleton<IValidator<ConsumptionMaterialDTO>, ConsumptionMaterialDTOValidator>();
            services.AddSingleton<IValidator<ConsumptionMaterialStockDTO>, ConsumptionMaterialStockDTOValidator>();
            services.AddSingleton<IValidator<ConsumptionMaterialSupplierDTO>, ConsumptionMaterialSupplierDTOValidator>();
            services.AddSingleton<IValidator<MaterialDTO>, MaterialDTOValidator>();
            services.AddSingleton<IValidator<MaterialShapeDTO>, MaterialShapeDTOValidator>();
            services.AddSingleton<IValidator<MaterialStockDTO>, MaterialStockDTOValidator>();
            services.AddSingleton<IValidator<MeetingRecordDTO>, MeetingRecordDTOValidator>();
            services.AddSingleton<IValidator<OfferDTO>, OfferDTOValidator>();
            services.AddSingleton<IValidator<OrderChannelDTO>, OrderChannelDTOValidator>();
            services.AddSingleton<IValidator<OrderDTO>, OrderDTOValidator>();
            services.AddSingleton<IValidator<OrderProductDTO>, OrderProductDTOValidator>();
            services.AddSingleton<IValidator<OrderTypeDTO>, OrderTypeDTOValidator>();
            services.AddSingleton<IValidator<ProcessDTO>, ProcessDTOValidator>();
            services.AddSingleton<IValidator<ProductDTO>, ProductDTOValidator>();
            services.AddSingleton<IValidator<ProductStockDTO>, ProductStockDTOValidator>();
            services.AddSingleton<IValidator<RawMaterialDTO>, RawMaterialDTOValidator>();
            services.AddSingleton<IValidator<RejectionDTO>, RejectionDTOValidator>();
            services.AddSingleton<IValidator<SawdustStockDTO>, SawdustStockDTOValidator>();
            services.AddSingleton<IValidator<StaffDTO>, StaffDTOValidator>();
            services.AddSingleton<IValidator<StaffProcessDTO>, StaffProccessDTOValidator>();
            services.AddSingleton<IValidator<StandDTO>, StandDTOValidator>();
            services.AddSingleton<IValidator<StoreDTO>, StoreDTOValidator>();
            services.AddSingleton<IValidator<UnitsOfMeasureDTO>, UnitsOfMeasureDTOValidator>();
            services.AddSingleton<IValidator<HeightMeasureDTO>, HeightMeasureDTOValidator>();
            services.AddSingleton<IValidator<MaterialHeightMeasureDTO>, MaterialHeightMeasureDTOValidator>();
            

            ///// Core katmanındaki Interface Repositoryler-Data katmanındaki Repositoryler
            services.AddScoped<ICategoriesRepository, CategoriesRepository>();
            services.AddScoped<ICategoriesLanguageRepository, CategoriesLanguageRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ICommonRepository, CommonRepository>();
            services.AddScoped<ICompaniesRepository, CompaniesRepository>();
            services.AddScoped<ICompanyAddressRepository, CompanyAddressRepository>();
            services.AddScoped<IConsumptionMaterialsRepository, ConsumptionMaterialsRepository>();
            services.AddScoped<IConsumptionMaterialSuppliersRepository, ConsumptionMaterialSuppliersRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<ICurrenciesRepository, CurrenciesRepository>();
            services.AddScoped<IDocumentRepository, DocumentRepository>();
            services.AddScoped<IMaterialCertificatesRepository, MaterialCertificatesRepository>();
            services.AddScoped<IMaterialRawMaterialsRepository, MaterialRawMaterialsRepository>();
            services.AddScoped<IMaterialShapeRepository, MaterialShapeRepository>();
            services.AddScoped<IMaterialsRepository, MaterialsRepository>();
            services.AddScoped<IMaterialStockRepository, MaterialStockRepository>();
            services.AddScoped<IMaterialSuppliersRepository, MaterialSuppliersRepository>();
            services.AddScoped<IMaterialUnitsOfMeasuresRepository, MaterialUnitsOfMeasuresRepository>();
            services.AddScoped<IMeetingRecordRepository, MeetingRecordRepository>();
            services.AddScoped<IOffersRepository, OffersRepository>();
            services.AddScoped<IOrderChannelRepository, OrderChannelRepository>();
            services.AddScoped<IOrderProductsRepository, OrderProductsRepository>();
            services.AddScoped<IOrdersRepository, OrdersRepository>();
            services.AddScoped<IOrderTypeRepository, OrderTypeRepository>();
            services.AddScoped<IProcessLanguageRepository, ProcessLanguagesRepository>();
            services.AddScoped<IProcessRepository, ProcessRepository>();
            services.AddScoped<IProductDocumentRepository, ProductDocumentRepository>();
            services.AddScoped<IProductMaterialsRepository, ProductMaterialsRepository>();
            services.AddScoped<IProductProcessRepository, ProductProcessRepository>();
            services.AddScoped<IProductsRepository, ProductsRepository>();
            services.AddScoped<IProductStockRepository, ProductStockRepository>();
            services.AddScoped<IRawMaterialsRepository, RawMaterialsRepository>();
            services.AddScoped<IRejectionRepository, RejectionRepository>();
            services.AddScoped<ISawdustStockRepository, SawdustStockRepository>();
            services.AddScoped<IStaffProcessPermisionsRepository, StaffProcessPermisionsRepository>();
            services.AddScoped<IStaffProcessRepository, StaffProcessRepository>();
            services.AddScoped<IStaffRolesRepository, StaffRolesRepository>();
            services.AddScoped<IStaffsRepository, StaffsRepository>();
            services.AddScoped<IStandProcessRepository, StandProcessRepository>();
            services.AddScoped<IStandsRepository, StandsRepository>();
            services.AddScoped<IStoresRepository, StoresRepository>();
            services.AddScoped<IUnitsOfMeasureRepository, UnitsOfMeasureRepository>();
            services.AddScoped<IHeightMeasureRepository, HeightMeasureRepository>();
            services.AddScoped<IMaterialHeightMeasureRepository, MaterialHeightMeasureRepository>();
            services.AddScoped<ISpeacialProductDescriptionRepository, SpeacialProductDescriptionRepository>();
            services.AddScoped<IMaterialExpertDeliverysRepository, MaterialExpertDeliverysRepository>();
            services.AddScoped<IConsumptionMaterialStockRepository, ConsumptionMaterialStockRepository>();
            services.AddScoped<IOrderMaterialRepository, OrderMaterialRepository>();
            services.AddScoped<IMaterialSupplyRequestsRepository, MaterialSupplyRequestsRepository>();
            services.AddScoped<ITodoListRepository, TodoListRepository>();
            services.AddScoped<ITodoMemberRepository, TodoMemberRepository>();
            services.AddScoped<IOrderNeedsRepository, OrderNeesRepository>();
            

            ///// Service katmanındaki Interfaceler
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICommonService, CommonService>();
            services.AddScoped<ICompanyAdressService, CompanyAdressService>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IConsumptionMaterialService, ConsumptionMaterialService>();
            services.AddScoped<IMaterialService, MaterialService>();
            services.AddScoped<IMaterialStockService, MaterialStockService>();
            services.AddScoped<IMaterialSuppliersService, MaterialSuppliersService>();
            services.AddScoped<IMeetingRecordService, MeetingRecordService>();
            services.AddScoped<IOfferService, OfferService>();
            services.AddScoped<IOrderChannelService, OrderChannelService>();
            services.AddScoped<IOrderProductService, OrderProductService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderTypeService, OrderTypeService>();
            services.AddScoped<IProcessService, ProcessService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductStockService, ProductStockService>();
            services.AddScoped<IRawMaterialService, RawMaterialService>();
            services.AddScoped<IRejectionService, RejectionService>();
            services.AddScoped<ISawdustStockService, SawdustStockService>();
            services.AddScoped<IStaffProcessService, StaffProcessService>();
            services.AddScoped<IStaffService, StaffService>();
            services.AddScoped<IStandService, StandService>();
            services.AddScoped<IStoreService, StoreService>();
            services.AddScoped<IStoresRepository, StoresRepository>();
            services.AddScoped<IUnitsOfMeasureRepository, UnitsOfMeasureRepository>();
            services.AddScoped<IConsumptionMaterialStockService, ConsumptionMaterialStockService>();
            services.AddScoped<IMaterialExpertDeliverys, MaterialExpertDeliverysService>();
            services.AddScoped<IMaterialSupplyRequestsService, MaterialSupplyRequestsService>();
            services.AddScoped<ISpecialProductDescriptionService, SpecialProductDescriptionService>();
            services.AddScoped<ITodoService, TodoService>();
            services.AddScoped<ITodoMemberService, TodoMemberService>();
            services.AddScoped<IOrderNeesService, OrderNeedService>();
        }
    }
}
