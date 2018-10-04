// <copyright file="Car.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Hoczkiewicz.Audi.CORE
{
    // Opposite to SUV "Car" is kind of limousine or hatchback.
    public class Car : Audi
    {
        public Car(string type, int model, int ps, int price, CarColor color)
            : base(type, model, ps, price, color)
        {
            if (type == string.Empty)
            {
                this.Type = "A";
            }
        }

        public override string ToString()
        {
            // return "Audi " + (Type==""?"A":Type) + Model + " has " + PS + "PS and costs " + Price + " euro.";
            return "Car";
        }
    }
}
