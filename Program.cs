using System.Collections;
using System.Net;
using System.Runtime.InteropServices;
using System.Transactions;

namespace series_analyzer
{
    public class Program()
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("_ _ _welcome to series analayzer_ _ _");
            Console.WriteLine("");
            menu();

        void menu ()
        {
            List<int> numbers = new List<int>(); // initializer an emtpy list for use in the functions bellow.
            int UseSelectionOption=0; // user's menu selection ( initialized to zero).
            
            while (UseSelectionOption!=10) //ensure the loop runs as long as the user dosen't press 9 (exit).
            {
                UseSelectionOption =  ShowMenu(); // gets the number of user's choise from the menu


                switch (UseSelectionOption) //we call functions based on user's chois
                {
                    case 1:
                        Console.WriteLine("to start the procses again please enter a seryes of numbers again.");
                        string userInput=Console.ReadLine();
                        bool Isvalid=ValidateInput(userInput);  //validats if user input 
                        if (Isvalid)
                        {
                            numbers = ConvertToListOfInt(userInput);// convert the input to list of integers  to manipulate the list in the functions  
                        } 

                        else
                        {
                            ShowMenu();
                        }
  
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
                        int max = FindMax(numbers);
                        Console.WriteLine(max);

                        break;
                    
                    case 6:
                        int min =FindMin(numbers);
                        Console.WriteLine(min);
                        break;

                    case 7:
                        double AverageofList= Average(numbers);
                        Console.WriteLine(AverageofList);
                        break;

                    case 8:
                        int AmountOfElements = AmountOfItems(numbers);
                        Console.WriteLine (AmountOfElements);
                        break;

                    case 9:
                        int SumOfNumbers= SumOfItems(numbers);
                        Console.WriteLine(SumOfNumbers);
                        break;   
            
            
                }   


        }
    }
                

    
              



            

            bool ValidateInput(string input)
            {
                //check if the input is empty
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("the serie is empty try again.");
                    return false;
                }
                //check if the input is a number
                string[] numbers = input.Split(',');
                // List<int> listofNumbers=new List<int>();
                int counter=0;
                foreach( string part in numbers)   
                {
                    counter++;      
                }


                if (counter<3)
                {
                     Console.WriteLine("you must enter at least 3 numbers!");
                     return false;

                }
                   

                for (int i=0 ; i<numbers.Length; i++)
                {
                    if (!int.TryParse(numbers[i], out _))
                    {
                        Console.WriteLine("you entered invalied input , please enter numbers only.");
                        return false;
                    }
                }
               
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
                Console.WriteLine("5. Display the Max value of the serie.");
                Console.WriteLine("6. Display the Min value of the series.");
                Console.WriteLine("7.Display the average of numbers in the serie");
                Console.WriteLine("8. Display the Number of elements in the series.");
                Console.WriteLine("9. Display the Sum of the series.");
                Console.WriteLine("10. EXIT");
                int option = Convert.ToInt32(Console.ReadLine());
                
                return option;
            


            }


            List<int> ConvertToListOfInt(string input)

            {   
                List<int> listofNumbers=new List<int>();
                string[] items=input.Split(",");

                 
                 foreach ( string item in items )
                 {
                    int number=int.Parse(item);
                    listofNumbers.Add(number);
                 }

                return listofNumbers;
            }
 

            // displays in console the numbers in order he entered.
            void DisplayInOder(List<int> list)
            {
                string ToDisplay=string.Join("," , list);  //convert the list to string with comma saprtor

                Console.WriteLine("Here is the list of numbers in the order you entered: [" + ToDisplay + "]");

            }

             // displays the numbers in reverse order.
            void DisplayInRevers(List<int> list)
            {
                List<int> reverseList =new List<int>();
                for (int i= list.Count-1; i>=0 ;i--) // loop through the list in reverse order .
                {
                    reverseList.Add (list[i]);
                }
                DisplayInOder( reverseList);
            }


            void SortedDiplay(List<int> list)
            {
                List<int> SortedList= list;
                SortedList.Sort();
                DisplayInOder(SortedList);

            }


            // gets list of numbers and returns the maximum value in the list.
            int FindMax(List<int> list) 
            {
                int max = list[0];
                for(int i=1 ; i<list.Count; i++) // loop through the list and updates larger value is found.
                {
                    if (list[i]>max)
                    {
                        max=list[i];
                    }

                }
                return max ;
            }

            

            // gets list of numbers and returns the minimum value in the list.
            int FindMin(List<int> list)
            {
                int min = list[0];
                for(int i=1 ; i<list.Count; i++) // loop through the list and updates larger value is found.
                {
                    if (list[i]<min)
                    {
                        min=list[i];
                    }

            }
                return min;
            }


            double Average(List<int> list)
            {   
                int counter=0;
                double average;
                double sum=0;
                 foreach(double num in list ) 
                {
                  sum+=num;
                  counter+=1;

                }
                average= sum/counter;
                return average;
            }


            int AmountOfItems(List<int> list)
            {
                int AmountOfItems = 0;
                foreach(int num in list ) 
                {
                  
                    AmountOfItems +=1;

                }
                return AmountOfItems;
            }


            int SumOfItems(List<int> list)
            {
                int sum = 0;
                foreach(int num in list ) 
                {
                  sum+=num;

                }
                return sum;
            }





        

        



     
        }
    }
}

