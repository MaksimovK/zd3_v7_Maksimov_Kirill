using System.Collections.Generic;

namespace zd3_v7
{
    public class EnhancedCable : Cable
    {
        public bool P { get; set; }
        public string Color { get; set; }

        public EnhancedCable(string type, int numberOfWires, double diameter, double lenght, double currentStrength,
            bool p, string color)
            : base(type, numberOfWires, diameter, lenght, currentStrength)
        {
            P = p;
            Color = color;
        }

        public override double GetQuality()
        {
            double q = Diameter / NumberOfWires;
            return P ? 2 * q : 0.7 * q;
        }

        public static void AddCable(Dictionary<string, EnhancedCable> enhancedCables, EnhancedCable cable)
        {
            enhancedCables.Add(cable.Type, cable);
        }

        public static void RemoveCable(Dictionary<string, EnhancedCable> enhancedCables, string type)
        {
            enhancedCables.Remove(type);
        }
    }
}