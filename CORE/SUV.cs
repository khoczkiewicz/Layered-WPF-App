// <copyright file="SUV.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Hoczkiewicz.Audi.CORE
{
    public class SUV : Audi
    {
        public SUV(string type, int model, int ps, int price)
            : base(type, model, ps, price)
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
            // return "Audi " + Type + "Q" + Model + " has " + PS + "PS and costs " + Price + " euro.";
            return "SUV";
        }
    }
}
