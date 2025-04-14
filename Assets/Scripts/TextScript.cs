using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextScript : MonoBehaviour
{
    public static int highScoreNum = 0;
    private int intScore;
    public Text gameOverText;
    public Text Score;
    public Text HighScore;
    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().name == "GameOver"){
            if(Score){
                intScore = (int) (Player.score * 100);
                Score.text = intScore.ToString();
            }
            if(intScore > highScoreNum){
                highScoreNum = intScore;
                
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(Player.alive == false){
            if(gameOverText){
                gameOverText.text = "Game Over";
            }
        }

        
        if(SceneManager.GetActiveScene().name == "Game"){
            if(Score){
                intScore = (int) (Player.score * 100);
                Score.text = intScore.ToString();
            }
        }
        if(HighScore){
            HighScore.text = highScoreNum.ToString();
        }
    }
}
