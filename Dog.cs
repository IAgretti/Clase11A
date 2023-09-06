using static System.Console;
public class Dog{
    public string nombre = "";
    public int edad;

    public void NombrePerro(){
        Write("Ingrese el nombre de su perro: ");
        nombre = Console.ReadLine();
    }

    public void EdadPerro(){
        Write("Ingrese la edad de su perro: ");
        edad = Convert.ToInt32(Console.ReadLine());
    }
}