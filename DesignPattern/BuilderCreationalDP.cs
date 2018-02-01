using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    class BuilderCreationalDP
    {
        public static void Main()
        {
            Director director = new Director();
            Builder b1 = new ConcreteBuilderA();
            Builder b2 = new ConcreteBuilderB();

            director.Construct(b1);
            Product p1 = b1.GetProduct();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetProduct();
            p2.Show();

        }
    }

    class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }

    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetProduct();
    } 

    class ConcreteBuilderA:Builder
    {
        private Product product = new Product();
        public override void BuildPartA()
        {
            product.Add("parta");
        }

        public override void BuildPartB()
        {
            product.Add("partb");
        }

        public override Product GetProduct()
        {
            return product;
        }
    }


    class ConcreteBuilderB : Builder
    {
        private Product product = new Product();
        public override void BuildPartA()
        {
            product.Add("pta");
        }

        public override void BuildPartB()
        {
            product.Add("ptb");
        }

        public override Product GetProduct()
        {
            return product;
        }
    }

    class Product
    {
        List<string> list = new List<string>();

        public void Add(string item)
        {
            list.Add(item);
        }

        public void Show()
        {
            Console.WriteLine("\n Product parts....");
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
