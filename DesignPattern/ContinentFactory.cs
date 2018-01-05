using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    abstract class ContinentFactory
    {
        abstract public Herbivore CreateHerbivore();
        abstract public Carnivore CreateCarnivore();
    }

    class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }

    class AmericaFactory: ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }

    abstract class Herbivore
    {

    }

    abstract class Carnivore
    {
        public abstract void Eat(Herbivore herbivore);
    }

    class Wildebeest : Herbivore
    {

    }
    class Bison : Herbivore
    {

    }

    class Lion : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine(this.GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }
    class Wolf : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine(this.GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }

    class WildWorld
    {
        private Herbivore herbivore;
        private Carnivore carnivore;

        public WildWorld(ContinentFactory continentFactory)
        {
            this.herbivore = continentFactory.CreateHerbivore();
            this.carnivore = continentFactory.CreateCarnivore();
        }

        public void Run()
        {
            this.carnivore.Eat(this.herbivore);
        }
    }
}
