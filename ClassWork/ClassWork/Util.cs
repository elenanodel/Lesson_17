﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.IO;

namespace Util
{
   public class FileWork
    {
        private const string fileName = "file.txt";
        public void WriteAllToFile(List<Transport> list)
        {
            StreamWriter sw = new StreamWriter(fileName, true);
            foreach (Transport t in list)
            {
                sw.WriteLine(t.infoToWrite());                
            }
            sw.Close();
        }

        public List<Transport> readAllFromFile()
        {
            List<Transport> result = new List<Transport>();

            string[] fromFile = File.ReadAllLines(fileName);

            foreach (string s in fromFile)
            {
                string[] items = s.Split('\t');
             
                switch (items[1])
                {
                    case "Car":
                        {
                            result.Add(getCarObject(items));
                            break;
                        } 
                }
            }

            return result;
        }

        private Car getCarObject(string[] items)
        {
            Car car = new Car();

            car.Manufactor = items[2];
            car.Speed = int.Parse(items[3]);
            car.Width = double.Parse(items[4]);
            car.Height = double.Parse(items[5]);
            car.Engine = getEngine(items);
            car.Amount = int.Parse(items[10]);
            car.Transmisson = items[11];
            car.Body = items[12];

            Console.WriteLine(car.getInformation());

            return car;
        }

        private Engine getEngine(string[] items) 
        {
            Engine engine = null;

            switch (items[6])
            {
                case "PetrolEngine":
                {
                    engine = getPetrolEngine(items);
                    break;
                }
            }

            return engine;
        }

        private PetrolEngine getPetrolEngine(string[] items)
        {
            PetrolEngine petrolEngine = new PetrolEngine();

            petrolEngine.Power = int.Parse(items[7]);
            petrolEngine.Manufactor = items[8];
            petrolEngine.BlendingProcess = items[9];

            return petrolEngine;
        }
    }
}
