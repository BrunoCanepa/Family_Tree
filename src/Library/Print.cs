namespace Library
{
    //Esta clase sirve para imprimir cada funcion de visitor
    public class Print
    {
        public int Edades(PersonNode personNode)
        {
            VisitorAges ages = new VisitorAges();
            ages.Visit(personNode);
            return ages.edades;
        }
        public string Mayor(PersonNode personNode)
        {
            VisitorOlder older = new VisitorOlder();
            older.Visit(personNode);
            return older.mayor;
        }
        public string NombreLargo(PersonNode personNode)
        {
            VisitorLargestNAme largest = new VisitorLargestNAme();
            largest.Visit(personNode);
            return largest.largest;
        }
    }
}