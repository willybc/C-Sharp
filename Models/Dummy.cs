﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institucion.Models
{
    class Dummy
    {
        public string DummyId { get {
                return Guid.NewGuid().ToString();
            } }
    }
}
