using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eagle : MonoBehaviour
{
    public float velocity;
    public bool m_FacingRight;
    Rigidbody2D rb2d;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = new Vector2(velocity, rb2d.velocity.y);

       
        if (velocity > 0 && !m_FacingRight)
        {
            Flip();
        }
        else if (velocity < 0 && m_FacingRight)
        {
            
            Flip();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Eagle colider")
        {
            velocity *= -1;
        }
        if (other.tag == "Hitbox")
        {


            Destroy(gameObject);

        }
    }

    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}
