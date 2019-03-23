namespace RodolfoRobles.Models
{
    public class Submarino : Vehiculo
    {
        public float ProfundidadMaxima { get; set; }

        public void Sumergir(float metros) { }

        public override string ToString() {
            return "Modelo: " + Modelo + " Marca: " + Marca + " Profundidad Maxima: " + ProfundidadMaxima;
        }
    }
}