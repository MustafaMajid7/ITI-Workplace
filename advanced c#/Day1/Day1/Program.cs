using Referencing;
namespace Day1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int x=7, y=14;
            int[] xarr = { 1,2,3 };
            int[] yarr = { 4, 5, 6 };


            Console.WriteLine("value by value");

            Console.WriteLine("Before");
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Class1.swapValueByValue(x, y);

            Console.WriteLine("After");
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);


            Class1.swapValueByValue(x, y);

            //-------------------------------------------------------------------------

            Console.WriteLine("value by Ref"); 


            Console.WriteLine("Before");
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Class1.swapValueByRef(ref x,ref y);

            Console.WriteLine("After");
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);


            Class1.swapValueByRef(ref x,ref y);

            //-------------------------------------------------------------------------

            Console.WriteLine("Ref by value");

            Console.WriteLine("Before");
            Console.WriteLine("XArr = " + xarr[0] + " " + xarr[1] + " " + xarr[2]);
            Console.WriteLine("YArr = " + yarr[0] + " " + yarr[1] + " " + yarr[2]);

            Class1.swapRefByValue( xarr, yarr);

            Console.WriteLine("After");
            Console.WriteLine("XArr = " + xarr[0] + " " + xarr[1] + " " + xarr[2]);
            Console.WriteLine("YArr = " + yarr[0] + " " + yarr[1] + " " + yarr[2]);

            Class1.swapRefByValue( xarr, yarr);

            //-------------------------------------------------------------------------

            Console.WriteLine("Ref by Ref");


            Console.WriteLine("Before");
            Console.WriteLine("XArr = " + xarr[0] + " " + xarr[1] + " " + xarr[2]);
            Console.WriteLine("YArr = " + yarr[0] + " " + yarr[1] + " " + yarr[2]);

            Class1.swapRefByRef(ref xarr, ref yarr);

            Console.WriteLine("After");
            Console.WriteLine("XArr = " + xarr[0] + " " + xarr[1] + " " + xarr[2]);
            Console.WriteLine("YArr = " + yarr[0] + " " + yarr[1] + " " + yarr[2]);


            Class1.swapRefByRef(ref xarr, ref yarr);
        }

        
    }
}