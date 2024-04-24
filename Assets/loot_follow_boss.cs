using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loot_follow_boss : MonoBehaviour
{
    public float moveSpeed = 5f; // Vitesse de d�placement de l'ennemi

    private Transform boss; // R�f�rence au joueur

    private void Start()
    {
        boss = GameObject.FindGameObjectWithTag("boss").transform; // Trouver le joueur
    }

    private void Update()
    {
        if (boss != null)
        {
            // Calculer la direction du mouvement vers le joueur
            Vector2 direction = boss.position - transform.position;
            direction.Normalize();

            // Appliquer le mouvement
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }
}