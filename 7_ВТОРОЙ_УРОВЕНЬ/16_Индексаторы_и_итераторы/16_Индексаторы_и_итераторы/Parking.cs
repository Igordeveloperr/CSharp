using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16_Индексаторы_и_итераторы
{
    class Parking : IEnumerable
    {
        // индексатор
        public Car this[string number]
        {
            get
            {
                Car car = Cars.Single(car => car.Number.Equals(number));
                return car;
            }
        }
        // перегрузка индексатора
        public Car this[int position]
        {
            get
            {
                Car car = Cars[position];
                return car;
            }
        }
        private List<Car> Cars = new List<Car>();
        private const int MAX_CARS = 100;
        public string Name { get; set; }
        public int Count => Cars.Count;
        public int Add(Car car)
        {
            if (car == null) throw new ArgumentException("car");
            if(Cars.Count < MAX_CARS) Cars.Add(car);
            return Cars.Count - 1;
        }
        public void GetOut(string number)
        {
            Car car = Cars.Single(car => car.Number.Equals(number));
            if(car == null)
            {
                Console.WriteLine("такой бибики нет");
                return;
            }
            Cars.Remove(car);
            Console.WriteLine($"покинул(а) гараж {car.Name}");
        }
        // генерирую коллекцию чисел
        public IEnumerable<int> GetNumbers(int max)
        {
            int current = 0;
            for(int i = 0; i < max; i++)
            {
                current += i;
                yield return current;
            }
        }
        public IEnumerator<Car> GetEnumerator()
        {
            return Cars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Cars.GetEnumerator();
        }
    }
}
