using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject startMenu;
    public GameObject scoreObject;

    [HideInInspector]
    public Text Score;

    int updateScore = 0;

    private void Awake()
    {
        instance = this;
        Score = scoreObject.GetComponent<Text>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void increaseScore()
    {
            updateScore++;
            Score.text = updateScore.ToString();
    }

    public void restart()
    {
        SceneManager.LoadScene("Game");
    }
}
