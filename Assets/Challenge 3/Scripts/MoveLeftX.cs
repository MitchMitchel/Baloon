using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftX : MonoBehaviour
{
    public float speed;
    private PlayerControllerX playerControllerScript;
    private float rightBound = 5;
    public bool gameOver;


    
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

    
    void Update()
    {
        
        
        if ( ! playerControllerScript.gameOver )
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
        }
        
        
        if (transform.position.x > rightBound && !gameObject.CompareTag("Background"))
        {
            Destroy(gameObject);
        }

    }
}
