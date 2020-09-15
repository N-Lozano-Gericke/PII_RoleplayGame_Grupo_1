using System;

namespace Program
{
    public class Mago
    {
        private int Attackdmg = 10;
        private int Health = 100;
        private int Defence = 10;
        public Baston Baston;
        public Libro Libro;
        public Mago(string name)
        {
            this.Name = name;

        }
        private string name;
        private int life;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public int Atacar()
        {
                return this.Attackdmg;
        }

        public void AgregarBaston(Baston baston)
        {
            if(this.Baston == null)
            {
                this.Baston = baston;
                Attackdmg = Attackdmg + Baston.AttackDmg;
            }
        }
        public void QuitarBaston(Baston baston)
        {
            if(this.Baston != null)
            {
                Attackdmg = Attackdmg - Baston.AttackDmg;
                this.Baston = null;
            }
        }
         public void AgregarLibro(Libro libro)
        {
            if(this.Libro == null)
            {
                this.Libro = libro;
                Defence = Defence + Libro.Defence;
            }
        }
        public void QuitarLibro(Libro libro)
        {
            if(this.Libro != null)
            {
                Defence = Defence - Libro.Defence;
                this.Libro = null;
            }
        }

        public void RecibirAtaque(int atacar)
        {
            if (this.Health > 0)
            {
                this.Health = this.Health - atacar*(this.Defence/100);
            }
            
        }

    }
}
