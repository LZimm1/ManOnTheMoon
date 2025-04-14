using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{

    private float movementX = -1;
    private float posX, posY;
    private float moveSpeed = 6f;
    private float rotationZ;
    // Start is called before the first frame update
    void Start()
    {
        posX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        AsteroidMove();
        if(transform.position.x < -8.4){
            Destroy(gameObject);
        }
    }
    void AsteroidMove(){
        posX += movementX * Time.deltaTime *moveSpeed;
        transform.position = new Vector3(posX, transform.position.y,transform.position.z);
        rotationZ += 360 * Time.deltaTime *2;
        transform.rotation = Quaternion.Euler(0.0f,0.0f,-rotationZ);
    }
}
