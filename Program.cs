namespace Memento
{
    class Program{
        static Caretaker caretaker = new Caretaker();

        static void Main(string[] args){
            // Creamos nuestro expediente.
            Expediente expediente = new Expediente();

            // Añaadimos los expedientes a nuestra lista.

            expediente.Nombre = "Expediente uno";
            caretaker.Add(expediente.saveToMemento());

            expediente.Nombre = "Expediente dos";
            caretaker.Add(expediente.saveToMemento());

            expediente.Nombre = "Expediente tres";
            caretaker.Add(expediente.saveToMemento());


            // Creamos nuestro Memento para poder acceder a los diferentes estados creados.
            Memento memento = caretaker.GetMemento(0);

            Console.WriteLine("Viendo expediente 1: " + memento.Estado);
            Console.WriteLine("Viendo expediente 2:" + caretaker.GetMemento(1).Estado);
            Console.WriteLine("Viendo expediente 3: " + caretaker.GetMemento(2).Estado);

            expediente.restoreToMemento(memento);
            Console.ReadKey();
        }
    }
}