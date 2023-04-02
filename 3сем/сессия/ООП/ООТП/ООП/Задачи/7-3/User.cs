using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taska7_3
{
    public delegate void click ();
    public delegate void resize (int x);
    
    class User
    {
       public event click Click;
       public event resize Resize;
        public void Events()
        {
            
                Click.Invoke();
                Resize.Invoke(100);
            
        }
    }
}
