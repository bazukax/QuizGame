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
        int generatedNumber = 0;
        //ACT
        GameObject obj = new GameObject();
        obj.AddComponent<Quiz>();

  
        generatedNumber = obj.GetComponent<Quiz>().generateRandomId(5);

        obj.GetComponent<Quiz>().CheckNegative(generatedNumber);
        //ASSERT
        Assert.IsFalse(generatedNumber < 0);
        Assert.IsFalse(obj.GetComponent<Quiz>().CheckNegative(generatedNumber));
        Assert.IsTrue(generatedNumber >= 0);
        Assert.IsTrue(generatedNumber < 5);    
        


    }
}
