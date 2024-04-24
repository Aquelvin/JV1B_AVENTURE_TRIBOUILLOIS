using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruction : MonoBehaviour
{
    [SerializeField]
    private BoxCollider2D bc2d;

    [SerializeField]
    private KeyCode attackkey = KeyCode.Space;

    public bool aportee = false;

    bool_sword collected;
    // Start is called before the first frame update
    void Start()
    {
        collected = FindObjectOfType<bool_sword>();
    }

    // Update is called once per frame
    void Update()
    {
        if (collected.recup)
        {
            if (aportee)
            {
                if (Input.GetKeyDown(attackkey))
                {
                    Destroy(bc2d.gameObject);
                }


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
