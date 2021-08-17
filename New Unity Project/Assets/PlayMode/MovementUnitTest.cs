using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class MovementUnitTest
    {
        GameObject cube;
        [OneTimeSetUp]
        public void init()
        {
            cube = GameObject.Instantiate(new GameObject());
            cube.AddComponent<Mobement>();
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestRight()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            float x = cube.transform.position.x;
            cube.GetComponent<Mobement>().MoveRight();
            yield return new WaitForSeconds(0.5f);
            Assert.AreEqual(x + 1, cube.transform.position.x);
        }

        [UnityTearDown]
        public void DestroyAfter()
        {
            GameObject.Destroy(cube.gameObject);
        }
    }
}
