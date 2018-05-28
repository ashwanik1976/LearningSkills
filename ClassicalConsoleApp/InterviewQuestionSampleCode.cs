using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicalConsoleApp
{
    class InterviewQuestionSampleCode
    {
        private static int instanceCount;
        public void Only100Instance()
        {
            for (int n = 0; n < 5; n++)
                new InterviewQuestionSampleCode();
        }
        public InterviewQuestionSampleCode()
        {
            if (instanceCount > 5)
                throw new InvalidOperationException("Only 100 instances of Program are allowed");
            instanceCount++;
        }
    }

    public interface T1
    {
        void Display();
    }
    public interface T2
    {
        void Display();
    }

    public class Test1 : T1, T2
    {
        void Display()
        {
            Console.WriteLine("Interface T1 implemented");
        }
        //Implement here  
        void T1.Display()
        {
            Console.WriteLine("Interface T1 implemented");
        }
        void T2.Display()
        {
            Console.WriteLine("Interface T2 implemented");
        }
    }
}
