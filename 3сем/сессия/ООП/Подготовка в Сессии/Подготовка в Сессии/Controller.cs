using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Подготовка_в_Сессии
{
    public interface IAirable
    {
        public void Check();
        public void Fly();
    }

    public interface IAir
    {
        public void Check();
    }
    public abstract class Transport
    {
        public string Name;
    }
    
    public class Air : Transport, IAirable, IAir
    {
        public Air()
        {
            _status = StatusList.stop;
        }

        public int CountOfPassengers;
        public int Speed;

        public enum StatusList
        {
            fly,
            ready,
            stop
        }

        StatusList _status;
        public StatusList Status 
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        void IAirable.Check()
        {
            if (CountOfPassengers == 0 && Speed == 0)
                Status = StatusList.stop;
            if (CountOfPassengers > 0 && Speed == 0)
                Status = StatusList.ready;
            if (CountOfPassengers > 0 && Speed > 0)
                Status = StatusList.fly;
            Console.WriteLine("IAirable");
        }

        void IAir.Check()
        {
            if (CountOfPassengers > 2 && CountOfPassengers < 100 && Speed == 0)
                Status = StatusList.ready;
            Console.WriteLine("IAir");
        }

        public void Fly()
        {
            if (Status == StatusList.fly)
                Console.WriteLine("Flying");
            else
                throw new Exception("Ошибка");
        }
    }

    public static class Control
    {
        public static async void write()
        {
            // запись в файл
            using (FileStream fstream = new FileStream("File.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] buffer = Encoding.Default.GetBytes("текст");
                // запись массива байтов в файл
                await fstream.WriteAsync(buffer, 0, buffer.Length);
            }
        }
        public static void Main()
        {
            Air AirOne = new Air();
            AirOne.Name = "1";

            Air AirTwo = new Air();
            AirTwo.Name = "2";

            try
            {
                AirOne.Fly();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { 
            }

            AirOne.CountOfPassengers = 1;
            AirOne.Speed = 1;

            AirTwo.CountOfPassengers = 40;
            AirTwo.Speed = 60;

            ((IAir)AirOne).Check();
            ((IAirable)AirOne).Check();
            AirOne.Fly();

            ((IAirable)AirTwo).Check();

            write();

            List<Air> AirList = new List<Air>();
            AirList.Add(AirOne);
            AirList.Add(AirTwo);

            var selectedPeople = from p in AirList // передаем каждый элемент из people в переменную p
                                 where p.Status == Air.StatusList.fly //фильтрация по критерию
                                 select p;// выбираем объект в создаваемую коллекцию

            foreach (var p in selectedPeople)
                Console.WriteLine(p.Name);
        }
    }
}
