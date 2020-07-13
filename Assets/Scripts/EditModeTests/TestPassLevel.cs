using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestPassLevel
    {
        private PassLevel passLevel;
        private Collider2D collider2D;
        private GameObject gameObject;
        [SetUp]
        public void SetUpGameObject()
        {

            //passLevel = gameObject.AddComponent<PassLevel>();
        }
        // A Test behaves as an ordinary method
        [Test]
        public void TestPassLevelSimplePasses()
        {
            // Use the Assert class to test conditions 
            //passLevel.OnTriggerEnter2D(collider2D);
            bool a = true;
            Assert.AreEqual(true,a);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestPassLevelWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
        [TearDown]
        public void DestroyGameObject()
        {
            passLevel = null;
            collider2D = null;
        }
    }
}
