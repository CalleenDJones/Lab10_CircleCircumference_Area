using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_CircleCircumference_Area
{
    class Circle
    {
        //data members
        private double radius;
        
        public double Radius { get; set; }

        public Circle (double radius)
        {
            Radius = radius;
        }


        public double CalculateCircumference()
        {
            //obtain the correct formula for each of the methods needed
            double CalCirc = (2 * Math.PI * Radius); 
            return CalCirc;
        }


        public string CalculateFormattedCircumference()
        {
            double CalCirc = (2 * Math.PI * Radius);
            //string CalFormCirc = (Convert.ToString(2 * Math.PI * Radius)); - DID NOT WORK 
            //obtain the correct formula for each of the methods needed
            return ($"{CalCirc, 0:N2}");
        }


        public double CalculateArea()
        {
            double R2 = (Radius * Radius);
            double CalArea = (Math.PI * R2); //obtain the correct formula for each of the methods needed
            return CalArea;
        }


        public string CalculateFormattedArea()
        {
            double R2 = (Radius * Radius);
            double CalArea = (Math.PI * R2);
            //double R2 = (Radius * Radius); - DID NOT WORK
            //string CalFormArea = (Convert.ToString(Math.PI * R2)); 
            //obtain the correct formula for each of the methods needed
            return ($"{CalArea, 0:N2}");
        }


        //private double Radius { get; set; }
       // private string FormatNumber ()
    }

}








//        //Data here (member variables) 
//        //We typically want data to be private
//        //don't put values in here--this is the blueprint
//        //DECLARATIONS ONLY
//        //  (there can be default values, like paid always starts false)
//        //Fields 
//        //Full name
//        private string name;
//        //password
//        private string password;
//        //email
//        private string email;
//        //age
//        private int age;
//        //paid subscriber?
//        private bool paid;
//        //registration date
//        private DateTime regDate;

//        //Methods
//        //we typically want methods to be public
//        //these are instance methods--by definition they aren't static

//        //Constructor: method that initializes a new instance of this class
//        //access modifier: almost always public
//        //return type: none (not void, nothing)
//        //name: same as class (capitalization counts)
//        //parameter list: varies
//        //  no-arguments version which sets everything to null or default values
//        //  all-arguments version which takes a parameter for each data member
//        //  we might use some number in between based on our design

//        //shadow variables: I can have a local variable/parameter
//        //  with the same name as an instance variable
//        public User(string name, string password,
//            string email, int age)
//        {
//            //common mistake: don't put the parameter on the left
//            //instance variable always goes on the left
//            //this. refers to this actual instance running the code
//            this.name = name;
//            this.password = password;
//            this.email = email;
//            this.age = age;
//            this.paid = false; //all users start unpaid (false)
//            this.regDate = DateTime.Now; //I don't need a parameter, I need NOW
//        }

//        //getters: public methods which let you read private instance data
//        //(accessor)
//        //access: public
//        //return type: data type of the member you're trying to get
//        //name: usually Get + instance var name; 
//        //  for booleans, might be Is + var name
//        //parameter list: usually empty
//        public string GetName()
//        {
//            return name;
//        }

//        public int GetAge()
//        {
//            return age;
//        }

//        public DateTime GetRegDate()
//        {
//            return regDate;
//        }

//        //setters: public methods which let you change private instance data
//        //(mutator)
//        //access: public
//        //return type: typically void (might be bool if I need to know it worked)
//        //name: typically Set + var name
//        //parameter list: same type as I'm setting
//        public void SetName(string name)
//        {
//            this.name = name; //taking the temp value and storing it in state
//        }

//        public void SetPassword(string password)
//        {
//            this.password = password;
//        }

//        //helper methods: generally private methods which are called by other 
//        //  methods in the class to accomplish a subtask


//        //other methods
//        //TODO: CheckPassword()
//        public bool CheckPassword(string password)
//        {
//            return (this.password == password);
//        }
//    }
//}
