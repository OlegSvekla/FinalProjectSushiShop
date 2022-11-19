using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectSushiShop
{
    public class SushiBase
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int SushiAmount { get; set; }

        public string SushiSpecification { get; set; }

        public string Email { get; set; }

        public string SushiType { get; set; }

        public int Value { get; set; }

        public void StartMenu()
        {
            Console.WriteLine("Please select your next action:\n To Create order, choose: 1.\n " +
            "To see all information about your order, choose: 2.\n " +
            "To update your order, choose: 3.\n " +
            "To delete your order's some information, choose: 4.\n " +
            "To exit, choose: 0. ");
        }

        public void ChooseSushiType()
        {
            Console.WriteLine("Choose type of sushi:\n " +
                "1 - Futomaki,\n " +
                "2 - Hosomaki,\n " +
                "3 - Uramaki,\n " +
                "4 - Gunkanmaki,\n " +
                "5 - Shiromaki");

            string type = Console.ReadLine();

            switch (type)
            {
                case "1":
                    SushiType = "Futomaki";
                    Console.WriteLine("Futomaki is one of the largest rice rolls with a variety of fillings.\n" +
                    "The most popular option is a seafood cocktail.\n" +
                    "In appearance, the roll resembles Makizushi, but it is much larger in size and fullness.\n" +
                    "But the difference between Futomaki is not only in size, but also in the variety of fillings.\n" +
                    "In addition to seafood, they are cooked with vegetables and mushrooms. Outwardly, it looks spectacular,\n" +
                    "because the combination of different components and shades looks beautiful!");
                    break;
                case "2":
                    SushiType = "Hosomaki";
                    Console.WriteLine("This is an incredibly tasty and easy-to-cook roll.\n" +
                    "It consists of only one, less often two types of filling.\n" +
                    "Hosomaki can be safely attributed to low-calorie rolls.\n" +
                    "Not surprisingly, they are often ordered by people who adhere to diets and proper nutrition.\n" +
                    "Hosomaki are rolled into a traditional roll and cut.One serving contains 6 pieces.\n" +
                    "There are different types: with salmon, shrimp, snow crab, mussels.\n" +
                    "If the dish is two - component, as a rule, the second component is cheese.");
                    break;
                case "3":
                    SushiType = "Uramaki";
                    Console.WriteLine("The roll differs from other types in that the nori sheet is placed inside, and the rice is outside." +
                    "Because of this, they are more difficult to cook than other dishes." +
                    "The appearance will not leave anyone indifferent, because it looks very colorful." +
                    "As a decoration, sesame, thin slices of salmon or flying fish caviar." +
                    "For inside-out rolls, the following is used as a filling: lightly salted fish - salmon, salmon, yellowtail, eel, trout;" +
                    "vegetable slices -green onions, carrots, avocados, cucumbers; different types of cheese.");
                    break;
                case "4":
                    SushiType = "Gunkanmaki";
                    Console.WriteLine("This is one of the most popular sushi options in the world.\n" +
                    "They are twisted using a special bamboo mat - makisu.\n" +
                    "The dish, ready to serve, looks like small rice cylinders wrapped with norms, scrambled eggs, fish - it all depends on the chef's imagination!\n" +
                    "The roll is cut after twisting. A prerequisite is a pair of pieces, usually 6-8.");
                    break;
                case "5":
                    SushiType = "Shiromaki";
                    Console.WriteLine("The dish is probably a likely solution - rice is pressed with the palms to give a shape that is questionable.\n" +
                    "Around the perimeter, all this is framed with a sheet of nori.\n" +
                    "To appreciate the beautiful and comfortable shape, you should choose a high quality seaweed, ideally of the Gold or Silver class.\n" +
                    "Gunkan - maki is often made with flying fish roe and snow crab meat, but other fillings are also possible.\n" +
                    "Fans of vegetable dishes will appreciate the avocado cream cheese gunkan.\n" +
                    "The peculiarity is that the filling is laid out on top of the \"rice\" ship.");
                    break;
                default:
                    Console.WriteLine("Wrong choose");
                    break;
            }
        }

        public void SushiValue()
        {
            int baseValue = 1;

            if (SushiType.Equals("Futomaki"))
            {
                Value = baseValue * SushiAmount;
            }
            else if (SushiType.Equals("Hosomaki"))
            {
                Value = baseValue * 3 * SushiAmount;
            }
            else if (SushiType.Equals("Uramaki"))
            {
                Value = baseValue * 5 * SushiAmount;
            }
            else if (SushiType.Equals("Gunkanmaki"))
            {
                Value = baseValue * 8 * SushiAmount;
            }
            else if (SushiType.Equals("Shiromaki"))
            {
                Value = baseValue * 8 * SushiAmount;
            }
        }

        public void GetSushiDescription()
        {
            if (SushiType.Equals("Futomaki"))
            {
                SushiSpecification = "Futomaki is one of the largest rice rolls with a variety of fillings.\n" +
                    "The most popular option is a seafood cocktail.\n" +
                    "In appearance, the roll resembles Makizushi, but it is much larger in size and fullness.\n" +
                    "But the difference between Futomaki is not only in size, but also in the variety of fillings.\n" +
                    "In addition to seafood, they are cooked with vegetables and mushrooms. Outwardly, it looks spectacular,\n" +
                    "because the combination of different components and shades looks beautiful!";

            }
            else if (SushiType.Equals("Hosomaki"))
            {
                SushiSpecification = "This is an incredibly tasty and easy-to-cook roll.\n" +
                    "It consists of only one, less often two types of filling.\n" +
                    "Hosomaki can be safely attributed to low-calorie rolls.\n" +
                    "Not surprisingly, they are often ordered by people who adhere to diets and proper nutrition.\n" +
                    "Hosomaki are rolled into a traditional roll and cut.One serving contains 6 pieces.\n" +
                    "There are different types: with salmon, shrimp, snow crab, mussels.\n" +
                    "If the dish is two - component, as a rule, the second component is cheese.";
            }
            else if (SushiType.Equals("Uramaki"))
            {
                SushiSpecification = "The roll differs from other types in that the nori sheet is placed inside, and the rice is outside.\n" +
                    "Because of this, they are more difficult to cook than other dishes.\n" +
                    "The appearance will not leave anyone indifferent, because it looks very colorful.\n" +
                    "As a decoration, sesame, thin slices of salmon or flying fish caviar.\n" +
                    "For inside-out rolls, the following is used as a filling: lightly salted fish - salmon, salmon, yellowtail, eel, trout;\n" +
                    "vegetable slices -green onions, carrots, avocados, cucumbers; different types of cheese.";
            }
            else if (SushiType.Equals("Gunkanmaki"))
            {
                SushiSpecification = "This is one of the most popular sushi options in the world.\n" +
                    "They are twisted using a special bamboo mat - makisu.\n" +
                    "The dish, ready to serve, looks like small rice cylinders wrapped with norms, scrambled eggs, fish - it all depends on the chef's imagination!\n" +
                    "The roll is cut after twisting. A prerequisite is a pair of pieces, usually 6-8.";
            }
            else if (SushiType.Equals("Shiromaki"))
            {
                SushiSpecification = "The dish is probably a likely solution - rice is pressed with the palms to give a shape that is questionable.\n" +
                    "Around the perimeter, all this is framed with a sheet of nori.\n" +
                    "To appreciate the beautiful and comfortable shape, you should choose a high quality seaweed, ideally of the Gold or Silver class.\n" +
                    "Gunkan - maki is often made with flying fish roe and snow crab meat, but other fillings are also possible.\n" +
                    "Fans of vegetable dishes will appreciate the avocado cream cheese gunkan.\n" +
                    "The peculiarity is that the filling is laid out on top of the \"rice\" ship.";
            }
        }

        public override string ToString()
        {
            return $"Full Name: {FirstName} {LastName}, \n" +
                $"SushiAmount: {SushiAmount}, \n" +
                $"SushiType: {SushiType} , \n" +
                $"Value: {Value} $ , \n" +
                $"Email: {Email}, \n" +
                $"Your SushiSpecification: {SushiSpecification} \n";
        }
    }
}