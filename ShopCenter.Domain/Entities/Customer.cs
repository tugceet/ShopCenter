﻿namespace ShopCenter.Domain.Entities
{
    public class Customer : BaseEntity
    {
      
        public string Name { get; set; }
        public string SurName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public ICollection<CustomerDebt> CustomerDebt { get; set; }
        
    }
}
