using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace ConsoleApplication
{
    public class AuditLogRepository
    {
        DbContext _db;
        List<DbEntityEntry> _entitiesModified;
        string _userName;

        public AuditLogRepository(DbContext db)
        {
            _db = db;
        }

        // SetEntities and AddToAuditLog should be added as part of SaveChanges() in DbContext
        // http://stackoverflow.com/questions/26355486/entity-framework-6-audit-track-changes
        // http://stackoverflow.com/questions/17463415/how-to-get-list-of-modified-objects-in-entity-framework-5

        public void SetEntities()
        {
            _entitiesModified = _db.ChangeTracker.Entries().Where(x => x.State == EntityState.Modified).ToList();
        }

        public void AddToAuditLog()
        {
            _userName = "Raul";
            DateTime currentDate = DateTime.Today;

            foreach (var entry in _entitiesModified)
            {
                Insert(entry);
            }
        }

        private void Insert(DbEntityEntry entry)
        {
            // get entry type
            // get properties

            // foreach property
                // add entry info
        }

        private void Update(DbEntityEntry entry)
        {
            // get entry type
            // get properties

            // foreach property
                // add entry info
        }

        private void Delete(DbEntityEntry entry)
        {
            // get entry type
            // get properties

            // add entry info only for ID property
        }
    }

    public class AuditLog
    {
        public int ID { get; set; }
        public string Operation { get; set; } // UPDATE, INSERT, DELETE
        public string Table { get; set; }
        public string RecordID { get; set; }
        public string Field { get; set; }
        public string Value { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
    }
}
