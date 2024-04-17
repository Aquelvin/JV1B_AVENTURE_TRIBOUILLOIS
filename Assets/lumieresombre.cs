using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lumieresombre : MonoBehaviour
{
    [SerializeField]
    private KeyCode lanterne;

    

    public GameObject lumiere;

    public GameObject obscurity;

    // Start is called before the first frame update
    void Start()
    {
        lumiere.SetActive(false);

        obscurity.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(lanterne))
        {
            lumiere.SetActive(!lumiere.activeSelf);
        }

        if (Input.GetKeyDown(lanterne))
        {
            obscurity.SetActive(!obscurity.activeSelf);
        }
    }
}
