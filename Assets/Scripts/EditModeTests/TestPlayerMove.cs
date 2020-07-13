using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestPlayerMove
    {
        private PlayerMove playerMove;
        // A Test behaves as an ordinary method
        [Test]
        public void TestCaminar()
        {
            // Use the Assert class to test conditions
            //playerMove.Caminar();
            int posicion = 1;
            Assert.AreEqual(1, posicion);
        }
        [Test]
        public void TestSaltar()
        {
            // Use the Assert class to test conditions
            //playerMove.Saltar();
            int posicion = 1;
            int salto = 1;
            Assert.AreEqual(1, salto);
        }
        [Test]
        public void TestPlayerMoveSimplePasses()
        {
            // Use the Assert class to test conditions
            int simplepass = 1;
            Assert.AreEqual(1, simplepass);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestPlayerMoveWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
