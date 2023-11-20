using Core;
using Entity;

namespace Data.Repository
{
    public class MeetingRecordRepository : Repository<MeetingRecord>, IMeetingRecordRepository
    {
        public MeetingRecordRepository(Erp_Context erp_Context) : base(erp_Context)
        {
        }
    }
}