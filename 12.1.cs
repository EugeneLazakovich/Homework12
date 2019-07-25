using System;
using System.Collections;
using System.Collections.Generic;

namespace _12._1
{
    class Gen<T> where T : Item
    {
        T ob;
        public Gen(T ob)
        {
            this.ob = ob;
        }
        public void getUltimate()
        {
            ob.getUltimate();
        }
        public override string ToString()
        {
            return ob.ToString();
        }
    }
    abstract class Item
    {
        protected String name;
        protected int intel;
        protected int agil;
        protected int stren;
        public Item(String name, int intel, int agil, int stren)
        {
            this.name = name;
            this.intel = intel;
            this.agil = agil;
            this.stren = stren;
        }
        public abstract void getUltimate();
        public override string ToString()
        {
            return "Name: " + name + "; Intelligence: " + intel + "; Agility: " + agil + "; Strength: " + stren;
        }
    }
    class PhaseBoots : Item
    {
        public PhaseBoots(String name, int intel, int agil, int stren) : base(name, intel, agil, stren) { }
        public override void getUltimate()
        {
            Console.WriteLine("PhaseBoots's Ultimate");
        }
    }
    class MantaStyle : Item
    {
        public MantaStyle(String name, int intel, int agil, int stren) : base(name, intel, agil, stren) { }
        public override void getUltimate()
        {
            Console.WriteLine("MantaStyle's Ultimate");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Gen<Item> gen = new Gen<Item>(new PhaseBoots("PhaseBoots", 10, 25, 12));
            Console.WriteLine(gen);
            gen.getUltimate();
            Console.WriteLine("---------------------");
            List<Item> stringList = new List<Item>();
            stringList.Add(new PhaseBoots("PhaseBoots", 10, 25, 12));
            stringList.Add(new MantaStyle("MantaStyle", 23, 13, 13));
            stringList.Add(new PhaseBoots("PhaseBoots", 11, 23, 14));
            foreach(Item str in stringList)
            {
                Console.WriteLine(str);                
            }
        }
    }
}
