using System;

namespace CatAPITesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the TalkToCat method of TalkToCatAPI class to return an array of type CatsInformation
            TalkToCatAPI objTalkToCatAPI = new TalkToCatAPI();
            var Cats = objTalkToCatAPI.TalkToCat();

            //creating a header before ouput:
            Console.WriteLine("CAT Name, Origin,       Id,           Intelligence");

            //parsing and printing the CatsInformation array
            foreach (var cat in Cats)
            {
                Console.WriteLine($"Cat name: {cat.Name}, Origin: {cat.Origin}, ID:{cat.Id},Intelligence:{cat.Intelligence}");
            }
            Console.ReadLine();
            
        }
    }
}
