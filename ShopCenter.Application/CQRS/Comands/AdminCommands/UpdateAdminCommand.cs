namespace ShopCenter.Application.CQRS.Comands.AdminCommands
{
    public class UpdateAdminCommand
    {
        public DateTime CreatedDate { get; set; }
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
