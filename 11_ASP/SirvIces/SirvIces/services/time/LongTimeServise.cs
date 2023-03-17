namespace SirvIces.services.time
{
    public class LongTimeServise : ITimeService
    {
        public string GetTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
    }
}
