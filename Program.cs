using System;
namespace oopPractices
{
    class Program
    {
        
        public static void trackStruct(newStruct st)
        {
            st.n = 8;
        }
        public static void tracClass(newClass cl)
        {
            cl.n = 8;
        }
        static void Main(string[] args)
        {

            string input = "1";
            while (input != "0")
            {
                Console.WriteLine("Welcome :)   Press 1 to 8 for general practices and 0 to Close");
                input = Console.ReadLine();
                if (input == "1")
                {
                    int dd = 0, mm = 0, yy = 0;
                    int total = 2;
                    Console.Write("\n\nCreate a nested struct and store data in an array :\n");
                    Console.Write("-------------------------------------------------------\n");
                    employee[] emp = new employee[total];

                    for (int i = 0; i < total; i++)
                    {
                        Console.Write("Name of the employee : ");
                        string nm = Console.ReadLine();
                        emp[i].eName = nm;

                        Console.Write("Input day of the birth : ");
                        dd = Convert.ToInt32(Console.ReadLine());
                        emp[i].Date.Day = dd;

                        Console.Write("Input month of the birth : ");
                        mm = Convert.ToInt32(Console.ReadLine());
                        emp[i].Date.Month = mm;

                        Console.Write("Input year for the birth : ");
                        yy = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        emp[i].Date.Year = yy;
                    }
                }

                if (input == "2")
                {
                    Console.Write("\n\nCreate a structure and Assign the Value and call it :\n");
                    Console.Write("---------------------------------------------------------\n");
                    aNewClass ClassNum1 = new aNewClass();
                    ClassNum1.x = 75;
                    ClassNum1.y = 95;
                    //	ClassNum2 is ClassNum1 type	
                    aNewClass ClassNum2 = ClassNum1;
                    ClassNum1.x = 7500;
                    ClassNum1.y = 9500;
                    Console.WriteLine("\nAssign in Class:       x:{0},   y:{1}", ClassNum2.x, ClassNum2.y);
                    aNewStruc StrucNum1 = new aNewStruc();
                    StrucNum1.x = 750;
                    StrucNum1.y = 950;
                    //	StrucNum2 is StrucNum1 type			
                    aNewStruc StrucNum2 = StrucNum1;
                    StrucNum1.x = 75;
                    StrucNum1.y = 95;
                    Console.WriteLine("Assign in Structure:   x:{0},    y:{1}\n\n", StrucNum2.x, StrucNum2.y);
                }
                if (input == "3")
                {
                    Console.Write("\n\nWhen a struct and a class instance is passed to a method :\n");
                    Console.Write("--------------------------------------------------------------\n");
                    newStruct ns = new newStruct();
                    newClass nc = new newClass();
                    ns.n = 5;
                    nc.n = 5;
                    //value of the struct field did not changed by passing its instance		
                    //because a copy of the struct was passed to the trackStruct method		
                    trackStruct(ns);
                    //value of the class field changed by passing its instance
                    //because a reference to the class was passed to the tracClass method		
                    tracClass(nc);
                    Console.WriteLine("\nns.n = {0}", ns.n);
                    Console.WriteLine("nc.n = {0}\n", nc.n);
                }
                if (input == "4")
                {
                    Console.Write("\n\nMethod that returns a structure  :\n");
                    Console.Write("--------------------------------------\n");
                    var Sqre = new Square();
                    Sqre.newSquare();
                    Console.WriteLine();
                    Console.WriteLine("Perimeter and Area of the square :");
                    Console.WriteLine("Length:    {0}", Sqre.Length.Value);
                    Console.WriteLine("Breadth:    {0}", Sqre.Breadth.Value);
                    Console.WriteLine("Perimeter: {0}", (Sqre.Length.Value + Sqre.Breadth.Value) * 2);
                    Console.WriteLine("Area:      {0}\n", Sqre.Length.Value * Sqre.Breadth.Value);
                }
            }
        }
    }
    //employee is a structure of members eName and dtObirth
    struct employee
    {
        public string eName;
        public dtObirth Date;
    }
    //dtObirth is a nested structure of employee
    struct dtObirth
    {
        public int Day;
        public int Month;
        public int Year;
    }
    class aNewClass
    {
        public int x;
        public int y;
    }
    //create a structure 
    struct aNewStruc
    {
        public int x;
        public int y;
    }
    class newClass
    {
        public int n;
    }
    struct newStruct
    {
        public int n;
    }
    public struct sampStru
    {
        private double val;
        public double Value
        {
            get { return val; }
            set { val = value; }
        }
        public double Read()
        {
            return double.Parse(Console.ReadLine());
        }
    }
    public struct Square
    {
        sampStru ln;
        sampStru ht;

        public sampStru Length
        {
            get { return ln; }
            set { ln = value; }
        }
        public sampStru Breadth
        {
            get { return ht; }
            set { ht = value; }
        }
        public void newSquare()
        {
            sampStru rct = new sampStru();

            Console.WriteLine("\nInput the dimensions of the Square( equal length and breadth ) : ");
            ln = sqrLength();
            Console.Write("breadth : ");
            ht.Value = rct.Read();
        }
        public sampStru sqrLength()
        {
            sampStru rct = new sampStru();

            Console.Write("length : ");
            rct.Value = rct.Read();
            return rct;
        }
    }
}
