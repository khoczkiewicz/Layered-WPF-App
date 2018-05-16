using System;

namespace Hoczkiewicz.Audi.CORE
{
    //Opposite to SUV "Car" is kind of limousine or hatchback.
    public class Car : Audi
    {
        public Car(string Type, int Model, int PS, int Price) : base(Type, Model, PS, Price)
        {
            if(Type=="")
                this.Type = "A"; 
        }
        
        public override string ToString()
        {
            //return "Audi " + (Type==""?"A":Type) + Model + " has " + PS + "PS and costs " + Price + " euro.";
            return "Car";
        }
    }
}
