using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventaire : MonoBehaviour
{
    public Image icone;

    public Image stuff;

    [SerializeField]
    private KeyCode open;

    public bool iconactif = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(open) && iconactif == true)
        {
            icone.enabled = false;
          
            iconactif = false;


        }
        else if (Input.GetKeyDown(open) && iconactif == false)
        {
            icone.enabled = true;
         
            iconactif = true;

        }
    }
}
