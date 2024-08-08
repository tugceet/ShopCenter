namespace ShopCenter.Domain.Entities
{
    public class CustomerDebt : BaseEntity
    {
        public int Debt { get; set; }
        public int PaidDebt { get; set; }
        public int CurrentDebt { get; set; }
        public string Description { get; set; }
        public Customer Customer { get; set; }


    }
}
