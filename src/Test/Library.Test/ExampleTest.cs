using NUnit.Framework;

namespace Program
{


    public class ExampleTest
    {
        Elfo Aldo = new Elfo("Aldo");
        Arco Arco = new Arco();
        Daga Daga = new Daga();

        [Test]
        public void ElfoCambiarNombre()
        {
            string NombreNuevo = "Aldino";
            Aldo.Nombre = NombreNuevo;
            Assert.AreEqual(Aldo.Nombre , NombreNuevo);
        }
        [Test]
        public void ElfoNoCambiarNombre()
        {
            string Nombre = Aldo.Nombre;
            Aldo.Nombre = "";
            Assert.AreEqual(Aldo.Nombre , Nombre);
        }
        [Test]
        public void SumaAtaque()
        {
            int a = Aldo.Ataque;
            Aldo.AgregarArco(Arco);
            Aldo.AgregarDaga(Daga);
            Assert.AreEqual(Aldo.Ataque , a+Arco.ataque+Daga.ataque);
        }
        [Test]
        public void RestaAtaque()
        {
            int a = Aldo.Ataque;
            Aldo.AgregarArco(Arco);
            Aldo.AgregarDaga(Daga);
            Aldo.QuitarArco();
            Aldo.QuitarDaga();
            Assert.AreEqual(Aldo.Ataque , a);
        }
        [Test]
        public void RecibirAtaqueDebil()
        {
            int a = Aldo.Vida;
            Aldo.RecibirAtaque(15);
            Assert.AreEqual(Aldo.Vida , a - 15 / Aldo.Defensa);
        }
        [Test]
        public void RecibirAtaqueFuerte()
        {
            int a = Aldo.Vida;
            Aldo.RecibirAtaque(10000);
            Assert.AreEqual(Aldo.Vida , 0);
        }
    }
}