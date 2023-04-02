﻿using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace LW4
{
    class Game<T>
    {
        public T Name { get; set; }
        public Game(T value)
        {
            Name = value;
        }
        public override string ToString()
        {
            return $"Name:{Name}\n";
        }

        public static async Task ExempleUsing()
        {
            Game<string>[] GameL = new Game<string>[3]
            {
                new Game<string>("1"),
                new Game<string>("2"),
                new Game<string>("3"),
            };
            foreach (var gm in GameL)
                Console.WriteLine(gm);
        }
    }
    class Games<T> : IEnumerable<T>
    {
        private Game<T>[] gm;
        public Games(Game<T>[] gArray)
        {
            gm = new Game<T>[gArray.Length];

            for (int i = 0; i < gArray.Length; i++)
            {
                gm[i] = gArray[i];
            }
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>) GetEnumeratorT();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public GamesEnum<T> GetEnumeratorT()
        {
            return new GamesEnum<T>();
        }
        public GamesEnum GetEnumerator()
        {
            return new GamesEnum();
        }
    }
    public class GamesEnum : IEnumerator
    {
        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
    public class GamesEnum<T> : IEnumerator<T>
    {
        T IEnumerator<T>.Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
    class BC_Manipulate
    {
        public static async Task BC_AddTakeCompleteAdding()
        {
            using (BlockingCollection<Game<string>> BCOl = new BlockingCollection<Game<string>>())
            {
                Task tsk1 = Task.Run(() =>
                {
                    BCOl.Add(new Game<string>("Игра1"));
                    BCOl.Add(new Game<string>("Игра2"));
                    BCOl.Add(new Game<string>("Игра3"));
                    BCOl.Add(new Game<string>("Игра4"));
                    BCOl.CompleteAdding();
                });

                Task tsk2 = Task.Run(() =>
                {
                    try
                    {
                        while (true) Console.WriteLine(BCOl.Take());
                    }
                    catch (InvalidOperationException)
                    {
                        Console.WriteLine("That's All!");

                    }
                });

                await Task.WhenAll(tsk1, tsk2);
            }
        }
    }

    class DC_and_List_Manipulate
    {
        public static async Task BC_and_List_Using()
        {
            Game<string> gm4 = new Game<string>("Игра4");
            BlockingCollection<Game<string>> BCOl = new BlockingCollection<Game<string>>();
            BCOl.Add(new Game<string>("Игра1"));
            BCOl.Add(new Game<string>("Игра2"));
            BCOl.Add(new Game<string>("Игра3"));
            BCOl.Add(gm4);
            BCOl.CompleteAdding();

            List<Game<string>> GameList = new List<Game<string>>();

            foreach (var gm in BCOl)
            {
                GameList.Add(gm);
            }
            foreach (var gm in GameList)
            {
                Console.WriteLine(gm);
            }
            //проверка содержания элемента
            Console.WriteLine(GameList.Contains(gm4));
        }
    }

    class LastTask
    {
        public static async Task StartTask()
        {
            ObservableCollection<Game<string>> ObsColl = new ObservableCollection<Game<string>>()
            {
                new Game<string>("Игра1"),
                new Game<string>("Игра2")
            };
            ObsColl.CollectionChanged += ObsColl_CollectionChanged;

            ObsColl.Add(new Game<string>("Killer_Bob"));

            void ObsColl_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
            {
                switch (e.Action)
                {
                    case NotifyCollectionChangedAction.Add: // если добавление
                        if (e.NewItems?[0] is Game<string> newPerson)
                            Console.WriteLine($"Добавлен новый объект: {newPerson.Name}");
                        break;
                    case NotifyCollectionChangedAction.Remove: // если удаление
                        if (e.OldItems?[0] is Game<string> oldPerson)
                            Console.WriteLine($"Удален объект: {oldPerson.Name}");
                        break;
                    case NotifyCollectionChangedAction.Replace: // если замена
                        if ((e.NewItems?[0] is Game<string> replacingPerson) &&
                            (e.OldItems?[0] is Game<string> replacedPerson))
                            Console.WriteLine($"Объект {replacedPerson.Name} заменен объектом {replacingPerson.Name}");
                        break;
                }
            }
        }
    }
    class Home
    {
        public async static Task Main()
        {
            //task a,b,c
            Console.WriteLine("--------------------\nTask: a,b,c\n");
            await BC_Manipulate.BC_AddTakeCompleteAdding();
            Console.WriteLine("\n");
            await Game<object>.ExempleUsing();

            //task d,e
            Console.WriteLine("--------------------\nTask: d,e, f\n");
            await DC_and_List_Manipulate.BC_and_List_Using();

            Console.WriteLine("--------------------\nTask: 3\n");
            await LastTask.StartTask();
            /*
            //неnew Game<string>("Игра4") реализованная часть
            Games<string> GamesList = new Games<string>(GameL);
            try
            {
                foreach (var gm in GamesList)
                    Console.WriteLine(gm);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            */
        }
    }
}