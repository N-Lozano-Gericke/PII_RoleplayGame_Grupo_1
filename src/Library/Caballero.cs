using System;

namespace Program
{
    public class Caballero
    {
        private int Vida = 100;
        private int Ataque = 50;

        private int Defensa = 60;
        private String Nombre;

        public Espada Espada;        
        public Escudo Escudo;    
        public Caballero (String nombre, int vida, int ataque, int defensa)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Ataque = ataque;
            this.Defensa = defensa;


        }
        
        public void AgregarEspada(Espada espada)
        {
            if (this.Espada == null)
            {
                this.Espada = espada;
                this.Ataque = this.Ataque + espada.valorAtaque;
            }
        }
        public void QuitarEspada()
        {
            if (this.Espada != null)
            {
                this.Ataque = this.Ataque - this.Espada.valorAtaque;
                this.Espada = null;
            }
        }
        public void AgregarEscudo(Escudo escudo)
        {
            if (this.Escudo == null)
            {
                this.Escudo = escudo;
                this.Defensa = this.Defensa + escudo.valorDefensa;
            }
        }
        public void QuitarEscudo()
        {
            if (this.Escudo != null)
            {
                this.Defensa = this.Defensa - this.Escudo.valorDefensa;
                this.Espada = null;
            }
        }
    }
}
