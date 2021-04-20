using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
public class PlayerControllerTests 
{
    
     [Test]
    public void TestMovement()
    {
        //ARRANGE
        float speed = 5f;
        GameObject obj = new GameObject();
        obj.AddComponent<PlayerController>();
        //ACT


        //ASSERT
        Assert.IsTrue(obj.GetComponent<PlayerController>().runSpeed >= 0);
        Assert.IsTrue(obj.GetComponent<PlayerController>().SpeedTooFast(speed));
    }

    [Test]
    public void TestMovementLimiter()
    {
        //ARRANGE
        GameObject obj = new GameObject();
        obj.AddComponent<PlayerController>();
        //ACT


        //ASSERT
        Assert.IsTrue(obj.GetComponent<PlayerController>().moveLimiter >= 0);
        Assert.IsTrue(obj.GetComponent<PlayerController>().LimiterBreak(5));
    }


}
