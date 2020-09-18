using System;

namespace Program
{
    public class Mago
    {
        private int attackdmg;
        private int health;
        private int defence;
        private string name;
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
        public int AttackDmg
        {
            get {return attackdmg;}
            set
            {
                if (value>0)
                {
                    attackdmg = value;
                }
            }
        }
         
         public int Health
        {
            get {return health;}
            set
            {
                if (value>0)
                {
                    health = value;
                }
                else
                {
                    health = 0;
                }

            }
        }
         public int Defence
        {
            get {return defence;}
            set
            {
                if (value>0)
                {
                    defence = value;
                }
            }
        }
        public Baston Baston;
        public Libro Libro;
        public Mago(string name)
        {
            this.Name = name;
            this.Health = 100;
            this.Defence = 10;
            this.AttackDmg = 10;

        }
        public int Atacar()
        {
                return this.attackdmg;
        }

        public void AgregarBaston(Baston baston)
        {
            if(this.Baston == null)
            {
                this.Baston = baston;
                this.AttackDmg = this.attackdmg + baston.AttackDmg;
            }
            else
            {
                Console.WriteLine("Ya posee este item");
            }
        }
        public void QuitarBaston()
        {
            if(this.Baston != null)
            {
                this.AttackDmg = this.AttackDmg - this.Baston.AttackDmg;
                this.Baston = null;
            }
            else
            {
                Console.WriteLine("No posee este item");
            }
        }
         public void AgregarLibro(Libro libro)
        {
            if(this.Libro == null)
            {
                this.Libro = libro;
                this.Defence = this.defence + libro.Defence;
            }
            else
            {
                Console.WriteLine("Ya posee este item");
            }
        }
        public void QuitarLibro()
        {
            if(this.Libro != null)
            {
                this.Defence = this.Defence - this.Libro.Defence;
                this.Libro = null;
            }
             else
            {
                Console.WriteLine("No posee este item");
            }
        }

        public void RecibirAtaque(int atacar)
        {
            if (this.Health > 0)
            {  
                
                if (this.Defence > 0)
                {
                    this.Health = this.health - atacar / this.Defence;
                }
                else
                {
                    this.Health = this.health - atacar;
                }  
            }   
            
        }

    }
}
