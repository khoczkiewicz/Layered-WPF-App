using System.Collections.Generic;

namespace Hoczkiewicz.Audi.INTERFACES
{
    public class Interfaces
    {
        public interface IBL
        {
            List<IAudi> GetDataBase();
        }
        public interface IDAO
        {
            List<IAudi> GetAudis();
        }
        public interface IAudi
        {
            string Type { get; set; }
            int Model { get; set; }
            int PS { get; set; }
            int Price { get; set; }
        }
    }
}
