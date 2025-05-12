using System.Net;
using System.Transactions;

namespace series_analyzer
{
    public class Program

    {
        static int option;
        static List<int> numbers = new List<int>(); // initializer an emtpy list for use in the functions bellow.

        public static void Main(string[] args)
        {
          

            void Menu()
            {   
                option=0; // user's menu selection ( initialized to zero).
                while (option!=9) //ensure the loop runs as long as the user dosen't press 9 (exit).
                {
                    option =  ShowMenu(); // gets the number of user's choise from the menu.




                    switch (option) //we call functions based on user's chois
                    {
                        case 1:
                             Starthandling();
                         //if user's chois is 1(to enter a new serie) the program will reshow the menu and gets rhe option

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




            
            void Starthandling()
            {
                Console.WriteLine("to start the procses pleas enter a seryes of numbers you want to analyze.");
                string userInput=Console.ReadLine();
                // bool Isvalid=ValidateInput(userInput);  //validats if user input contains only integer
                // if (Isvalid) 
                
                numbers = ConvertToListOfInt(userInput);// convert the input to list of integers  to manipulate the list in the functions
              
                        // Console.WriteLine("Invalide input, you have to enter numbers only");
                    
            
                
            
        
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
                 List<int> listofNumbers=new List<int>();
                 foreach (char c in input)
                 {
                    int number=int.Parse(c.ToString());
                    listofNumbers.Add(number);
                 }

                return listofNumbers;
            }
 

            // displays in console the numbers in order he entered.
            void DisplayInOder(List<int> list)
            {
                string ToDisplay=string.Join("," , list);  //convert the list to string with comma saprtor
                 
                Console.WriteLine( "here is the list of the  numbers in the order +you entered " +"["+ToDisplay+"]");      

            }

             // displays the numbers in reverse order.
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

