namespace Clase11A;

class Program
{
    static void Main(string[] args)
    {
        //Clase Dog
        Dog d = new Dog();
        d.NombrePerro();
        d.EdadPerro();
        Console.WriteLine("\nEl nombre de su perro es: {0}", d.nombre);
        Console.WriteLine("La edad de su perro es: {0}", d.edad);  

        //Clase derivada Porton
        Porton p = new Porton();
        Console.WriteLine("\nValores iniciales...\n");
        p.MostrarEstado();
        
        Console.WriteLine("\nBloqueamos el portón..\n");
        p.Bloquear();
        p.MostrarEstado();

        Console.WriteLine("\nAbrimos la puerta y desbloqueamos el portón...\n");
        p.Abrir();
        p.Desbloquear();
        p.MostrarEstado();

    }
}
