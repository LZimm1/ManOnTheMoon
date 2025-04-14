using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    public static bool replay = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void clickButton(){
        replay = true;
        Player.gameOver = false;
        Player.alive = true;
        Player.score = 0;
    }
}
