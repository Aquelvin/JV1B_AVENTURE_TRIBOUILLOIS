using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventaire : MonoBehaviour
{
    public Image inventory_icon;
    public Canvas inventory;
    private bool inventory_open = false;

    // Start is called before the first frame update
    void Start()
    {
        inventory.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            inventory_icon.enabled = false;
            inventory_open = !inventory_open;
        }

        if (inventory_open)
        {
            inventory.enabled = true;
        } else if (!inventory_open)
        {
            inventory_icon.enabled = true;
            inventory.enabled = false;
        }
    }
}
