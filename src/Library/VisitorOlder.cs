namespace Library;

public class VisitorOlder : Visitor
{
    public string mayor;
    public override void Visit(PersonNode personNode)
    {
        int edades = 0;
        foreach (PersonNode item in personNode)
        {
            item.Accept(this);
            if (edades < personNode.Edad)
            {
                mayor = personNode.Nombre;
                edades = personNode.Edad;
            }
        }
        
    }
}