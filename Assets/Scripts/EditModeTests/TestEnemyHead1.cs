using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestEnemyHead1
    {
        EnemyHead enemyHead;
        [SetUp]
        public void setUp()
        {
            enemyHead = new EnemyHead();
        }
        // A Test behaves as an ordinary method
        [Test]
        public void TestEnemyHead1SimplePasses()
        {
            // Use the Assert class to test conditions
            int aplastado = 1;        
            Assert.AreEqual(1,aplastado);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestEnemyHead1WithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
