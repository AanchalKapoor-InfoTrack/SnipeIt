using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnipeIt.Configuration
{
    public class SnipeItConfiguration
    {
        public const string SnipeIt = "SnipeIt";

        public string ApiBaseUrl { get; set; }
        public string AccessToken { get; set; }
    }
}
