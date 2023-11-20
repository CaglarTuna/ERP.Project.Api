using Data.Configuration;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Erp_Context : DbContext
    {
        public Erp_Context(DbContextOptions<Erp_Context> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriesConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriesLanguageConfiguration());
            modelBuilder.ApplyConfiguration(new CompaniesConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyAddressConfiguration());
            modelBuilder.ApplyConfiguration(new ConsumptionMaterialsConfiguration());
            modelBuilder.ApplyConfiguration(new ConsumptionMaterialStockConfiguration());
            modelBuilder.ApplyConfiguration(new ConsumptionMaterialSuppliersConfiguration());
            modelBuilder.ApplyConfiguration(new CurrenciesConfiguration());
            modelBuilder.ApplyConfiguration(new DocumentsConfiguration());
            modelBuilder.ApplyConfiguration(new LanguagesConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialCertificatesConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialExpertDeliverysConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialRawMaterialsConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialsConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialShapeConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialStockConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialSuppliersConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialSupplyRequestsConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialUnitsOfMeasuresConfiguration());
            modelBuilder.ApplyConfiguration(new MeetingRecordConfiguration());
            modelBuilder.ApplyConfiguration(new OffersConfiguration());
            modelBuilder.ApplyConfiguration(new OrderChannelConfiguration());
            modelBuilder.ApplyConfiguration(new OrderProductsConfiguration());
            modelBuilder.ApplyConfiguration(new OrdersConfiguration());
            //modelBuilder.ApplyConfiguration(new OrderTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProcessConfiguration());
            modelBuilder.ApplyConfiguration(new ProcessLanguagesConfiguration());
            modelBuilder.ApplyConfiguration(new ProductDocumentConfiguration());
            modelBuilder.ApplyConfiguration(new ProductMaterialsConfiguration());
            modelBuilder.ApplyConfiguration(new ProductProcessConfiguration());
            modelBuilder.ApplyConfiguration(new ProductsConfiguration());
            modelBuilder.ApplyConfiguration(new ProductStockConfiguration());
            modelBuilder.ApplyConfiguration(new RawMaterialsConfiguration());
            modelBuilder.ApplyConfiguration(new RolesConfiguration());
            modelBuilder.ApplyConfiguration(new SawdustStockConfiguration());
            modelBuilder.ApplyConfiguration(new SpeacialProductDescriptionConfiguration());
            modelBuilder.ApplyConfiguration(new StaffProcessConfiguration());
            modelBuilder.ApplyConfiguration(new StaffProcessPermisionsConfiguration());
            modelBuilder.ApplyConfiguration(new StaffRolesConfiguration());
            modelBuilder.ApplyConfiguration(new StaffsConfiguration());
            modelBuilder.ApplyConfiguration(new StandProcessConfiguration());
            modelBuilder.ApplyConfiguration(new StandsConfiguration());
            modelBuilder.ApplyConfiguration(new StoresConfiguration());
            modelBuilder.ApplyConfiguration(new TodoListConfiguration());
            modelBuilder.ApplyConfiguration(new UnitsOfMeasureConfiguration());
            modelBuilder.ApplyConfiguration(new HeightMeasureConfiguration());
            modelBuilder.ApplyConfiguration(new StatusConfiguration());
            modelBuilder.ApplyConfiguration(new OrderMaterialConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialSupplyStatuConfiguration());
            modelBuilder.ApplyConfiguration(new TodoMemberConfiguration());
            modelBuilder.ApplyConfiguration(new OrderNeedsConfiguration());
        }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<CategoriesLanguage> CategoriesLanguages { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<CityLanguage> CityLanguage { get; set; }
        public DbSet<Companies> Companies { get; set; }
        public DbSet<CompanyAddress> CompanyAddress { get; set; }
        public DbSet<ConsumptionMaterials> ConsumptionMaterials { get; set; }
        public DbSet<ConsumptionMaterialStock> ConsumptionMaterialStock { get; set; }
        public DbSet<ConsumptionMaterialSuppliers> ConsumptionMaterialSuppliers { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<CountryLanguage> CountryLanguage { get; set; }
        public DbSet<Currencies> Currencies { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Languages> Languages { get; set; }
        public DbSet<MaterialCertificates> MaterialCertificates { get; set; }
        public DbSet<MaterialExpertDeliverys> MaterialExpertDeliverys { get; set; }
        public DbSet<MaterialRawMaterials> MaterialRawMaterials { get; set; }
        public DbSet<Materials> Materials { get; set; }
        public DbSet<MaterialShape> MaterialShapes { get; set; }
        public DbSet<MaterialStock> MaterialStock { get; set; }
        public DbSet<MaterialSuppliers> MaterialSuppliers { get; set; }
        public DbSet<MaterialSupplyRequests> MaterialSupplyRequests { get; set; }
        public DbSet<MaterialUnitsOfMeasures> MaterialUnitsOfMeasures { get; set; }
        public DbSet<MeetingRecord> MeetingRecord { get; set; }
        public DbSet<Offers> Offers { get; set; }
        public DbSet<OrderChannel> OrderChannel { get; set; }
        public DbSet<OrderProducts> OrderProducts { get; set; }
        public DbSet<Orders> Orders { get; set; }
        //public DbSet<OrderType> OrderTypes { get; set; }
        public DbSet<Process> Process { get; set; }
        public DbSet<ProcessLanguage> ProcessLanguages { get; set; }
        public DbSet<ProductDocument> ProductDocuments { get; set; }
        public DbSet<ProductMaterials> ProductMaterials { get; set; }
        public DbSet<ProductProcess> ProductProcess { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductStock> ProductStock { get; set; }
        public DbSet<RawMaterials> RawMaterials { get; set; }
        public DbSet<Rejection> Rejections { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<SawdustStock> SawdustStock { get; set; }
        public DbSet<SpeacialProductDescription> SpeacialProductDescription { get; set; }
        public DbSet<StaffProcess> StaffProcess { get; set; }
        public DbSet<StaffProcessPermisions> StaffProcessPermisions { get; set; }
        public DbSet<StaffRoles> StaffRoles { get; set; }
        public DbSet<Staffs> Staffs { get; set; }
        public DbSet<StandProcess> StandProcess { get; set; }
        public DbSet<Stands> Stands { get; set; }
        public DbSet<Stores> Stores { get; set; }
        public DbSet<TodoList> TodoList { get; set; }
        public DbSet<UnitsOfMeasure> UnitsOfMeasure { get; set; }
        public DbSet<HeightMeasure> HeightMeasures { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<OrderMaterial> OrderMaterials { get; set; }
        public DbSet<MaterialSupplyStatu> MaterialSupplyStatus { get; set; }
        public DbSet<TodoMember> TodoMembers { get; set; }
        public DbSet<OrderNeeds> OrderNeeds { get; set; }
    }
}