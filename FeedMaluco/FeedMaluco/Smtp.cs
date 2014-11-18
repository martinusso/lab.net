using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedMaluco
{
    struct Smtp
    {
        public string Host { get; private set; }
        public int Port { get; private set; }
        public Boolean UseSSL { get; private set; }

        public Smtp(string host, int port, Boolean useSSL)
            : this()
        {
            Host = host;
            Port = port;
            UseSSL = useSSL;
        }

    }
}
