using System;

namespace Zoo
{
    /*
     Main Story Line:
     We just bought a zoo and employ jr. high students to write queries against our db for our web site.
     We see bad final queries like 
     https://WeBoughtAZoo.com/api&location=Asia
     https://WeBoughtAZoo.com/api&location=South America?type=reptile&pen=a2#4&time
         
        We need a helper URL builder function to make errors less likely, something like,
           string url = Utilities.BuildUrl(host, name1, value1, name2, value2, ....)
           See the comments at the top of UtilitiesTest.cs for more details.
    */
    public class ZooMain
    {
        //this method is just a placeholder so the tests will run
        public static void Main2(string[] args)
        {
            string host = "https://WeBoughtAZoo.com/api";
            var url = host + "?location=Africa";
            Console.Out.WriteLine("url = {0}", url);
            Console.In.ReadLine();
        }
    }
}
