using System.Transactions;

namespace series_analyzer
{
    public class Program()
    {
        public static void Main(string[] args)
        {
            void Menu()
            {   
                int option=0;
                while (option!=9)
                {
                    option =  ShowMenu();
                    List<int> numbers = new List<int>();
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("to start the procses pleas enter a seryes of numbers you want to analyze.");
                            string listOfnumbers=Console.ReadLine();
                            // bool Isvalid=ValidateInput(listOfnumbers);  //validats if user input contains only integer
                            // if (Isvalid)
                            // {
                            // }
                            numbers = ConvertToListOfInt(listOfnumbers);// convert the input to list of integers
                            option =ShowMenu();
                            break;

                        case 2:
                            DisplayInOder(numbers);
                            break;

                        case 3:
                            DisplayInRevers(numbers);
                            break;

                        case 4:
                            SortedDiplay(numbers);
                            break;

                        case 5:
                            FindMax(numbers);
                            break;
                        
                        case 6:
                            FindMin(numbers);
                            break;

                        case 7:
                            Average(numbers);
                            break;

                        case 8:
                            AmountOfItems(numbers);
                            break;

                        case 9:
                            SumOfItems(numbers);
                            break;   
                
                
                    }   

                    

                }
              



            }

            bool ValidateInput(string input)
            {
                //check if the input is empty
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter a valid series of numbers.");
                }
                //check if the input is a number
                string[] numbers = input.Split(',');
                return true;

            }


            int ShowMenu()
            {
                
            //display the menu of opthins and return the option. 
        
                Console.WriteLine("Please select an option from the menu below:");
                Console.WriteLine("1. Input a Series. (Replace the current series)");
                Console.WriteLine("2. Display the series in the order it was entered.");
                Console.WriteLine("3. Display the series in the reversed order it was entered");
                Console.WriteLine("4. Display the series in sorted order (from low to high)");
                Console.WriteLine("5. Display the Max value of the series.");
                Console.WriteLine("6. Display the Min value of the series.");
                Console.WriteLine("7. Display the Number of elements in the series.");
                Console.WriteLine("8. Display the Sum of the series.");
                Console.WriteLine("9. EXIT");
                int option = Convert.ToInt32(Console.ReadLine());
                
                return option;
            


            }


            List<int> ConvertToListOfInt(string input)
            {
                return new List<int>();
            }


            void DisplayInOder(List<int> list)
            {
                Console.WriteLine(3*3);


            }


            void DisplayInRevers(List<int> list)
            {

            }


            void SortedDiplay(List<int> list)
            {

            }

            int FindMax(List<int> list)
            {
                int max = 0;
                return max;
            }


            int FindMin(List<int> list)
            {
                int min = 0;
                return min;
            }


            double Average(List<int> list)
            {
                double average = 0;
                return average;
            }


            int AmountOfItems(List<int> list)
            {
                int amountOfItems = 0;
                return amountOfItems;
            }


            double SumOfItems(List<int> list)
            {
                double sum = 0;
                return sum;
            }







        Menu();



        }
    }
}

