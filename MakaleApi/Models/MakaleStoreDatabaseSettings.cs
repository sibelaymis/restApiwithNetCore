using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakaleApi.Models
{
    public class MakaleStoreDatabaseSettings : IMakaleStoreDatabaseSettings
    {
        public string MakalelerCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IMakaleStoreDatabaseSettings
    {
        string MakalelerCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
