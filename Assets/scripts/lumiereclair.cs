using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lumiereclair : MonoBehaviour
{
    [SerializeField]
    private KeyCode lanterne;

 
    public GameObject lumiere ;

    public bool_huile collected;

    // Start is called before the first frame update
    void Start()
    {
        collected = FindObjectOfType<bool_huile>();
        lumiere.SetActive(false);
    }
    
    
    // Update is called once per frame
    void Update()
    {
        if (collected.recup)
        {
            if (Input.GetKeyDown(lanterne))
            {
                lumiere.SetActive(!lumiere.activeSelf);
            }
        }
    }
}
