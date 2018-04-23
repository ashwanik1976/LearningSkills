using System;
using System.Collections.Generic;
using System.Text;

namespace MyFiestConsoleApp
{
    public class InterviewQuestionForCoding
    {

        private static int instanceCount;
        public void Only100Instance()
        {
            for (int n = 0; n < 101; n++)
                new InterviewQuestionForCoding();
        }
        public InterviewQuestionForCoding()
        {
            if (instanceCount > 5)
                throw new InvalidOperationException("Only 100 instances of Program are allowed");
            instanceCount++;
        }
    }
}
