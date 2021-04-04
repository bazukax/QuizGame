using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitController : MonoBehaviour
{
    public int nextLevelId = 0;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            ChangeLevel();
        }
    }
    void ChangeLevel()
    {
        Application.LoadLevel(nextLevelId);
    }
}
