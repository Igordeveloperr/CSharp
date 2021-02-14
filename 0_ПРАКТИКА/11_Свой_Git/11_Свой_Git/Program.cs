using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Firebase.Storage;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace _11_Свой_Git
{
    class Program
    {
        private static IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "drk6Unu1HbFeKRyniq5vHMHOaguU1pV8yYYvWA4V",
            BasePath = "https://test-4fe4f.firebaseio.com/"
        };
        static void Main(string[] args)
        {
            IFirebaseClient client = new FireSharp.FirebaseClient(config);
            // отправка запросов
            client.Push("file", File.Open(@"E:\Igor\r.txt", FileMode.Open));
            // получение данных
            FirebaseResponse response = client.Get("a");
            Console.WriteLine(response.Body);

            // работа с хранилищем файлов в firebase
            AddFileToStorage();
        }

        private static void AddFileToStorage()
        {
            var stream = File.Open(@"E:\Igor\r.txt", FileMode.Open);
            var task = new FirebaseStorage("gs://test-4fe4f.appspot.com");
            task.Child("Igor").Child("r.txt").PutAsync(stream).Progress.ProgressChanged += (s, e) => Console.WriteLine($"Progress: {e.Percentage} %");
            
        }
    }
}
