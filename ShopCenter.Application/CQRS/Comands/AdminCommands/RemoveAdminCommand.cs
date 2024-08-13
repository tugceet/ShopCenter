namespace ShopCenter.Application.CQRS.Comands.AdminCommands
{
    public class RemoveAdminCommand
    {
        public Guid Id { get; set; }

        public RemoveAdminCommand(Guid id)
        {
            Id = id;
        }
    }
}
