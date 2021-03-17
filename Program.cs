/*
 * Program Taxi
 * Author : 20.11.3355 Verry R. Wibawa
 */

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek taxi dari class Taxi
            Taxi taxi = new Taxi();

            // set nilai properties
            taxi.DriverName = "Verry";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            // pemanggilan methods
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();

        }
    }
}
