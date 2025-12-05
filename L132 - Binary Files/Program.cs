using System;
using System.Collections.Generic;
using System.IO;

namespace L132___Binary_Files
{
    public struct Animal
    {
        public string name;
        public int height;
        public bool isAlive;
    }

    internal class Program
    {

        static void WriteAnimalsToFile(string filename, List<Animal> animals)
        {
            // Write to file
            using (BinaryWriter w = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate)))
            {
                w.Write(animals.Count);
                for (int i = 0; i < animals.Count; i++)
                {
                    w.Write(animals[i].name);
                    w.Write(animals[i].height);
                    w.Write(animals[i].isAlive);
                }
            }
        }

        static List<Animal> ReadAnimalsFromFile(string filename)
        {
            List<Animal> results = new List<Animal>();
            using (BinaryReader r = new BinaryReader(File.Open(filename, FileMode.OpenOrCreate)))
            {
                int numAnimals = r.ReadInt32();
                for (int i = 0; i < numAnimals; i++)
                {
                    Animal newAnimal;
                    newAnimal.name = r.ReadString();
                    newAnimal.height = r.ReadInt32();
                    newAnimal.isAlive = r.ReadBoolean();
                    results.Add(newAnimal);
                }
            }
            return results;
        }

        static void Main(string[] args)
        {
            string filename = "animals.matt";

            List<Animal> animals = new List<Animal>()
            {
                new Animal() {name="Orca", height=4, isAlive=true},
                new Animal() {name="Girqaffe", height=9001, isAlive=false},
                new Animal() {name="Dog", height=2, isAlive=false},
                new Animal() {name="Pigeon", height=1, isAlive=true}
            };

            WriteAnimalsToFile(filename, animals);

            List<Animal> newAnimals = ReadAnimalsFromFile(filename);

            foreach (Animal animal in newAnimals)
            {
                Console.WriteLine($"{animal.name}, height = {animal.height}, is alive = {animal.isAlive}");
            }
        }
    }
}
