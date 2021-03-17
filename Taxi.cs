/*
 * Program Taxi
 * Author : 20.11.3355 Verry R. Wibawa
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Taxi
    {
        // Deklarasi properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        // Deklarasi dan juga definisi methods / fungsi
        public void TaxiInfo()
        {
            // Menampilkan nama driver
            Console.WriteLine("Driver Name\t    : {0}", DriverName);

            // Menggunakan ternary condition untuk menentukan Yes atau No berdasarkan nilai boolean
            Console.WriteLine("On Duty\t\t    : {0}", OnDuty == true ? "Yes" : "No");

            // Menampilkan jumlah penumpang
            Console.WriteLine("Number Of Passenger : {0}\n", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang.", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang.", DriverName);
        }
    }
}
