using System;

namespace _4_Исключения
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            // ловим исключение
            try
            {
                throw new MyShizException("произошла шизоидная ошибка в твоей жизни");
                int b = a / 0;
            }
            catch (DivideByZeroException error) when (a == 10)
            {

                Console.WriteLine("на ноль делить нельзяяя!!!!" + error.Message);
            }
            catch(MyShizException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Работа завершена");
            }
        }
    }
}
