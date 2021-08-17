using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class IsPrimeUnitTest
    {
        [SetUp]
        public void Init()
        {
            Debug.Log("Before");
        }

        // A Test behaves as an ordinary method
        [Test]
        public void Sanity()
        {
            // Use the Assert class to test conditions
            Assert.AreEqual(true, Main.IsPrime(13));
        }

        [Test]
        public void CheckNotPrime()
        {
            // Use the Assert class to test conditions
            Assert.AreEqual(false, Main.IsPrime(15));
        }

        [Test]
        public void CheckEvenPrime()
        {
            Debug.Log("Test");
            // Use the Assert class to test conditions
            Assert.AreEqual(false, Main.IsPrime(12));
        }


        [TearDown]
        public void After()
        {
            Debug.Log("After");
        }


        [OneTimeTearDown]
        public void AfterAll()
        {
            Debug.Log("After All");
        }


    }
}
