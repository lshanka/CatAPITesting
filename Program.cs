using System;

namespace CatAPITesting
{
    class Program
    {
        static void Main(string[] args)
        {
            TalkToCatAPI objTalkToCatAPI = new TalkToCatAPI();
            var catInfo = new CatsInformation();
            var Cats = objTalkToCatAPI.TalkToCat();


            Console.WriteLine("CAT Name, Origin", "Id", "Intelligence");
            foreach(var cat in Cats)
            {
                //Console.WriteLine(cat.ToString());
                Console.WriteLine($"Cat name: {catInfo.Name}, Origin: {catInfo.Origin}, ID:{catInfo.Id},Intelligence:{catInfo.Intelligence}");
            }

            {


                Console.ReadLine();
            }
        }
    }
}
