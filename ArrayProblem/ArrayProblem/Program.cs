namespace Day13_Array
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayListOfDataTypes arrayListOfData = new ArrayListOfDataTypes();
            Console.WriteLine("Using Normal Method: ");
            arrayListOfData.PrintIntArray();
            arrayListOfData.PrintDoubleArray();
            arrayListOfData.PrintCharArray();

            int[] intArray = { 1, 2, 3, 4, 5, 6, 7 };
            double[] doubleArray = { 1.2, 1.3, 1.4, 1.5 };
            char[] charArray = { 'A', 'B', 'C', 'D' };
            ArrayListWithGenerics arrayListWithGenerics = new ArrayListWithGenerics();


            Console.WriteLine("Using Generic Method: ");
            arrayListWithGenerics.ToprintGeneric<int>(intArray);
            arrayListWithGenerics.ToprintGeneric<double>(doubleArray);
            arrayListWithGenerics.ToprintGeneric<char>(charArray);

            Console.WriteLine("Using Generic Classes: ");
            new ArrayListUsingGenericClass<int>(intArray).ToPrint();
            new ArrayListUsingGenericClass<double>(doubleArray).ToPrint();
            new ArrayListUsingGenericClass<char>(charArray).ToPrint();
        }
    }
}