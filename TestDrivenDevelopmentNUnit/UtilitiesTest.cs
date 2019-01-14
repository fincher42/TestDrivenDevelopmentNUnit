using System;
using NUnit.Framework;
using Zoo;

namespace Test.Zoo
{
    /*
       Main Story Line:
       We just bought a zoo and employ jr. high students to write queries against our db for our web site
       to create pages based on themes, like a page showing all reptiles from Asia or what animal is in pen #16.
       But our students have a hard time with the URL syntax and we see bad queries like 
       https://WeBoughtAZoo.com/api&location=Asia
       https://WeBoughtAZoo.com/api&location=South America?type=reptile&animal's pen=#16&time
       
       We need a helper URL builder function to make errors less likely, something like,
       string url = Utilities.BuildUrl(host, name1, value1, name2, value2, ....)
        
     Five Workshop tasks: 
         Your job is to incrementally build and test a method called "BuildUrl"
         that will iteratively pass the following tests.  
         One person should write a test that fails, another updates the BuildUrl method to make it pass.  
         With 5 tasks, 10 people can participate.
         Each time you update the BuildUrl, change it just enough to pass the test.
     1. Passing a single, simple name-value pair:
        string url = BuildUrl(host, "location","Africa");
     2. Name-value pair with non-url friendly characters:
        string url = BuildUrl(host, "animal pen","#16"); //(note: # in hex is 23) hint: HttpUtility.UrlEncode()
     3. Multiple name-value pairs
        string url = BuildUrl(host, "type","mammal","continent","Africa","size","small","food appetite","carnivore","animal pen","#16"); //hint:  fn(..., params string[] nameValuePairs)
     4. Check for bad number of parameters
        string url = BuildUrl(host, "type","mammal","continent");
     5. Check for bad host value
    */
    [TestFixture]
    public class UtilitiesTest
    {
        //example for task 1.
        [Test]
        public void BuildUrl_SimpleUrl_Good_Input()
        {
            // Arrange
            string host = "https://www.WeBoughtAZoo.com/api";
            string name = "location";
            string value = "Africa";

            // Act
            var url = Utilities.BuildUrl(host, name, value);
            Console.Out.WriteLine("url = {0}", url);

            // Assert
            Assert.AreEqual("https://www.WeBoughtAZoo.com/api?location=Africa", url);
        }
    }
}
