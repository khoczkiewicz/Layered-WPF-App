namespace Hoczkiewicz.Audi.CORE
{
    class Car : Audi
    {
        public Car(string Type, int Model, int PS, int Price) : base(Type, Model, PS, Price)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
