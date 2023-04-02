using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace try_2
{
    internal class SPC<T, G> : Interface<T> //where T : G
    {
        T ob;
        G bo;
        public SPC(T o)
        {
            ob = o;
        }
        public G GetOb()
        {
            return bo;
        }

        public T Add
        {
            set
            {
                ob = value;
            }
        }
        public T Delete
        {
            set
            {
                ob = default(T);
            }
        }
        public T Watch
        {
            get
            {
                return ob;
            }
        }
    }
    internal class GGBET<T>
    {
        T Value;
        public T Add
        {
            set
            {
                Value = value;
            }
        }
        public T Delete
        {
            set
            {
                Value = default(T);
            }
        }
        public T Watch
        {
            get
            {
                return Value;
            }
        }
    }
    internal class somebody
    {
        public int somethink;
        public somebody()
        {

        }
        public somebody(int a)
        {
            somethink = a;
        }
    }
    internal class trash<T> where T : somebody
    {
        public trash()
        {
        }
        public trash(T value)
        {
            Value = value;
        }
        public T Value;
    }
    internal class MY_CollectionType<T>
    {
        FileStream fs = null;

        public SPC<T, T> spc;
        public GGBET<T>[] ggbet;
        somebody objS;
        public trash<somebody> trash_inner;
        public MY_CollectionType(T obj){
            ggbet[0] = new GGBET<T>();
            spc = new SPC<T, T>(obj);
            objS = new somebody(5);
            trash_inner = new trash<somebody>(objS);
        }

        public void Write(string obj)
        {
            try {
                using (FileStream fs = new FileStream("File.txt", FileMode.OpenOrCreate))
                {
                    byte[] buffer = Encoding.Default.GetBytes(obj);
                    fs.WriteAsync(buffer, 0, buffer.Length);
                    fs.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("конец операции записи");
            }
        }
        public void Read()
        {
            StreamReader sr = new StreamReader("File.txt");
            string? line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            sr.Close();
        }

    }
}
