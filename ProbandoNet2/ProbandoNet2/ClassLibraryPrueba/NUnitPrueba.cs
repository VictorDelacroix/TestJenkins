using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProbandoNet2;

namespace ClassLibraryPrueba
{
    public class NUnitPrueba
    {
        //Valores Iguales
        [Test]
        public void TestSumaEqual()
        {
            Prueba objPrueba = new Prueba();
            Assert.AreEqual(9, objPrueba.Suma(8, 1));
        }

        [Test]
        public void TestUnirEqual()
        {
            Prueba objPrueba = new Prueba();
            Assert.AreEqual("Don Ian", objPrueba.Unir("Don ", "Ian"));
        }


        //Valores Distintos
        [Test]
        public void TestSumaNotEqual()
        {
            Prueba objPrueba = new Prueba();
            Assert.AreNotEqual(9, objPrueba.Suma(1, 2));
        }

        [Test]
        public void TestUnirNotEqual()
        {
            Prueba objPrueba = new Prueba();
            Assert.AreNotEqual("Don Ian", objPrueba.Unir("No", "Ian"));
        }

        //Valores Nulos
        [Test]
        public void TestUnirNull()
        {
            Prueba objPrueba = new Prueba();
            Assert.IsNull(objPrueba.Unir(null, null));
        }

        //Boolean
        [Test]
        public void TestBoolTrue()
        {
            Prueba objPrueba = new Prueba();
            Assert.IsTrue(objPrueba.CompararIguales("Igual", "Igual"));
        }

        [Test]
        public void TestBoolFalse()
        {
            Prueba objPrueba = new Prueba();
            Assert.IsFalse(objPrueba.CompararIguales("Igual", "Igul"));
        }
    }
}
