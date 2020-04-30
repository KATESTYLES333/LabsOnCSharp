﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder
{
    interface Cryptor
    {
        string Text { get; set; }
        string Key { get; set; }
        string Execute();
        
    }
}
