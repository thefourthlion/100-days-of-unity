using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool hasPkg = false;
    Color32 hasPackageColor = new Color32(127, 61, 255, 255);
    Color32 noPackageColor = new Color32(255, 255, 255, 255);


    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPkg)
        {
            Debug.Log("Triggered Package");
            hasPkg = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, 0.05f);
        }

        if (other.tag == "Customer" && hasPkg)
        {
            Debug.Log("Triggered Customer");
            hasPkg = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
