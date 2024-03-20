using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{

    public BoxCollider2D bc;

    public Rigidbody2D rgbd;

    public float speed;
    private float horizontal;
    private float vertical;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        rgbd.velocity = new Vector2(horizontal, vertical).normalized * speed;

    }
}
