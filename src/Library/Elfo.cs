using System;

namespace Program
{
    public class Elfo
    {
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
                if (value>0)
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
        public Arco Arco;
        public Daga Daga;
        public Elfo(string nombre)
        {
            this.Nombre = nombre;
            this.Vida = 80;
            this.Ataque = 20;
            this.Defensa = 15;
        }
        public void AgregarArco(Arco arco)
        {
            if (this.Arco == null)
            {
                this.Arco = arco;
                this.Ataque = this.ataque + arco.ataque;
            }
            else
            {
                Console.WriteLine("Ya posees un item de este estilo equipado");
            }
        }
        public void AgregarDaga(Daga daga)
        {
            if (this.Daga == null)
            {   
                this.Daga = daga;
                this.Ataque = this.ataque + daga.ataque;
            }
            else
            {
                Console.WriteLine("Ya posees un item de este estilo equipado");
            }
        }
        public void QuitarArco()
        {
            if (this.Arco != null)
            {
                this.Ataque = this.Ataque - this.Arco.ataque;
                this.Arco = null;
            }
            else
            {
                Console.WriteLine("No posees un item de este estilo equipado");
            }
        }
        public void QuitarDaga()
        {
            if (this.Daga != null)
            {
                this.Ataque = this.Ataque - this.Daga.ataque;
                this.Daga = null;
            }
            else
            {
                Console.WriteLine("No posees un item de este estilo equipado");
            }
        }
        public void RecibirAtaque(int poder)
        {
            if (this.Vida - poder / this.Defensa < 0)
            {
                this.Vida = 0;
            }
            else
            {
                this.Vida = this.Vida - poder / this.Defensa;
            }
        }
    }
}