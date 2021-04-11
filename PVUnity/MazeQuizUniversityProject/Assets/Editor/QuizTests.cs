using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class QuizTests
{
    [Test]
    public void TestRNG()
    {
        //ARRANGE
        float generatedNumber = 0;
        //ACT
        GameObject obj = new GameObject();
        obj.AddComponent<Quiz>();

        generatedNumber = obj.GetComponent<Quiz>().generateRandomId(5);
        //ASSERT
        Assert.IsTrue(generatedNumber >= 0);
        Assert.IsTrue(generatedNumber < 5);
        Assert.IsFalse(generatedNumber < 0);
        

    }
}
