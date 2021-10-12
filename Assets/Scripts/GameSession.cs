using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSession : MonoBehaviour
{
    [SerializeField] int score = 0;
    [SerializeField] Text scoreText;
    [SerializeField] GameObject loseLabel;
    // int blueStreak = 0;
    //  int redStreak = 0;


    //in case new levels are added in the future and we want to keep track of the score
    /* private void Awake() 
    {
        int numOfGameSessions = FindObjectsOfType<GameSession>().Length;

        if (numOfGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    */


    private void Start()
    {
        loseLabel.SetActive(false); //disable lose screen - safety measure
        scoreText.text = score.ToString();
    }

    public void AddToScore(int amount)
    {
            score += amount;
            
            scoreText.text = score.ToString();
        }

    // Future work to add points according to tags
   /* public void AddToScore(GameObject gameobject)
    {
        if (tag == "blue")
        {
            blueStreak++;
            score += (amount * blueStreak);
            redStreak = 0;
            scoreText.text = score.ToString();
        }
        else if (tag == "red")
        {
            redStreak++;
            score += (amount * redStreak);
            blueStreak = 0;
            scoreText.text = score.ToString();
        }


    }

    */

    // lose canvas is enabled, sets highscore & freezes time

    public void HandleLoseCondition()
    {

        Time.timeScale = 0;
        FindObjectOfType<HighScore>().SetHighScore(score);
        loseLabel.SetActive(true); // lose canvas 



    }


}

