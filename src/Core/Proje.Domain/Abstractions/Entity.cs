namespace Proje.Domain.Abstractions
{
    public abstract class Entity
    {
        public Entity()
        {
            
        }

        public Entity(string id)
        {
            Id = id;
        }
        public string Id { get; set; }= Guid.NewGuid().ToString();
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set;}
        public DateTime? DeletedDate { get; set; }

        
    }
}
