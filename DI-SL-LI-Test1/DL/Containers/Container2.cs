using System;
using DI_SL_LI_Test1.DL;

namespace DI_SL_LI_Test1.Containers.DL
{
    class Container2:IContainer
    {
        public bool Read() { return _Read(); }
        public bool Write(string value) { return _Write(value); }

        private bool _Read()
        {
            return true;
        }

        private bool _Write(string value)
        {
            Console.WriteLine(string.Format("Container2:{0}", value));
            return true;
        }
    }
}
