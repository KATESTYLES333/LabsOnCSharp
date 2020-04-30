using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder
{
    class SimpleEncryptor : Cryptor
    {
        public string Text { get; set; }
        public string Key { get; set; }

        public string Execute()
        {
            throw new NotImplementedException();
        }
    }
}
