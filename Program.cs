using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    
    abstract class Course
    {
        protected string name;
        protected int duration;
        protected int courseFee;

        public Course(string name, int dur, int courseF)
        {
            this.name = name;
            duration = dur;
            courseFee = courseF;
        }

        public virtual void Print()
        {
            Console.WriteLine("Course name: " + name);
            Console.WriteLine("Course Duration: " + duration);
            Console.WriteLine("Course Fees: " + courseFee);
        }

        public abstract double GetTotalFee();
    }

    class PartTime : Course
    {
        private string pTime;

        public PartTime(string name, int duration, int coursefee, string Time)
            : base (name, duration, coursefee)
        {
           pTime = Time;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Time: " + pTime);
        }

        public override double GetTotalFee()
        {
            return (int)(courseFee * 0.90);
        }

    }

    class OnsiteCourse : Course
    {
        private string companyName;
        private int numnerOfCand;

        public OnsiteCourse(string name, int duration, int coursefee, string companyN, int nOC)
       : base(name, duration, coursefee)
        {
            companyName = companyN;
            numnerOfCand = nOC;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Companny name: " + companyName);
            Console.WriteLine("Number of Candidates: " + numnerOfCand);
        }

        public override double GetTotalFee()
        {
            return (int)(courseFee * 1.1);
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            

           
            Course Course = new OnsiteCourse("Front-End", 120, 7000, "Aspire Solution", 55);
            Course.Print();
            Console.WriteLine("Total Fees: " + Course.GetTotalFee());
            Console.WriteLine("");
            PartTime pTime = new PartTime("HTML", 80, 2700, "2-5");
            pTime.Print();
            Console.WriteLine("Total Fees: " + pTime.GetTotalFee());
        }   
    }
}
