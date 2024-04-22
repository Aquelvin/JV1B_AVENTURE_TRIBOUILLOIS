using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestroyUI : MonoBehaviour
{
    life mort;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);

        mort = FindObjectOfType<life>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mort.dead)
        {
            Destroy(this);
        }
    }
}
