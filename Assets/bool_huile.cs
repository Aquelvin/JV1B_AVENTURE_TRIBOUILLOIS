using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bool_huile : MonoBehaviour
{
    [SerializeField]
    public BoxCollider2D bcd;
    public bool recup = false;

    public Image[] Slots;
    public Sprite huile_icon;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("huile"))
        {
            recup = true;
            Slots[0].sprite = huile_icon;
        }
    }
}
