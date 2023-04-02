using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taska7_3
{
    public enum States
    {
        checkeds,
        uncheckeds
    }
     public class CheckButton:Button
    {
        States state;

        public States State { get => state; set => state = value; }

        public CheckButton() { }
        public  CheckButton(States State,string Caption,Pointer Startpointer)
        {
            this.State = State;
            this.Caption = Caption;
            this.Startpointer = Startpointer;
        }


        public override string ToString()
        {
              return $"State : {State}\n" +
                     $"Caption : {Caption}\n" +
                     $"Coordinats :\n" +
                     $"X : {Startpointer.X}\n" +
                     $"Y : {Startpointer.Y}\n"  ;
        }
        public override bool Equals(object obj)
        {
            CheckButton myButton = obj as CheckButton;
            if (this.Caption == myButton.Caption)
                return true;
            else
                return false;
        }
        public void Check()
        {
            if (State == States.checkeds)
                State = States.uncheckeds;
            else
                State = States.checkeds;
        }
        public void Zoom(int persent)
        {
            Startpointer.X = Startpointer.X - (Startpointer.X * persent / 100);
            Startpointer.Y = Startpointer.Y - (Startpointer.Y * persent / 100);
        }
        public double Squer()
        {
            return Startpointer.X * Startpointer.Y;
        }
     }
}
