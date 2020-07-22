using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestCrabEnemy
    {
        int crabmata;
        [SetUp]
        public void SetUpCrab()
        {
            Enemy crab;
            crab = new Enemy();
            crabmata = 0;
        }
        // A Test behaves as an ordinary method
        [Test]
        public void TestCrabEnemySimplePasses()
        {
            // Use the Assert class to test conditions
            crabmata = 1;
            Assert.AreEqual(1, crabmata);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestCrabEnemyWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
