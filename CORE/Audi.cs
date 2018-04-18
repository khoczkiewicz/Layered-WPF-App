using System;

namespace Hoczkiewicz.Audi.CORE
{
    public class Audi
    {
        private string Typ { get; set; }
        private int Model { get; set; }
        private int PS { get; set; }
        private int Price { get; set; }
        public Audi(string typ,int model,int ps,int price)
        {
            Typ = typ;
            Model = model;
            PS = ps;
            Price = price;
        }
        public override string ToString() => "Audi " + Typ + Model + " has " + PS + "PS and costs " + Price + " euro.";
    }
}
