using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fraude : MonoBehaviour
{
    [SerializeField]
    private KeyCode lanterne;



    

    public GameObject obscurity;

    // Start is called before the first frame update
    void Start()
    {
        

        obscurity.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
      
        

        if (Input.GetKeyDown(lanterne))
        {
            obscurity.SetActive(!obscurity.activeSelf);
        }
    }
}
