namespace WebAPI.Data.Entities
{
    public class BaseEntity<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }
    }
}
