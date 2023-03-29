namespace Memento{
    public class Expediente{
        public string Nombre {get; set;}

        public Memento saveToMemento(){
            Console.WriteLine("Originator: Guardando memento para " + Nombre);
            return new Memento(Nombre);
            // Enviamos el nombre de estado a la clase constructor de Memento para que nos lo retorne.
        }

        public void restoreToMemento(Memento m){
            Nombre = m.Estado;

            Console.WriteLine("Originator: Recuperando memento " + Nombre);

            // Llamamos al getter de Memento para que nos muestre un estado existente.
        }
    }
}