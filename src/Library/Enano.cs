using System;

namespace Program
{
    public class Enano
    {
        public int Vida = 100;
        private int Ataque = 10;
        private int Defensa = 10;
        private String Nombre;

        public Enano (String nombre)
        {
            this.Nombre = nombre;
        }
        
        public void AgregarEscudoRedondo (EscudoRedondo EscudoRedondo)
        {
            this.Defensa = Defensa + EscudoRedondo.valordefensa;
        }

        public void AgregarHacha (Hacha Hacha)
        {
            this.Ataque = Ataque + Hacha.valorataque;
        }

        public int Atacar()
        {
            /*get
            {
                return this.Ataque;
            }*/
            return this.Ataque;
        }

        public int RecibirAtaque (Elfo a)
        {
            this.Vida = Vida - Elfo.Atacar();
            if (this.Vida < 0)
            {
                this.Vida = 0;
            }
            return this.Vida;
        }




    }
}