using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    float speedX = 4f;
    float movementX = -1f;
    float posX;
    float BGposX;
    
    public GameObject background;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!(Player.alive == false && Player.jumpReady)){
            MoveGround();
            MoveBackGround();
        }
        if(transform.position.x < -14.72){
            transform.position = new Vector3(23.02f, transform.position.y, transform.position.z);
        }
        if(background.transform.position.x < -20.12){
            background.transform.position = new Vector3(18.13001f,transform.position.y, transform.position.z);
        }
    }
    void MoveGround(){
        posX = transform.position.x;
        posX += movementX * speedX * Time.deltaTime;
        transform.position = new Vector3 (posX, transform.position.y, transform.position.z);
    }
    void MoveBackGround(){
        BGposX = background.transform.position.x;
        BGposX += movementX * speedX * Time.deltaTime;
        background.transform.position = new Vector3 (BGposX, transform.position.y, transform.position.z);
    }

}
