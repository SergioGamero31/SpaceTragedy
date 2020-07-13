using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class NewTestScript
    {
        private EnemyHead enemyHead;
        [Test]
        public void TestEnemy()
        {
            // Use the Assert class to test conditions
            bool enemy = true;
            string jugador = "vivo";
            if (enemy==true && jugador == "vivo")
            {
                Assert.AreEqual(true, enemy);
            }
        }
        // A Test behaves as an ordinary method
        [Test]
        public void NewTestScriptSimplePasses()
        {
            // Use the Assert class to test conditions
            int pass = 1;
            Assert.AreEqual(1, pass);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
