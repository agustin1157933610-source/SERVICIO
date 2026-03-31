class Pasante : Personal
{
    public override void presentarse()
    {
        Console.WriteLine($"Buen día, soy el: {grado} {nombre} {apellido}");
        Console.WriteLine($"TRABAJO Y ESTUDIO DE FORMA TEMPORAL EN EL TPS");
    }
}

class Soldado : Personal
{
    public override void presentarse()
    {
        Console.WriteLine($"Buen día, soy el: {grado} {nombre} {apellido}");
        Console.WriteLine($"TRABAJO EN APOYO DE LA PRODUCCION DE SOFTWARE DEL TPS Y BAJO BIDONES DE AGUA ");
    }
}
class Suboficial : Personal
{
    public override void presentarse()
    {
        Console.WriteLine($"Buen día, soy el: {grado} {nombre} {apellido}");
        Console.WriteLine($"SOY CUADRO PERMANENETE DENTRO DEL TPS Y CONSTANTEMENTE AJUSTO PROYECTOS😎");
    }
}

class Oficial : Personal
{
    public override void presentarse()
    {
        Console.WriteLine($"Buen día, soy el: {grado} {nombre} {apellido}");
        Console.WriteLine($"SOY EL JEFE DE LA PRODUCCION DE SOFTWARE DEL TPS Y ME ENCARGO DE LA GESTION DE PROYECTOS");
    }
}


