using System;

namespace HyruleHelper.DataAccess.Models
{
    public abstract class ResourceBase
    {
        public string Id { get; set; }
        public int Version { get; set; } = 1;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Deleted { get; set; }

        public ResourceBase()
        {
            Id = Guid.NewGuid().ToString();
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
        
        public ResourceBase(string id)
        {
            Id = id ?? Guid.NewGuid().ToString();
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}