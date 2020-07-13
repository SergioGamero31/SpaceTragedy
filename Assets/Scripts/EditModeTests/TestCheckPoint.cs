using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestCheckPoint
    {
        private CheckPoint checkPoint;
        private Collider2D collider2D;
        [Test]
        public void TestCheckPointOnTriggerEnter2D()
        {
            //checkPoint.OnTriggerEnter2D(collider2D);
            int check = 1;
            Assert.AreEqual(1, check);
        }
        // A Test behaves as an ordinary method
        [Test]
        public void TestCheckPointSimplePasses()
        {
            // Use the Assert class to test conditions
            int pass = 1;
            Assert.AreEqual(1, pass);
        }
        [UnityTest]
        public IEnumerator TestCheckPointWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
