// <copyright file="Audi.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Hoczkiewicz.Audi.CORE
{
    using static Hoczkiewicz.Audi.INTERFACES.Interfaces;

    public class Audi : IAudi
    {
        private string type;

        private int ps;

        private int price;

        private int model;

        public Audi(string type, int model, int ps, int price)
        {
            this.type = type;
            this.model = model;
            this.ps = ps;
            this.price = price;
        }

        public string Type { get => this.type; set => this.type = value; }

        public int PS { get => this.ps; set => this.ps = value; }

        public int Price { get => this.price; set => this.price = value; }

        public int Model { get => this.model; set => this.model = value; }

        public override string ToString()
        {
            return "Audi " + this.Type + this.Model + " has " + this.PS + "PS and costs " + this.Price + " euro.";
        }
    }
}
