using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stuff : MonoBehaviour
{


    public Image[] inventaire;

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
            inventaire[1].enabled = false;
            

            iconactif = false;


        }
        else if (Input.GetKeyDown(open) && iconactif == false)
        {
            inventaire[1].enabled = true;
            
            iconactif = true;

        }
    }
}