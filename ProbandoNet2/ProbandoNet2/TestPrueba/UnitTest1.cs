using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProbandoNet2;

namespace TestPrueba
{
    [TestClass]
    public class UnitTest1
    {
        //Valores Iguales
        [TestMethod]
        public void TestSumaEqual()
        {
            Prueba objPrueba = new Prueba();
            Assert.AreEqual(9, objPrueba.Suma(8, 1));
        }

        [TestMethod]
        public void TestUnirEqual()
        {
            Prueba objPrueba = new Prueba();
            Assert.AreEqual("Don Ian", objPrueba.Unir("Don ", "Ian"));
        }


        //Valores Distintos
        [TestMethod]
        public void TestSumaNotEqual()
        {
            Prueba objPrueba = new Prueba();
            Assert.AreNotEqual(9, objPrueba.Suma(1, 2));
        }

        [TestMethod]
        public void TestUnirNotEqual()
        {
            Prueba objPrueba = new Prueba();
            Assert.AreNotEqual("Don Ian", objPrueba.Unir("No", "Ian"));
        }

        //Valores Nulos
        [TestMethod]
        public void TestUnirNull()
        {
            Prueba objPrueba = new Prueba();
            Assert.IsNull(objPrueba.Unir(null, null));
        }

        //Boolean
        [TestMethod]
        public void TestBoolTrue()
        {
            Prueba objPrueba = new Prueba();
            Assert.IsTrue(objPrueba.CompararIguales("Igual", "Igual"));
        }

        [TestMethod]
        public void TestBoolFalse()
        {
            Prueba objPrueba = new Prueba();
            Assert.IsFalse(objPrueba.CompararIguales("Igual", "Igul"));
        }
    }
}
