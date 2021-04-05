using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void startGame(){
        Application.LoadLevel(0);
    }
    public void quit()
    {
        Application.Quit();
    }
}
