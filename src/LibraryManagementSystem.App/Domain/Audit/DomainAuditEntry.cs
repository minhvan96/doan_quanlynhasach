using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Text.Json;

namespace BookStoreManagementSystem.App.Domain.Audit
{
    public class DomainAuditEntry
    {
        public DomainAuditEntry(EntityEntry entry)
        {
            Entry = entry;
        }

        public EntityEntry Entry { get; }
        public string? UserId { get; set; }
        public string? TableName { get; set; }
        public Dictionary<string, object?>? KeyValues { get; } = new Dictionary<string, object?>();
        public Dictionary<string, object?>? OldValues { get; } = new Dictionary<string, object?>();
        public Dictionary<string, object?>? NewValues { get; } = new Dictionary<string, object?>();
        public AuditType AuditType { get; set; }
        public List<string> ChangedColumns { get; } = new List<string>();

        public DomainAudit ToAudit()
        {
            var audit = new DomainAudit
            {
                UserId = UserId,
                Type = AuditType.ToString(),
                TableName = TableName,
                CreatedDate = DateTimeOffset.Now,
                PrimaryKey = JsonSerializer.Serialize(KeyValues),
                OldValues = OldValues?.Count == 0 ? null : JsonSerializer.Serialize(OldValues),
                NewValues = NewValues?.Count == 0 ? null : JsonSerializer.Serialize(NewValues),
                AffectedColumns = ChangedColumns.Count == 0 ? null : JsonSerializer.Serialize(ChangedColumns)
            };
            return audit;
        }
    }
}