using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taska7_3
{//21:40 22:11 //22:26 22:50
    public class Button
    {
        private string caption;
        private Pointer startpointer;

        public string Caption { get => caption; set => caption = value; }
        internal Pointer Startpointer { get => startpointer; set => startpointer = value; }
    }
}
