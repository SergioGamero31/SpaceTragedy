using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestCollected
    {
        private Collected boladeenergia;
        // A Test behaves as an ordinary method
        [Test]
        public void TestCollectedSimplePasses()
        {
            // Use the Assert class to test conditions
            bool collected = true;
            Assert.AreEqual(true, collected);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestCollectedWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
