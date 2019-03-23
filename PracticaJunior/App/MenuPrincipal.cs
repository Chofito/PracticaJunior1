using System;
using static System.Console;
using System.Drawing;
using System.Collections.Generic;
using RodolfoRobles.Pastel;
using RodolfoRobles.Interfaces;
using RodolfoRobles.Models;

namespace RodolfoRobles.App
{
    public class MenuPrincipal : IBitacora
    {
        private static List<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();

        public void Start() {
            while (true)
            {
                WriteLine("\nSeleccione lo que desea hacer".PastelWithGradient(Color.Fuchsia, Color.Yellow));
                WriteLine("1.- Crear avion");
                WriteLine("2.- Crear submarino");
                WriteLine("3.- Mostrar informacion de todos los aviones");
                WriteLine("4.- Mostrar informacion de todos los submarinos");
                WriteLine("5.- Salir");
                Write("=> ".Pastel(Color.Aquamarine));

                var entrada = int.TryParse(ReadLine(), out var result) ? result : -1;
                switch (entrada)
                {
                    case -1:
                        WriteLine("Opcion desconocida, por favor no ingrese letras o simbolos");
                        break;
                    case 1:
                        var avionTemp = new Avion();
                        Write("Ingrese la altura maxima: ".Pastel(Color.DarkSlateBlue));
                        avionTemp.AlturaMaxima = float.TryParse(ReadLine(), out var alturaMax) ? alturaMax : 0.0f;

                        Write("Ingrese la altura minima: ".Pastel(Color.SkyBlue));
                        avionTemp.AlturaMinima = float.TryParse(ReadLine(), out var alturaMin) ? alturaMin : 0.0f;

                        Write("Ingrese la marca: ".Pastel(Color.GreenYellow));
                        avionTemp.Marca = ReadLine();

                        Write("Ingrese el modelo: ".Pastel(Color.OrangeRed));
                        avionTemp.Modelo = ReadLine();

                        Write("Ingrese la velocidad maxima: ".Pastel(Color.Purple));
                        avionTemp.VelocidadMaxima = float.TryParse(ReadLine(), out var velMaxAv) ? velMaxAv : 0.0f;

                        Write("Ingrese la velocidad minima: ".Pastel(Color.BlueViolet));
                        avionTemp.VelocidadMinima = float.TryParse(ReadLine(), out var velMinAv) ? velMinAv : 0.0f;

                        CrearAvion(avionTemp);
                        break;
                    case 2:
                        var submarinoTemp = new Submarino();

                        Write("Ingrese la profundidad maxima: ".Pastel(Color.DarkSlateBlue));
                        submarinoTemp.ProfundidadMaxima = float.TryParse(ReadLine(), out var profMax) ? profMax : 0.0f;

                        Write("Ingrese la marca: ".Pastel(Color.GreenYellow));
                        submarinoTemp.Marca = ReadLine();

                        Write("Ingrese el modelo: ".Pastel(Color.OrangeRed));
                        submarinoTemp.Modelo = ReadLine();

                        Write("Ingrese la velocidad maxima: ".Pastel(Color.Purple));
                        submarinoTemp.VelocidadMaxima = float.TryParse(ReadLine(), out var velMaxSub) ? velMaxSub : 0.0f;

                        Write("Ingrese la velocidad minima: ".Pastel(Color.BlueViolet));
                        submarinoTemp.VelocidadMinima = float.TryParse(ReadLine(), out var velMinSub) ? velMaxSub : 0.0f;

                        CrearSubmarino(submarinoTemp);
                        break;
                    case 3:
                        MostrarDetalle(1);
                        break;
                    case 4:
                        MostrarDetalle(2);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        WriteLine("\nOpcion desconocida\n");
                        break;
                }
            }
        }

        public void CrearAvion(Avion avion)
        {
            Vehiculos.Add(avion);
        }

        public void CrearSubmarino(Submarino submarino)
        {
            Vehiculos.Add(submarino);
        }

        public void MostrarDetalle(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    foreach (var item in Vehiculos)
                    {
                        if(item.GetType() == typeof(Avion))
                        {
                            WriteLine(item);
                        }
                    }
                    break;
                case 2:
                    foreach (var item in Vehiculos)
                    {
                        if(item.GetType() == typeof(Submarino))
                        {
                            WriteLine(item);
                        }
                    }
                    break;
            }
        }
    }
}