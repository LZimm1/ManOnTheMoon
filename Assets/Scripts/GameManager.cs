using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    void Awake(){
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameOver();
        NewGame();
        if(SceneManager.GetActiveScene().name == "Game"){
            Cursor.visible = false;
        }
        else{
            Cursor.visible = true;
        }
    }
    void GameOver(){
        if(Player.gameOver){
            SceneManager.LoadScene("GameOver");
            Player.gameOver = false;
        }
    }
    void NewGame(){
        if(ButtonScript.replay == true){
            SceneManager.LoadScene("Game");
            ButtonScript.replay = false;
        }
    }
}
