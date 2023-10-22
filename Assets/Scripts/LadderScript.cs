using System.Collections;
using System.Collections.Generic;
using UnityEngine;
​
public class LadderScript : MonoBehaviour {
​
    public float speed;
    private Rigidbody2D rb;
    private bool isClimbing;
    private float inputVertical;
​
    public LayerMask whatIsLadder;
    public float distance;
​
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
    
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance, whatIsLadder);
​
        if(hitInfo.collider != null)
        {
            if (Input.GetButtonDown("Vertical"))
            {
                isClimbing = true;
            }
        }
        else
        {
            if(Input.GetButtonDown("Vertical") || Input.GetKeyDown(KeyCode.RightArrow))
            {
                isClimbing = false;
            }
        }
​
        if (isClimbing == true && hitInfo.collider != null)
        {
            inputVertical = Input.GetAxisRaw("Vertical");
            rb.velocity = new Vector2(rb.velocity.x, inputVertical * speed);
            rb.gravityScale = 0;
        } else
        {
            rb.gravityScale = 5;
        }
	}
}