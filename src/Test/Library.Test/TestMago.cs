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

    }


}