using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalExam;

public class Car
{
    public string CarReg { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Colour { get; set; }
    public string Fuel { get; set; }

    public Car(string carReg, string make = null, string model = null, string colour = null, string fuel = null)
    {
        CarReg = carReg;
        Make = make;
        Model = model;
        Colour = colour;
        Fuel = fuel;
    }

}
