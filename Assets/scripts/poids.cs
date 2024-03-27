using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poids : MonoBehaviour
{
    public Rigidbody2D rgbd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rgbd.velocity.x > 0)
        {
            rgbd.velocity = new Vector2(0f, rgbd.velocity.y);
        }
        if (rgbd.velocity.y > 0)
        { 
            rgbd.velocity = new Vector2(0f, rgbd.velocity.x);
        }
        if (rgbd.velocity.x < 0)
        {
            rgbd.velocity = new Vector2(0f, rgbd.velocity.y);
        }
        if (rgbd.velocity.y < 0)
        {
            rgbd.velocity = new Vector2(0f, rgbd.velocity.x);
        }
    }
}
