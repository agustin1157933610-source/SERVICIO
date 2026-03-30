class Registro : IRegistro
{
    public int Id { get; set; }
    public Personal? Persona { get; set; }

    public DateTime horaentrada { get; private set; }
    public DateTime horasalida { get; private set; }

    public void RegistrarEntrada()
    {
        horaentrada = DateTime.Now;
        Console.WriteLine($"Entrada registrada a las {horaentrada.ToString("HH:mm:ss")}");
    }

    public void RegistrarSalida()
    {
        horasalida = DateTime.Now;
        Console.WriteLine($"Salida registrada a las {horasalida.ToString("HH:mm:ss")}");
    }
}