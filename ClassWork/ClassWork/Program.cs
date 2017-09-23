using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Util;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport car = new Car();
            //  Console.WriteLine(car.getInformation());

            Transport plane = new AirPlane();
            //  Console.WriteLine(plane.getInformation());

            List<Transport> list = new List<Transport>();
            list.Add(car);
            list.Add(plane);

            foreach (Transport t in list)
            {
           //     Console.WriteLine(t.infoToWrite());
            }
            /* foreach (Transport t in list)
             {
                 Console.WriteLine(t.getInformation());
             }*/

            FileWork fw = new FileWork();
            //fw.WriteAllToFile(list);
            fw.readAllFromFile();

            Console.ReadLine();
        }
    }
}
    

