namespace BookStoreManagementSystem.App.Shared.Entity
{
    public abstract class Entity : IAuditableEntity, IBaseEntity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTimeOffset.UtcNow;
            UpdatedDate = DateTimeOffset.UtcNow;
        }

        private Guid _Id;

        public virtual Guid Id
        {
            get
            {
                return _Id;
            }
            protected set
            {
                _Id = value;
            }
        }


        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }

        public void SetCreatedBy(string? userId)
        {
            CreatedBy = userId;
        }

        public void SoftDelete()
        {
            IsDeleted = true;
        }
    }
}
