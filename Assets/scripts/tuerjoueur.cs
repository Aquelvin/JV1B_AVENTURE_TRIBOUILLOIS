using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuerjoueur : MonoBehaviour
{
    public BoxCollider2D bcd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player") // Vérifie si la collision est avec le joueur
        {
            Debug.Log("touch");

            life player = other.gameObject.GetComponent<life>(); // Obtient une référence au script du joueur
            if (player != null)
            {
                player.PerdPv();
            }
        }
    }
}
