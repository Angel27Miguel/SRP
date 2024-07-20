
namespace SRP
{
    public class Persona
    {
        private string nombre;
        private int edad;
        private string direccion;
        private string correoElectronico;

        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Direccion: {direccion}");
            Console.WriteLine($"coreo electronico: {correoElectronico}");
        }
    }
}
