using VeterinariaApp.Models;

namespace VeterinariaApp.Services
{
    public class MascotaService
    {
        private List<Mascota> mascotas = new List<Mascota>();

        public void Agregar(Mascota mascota)
        {
            mascotas.Add(mascota);
        }

        public List<Mascota> ObtenerTodas()
        {
            return mascotas;
        }

        public bool Eliminar(int id)
        {
            var mascota = mascotas.FirstOrDefault(m => m.Id == id);

            if (mascota != null)
            {
                mascotas.Remove(mascota);
                return true;
            }

            return false;
        }
    }
}
