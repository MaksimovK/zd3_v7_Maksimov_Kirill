using System;
using System.Collections.Generic;

namespace zd3_v7
{
    public class Cable
    {
        public string Type { get; set; }
        public int NumberOfWires { get; set; }
        public double Diameter { get; set; }
        public double Lenght { get; set; }
        public double CurrentStrength { get; set; }


        public Cable(string type, int numberOfWires, double diameter, double lenght, double currentStrength)
        {
            Type = type;
            NumberOfWires = numberOfWires;
            Diameter = diameter;
            Lenght = lenght;
            CurrentStrength = currentStrength;
        }


        public virtual double GetQuality()
        {
            double q = Diameter / NumberOfWires;
            return q;
        }


        public static void AddCable(List<Cable> cables, Cable cable)
        {
            cables.Add(cable);
        }

        public static void RemoveCable(List<Cable> cables, Cable cable)
        {
            cables.Remove(cable);
        }

        public static void RemoveCable(List<Cable> cables, int index)
        {
            cables.RemoveAt(index);
        }
    }
}