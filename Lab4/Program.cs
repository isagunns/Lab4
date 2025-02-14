using System;
using System.Collections;
using System.Collections.Generic;


namespace Lab4
{
    class Town
    {
        public string town;
        public int distance;

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] towns = {"Balçova", "Bornova", "Buca", "Çiğli", "Gaziemir", "Güzelbahçe", "Karşıyaka", "Konak",
                        "Narlıdere", "Aliağa", "Bayındır", "Bergama","Beydağ", "Çeşme", "Dikili", "Foça", "Karaburun",
                        "Kemalpaşa", "Kınık", "Kiraz", "Menderes", "Menemen", "Ödemiş", "Seferihisar", "Selçuk", "Tire",
                        "Torbalı", "Urla"};
            int[] distances = {14, 4, 10, 11, 8, 30, 6, 0, 17, 53, 78, 102, 141, 88, 105, 64, 107, 24, 119,
                          142, 23, 29, 113, 52, 76, 84, 46, 42 };

            ArrayList arrayList = new ArrayList();

            int count = 0;
            for (int i = 0; i < towns.Length;)
            {
                List<Town> townList = new List<Town>();
                int elementCount = (int)Math.Pow(2, count);
                int j;
                for (j = 0; j < elementCount; j++)
                {
                    Town objectTown = new Town();
                    objectTown.town = towns[i];
                    objectTown.distance = distances[i++];

                    townList.Add(objectTown);
                    if (i == towns.Length) { break; }
                }
                j--;
                count++;
                arrayList.Add(townList);
            }
            int index = 0;
            foreach(List<Town> tList in arrayList)
            {
                Console.WriteLine($"ArrayList Index {index}:");
                index++;
                foreach(Town tObject in tList )
                {
                    Console.WriteLine($"{tObject.town},{tObject.distance}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            
        }
    }
}


