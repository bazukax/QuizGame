using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class MovementTest
{
    [Test]
    public void TestMovement()
    {
        //ARRANGE
        GameObject obj = new GameObject();
        obj.AddComponent<PlayerController>();
        //ACT


        //ASSERT
        Assert.IsTrue(obj.GetComponent<PlayerController>().runSpeed >= 0);
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
    }
}
