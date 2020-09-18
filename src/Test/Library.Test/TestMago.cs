using NUnit.Framework;

namespace Program
{

    public class TestMago
    {
       private Mago Gandalf;
       private Baston Baston;
       private Libro Libro;

        [SetUp]
        public void Setup()
        {
            Gandalf = new Mago("Gandalf");
            Baston = new Baston();
            Libro = new Libro();
        }
        //Test para verificar el correcto funcionamiento del Name de la clase Mago
        [Test]
        public void TestMago_CambiarNombre()
        {
            string nuevonombre = "Merlin";
            Gandalf.Name = nuevonombre;
            Assert.AreEqual(Gandalf.Name, nuevonombre);
        }
        //Test para verificar la correcta validacion del Name de la clase Mago
        [Test]
        public void TestMago_NoCambiarNombre()
        {
            string Nombre = Gandalf.Name;
            Gandalf.Name = "";
            Assert.AreEqual(Gandalf.Name, Nombre);
        }
        //Test para verificar el funcionamiento del AttackDmg y del metodo QuitarBaston de la clase Mago
        [Test]
        public void TestMago_QuitarAtaque()
        {
            int damage = Gandalf.AttackDmg;
            Gandalf.AgregarBaston(Baston);
            Gandalf.QuitarBaston();
            Assert.AreEqual(Gandalf.AttackDmg, damage);
        }
        //Test para verificar el correcto funcionamiento del AttackDmg y del metodo AgregarBaston de la clase Mago
        [Test]
        public void TestMago_AgregarAtaque()
        {
            int damage = Gandalf.AttackDmg;
            Gandalf.AgregarBaston(Baston);
            Assert.AreEqual(Gandalf.AttackDmg, damage + Baston.AttackDmg);
        }
        //Test para verificar el funcionamiento del Defence y del metodo QuitarLibro de la clase Mago
        [Test]
        public void TestMago_QuitarDefensa()
        {
            int defence = Gandalf.Defence;
            Gandalf.AgregarLibro(Libro);
            Gandalf.QuitarLibro();
            Assert.AreEqual(Gandalf.Defence, defence);
        }
        //Test para verificar el funcionamiento del Defence y del metodo AgregarLibro de la clase Mago
        [Test]
        public void TestMago_AgregarDefensa()
        {
            int defence = Gandalf.Defence;
            Gandalf.AgregarLibro(Libro);
            Assert.AreEqual(Gandalf.Defence, defence + Libro.Defence);
        }
        //Test para verificar el funcionamiento del Health y del metodo RecibirAtaque de la clase Mago
        [Test]
        public void TestMago_RecibirAtaque()
        {
            int health = Gandalf.Health;
            Gandalf.RecibirAtaque(10);
            Assert.AreEqual(Gandalf.Health, health - 10 / Gandalf.Defence);
        }
        //Test para verificar la correcta validacion del Health de la clase Mago
        [Test]
        public void TestMago_RecibirAtaqueLetal()
        {
            Gandalf.RecibirAtaque(10000);
            Assert.AreEqual(Gandalf.Health, 0);
        }
    }


}
