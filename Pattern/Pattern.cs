namespace PracticeProject.Pattern
{
    public class Pattern
    {
        public Pattern()
        {
            // Pattern pattern = new Pattern();
            // pattern.Pattern1();
            // pattern.Pattern2();
            //pattern.Pattern3();
            // pattern.Pattern4();
            //pattern.Pattern5();
            // pattern.Pattern6();
            // pattern.Pattern7();
        }

        // Star Pattern

        public void Pattern1()
        {
            int n = 5;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        public void Pattern2()
        {
            int n = 6;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

        }
        public void Pattern3()
        {
            int n = 3;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j + 1);
                }
                Console.WriteLine();
            }

        }
        public void Pattern4()
        {
            int n = 6;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(i + 1);
                }
                Console.WriteLine();
            }

        }
        public void Pattern5()
        {
            int n = 6;
            for (int i = 0; i < n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        public void Pattern6()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {

                for (int j = n; j > i; j--)
                {
                    Console.Write(n + 1 - j);

                }
                Console.WriteLine();
            }
        }

        public void Pattern7()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                // Spaces before *
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(' ');
                }
                // *
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write('*');
                }
                // Spaces after *
                for (int l = 0; l < n - i - 1; l++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}
