using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public AudioSource source;
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float jumpForce;
    [SerializeField]
    private Rigidbody2D mybody;
    private float movementX;
    public static bool jumpReady = false;
    public static float score;
    public static bool alive = true;

    private float leftPos = -8.4f;
    private float rightPos = 8.4f;
    public static bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(alive){
            transform.rotation = Quaternion.Euler(0,0,0);
            PlayerMove();
            PlayerJump();
            score += Time.deltaTime;
            if(transform.position.x < leftPos){
                transform.position = new(leftPos,transform.position.y,transform.position.z);
            }
            else if(transform.position.x > rightPos){
                transform.position = new Vector3(rightPos,transform.position.y,transform.position.z);
            }
        }
        StartCoroutine(EndGame());
        
        
        
        mybody.velocity = new Vector2(0f,mybody.velocity.y);
        
    }
    void PlayerMove(){
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX,0,0) * Time.deltaTime * moveSpeed;

    }
    void PlayerJump(){
        if(Input.GetButtonDown("Jump") && jumpReady && alive){
            mybody.AddForce(new Vector2(0f,jumpForce), ForceMode2D.Impulse);
            jumpReady = false;
        }
    }
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Asteroid")){
            alive = false;
            source.Play();
        }
        if(collision.gameObject.CompareTag("Ground")){
            jumpReady = true;
            
        }
    }
    IEnumerator EndGame(){
        if(alive == false && jumpReady || transform.position.y < -6){
            
            
            yield return new WaitForSeconds(0.5f);
            
            gameOver = true;
        
            
            
        }
        
        
       
    }
}
