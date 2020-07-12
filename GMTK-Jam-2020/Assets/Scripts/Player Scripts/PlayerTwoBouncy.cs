using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoBouncy : MonoBehaviour
{
    public PhysicsMaterial2D slippery;
    public PhysicsMaterial2D bouncy;

    public bool bouncyBool = false;
    public Collider2D boxCollider;
    // Start is called before the first frame update

    // Update is called once per frame

    public void bouncyToggleOn()
    {
        bouncyBool = true;
    }
    public void bouncyToggleOff()
    {
        bouncyBool = false;
    }

    void Update()
    {
        if (bouncyBool == true)
        {
            boxCollider.sharedMaterial = bouncy;
        }

        if (bouncyBool == false)
        {
            boxCollider.sharedMaterial = slippery;
        }
    }
}
