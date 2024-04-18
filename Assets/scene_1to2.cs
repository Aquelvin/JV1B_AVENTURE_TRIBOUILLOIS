using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_1to2 : MonoBehaviour
{
    public BoxCollider2D bc;
    bool_cle_A collected;


    // Start is called before the first frame update
    void Start()
    {
        collected =    FindObjectOfType<bool_cle_A>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && collected.recup )
        {
            SceneManager.LoadScene(2);
        }
    }
}