using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using TMPro;

public class text : MonoBehaviour
{
  public TextMeshProUGUI txt;
 [SerializeField]
    private float moveForce =10f;
 [SerializeField]
    private float jumpForce =11f;


    private float movementX;
    public Rigidbody2D myBody;

    private SpriteRenderer sr;

    private Animator anim;
    private string WALK_ANIMATION ="walk";

    private bool isGrounded;
    private string GROUND_TAG="ground";

   private string ENEMY_TAG ="Enemy";
    private void Awake()
    {
    myBody=GetComponent<Rigidbody2D>();
    anim=GetComponent<Animator>();

    sr= GetComponent<SpriteRenderer>();    
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyBoard();
        AnimatePlayer();
        
       
       } 
       private void FixedUpdate()
       {
       PlayerJump();

       }
        
       
    
      void PlayerMoveKeyBoard(){

        movementX=Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(movementX, 0f, 0f)*Time.deltaTime*moveForce;
        
    }
    void AnimatePlayer(){

        if(movementX>0){
          anim.SetBool(WALK_ANIMATION,true);
          sr.flipX=false;
        }
        else if(movementX<0)
        {
          anim.SetBool(WALK_ANIMATION,true); 
          sr.flipX=true;
        }
        else
         {
          anim.SetBool(WALK_ANIMATION,false);
         }
    }
    void PlayerJump(){
        if (Input.GetButtonDown("Jump") && isGrounded){
            isGrounded=false;
           myBody.AddForce(new Vector2(0f, jumpForce),ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag(GROUND_TAG))
        {
         isGrounded=true;
        
        }
        if(collision.gameObject.CompareTag(ENEMY_TAG)){
          Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision){

      if(collision.CompareTag(ENEMY_TAG)){
       
        Debug.Log("Game Over, Press Restart to continue");
        Destroy(gameObject);
      }
        
    }
    
  
}

