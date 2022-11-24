using TwinCAT.Ads;

namespace AdsClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            using (AdsClient client = new AdsClient())
            {
                int valueToRead = 0;
                int valueToWrite = 42;

                client.Connect(AmsNetId.Local, 851);
                //client.WriteValue("MAIN.nCounter", valueToWrite);
                valueToRead = (int)client.ReadValue("MAIN.nCounter", typeof(int));
                Console.WriteLine("Read value: " + valueToRead);
            }
            Console.WriteLine("Finished");
        }
       
    }
}