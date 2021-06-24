using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace _7_Асинхронность_Многопоточность
{
    class Program
    {
        public static object Locker = new object();
        static void Main(string[] args)
        {
            #region threads
            // многопоточность
            Thread thread = new Thread(new ThreadStart(Work)); // создание потока
                                                               //thread.Start(); // запускаю поток

            //Thread thread2 = new Thread(new ParameterizedThreadStart(CalcRocket)); // создание потока с параметрами
            //thread2.Start(22); // запускаю поток
            #endregion
            #region async/await
            // вызываю асинхронный метод
            DoAsyncWork();
            #endregion
            #region async app
            SaveFileAsync(@"E:\\Igor\r.txt");
            Console.WriteLine("а мне поебать, я дальше работаю шо");
            #endregion
        }
        #region async/await
        // асинхронный метод
        static async Task DoAsyncWork()
        {
            Console.WriteLine("Start");
            await Task.Run(() => Work());
            await Task.Run(() => CalcRocket());
            Console.WriteLine("This is async method");
        }

        public static void Work()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Work");
            }
        }

        public static void CalcRocket()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Rocket");
            }
        }
        #endregion
        #region async app
        static async Task<bool> SaveFileAsync(string path)
        {
            bool res = await Task.Run(() => SaveFile(path));
            return res;
        }
        static bool SaveFile(string path)
        {   
            lock (Locker)
            {
                var rnd = new Random();
                string text = "";
                for (int i = 0; i < 100; i++)
                {
                    text += $"text{rnd.Next()}";
                }
                using (var strWriter = new StreamWriter(path, true, Encoding.UTF8))
                {
                    strWriter.WriteLine(text);
                }

                return true;
            }
        }
        #endregion
    }
}
