namespace Core.Interfases;

public interface IUnitOfWork
{
    IUsuarioRepository Usuarios { get; }
    Task<int> SaveAsync();
}
