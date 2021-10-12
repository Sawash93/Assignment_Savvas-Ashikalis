using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    float CURRENT_HIGH_SCORE = 60f;
    [SerializeField] Text highScore;
    [SerializeField] GameObject scoreLabel;
  
        private void Start()
        {

            scoreLabel.SetActive(false);

        }
        public void SetHighScore(float highscore)                           //static only set once and has 1 value in all places
    {
        if (highscore >= CURRENT_HIGH_SCORE)
        {
            Debug.Log("High Score is set to " + highscore);
            CURRENT_HIGH_SCORE = highscore;
            
        }
       
        else
        {
            Debug.LogError("High Score is Lower");
        }
    }

    public void ShowHighScore()
    {
        scoreLabel.SetActive(true);
        highScore.text = CURRENT_HIGH_SCORE.ToString();
    }
    
    public void HideHighScore()
    {
        scoreLabel.SetActive(false);
    }
    

}
