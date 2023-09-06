public class Dog{
    public string nombre;
    public int edad;

    public void NombrePerro(){
        Console.Write("Ingrese el nombre de su perro: ");
        nombre = Console.ReadLine();
    }

    public void EdadPerro(){
        Console.Write("Ingrese la edad de su perro: ");
        edad = Convert.ToInt32(Console.ReadLine());
    }
}