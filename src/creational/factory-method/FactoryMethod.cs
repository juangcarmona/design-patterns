namespace DesignPatterns.Creational.FactoryMethod
{
    // Product interface
    public interface IIceCream
    {
        void Serve();
    }

    // Concrete Product: Cone
    public class ConeIceCream : IIceCream
    {
        public void Serve()
        {
            Console.WriteLine("Serving ice cream in a cone.");
        }
    }

    // Concrete Product: Cup
    public class CupIceCream : IIceCream
    {
        public void Serve()
        {
            Console.WriteLine("Serving ice cream in a cup.");
        }
    }

    // Creator abstract class
    public abstract class IceCreamCreator
    {
        public abstract IIceCream FactoryMethod();

        public void ServeIceCream()
        {
            var iceCream = FactoryMethod();
            iceCream.Serve();
        }
    }

    // Concrete Creator: Cone
    public class ConeIceCreamCreator : IceCreamCreator
    {
        public override IIceCream FactoryMethod()
        {
            return new ConeIceCream();
        }
    }

    // Concrete Creator: Cup
    public class CupIceCreamCreator : IceCreamCreator
    {
        public override IIceCream FactoryMethod()
        {
            return new CupIceCream();
        }
    }

    // Client code
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose your ice cream type (cone/cup):");
            string? input = Console.ReadLine()?.ToLower();

            IceCreamCreator creator = input switch
            {
                "cone" => new ConeIceCreamCreator(),
                "cup" => new CupIceCreamCreator(),
                _ => throw new ArgumentException("Invalid type")
            };

            creator.ServeIceCream();
        }
    }
}
