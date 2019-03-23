namespace RodolfoRobles.Models
{
    public class Avion : Vehiculo
    {
        public float AlturaMaxima { get; set; }
        public float AlturaMinima { get; set; }

        public void Despegar() { }
        public void Aterrizar() { }
        public void DisminuirAltur(float pie) { }

        public override string ToString() {
            return "Modelo: " + Modelo + " Marca: " + Marca + " Altura Maxima: " + AlturaMaxima + " Altura Minima: " + AlturaMinima;
        }
    }
}