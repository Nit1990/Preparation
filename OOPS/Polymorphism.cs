namespace OOPS
{

    public class Base
    {

        // Method Overloading - Compile Time Polymorphism, Static Polymorphism.
        // Run Time Polymosphism also Implement Liskov Substituion Principle.
        // Cant have same method name with different return type.
        public int add(int x, int y)
        {
            return x + y;
        }
        public int add(int x, int y, int z)
        {
            return x + y + z;
        }
        public virtual void show()
        {
            Console.WriteLine("Base Class");
        }

    }
    public class Derived : Base
    {

        // Method Hiding by new Keyword.
        public new void show()
        {
            Console.WriteLine("Derived Class");
        }
    }

    public class CsharpTest
    {
        public void TestVariable()
        {
            var variable = 10;
            dynamic dynamic = 10;
            object obj = 10;

          //  variable = "Hi";

            dynamic = "Hello";

            obj = "Hello";
        }
    }

}