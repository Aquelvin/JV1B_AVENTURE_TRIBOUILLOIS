using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bool_loot_final : MonoBehaviour
{
    [SerializeField]
    public BoxCollider2D bcd;
    public bool recup = false;

    public Image[] Slots;
    public Sprite ocean_icon;

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
        if (other.CompareTag("lootfinal"))
        {
            recup = true;
            Slots[0].sprite = ocean_icon;
;
        }
    }
}
