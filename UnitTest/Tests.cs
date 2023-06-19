using System.Collections.Generic;
using NUnit.Framework;
using zd3_v7;

namespace UnitTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void GetQuality_CalculatesCorrectly()
        {
            Cable cable = new Cable("Type", 4, 0.5, 10, 5);

            double quality = cable.GetQuality();

            Assert.AreEqual(0.125, quality);
        }

        [Test]
        public void AddCable_AddsCableToList()
        {
            List<Cable> cables = new List<Cable>();
            Cable cable = new Cable("Type", 4, 0.5, 10, 5);

            Cable.AddCable(cables, cable);

            Assert.AreEqual(1, cables.Count);
            Assert.AreEqual(cable, cables[0]);
        }

        [Test]
        public void RemoveCable_RemovesCableFromList_ByCable()
        {
            List<Cable> cables = new List<Cable>();
            Cable cable = new Cable("Type", 4, 0.5, 10, 5);
            Cable.AddCable(cables, cable);

            Cable.RemoveCable(cables, cable);

            Assert.AreEqual(0, cables.Count);
        }

        [Test]
        public void RemoveCable_RemovesCableFromList_ByIndex()
        {
            List<Cable> cables = new List<Cable>();
            Cable cable1 = new Cable("Type1", 4, 0.5, 10, 5);
            Cable cable2 = new Cable("Type2", 4, 0.5, 10, 5);
            Cable.AddCable(cables, cable1);
            Cable.AddCable(cables, cable2);

            Cable.RemoveCable(cables, 0);

            Assert.AreEqual(1, cables.Count);
            Assert.AreEqual(cable2, cables[0]);
        }

        [Test]
        public void GetQuality_CalculatesCorrectly_WhenP_True()
        {
            EnhancedCable cable = new EnhancedCable("Type", 4, 0.5, 10, 5, true, "Red");

            double quality = cable.GetQuality();

            Assert.AreEqual(0.25, quality);
        }

        [Test]
        public void GetQuality_CalculatesCorrectly_WhenP_False()
        {
            EnhancedCable cable = new EnhancedCable("Type", 4, 0.5, 10, 5, false, "Green");

            double quality = cable.GetQuality();

            Assert.AreEqual(0.0875, quality);
        }

        [Test]
        public void AddCable_AddsCableToDictionary()
        {
            Dictionary<string, EnhancedCable> enhancedCables = new Dictionary<string, EnhancedCable>();
            EnhancedCable cable = new EnhancedCable("Type", 4, 0.5, 10, 5, true, "Red");

            EnhancedCable.AddCable(enhancedCables, cable);

            Assert.AreEqual(1, enhancedCables.Count);
            Assert.AreEqual(cable, enhancedCables["Type"]);
        }

        [Test]
        public void RemoveCable_RemovesCableFromDictionary()
        {
            Dictionary<string, EnhancedCable> enhancedCables = new Dictionary<string, EnhancedCable>();
            EnhancedCable cable = new EnhancedCable("Type", 4, 0.5, 10, 5, true, "Red");
            EnhancedCable.AddCable(enhancedCables, cable);

            EnhancedCable.RemoveCable(enhancedCables, "Type");

            Assert.AreEqual(0, enhancedCables.Count);
        }
    }
}