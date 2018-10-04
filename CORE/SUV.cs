// <copyright file="SUV.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Hoczkiewicz.Audi.CORE
{
    public class SUV : Audi
    {
        public SUV(string type, int model, int ps, int price, CarColor color)
            : base(type, model, ps, price, color)
        {
            if (type == string.Empty)
            {
                this.Type = "Q";
            }
            else
            {
                this.Type = type + "Q";
            }
        }

        public override string ToString()
        {
            return "Audi " + this.Type + "Q" + this.Model + " has " + this.PS + "PS and costs " + this.Price + " euro.";

            // return "SUV";
        }
    }
}
