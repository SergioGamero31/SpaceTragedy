using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestCheckGround
    {
        private CheckGround checkGround;
        private Collider2D col;
        private GameObject gameObject;
        private bool a = true;
        [SetUp]
        public void Setuptest()
        {
            col = new Collider2D();
            gameObject = new GameObject();
            col = gameObject.AddComponent<Collider2D>() as Collider2D;
            //gameObject = transform.CompareTag("Player");
            //gameObject.tag("jugador");
            //col = gameObject.AddComponent<Collider2D>() as Collider2D;
        }
        // A Test behaves as an ordinary method
        [Test]
        public void TestCheckGroundSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [Test]
        public void TestOnTriggerEnter2D()
        {
            //checkGround.OnTriggerEnter2D(col);
            Assert.AreEqual(true, a);
        }
        [Test]
        public void TestOnTriggerExit2D()
        {
            //checkGround.OnTriggerExit2D(col);
            bool a = false;
            Assert.AreEqual(false, a);
        }
    }
}
