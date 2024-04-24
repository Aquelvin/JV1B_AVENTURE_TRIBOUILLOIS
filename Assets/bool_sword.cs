using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bool_sword : MonoBehaviour
{
    [SerializeField]
    public BoxCollider2D bcd;
    public bool recup = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("sword"))
        {
            recup = true;
        }
    }
}
