namespace VeterinariaApp.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public int Edad { get; set; }

        public Mascota(int id, string nombre, string especie, int edad)
        {
            Id = id;
            Nombre = nombre;
            Especie = especie;
            Edad = edad;
        }
    }
}

