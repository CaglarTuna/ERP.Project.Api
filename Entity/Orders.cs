using System;
using System.Collections.Generic;

namespace Entity
{
    public class Orders : Base
    {
        public int? StoreId { get; set; }
        public Stores Stores { get; set; }
        public int? CompanyId { get; set; }
        public Companies Companies { get; set; }
        public int? OrderChannelId { get; set; }
        public OrderChannel OrderChannel { get; set; }
        public int? AddressId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? Deadline { get; set; }
        public string? OrderNote { get; set; }
        public string? OrderNo { get; set; }
        public int? OrderType { get; set; }
        public string? OrderFrom { get; set; }
        public string? RejectNote { get; set; }
        public string? OrderCustomerNo { get; set; }
        public string? Receiver { get; set; }
        public string? DeliveryNote { get; set; }
        public int? DellveryStaffId { get; set; }
        public int? OrderStatus { get; set; }
        public List<OrderProducts> OrderProducts { get; set; }
        public Staffs Staff { get; set; }
        public List<MaterialSupplyRequests> MaterialSupplyRequests { get; set; }
        public List<Offers> Offers { get; set; }
        public List<MeetingRecord> MeetingRecords { get; set; }
        public List<ConsumptionMaterialStock> ConsumptionMaterialStocks { get; set; }
        public List<SawdustStock> SawdustStock { get; set; }
        public List<OrderMaterial> OrderMaterials { get; set; }
        public int? OrderStatuId { get; set; }
        public Status Statuss { get; set; }
        public List<TodoList> TodoList { get; set; }
        public List<MaterialExpertDeliverys> MaterialExpertDeliverys { get; set; }
        public List<OrderNeeds> OrderNeeds { get; set; }
    }
}