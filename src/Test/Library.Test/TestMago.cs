using NUnit.Framework;

namespace Program
{


    public class TestMago
    {
        Mago Gandalf = new Mago("Gandalf");
        Baston Baston = new Baston();
        Libro Libro = new Libro();

        [Test]
        public void TestMago_CambiarNombre()
        {
            string nuevonombre = "Merlin";
            Gandalf.Name = nuevonombre;
            Assert.AreEqual(Gandalf.Name, nuevonombre);
        }
        [Test]
        public void TestMago_NoCambiarNombre()
        {
            string Nombre = Gandalf.Name;
            Gandalf.Name = "";
            Assert.AreEqual(Gandalf.Name, Nombre);
        }
        [Test]
        public void TestMago_AgregarAtaque()
        {
            int damage = Gandalf.AttackDmg;
            Gandalf.AgregarBaston(Baston);
            Assert.AreEqual(Gandalf.AttackDmg, damage + Baston.AttackDmg);
        }

        [Test]
        public void TestMago_QuitarAtaque()
        {
            int damage = Gandalf.AttackDmg;
            
            Gandalf.QuitarBaston();
            Assert.AreEqual(Gandalf.AttackDmg, damage);
        }

        [Test]
        public void TestMago_AgregarDefensa()
        {
            int defence = Gandalf.Defence;
            Gandalf.AgregarLibro(Libro);
            Assert.AreEqual(Gandalf.Defence, defence + Libro.Defence);
        }

        [Test]
        public void TestMago_QuitarDefensa()
        {
            int defence = Gandalf.Defence;
            Gandalf.AgregarLibro(Libro);
            Gandalf.QuitarLibro();
            Assert.AreEqual(Gandalf.Defence, defence);
        }

        [Test]
        public void TestMago_RecibirAtaque()
        {
            int health = Gandalf.Health;
            Gandalf.RecibirAtaque(10);
            Assert.AreEqual(Gandalf.Health, health - 10 / Gandalf.Defence);
        }
        
        [Test]
        public void TestMago_RecibirAtaqueLetal()
        {
            Gandalf.RecibirAtaque(10000);
            Assert.AreEqual(Gandalf.Health, 0);
        }
    }


}