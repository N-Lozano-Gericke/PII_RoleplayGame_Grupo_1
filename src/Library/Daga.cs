using System;

namespace Program
{
    // La clase Daga esta separada de la clase Elfo, ya que la Daga es un objeto que el Elfo puede utilizar pero que
    // no es propio de este. Además, según el patron SRP la clase Elfo no debería encargarse de los objetos que puedan
    // ser utilizados por el Elfo. Ademas, por el patron EXPERT, es la Daga quien debe encargarse de conocer sus atributos.
    public class Daga
    {
        private int ataque;
        public int Ataque
        {
            get {return ataque;}
        }
        public Daga()
        {
            this.ataque = 15;
        }
    }
}