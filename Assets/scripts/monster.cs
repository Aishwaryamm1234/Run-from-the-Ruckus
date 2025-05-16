using Unity.VisualScripting;
using UnityEngine;

public class monster : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    private Rigidbody2D myBody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        myBody=GetComponent<Rigidbody2D>();

    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      myBody.linearVelocity=new Vector2(speed,myBody.linearVelocity.y);  
    }
}
