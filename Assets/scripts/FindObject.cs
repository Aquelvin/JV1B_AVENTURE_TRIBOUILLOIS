using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindObject : MonoBehaviour
{
    public DontDestroyOnLoad destroy ;
    // Start is called before the first frame update
    void Start()
    {
        destroy = FindObjectOfType<DontDestroyOnLoad>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
