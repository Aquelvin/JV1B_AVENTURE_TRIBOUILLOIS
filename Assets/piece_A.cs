using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piece_A : MonoBehaviour
{
    [SerializeField]
    public BoxCollider2D bcd;
    public bool detruit = false;

    public GameObject coin;

    coin_A collected;

    // Start is called before the first frame update
    void Start()
    {
        collected = FindObjectOfType<coin_A>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            Destroy(bcd.gameObject);
            detruit = true;
        }

        else if (collected.recup)
        {
            coin.SetActive(false);
            Destroy(bcd.gameObject);
        }
    }
}