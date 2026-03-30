abstract class Personal
{
    public string grado { get; set; } = "";
    public string nombre { get; set; } = "";
    public string apellido { get; set; } = "";

    public virtual void presentarse()
    {
        Console.WriteLine($"");
    }
}
public interface IRegistro
{
    void RegistrarEntrada();
    void RegistrarSalida();
}