using System.Collections.Generic;

namespace Hoczkiewicz.Audi.INTERFACES
{
    public class INTERFACES
    {
        public interface IBL
        {
            List<CORE.Audi> GetDataBase();
        }
        public interface IDAO
        {
            List<CORE.Audi> GetAudis();
        }
    }
}
