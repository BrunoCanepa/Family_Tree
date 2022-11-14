using System;
namespace Library;

public class VisitorLargestNAme : Visitor
{
    public string largest = "";
    public override void Visit(PersonNode personNode)
    {
        foreach (PersonNode item in personNode)
        {
            item.Accept(this);
            if (largest.Length < personNode.Nombre.Length)
            {
                largest = personNode.Nombre;
                largest = personNode.Nombre;
            }
        }
        
    }
}