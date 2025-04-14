using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{

    public GameObject asteroid;
    private GameObject asteroidRef;

    float xPos = 8.4f;
    float yPos;
    float scale;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnAsteroids());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnAsteroids(){
        while(true){
            yield return new WaitForSeconds(1.5f);
            asteroidRef = Instantiate(asteroid);
            yPos = Random.Range(-3,3);
            scale = Random.Range(0.2f,0.5f);
            asteroidRef.transform.position = new Vector3(xPos, yPos, 0f);
            asteroidRef.transform.localScale = new Vector3(scale,scale,0f);
        }
    }
}
