using ClassicalConsoleApp.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassicalConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // TestWCFChannelfactory.CallWCFService();

            Task task = new Task(AsyncPrograming.callMethod);
            task.Start();
            task.Wait();
            Console.ReadLine();

            //T1 Obj1 = new Test1();
            //Obj1.Display();

            //T2 Obj2 = new Test1();

            //Obj2.Display();


            //InterviewQuestionSampleCode sc = new InterviewQuestionSampleCode();
            //sc.Only100Instance();


            //GetSendHighestDigitInGivenNumber();

            Console.Read();

        }
        private static void GetSendHighestDigitInGivenNumber()
        {
            int num, k = 0; int a = 0, b = 0, tmp = 0; num = 975846;
            int[] arr = new int[6];
            Array.BinarySearch(arr, 8);
            while (num > 0)
            {
                tmp = num % 10;
                num = num / 10;
                arr[k] = tmp;
                k++;
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
            }
            Console.WriteLine("Second largest number is b={0}", arr[1]);
        }
    }
    abstract class MyClass
    {
        //Your code  
    }
    class MyMath
    {
        readonly int read = 10;
        const int cons = 10;
        public MyMath()
        {
            read = 100;
            //cons = 100;
        }
        /// <summary>
        /// Catch block maintain hierarchy,if broke then showing compilation error.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Sum(int x, int y)
        {
            try
            {
                return x + y;
            }
            catch (OutOfMemoryException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public string Sum(int x, int y)
        //{
        //    return x + y;
        //}
    }
    class Test
    {
        readonly int read = 10;
        const int cons = 10;
        public Test()
        {
            read = 100;
            //cons = 100;
        }
        public void Check()
        {
            Console.WriteLine("Read only : {0}", read);
            Console.WriteLine("const : {0}", cons);
        }
    }
    class TestWCFChannelfactory
    {
        public static void CallWCFService()
        {
            //AuthorServiceClient ss = new AuthorServiceClient();
            //try
            //{
            //    var author = ss.GetInfo("102");
            //}
            //catch (FaultException<CustomException> fex)
            //{

            //    throw fex;
            //}
            //catch (Exception ex)
            //{

            //    throw;
            //}
            WSHttpContextBinding myBinding = new WSHttpContextBinding();
            EndpointAddress myEndpoint = new EndpointAddress("http://localhost:51541/AuthorService.svc");
            ChannelFactory<IAuthorService> myChannelFactory = new ChannelFactory<IAuthorService>(myBinding, myEndpoint);

            IAuthorService instance = myChannelFactory.CreateChannel();
            // Call Service.
            Console.WriteLine(instance.GetInfo(new AuthorRequest() { AuthorId = "101" }));
            myChannelFactory.Close();
        }
    }


}
