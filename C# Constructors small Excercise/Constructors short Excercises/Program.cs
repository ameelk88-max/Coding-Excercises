namespace Constructors_short_Excercises
{
    /* Task 1, easy: Create a class called "Car" with the properties Brand and Year.
    Write a constructor that sets both values. In the program, create a car and print its data to the console.     Schwierigkeit: Einfach     */

    internal class Car // create class and put variable inside
    {
       public string Brand { get; set; } // make variables public not static so each object made from this class has it's own variables
       public int Year  { get; set; }

        public Car (string a, int b ) // create Constructor and add parameters so when I create objects from this class they chagne the value of their variables
        {
            Brand = a;
            Year = b;
        }

    }

    /*   Task 2, medium: Create a class called "BankAccount" with Owner and Balance. Write two constructors: 
    one that takes both values, and one that takes only the owner and sets the balance to zero. The second 
    one should call the first one using "this".   Schwierigkeit: mittel    */
    class BankAccount 
    {
        public string Owner {  get; set; }
        public double Balance { get; set; }

        public BankAccount (string owner, double balance) // first Constructor
        {
            // change the value of variables so each object has it's uniqe values
         Owner = owner; 
         Balance = balance;
        }
        public BankAccount (string owner) : this(owner, 0) { }  // Second costructor this will find alone the suitable Constructor I wrote before
        
    }

    /* Task 3, hard: Create a class called "Student" with a Name and a list of grades.
     * The constructor should check that the name is not empty, otherwise throw an 
     * exception. Also write a copy constructor that creates an independent copy of
     * an existing student, including its own grades list. Prove in the program that
     * changing the copy does not change the original.*/

    
    class Student 
    {
     public string Name { get; set; }
     public List<int> GradesList { get; set; }

      public Student (string name,List<int> gradesList )// make Constructor
      {
            if (Name == null) { throw new ArgumentException("nostudent's name not found"); } // if no student was found throw error
            Name = name; 
            GradesList = new List<int>(gradesList);   
      }    
        
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // make object from class Car and write it in Console
            Car car1 = new Car("BMW",2020);
            Console.WriteLine("Car1 informations:\n" +"Brand: " +car1.Brand + "\nYear: " +car1.Year);

            // second task
            BankAccount account = new BankAccount("Olivar");
            Console.WriteLine("Owner is " + account.Owner+ " Balance:" + account.Balance);
        }
    }
}
