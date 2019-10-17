using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;

    public Text pointsText;

    [HideInInspector]
    public float pointsCount;


    public Text bestPoints;

    [HideInInspector]
    public float bestPointsCount;


    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
   
    void Start()
    {
        pointsCount = 0;
        if (PlayerPrefs.HasKey("HighScore"))
        {
            pointsText.text = "Score = "+pointsCount;
            
            bestPointsCount = PlayerPrefs.GetFloat("HighScore");
            bestPoints.text = PlayerPrefs.GetFloat("HighScore").ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (pointsCount > bestPointsCount )
        {
            bestPointsCount = pointsCount;
            

            PlayerPrefs.SetFloat("HighScore", bestPointsCount);
            
        }

        pointsText.text = "Points : " + Mathf.Round(pointsCount);

        bestPoints.text = "Best Score : " + Mathf.Round(bestPointsCount);

        
    }

    public void AddScore(int pointsToAdd)
    {
        pointsCount += pointsToAdd;
       
    }

}
