using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class setactive_scriptlight : MonoBehaviour
{
    public GameObject monObj;

    public lumieresombre monScript;

    public lumiereclair secondscript;



    public GameObject lumiere;

    public GameObject obscurity;

    // Start is called before the first frame update
    void Start()
    {
        monScript = monObj.GetComponent<lumieresombre>();
        secondscript = monObj.GetComponent<lumiereclair>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("zut");
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
    if ( SceneManager.GetActiveScene().buildIndex == 3)
    {
            Debug.Log("scene 3");
            monScript.enabled = true;
            secondscript.enabled = false;
            obscurity.SetActive(true);
        }
    else
        {
            secondscript.enabled = true;
            monScript.enabled = false;


            lumiere.SetActive(false);
            obscurity.SetActive(false);
        }
    

       
    }
}
