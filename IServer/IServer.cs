﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IocpServer
{
    public interface IServer
    {
        void Start();

        void PrintCurrentConnections();
    }
}
