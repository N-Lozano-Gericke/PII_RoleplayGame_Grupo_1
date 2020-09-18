using System;

namespace Program
{
    // La clase Arco esta separada de la clase Elfo, ya que la Arco es un objeto que el Elfo puede utilizar pero que
    // no es propio de este. Además, según el patron SRP la clase Elfo no debería encargarse de los objetos que puedan
    // ser utilizados por el Elfo. Ademas, por el patron EXPERT, es la Arco quien debe encargarse de conocer sus atributos.
    public class Arco
    {
        private int ataque;
        public int Ataque
        {
            get {return ataque;}
        }
        public Arco()
        {
            this.ataque = 20;

        }
    }
}