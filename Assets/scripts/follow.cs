using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public float moveSpeed = 5f; // Vitesse de déplacement de l'ennemi

    private Transform player; // Référence au joueur

    private Rigidbody2D rgbd;

    public bool statique = false;

    private void Start()
    {
        DontDestroyOnLoad(this);
        player = GameObject.FindGameObjectWithTag("Player").transform; // Trouver le joueur
    }

    private void Update()
    {
        if (player != null)
        
        {
            if (statique == false)
            {
                // Calculer la direction du mouvement vers le joueur
                Vector2 direction = player.position - transform.position;
                direction.Normalize();

                // Appliquer le mouvement
                transform.Translate(direction * moveSpeed * Time.deltaTime);
            }

            else
            {
                rgbd.velocity = new Vector2(0,0);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("limite_cam"))
        {
            statique = true;
        }

        else
        {
            statique = false;
        }
    }
}