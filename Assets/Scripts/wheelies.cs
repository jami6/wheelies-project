using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelies : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 10f;

    // [SerializeField]
    //private float jumpForce = 11f;

    private float movementX;
    private Rigidbody2D myBody;
    private SpriteRenderer sr;
    private Animator anim;
    private string DRIVE_ANIMATION = "drive";

    private string BOOP_TAG  = "Boop";

    // Here we are getting wheelies attached components or you can use the dragging method
    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WheeliesMoveKeyboard();
        AnimateWheelies();
    
    }

    // A is left movement, D is right movement on the keyboard
    void WheeliesMoveKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;         
    }

    void AnimateWheelies()
    {
        sr.flipX = true;
        //we are moving to the right
        if(movementX > 0){
            anim.SetBool(DRIVE_ANIMATION, true);
            sr.flipX = true;
        }
        //we are moving to the left
        else if(movementX < 0){
            anim.SetBool(DRIVE_ANIMATION, true);
            sr.flipX = false;
        }
        //we are not moving
        else{
            anim.SetBool(DRIVE_ANIMATION, false);
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag(BOOP_TAG)){
            Destroy(gameObject);
        }

    }

} //class
