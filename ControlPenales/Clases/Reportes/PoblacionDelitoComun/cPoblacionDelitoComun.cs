﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlPenales
{
    public class cPoblacionDelitoComun
    {
        public string DelitoComun { get; set; }
        public string Sexo { get; set; }
        public int Indiciados { get; set; }
        public int Procesados { get; set; }
        public int Sentenciados { get; set; }
        public int Total { get; set; }
    }
}