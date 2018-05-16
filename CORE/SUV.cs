﻿namespace Hoczkiewicz.Audi.CORE
{
    public class SUV : Audi
    {
        public SUV(string Type, int Model, int PS, int Price) : base(Type, Model, PS, Price)
        {
            if (Type == "")
                this.Type = "Q";
            else
                this.Type = Type + "Q";
        }

        public override string ToString()
        {
            //return "Audi " + Type + "Q" + Model + " has " + PS + "PS and costs " + Price + " euro.";
            return "SUV";
        }
    }
}
