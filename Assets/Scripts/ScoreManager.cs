using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static ScoreManager instance;

    [Header("Campos de Texto")]
    public Text txtScore;
    public Text txtWin;

    private int score;
    private GameObject[] objs;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
        txtWin.gameObject.SetActive(false);
    }

    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        objs = GameObject.FindGameObjectsWithTag("ItemReward");
        
        if(objs.Length == 0)
        {
            youWin();
        }
		
	}


    public void increasePoints()
    {
        score++;
        txtScore.text = score.ToString();
    }

    private void youWin()
    {
        txtWin.gameObject.SetActive(true);
    }


}
