using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBusinessApi.Infrastructure.Options
{
    public class MongoClientOptions
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string DatabaseName { get; set; }
    }
}
