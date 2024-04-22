using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_clair : MonoBehaviour
{
    [SerializeField]
    private KeyCode lanterne;

    public bool allume = true;
    // Start is called before the first frame update
    void Start()
    {
        allume = false;
    }
    void allumage()
        {
            if (!allume && Input.GetKeyDown(lanterne))
            {
                allume = true;
            }

            else if (allume && Input.GetKeyDown(lanterne))
            {
                allume = false;
            }
        }
    // Update is called once per frame
    void Update()
    {
        allumage();

        if (allume)
        {
            gameObject.SetActive(true);
        }

        else if (!allume)
        {
            gameObject.SetActive(false);
        }

    }
}
