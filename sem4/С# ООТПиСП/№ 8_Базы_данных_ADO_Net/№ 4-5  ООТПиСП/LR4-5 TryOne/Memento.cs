using __4_5__ООТПиСП;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4_5_TryOne
{
    public class State
    {
        public List<Product> MementoProdList;
        public string PriceMax;
        public string PriceMin;
        public string Name;
        public string Type;

        public State(List<Product> Lst, string Pmax, string Pmin, string _name, string type)
        {
            MementoProdList = Lst;
            PriceMax = Pmax;
            PriceMin = Pmin;
            Name = _name;
            Type = type;
        }
    }
    internal class Memento {

        Stack<State> UndoQeue;
        Stack<State> RedoQeue;
        public Memento() { 
            UndoQeue = new Stack<State>();
            RedoQeue = new Stack<State>();
        }

        public void SaveStatus(State st)
        {
            UndoQeue.Push(st);
            RedoQeue.Clear();
        }

        public State Undo()
        {
            if (RedoQeue.Count == 0)
                return null;

            State buff = RedoQeue.Pop();
            UndoQeue.Push(buff);

            return buff;
        }
        public State Redo()
        {
            if (UndoQeue.Count == 0)
                return null;

            State buff = UndoQeue.Pop();
            RedoQeue.Push(buff);

            return buff;
        }

    }
}
