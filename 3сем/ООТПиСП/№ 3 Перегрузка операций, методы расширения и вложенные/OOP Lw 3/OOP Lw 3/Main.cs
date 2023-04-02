using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lw_3
{
    static internal class MainClass
    {
        static int Main()
        {
            LW3.MyList ListOne = new();
            ListOne.AddEnd();
            ListOne += "2";
            ListOne.ViewItems();
            --ListOne;
            ListOne.ViewItems();

            LW3.MyList ListTwo = new();
            ListTwo.AddEnd();

            if (ListOne != ListTwo) Console.WriteLine("Списки не равны");
            ListOne *= ListTwo;
            ListOne.ViewItems();
            LW3.StaticOperation.CheckDuplicate(ListOne);
            LW3.StaticOperation.UpperCaseCounter(ListOne);

            LW3.MyList.Product Prod = new();
            LW3.MyList.Developer Dev = new();
            Prod.Id = 4;
            Prod.Organization = "BSTU";
            Dev.Id = 1;
            Dev.Department = "BSTU";
            Dev.FIO = "PNA";
            return 0;
        }
    }
}
