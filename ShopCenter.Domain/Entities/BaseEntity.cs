using System.ComponentModel.DataAnnotations;

namespace ShopCenter.Domain.Entities
{
    public class BaseEntity
    {
       
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
