namespace bibob
{
    public class User
    {
        public string Name { get; }
        public int Age { get; }
        public User(string name="",int age = 0)
        {
            if(!string.IsNullOrWhiteSpace(name) && age > 0)
            {
                Name = name;
                Age = age;
            }
            else
            {
                throw new ArgumentException("Введены неверные данные!");
            }
        }
        public User() { }
    }
}
