﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HogarIoT
{
    class AireAcondicionado:Dispositivo
    {
        public int temperatura { get; set; }
        public Modo Mode { get; set; }
    }
}
