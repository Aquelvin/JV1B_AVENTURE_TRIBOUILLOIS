using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respirateur : MonoBehaviour
{
    [SerializeField]
    private BoxCollider2D bc2d;

    [SerializeField]
    private BoxCollider2D bcd;

    [SerializeField]
    private KeyCode breathing = KeyCode.A;

    public bool aportee = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (aportee)
        {
            if (Input.GetKey(breathing))
            {
                bcd.transform.position = new Vector2(2, -2);
            }


        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("hitboxattack"))
        {

            aportee = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("hitboxattack"))
        {

            aportee = false;
        }
    }
}
