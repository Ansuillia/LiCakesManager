namespace LiCakes.Infra.Data.Interfaces
{
    public interface IContextFactory
    {
        IDatabaseContext DbContext { get; }
    }
}
