using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paterns3 : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rgbd;
    private BoxCollider2D col;

    public bool droite = false;
    public bool gauche = false;
    public bool haut = false;
    public bool bas = false;


    // Start is called before the first frame update
    void Start()
    {
        gauche = true;
        rgbd = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (droite)
        {
            rgbd.velocity = new Vector2(speed, rgbd.velocity.y);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (haut)
        {      
            rgbd.velocity = new Vector2(rgbd.velocity.x, speed); 
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (gauche)
        {
            rgbd.velocity = new Vector2(-speed, rgbd.velocity.y);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (bas)
        {
            rgbd.velocity = new Vector2(rgbd.velocity.x, -speed);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }



    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Limit_enemis1"))
        {
            rgbd.velocity = new Vector2(0, 0);
            gauche = false;
            haut = true;
            
        }

        if (other.CompareTag("Limit_enemis2"))
        {
            rgbd.velocity = new Vector2(0, 0);
            haut = false;
            droite = true;
            
        }

        if (other.CompareTag("Limit_enemis3"))
        {
            rgbd.velocity = new Vector2(0, 0);
            droite = false;
            bas = true;
            
        }

        if (other.CompareTag("Limit_enemis4"))
        {
            rgbd.velocity = new Vector2(0, 0);
            bas = false;
            gauche = true;
            
        }
    }
}