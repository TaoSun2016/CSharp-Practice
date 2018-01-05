using System;

namespace DesignPattern
{
    abstract class AbstractFactory1
    {
       public abstract AbstractProduct1A CreateProduct1A();
        public abstract AbstractProduct1B CreateProduct1B();
    }

    class ConcreteFactory11: AbstractFactory1
    {
        public override AbstractProduct1A CreateProduct1A() {
            return new Product1A1();
        }

        public override AbstractProduct1B CreateProduct1B()
        {
            return new Product1B1();
        }
    }

    class ConcreteFactory12: AbstractFactory1
    {
        public override AbstractProduct1A CreateProduct1A()
        {
            return new Product1A2();
        }

        public override AbstractProduct1B CreateProduct1B()
        {
            return new Product1B2();
        }
    }

    abstract class AbstractProduct1A
    {

    }
    abstract class AbstractProduct1B
    {
        public abstract void Interact(AbstractProduct1A a);
    }

    class Product1A1: AbstractProduct1A
    {

    }
    class Product1A2: AbstractProduct1A
    {

    }

    class Product1B1: AbstractProduct1B
    {
        public override void Interact(AbstractProduct1A a)
        {
            Console.WriteLine(this.GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }

    class Product1B2 : AbstractProduct1B
    {
        public override void Interact(AbstractProduct1A a)
        {
            Console.WriteLine(this.GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }

    class Client
    {
        private AbstractProduct1A _abstractProductA;
        private AbstractProduct1B _abstractProductB;

        // Constructor
        public Client(AbstractFactory1 factory)
        {
            _abstractProductB = factory.CreateProduct1B();
            _abstractProductA = factory.CreateProduct1A();
        }

        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }

}
