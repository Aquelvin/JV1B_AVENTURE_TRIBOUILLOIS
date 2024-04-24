using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objet_final : MonoBehaviour
{
    public float moveSpeed = 5f; // Vitesse de d�placement de l'ennemi

    private Transform boss; // R�f�rence au joueur

    private void Start()
    {
        boss = GameObject.FindGameObjectWithTag("mob_huile").transform; // Trouver le joueur
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