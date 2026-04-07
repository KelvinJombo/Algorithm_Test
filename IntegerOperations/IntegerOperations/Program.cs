namespace IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var run = ArrayWorks([ 8, 8]);

            Console.WriteLine(run);
        }


        private static int ArrayWorks(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }


            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) 
                {
                    sum += 1;

                    if (numbers[i] == 8)
                    {
                        sum += 5;
                    }

                }               
                else
                {
                    sum += 3;
                }
            }

            return sum;

        }




    }

}
