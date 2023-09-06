public class Puerta {
    protected int ancho, alto, color;
    protected bool abierta;

    public void Abrir(){
        abierta = true;
    }
    public void Cerrar(){
        abierta = false;
    }
    public void MostrarEstado(){
        Console.WriteLine("Ancho: {0}", ancho);
        Console.WriteLine("Alto: {0}", alto);
        Console.WriteLine("Color: {0}", color);
        Console.WriteLine("Abierta: {0}", abierta);
    }
} //fin de la clase Puerta

public class Porton: Puerta {
    bool bloqueada;
    public void Bloquear(){
        bloqueada = true;
    }
    public void Desbloquear(){
        bloqueada = false;
    }
    public new void MostrarEstado(){
        Console.WriteLine("Ancho: {0}", ancho);
        Console.WriteLine("Alto: {0}", alto);
        Console.WriteLine("Color: {0}", color);
        Console.WriteLine("Abierta: {0}", abierta);
        Console.WriteLine("Bloqueada: {0}", bloqueada);
    }

}