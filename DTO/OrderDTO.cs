using System;
using System.Collections.Generic;

namespace DTO
{
    public class OrderDTO : BaseDTO
    {
        public int? StoreId { get; set; }
        public StoreDTO Stores { get; set; }
        public int? CompanyId { get; set; }
        public CompanyDTO Companies { get; set; }
        public int? OrderChannelId { get; set; }
        public OrderChannelDTO OrderChannel { get; set; }
        public int? AddressId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? Deadline { get; set; }
        public string OrderNote { get; set; }
        public string OrderNo { get; set; }
        public int? OrderType { get; set; }
        public string OrderFrom { get; set; }
        public string RejectNote { get; set; }
        public string OrderCustomerNo { get; set; }
        public int? OrderStatuId { get; set; }
        public string? Receiver { get; set; }
        public string? DeliveryNote { get; set; }
        public int? DellveryStaffId { get; set; }
        public int? OrderStatus { get; set; }
        public StaffDTO Staff { get; set; }
        public List<OrderProductDTO> OrderProducts { get; set; }
        public List<MaterialSupplyRequestsDTO> MaterialSupplyRequests { get; set; }
        public List<OfferDTO> Offers { get; set; }
        public MeetingRecordDTO MeetingRecord { get; set; }
        public List<MeetingRecordDTO> MeetingRecords { get; set; }
        public List<SpeacialProductDescriptionDTO> speacialProductDescriptions { get; set; }
        public List<OrderMaterialDTO> OrderMaterials { get; set; }
        public List<StaffProcessDTO> StaffProcesses { get; set; }
        public StatusDTO Statuss { get; set; }
        public List<OrderNeedsDto> OrderNeeds { get; set; }


    }
}
