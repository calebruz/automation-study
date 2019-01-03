using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;

namespace AutomationStudy.SandboxApp.Vehicles
{
    [TestFixture]
    public class VehiclesTests
    {
        [Test]
        public void Can_create()
        {
            var vehicle = new Vehicle("Ford", "Focus", 2018, 4);
            vehicle.Make.Should().Be("Ford");
            vehicle.Model.Should().Be("Focus");
            vehicle.Year.Should().Be(2018);
            vehicle.WheelCount.Should().Be(4);

        }

        [Test]
        public void Make_has_to_be_visible_string()
        {
            Action act = () => new Vehicle("", "Focus", 2018, 4);
            act.Should().Throw<ArgumentException>();
        }
        //switch gears to selenium testing -- start writing selenium tests
    }
}
