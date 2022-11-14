using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonNode Juan = new PersonNode("Juan", 88);
            PersonNode Mario = new PersonNode("Mario", 50);
            PersonNode Ana = new PersonNode("Ana", 43);
            PersonNode María = new PersonNode("María", 52);
            PersonNode Vida = new PersonNode("Vida", 26);
            PersonNode Bruno = new PersonNode("Bruno", 27);
            PersonNode Noah = new PersonNode("Noah", 13);
            PersonNode Luna = new PersonNode("Luna", 13);

            Juan.AddChildren(Mario);
            Juan.AddChildren(María);

            Mario.AddChildren(Vida);
            Ana.AddChildren(Vida);

            Vida.AddChildren(Noah);
            Vida.AddChildren(Luna);
            Bruno.AddChildren(Noah);
            Bruno.AddChildren(Luna);

            Print print = new Print();
            Console.WriteLine(print.Edades(Vida));
            Console.WriteLine(print.NombreLargo(Juan));
            Console.WriteLine(print.Mayor(Juan));

        }
    }
}
