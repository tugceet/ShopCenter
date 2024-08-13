namespace ShopCenter.Application.CQRS.Comands.AdminCommands
{
    public class CreateAdminCommand
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
