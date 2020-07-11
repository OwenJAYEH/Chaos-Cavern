using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SlowMotion : MonoBehaviour
{

    public float timeScale = 0.5f;
    public bool frozen = false;

    Rigidbody2D rb2d;
    float startMass;
    float startGravityScale;

    bool slowMoBool = true;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();

        startGravityScale = rb2d.gravityScale;
        startMass = rb2d.mass;
    }

    void FixedUpdate()
    {
        if (frozen)
        {
            SlowMo();
        }
        else
        {
            StopSlowMo();
        }
    }

    void SlowMo()
    {
        rb2d.gravityScale = 0.15f;

        if (slowMoBool)
        {
            rb2d.mass /= timeScale;
            rb2d.velocity *= timeScale;
            rb2d.angularVelocity *= timeScale;
        }
        slowMoBool = false;

        float dt = Time.fixedDeltaTime * timeScale;
        rb2d.velocity += Physics2D.gravity / rb2d.mass * dt;
    }

    void StopSlowMo()
    {
        if (!slowMoBool)
        {
            rb2d.gravityScale = startGravityScale;
            rb2d.mass = startMass;

            rb2d.velocity /= timeScale;
            rb2d.angularVelocity /= timeScale;
        }
        slowMoBool = true;
    }
}