
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tp_to_congrat : MonoBehaviour
{
    public BoxCollider2D bc;

    bool_loot_final collected;

    // Start is called before the first frame update
    void Start()
    {
        collected = FindObjectOfType<bool_loot_final>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && collected.recup )
        {
            SceneManager.LoadScene(5);
        }
    }
}