using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class FactoryMethod2_1
    {
        public static void Main()
        {
            Creator[] creators = new Creator[2];
            creators[0] = new ProductACreator();
            creators[1] = new ProductBCreator();

            foreach (var creator in creators )
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine(product.GetType().Name);
            }
        }
        
    }

    abstract class Product
    {

    }

    class ConcreteProductA : Product
    {

    }

    class ConcreteProductB : Product
    {

    }

    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    class ProductACreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    class ProductBCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
