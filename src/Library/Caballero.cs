using System;

namespace Program
{
    public class Caballero
    {
        private int vida;
        public int Vida
        {
            get {return vida;}
            set
            {
                if (value>=0)
                {
                    vida = value;
                }
            }
        }
        private int ataque;

        public int Ataque
        {
            get {return ataque;}
            set
            {
                if (value>=0)
                {
                    ataque = value;
                }
                }
        }

        private int defensa;
        public int Defensa
        {
            get {return defensa;}
            set
            {
                if (value>0)
                {
                    defensa = value;
                }
            }
        }
        
        private string nombre;
        public string Nombre
        {
            get {return nombre;}
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    nombre = value;
                }
            }
        }

        public Espada Espada;        
        public Escudo Escudo;    
        public Caballero (String nombre)
        {
            this.Nombre = nombre;
            this.Vida = 100;
            this.Ataque = 50;
            this.Defensa = 60;
        }
        
        public void AgregarEspada(Espada espada)
        {
            if (this.Espada == null)
            {
                this.Espada = espada;
                this.Ataque = this.Ataque + espada.AtaqueEspada;
            }
            else
            {
                Console.WriteLine("Ya posees una espada equipada");
            }
        }
        public void QuitarEspada()
        {
            if (this.Espada != null)
            {
                this.Ataque = this.Ataque - this.Espada.AtaqueEspada;
                this.Espada = null;
            }
            else
            {
                Console.WriteLine("No posees una espada equipada");
            }
        }
        public void AgregarEscudo(Escudo escudo)
        {
            if (this.Escudo == null)
            {
                this.Escudo = escudo;
                this.Defensa = this.Defensa + escudo.DefensaEscudo;
            }
            else
            {
                Console.WriteLine("Ya posees un escudo equipada");
            }
        }
        public void QuitarEscudo()
        {
            if (this.Escudo != null)
            {
                this.Defensa = this.Defensa - this.Escudo.DefensaEscudo;
                this.Escudo = null;
            }
            else
            {
                Console.WriteLine("No posees una escudo equipado");
            }
        }
    }
}
