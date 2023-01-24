using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boop : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    private string PLAYER_TAG = "Player";
    private string GROUND_TAG = "Ground";

    private Rigidbody2D myBody;
    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myBody.velocity = new Vector2(myBody.velocity.x, myBody.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag(GROUND_TAG)){
            Destroy(gameObject);
        }

        if(collision.gameObject.CompareTag(PLAYER_TAG)){
            Destroy(gameObject);
        }
    }

} //class
