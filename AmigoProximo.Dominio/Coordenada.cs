﻿namespace AmigoProximo.Dominio
{
    public class Coordenada
    {
        public Coordenada(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        public double Latitude  { get; private set; }
        public double Longitude { get; private set; }

        public override string ToString()
        {
            return string.Concat(Latitude.ToString(), " ", Longitude.ToString()) ;
        }

    }
}
