using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections;
using System;

namespace Library
{
    public class PersonNode : IEnumerable
    {
        private int edad;
        private string nombre;

        public List<PersonNode> children = new List<PersonNode>();

        public string Nombre {
            get
            {
                return this.nombre;
            }
        }
        public int Edad {
            get
            {
                return this.edad;
            }
        }

        public ReadOnlyCollection<PersonNode> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public PersonNode(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public void AddChildren(PersonNode n)
        {
            this.children.Add(n);
        }
        public void Accept(Visitor visitor)
        {
        visitor.Visit(this);
        }

        public IEnumerator GetEnumerator()
        {
            return this.children.GetEnumerator();
        }
    }
}
