using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public abstract class Visitor
    {
        public abstract void Visit(PersonNode personNode);
    }
}