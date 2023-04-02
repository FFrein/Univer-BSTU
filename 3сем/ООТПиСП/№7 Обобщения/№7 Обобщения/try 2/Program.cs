namespace try_2
{
    static class Home
    {
        static void Main()
        {
            SPC<int, string> objInt = new SPC<int, string>(1);
            SPC<double, double> objDb = new SPC<double, double>(1.123);
            SPC<string, string> objStr = new SPC<string, string>("str");

            Console.WriteLine(objInt.Watch);
            Console.WriteLine(objDb.Watch);
            Console.WriteLine(objStr.Watch);

            Console.WriteLine("\n");

            MY_CollectionType<string> obj2 = new MY_CollectionType<string>("13");
            obj2.spc.Add = "10";
            obj2.ggbet[0].Add = "99";
            Console.WriteLine(obj2.spc.Watch);
            Console.WriteLine(obj2.ggbet[0].Watch);
            Console.WriteLine(obj2.trash_inner.Value.somethink);
            obj2.ggbet[0].Delete = "";

            Console.WriteLine(obj2.ggbet[0].Watch);

            obj2.Write(Convert.ToString(obj2.trash_inner.Value.somethink));
            obj2.Read();
        }
    }
}