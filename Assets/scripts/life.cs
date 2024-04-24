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

    public bool dead = false;


    // Start is called before the first frame update
    void Start()
    {

        currentHealth = maxHealth;

    }


    private void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        for (int i = 0; i < coeurs.Length; i++)
        {
            if (i >= currentHealth)
            {
                coeurs[i].enabled = false;
            }
        }
        if (currentHealth <= 0)
        {
            Respawn();
        }
    }

    public void PerdPv()
    {
        currentHealth-=1;
        Debug.Log("tamer");

        // essaie de mettre le code de Mel ici, pour les frames d'invulnérabilité
    }

    public void Respawn()
    {
        
        SceneManager.LoadScene(13);
        dead = true;
        Destroy(gameObject);
        transform.position = respawnPoint.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "mob" || collision.gameObject.tag == "boss")
        {
            PerdPv();

            
        }
    }
}