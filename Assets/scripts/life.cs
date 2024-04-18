using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class life : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public Image[] coeurs;

    public Transform respawnPoint;


    // Start is called before the first frame update
    void Start()
    {

        currentHealth = maxHealth;
        for ( int i = 0;i < coeurs.Length; i++)
        {
            if( i >= currentHealth)
            {
                coeurs[i].enabled = false;
            }
        }

    }


    private void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (currentHealth <= 0)
        {
            Respawn();
        }
    }

    public void PerdPv()
    {
        currentHealth--;

        // essaie de mettre le code de Mel ici, pour les frames d'invulnérabilité
    }

    public void Respawn()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(0);
        transform.position = respawnPoint.position;
    }

}