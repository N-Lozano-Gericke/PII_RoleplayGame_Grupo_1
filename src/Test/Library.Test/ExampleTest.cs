using NUnit.Framework;

namespace Program
//namespace Test.Library
{


    public class ExampleTest
    {

        [Test]
        /*public void dummyTest()
        {
            Assert.True(true);
        }
        */
        public void EnanoAtaque()
        {
            Enano Guz = new Enano ("Guzman");
            Hacha a = new Hacha ();
            Guz.AgregarHacha (a);
            Assert.AreEqual (Guz.Atacar, 50);


        }

    }


}