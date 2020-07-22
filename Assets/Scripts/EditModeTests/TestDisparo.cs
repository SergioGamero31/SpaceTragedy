using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestDisparo
    {
        BulletMove disparoDerecha;
        BulletMove disparoIzquierda;
        int dispararderecha;
        int dispararizquierda;
        [SetUp]
        public void SetUpDisparo()
        {
            disparoDerecha = new BulletMove();
            disparoIzquierda = new BulletMove();
            dispararderecha = 0;
            dispararizquierda = 0;
        }
        // A Test behaves as an ordinary method
        [Test]
        public void TestDisparoIzquierda()
        {
            // Use the Assert class to test conditions
            dispararizquierda = 1;
            Assert.AreEqual(1, dispararizquierda);
        }
        [Test]
        public void TestDisparoDerecha()
        {
            // Use the Assert class to test conditions
            dispararderecha = 1;
            Assert.AreEqual(1, dispararderecha);
        }
        [Test]
        public void TestDisparoSimplePasses()
        {
            // Use the Assert class to test conditions

        }
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestDisparoWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
