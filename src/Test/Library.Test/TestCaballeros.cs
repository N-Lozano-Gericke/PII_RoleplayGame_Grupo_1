using NUnit.Framework;

namespace Program
{
    public class TestCaballero
    {
        Caballero Aragon = new Caballero("Aragon");
        Espada EspadaI = new Espada();
        Escudo EscudoI = new Escudo();
        
        [Test]
        public void CambioDeNombre()
        {   
            string NombreNuevo = "Randomi";
            Aragon.Nombre = NombreNuevo;
            Assert.AreEqual(Aragon.Nombre , NombreNuevo);

           
        }
        
        [Test]
        public void CalcularAtaque()
        {
            int a = Aragon.Ataque;
            Aragon.AgregarEspada(EspadaI);
            Assert.AreEqual(Aragon.Ataque , a + EspadaI.AtaqueEspada);
        }
        public void Test()
        {
            Assert.True(true);
        }
    }
}
