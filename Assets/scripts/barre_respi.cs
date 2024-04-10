using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barre_respi : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rgbd;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
            rgbd.velocity = new Vector2(-speed, rgbd.velocity.y);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
    }

}

