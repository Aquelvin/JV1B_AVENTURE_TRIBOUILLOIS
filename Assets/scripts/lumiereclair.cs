using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lumiereclair : MonoBehaviour
{
    [SerializeField]
    private KeyCode lanterne;

 
    public GameObject lumiere ;

    // Start is called before the first frame update
    void Start()
    {
        lumiere.SetActive(false);
    }
    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(lanterne))
        {
            lumiere.SetActive(!lumiere.activeSelf);
        }

    }
}
