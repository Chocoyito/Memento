namespace Memento
{
    public class Caretaker{
        private List<Memento> _mementos = new List<Memento>();
        // Lista de tipo Memento, necesita enviarsele un estado de tipo string.
        
        public void Add(Memento m){
            _mementos.Add(m); 
            // Añade el Memento dentro de la lista de su mismo tipo.
        }

        public Memento GetMemento(int index){
            return _mementos[index];
            // Recupera el memento según el índice que se le envía desde el Programa.
        }
    }
}