using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        
        static void Main()
        {
            bool run = true;
           // while run = true it will ask for the student number and ask which information do you want to know.
            while (run == true)
            {
                int input;
                Console.WriteLine("Which student would you like to learn more about? Enter a number between 0 and 13");
                input = int.Parse(Console.ReadLine());
                string name = getName(input);
                Console.WriteLine("Student " + input + " is " + name+". What would you like to know about "+name+"?");
                Console.WriteLine("0-Food to Taco Bar\n" + "1-Hometown\n" + "2-Age\n" + "Please enter the number of the menu item you want to know more about");
                int input2 = int.Parse(Console.ReadLine());
                string menuList = getMenu(input2);
                getInfo(input2, name);               
                
            }
        }
        //this method lists the students names and it will correspond with the index number to choose the name.
        public static string getName(int x)
        {
            if (x <= 13)
            {
                List<string> names = new List<string>();
                names.Add("Diane Watts");
                names.Add("Christopher Helgeson");
                names.Add("Ariana Waller");
                names.Add("Doreen Troyer");
                names.Add("Jillane Cook");
                names.Add("JJ Ryan");
                names.Add("Kelsey Perdue");
                names.Add("Megan Norton");
                names.Add("Ryan Slager");
                names.Add("Sabrina Mason");
                names.Add("Stephanie Banks");
                names.Add("Tommy Waalkes");
                names.Add("Tori Boone");
                names.Add("Josh Winchester");
                string name = (names[x]);
                return name;
            }
            else //this part of the method will give an error message if its not within the scope of the list.
            {
                Console.WriteLine("I am sorry that student doesn't exist please re-enter a number between 1 and 14");
                int input = int.Parse(Console.ReadLine());
                string name = getName(input);
                return name;
            }
        }
        public static string getMenu(int y) //this method lists the menu items
        {
            List<string> menu = new List<string>();
            menu.Add("Food to Taco Bar");
            menu.Add("Hometown");
            menu.Add("Age");
            string menuList = (menu[y]);
            return menuList;
        }
        public static void getInfo(int x, string y) //this method gives the appropriate information based on the menu item chosen.
        {
            bool more = true;
            while (more == true)
            {
                if (x == 0)
                {
                    string food = getFood(x);
                    Console.WriteLine(y + " is bringing " + food);
                                       

                }
                else if (x == 1)
                {
                    string Hometown = getHomeTown(x);
                    Console.WriteLine(y + " is from " + Hometown);
                    
                    

                }
                else if (x == 2)
                {
                    string age = getAge(x);
                    Console.WriteLine(y + " is " + age);
                    
                    
                }
                else //if the number chosen is out of scope it will give the below error message.
                {
                    Console.WriteLine("I did not understand");
                    Console.WriteLine("0-Food to Taco Bar\n" + "1-Hometown\n" + "2-Age\n" + "Please enter the number of the menu item you want to know more about");
                    int input3 = int.Parse(Console.ReadLine());
                    getInfo(input3, y);
                    
                    
                    
                }
                more = getMoreInfo(y);
            }
            
            
        }
        public static string getFood(int x) //This method lists and corresponds the food to the name indexes.
        {
            List<string> food = new List<string>();
            food.Add("soft taco shells");
            food.Add("hard taco shells");
            food.Add("salsa");
            food.Add("snacks");
            food.Add("onion, tomatoe & lime");
            food.Add("sour cream");
            food.Add("turkey");
            food.Add("guac");
            food.Add("chicken");
            food.Add("chips");
            food.Add("jalapeno");
            food.Add("olives & cilantro");
            food.Add("lettuce");
            food.Add("cheese");
            string tacoFood = (food[x]);
            return tacoFood;
            
        }

        public static string getHomeTown(int x) //This method lists and corresponds the hometown to the name indexes.
        {
            List<string> hometwn = new List<string>();
            hometwn.Add("Warren");
            hometwn.Add("Indiana");
            hometwn.Add("Grand Rapids");
            hometwn.Add("California");
            hometwn.Add("Ohio");
            hometwn.Add("Detroit");
            hometwn.Add("Grand Rapids");
            hometwn.Add("Indiana");
            hometwn.Add("Monroe");
            hometwn.Add("Kalamazoo");
            hometwn.Add("Grand Rapids");
            hometwn.Add("Holland");
            hometwn.Add("Grand Rapids");
            hometwn.Add("Wyoming");
            
            string homeTown = (hometwn[x]);
            return homeTown;
        }
        public static string getAge(int x) //This method lists and corresponds the age to the name indexes.
        {
            List<string> ages = new List<string>();
            ages.Add("35");
            ages.Add("48");
            ages.Add("24");
            ages.Add("40");
            ages.Add("33");
            ages.Add("47");
            ages.Add("34");
            ages.Add("39");
            ages.Add("25");
            ages.Add("28");
            ages.Add("36");
            ages.Add("27");
            ages.Add("34");
            ages.Add("23");

            string age = (ages[x]);
            return age;
        }
       
        public static Boolean Continue()  //continue method
        {
            Boolean run;
            Console.WriteLine("Do you want to research another student? Y/N");
            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
                Main();
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("Good Bye!");
            }
            else
            {
                Console.WriteLine("I'm sorry I don't understand. Let's try again");
                run = Continue();
            }
            return run;
        }
        public static Boolean getMoreInfo(string y) //this method will generate the more student information if desired
        {
            Boolean more;
            Console.WriteLine("Do you want to know more? Y/N");
            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                Console.WriteLine("0-Food to Taco Bar\n" + "1-Hometown\n" + "2-Age\n" + "Please enter the number of the menu item you want to know more about");
                int input2 = int.Parse(Console.ReadLine());
                string menuList = getMenu(input2);
                getInfo(input2, y);
                more = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                more = false;
                Continue();
            }
            else
            {
                Console.WriteLine("I'm sorry I don't understand. Let's try again");
                more = getMoreInfo(y);
            }
            return more;
        }

    }
}


