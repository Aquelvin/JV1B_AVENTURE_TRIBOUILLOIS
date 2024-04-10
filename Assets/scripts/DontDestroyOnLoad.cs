using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{

    public BoxCollider2D bc;

    public Rigidbody2D rgbd;

    public float speed;
    private float horizontal;
    private float vertical;

    public RectTransform health_bar;
    public float respiration;
    public float res_perdue;
    public float res_regen;

    public bool aportee = false;

    [SerializeField]
    private KeyCode breathing;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        Res_perd();
        if(aportee && Input.GetKey(breathing))
        {
            Res_gagne();
        }
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        rgbd.velocity = new Vector2(horizontal, vertical).normalized * speed;

        if(respiration <= 0)
        {
            Death();
        }
    }

    private void Res_perd()
    {
        respiration -= res_perdue;
        health_bar.transform.localScale = new Vector3(respiration / 100f, 1f, 1f);
    }

    void Res_gagne()
    {
        respiration += res_regen;
        if (respiration > 100)
        {
            respiration = 100;
        }
        health_bar.transform.localScale = new Vector3(respiration / 100f, 1f, 1f);
    }

    void Death()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("hitboxrespi"))
        {

            aportee = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("hitboxrespi"))
        {

            aportee = false;
        }
    }
}
