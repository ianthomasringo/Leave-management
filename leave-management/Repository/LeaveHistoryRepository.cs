using leave_management.Contracts;
using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(LeaveRequest entity)
        {
            _db.LeaveHistories.Add(entity);
            return Save();
        }

        public bool Delete(LeaveRequest entity)
        {
            _db.LeaveHistories.Remove(entity);
            return Save();
        }

        public ICollection<LeaveRequest> FindAll()
        {
            var LeaveHistorys = _db.LeaveHistories.ToList();
            return LeaveHistorys;
        }

        public LeaveRequest FindById(int id)
        {
            var LeaveHistory = _db.LeaveHistories.Find(id);
            return LeaveHistory;
        }

        public bool isExists(int id)
        {
            var exists = _db.LeaveHistories.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(LeaveRequest entity)
        {
            _db.LeaveHistories.Update(entity);
            return Save();
        }
    }
}
