namespace Library;

public class VisitorAges : Visitor
{
    public int edades = 0;
    public override void Visit(PersonNode personNode)
    {
        foreach (PersonNode item in personNode)
        {
            item.Accept(this);
            edades += item.Edad;
        }
        
    }
}