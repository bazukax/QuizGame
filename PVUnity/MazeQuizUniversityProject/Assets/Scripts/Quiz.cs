using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Quiz : MonoBehaviour
{
    public bool provoked = false;
    public string[] qList;
    public string[] correctAnswer;
    public string[] wrongAnswer;
    public int randomQuestionId;

    public Text question;
    public Button[] answerButton;

    public GameObject UImanager;
    public GameObject player;

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
            provoked = true;
            randomQuestionId = generateRandomId(qList.Length);
            UpdateUserInterface();
            player.GetComponent<PlayerController>().enabled = false;
        }
    }
    public void Restart()
    {
        provoked = true;
        randomQuestionId = generateRandomId(qList.Length);
        UpdateUserInterface();
        player.GetComponent<PlayerController>().enabled = false;
    }
    public int generateRandomId(int max)
    {
       int rng = Random.Range(0, max);
        return rng;
    }
    void UpdateUserInterface()
    {
        question.text = qList[randomQuestionId];

       
        //set correct answer button
        int correctId = generateRandomId(3);
        answerButton[correctId].GetComponentInChildren<Text>().text = correctAnswer[randomQuestionId];
        answerButton[correctId].onClick.RemoveAllListeners();
        answerButton[correctId].onClick.AddListener(delegate { UImanager.GetComponent<UIcontroller>().OnCorrectAnswerClick(this.gameObject); });
        Debug.Log(randomQuestionId + "  " + correctAnswer + " " + correctId);
        for (int i = 0; i < answerButton.Length; i++)
        {
            if (correctId == i) continue;
            else
            {
                answerButton[i].GetComponentInChildren<Text>().text = wrongAnswer[generateRandomId(wrongAnswer.Length)];
                answerButton[i].onClick.RemoveAllListeners();
                answerButton[i].onClick.AddListener(delegate { UImanager.GetComponent<UIcontroller>().OnWrongAnswerClick(this.gameObject); });
            }
        }
    }
}
