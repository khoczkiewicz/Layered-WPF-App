namespace Hoczkiewicz.Audi.CORE
{
    class SUV : Audi
    {
        public SUV(string Type, int Model, int PS, int Price) : base(Type, Model, PS, Price)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
