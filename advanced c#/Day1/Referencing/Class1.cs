namespace Referencing
{
    public class Class1
    {
        public static void swapValueByValue(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void swapValueByRef(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void swapRefByValue( int[] x,  int[] y)
        {
            int[] temp = x;
            x = y;
            y = temp;
        }
        public static void swapRefByRef(ref int[] x,ref int[] y)
        {
            int[] temp = x;
            x = y;
            y = temp;
        }
    }

}