namespace RodolfoRobles.Models
{
    public abstract class Vehiculo
    {
        public float VelocidadMaxima { get; set; }
        public float VelocidadMinima { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo() { }

        public void Encender() { }

        public void Apagar() { }
    }
}