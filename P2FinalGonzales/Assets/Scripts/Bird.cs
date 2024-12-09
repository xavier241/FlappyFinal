using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Bird : MonoBehaviour
{
    public float upforce = 200f;


    // Start is called before the first frame update
    private bool isDead = false;
    private Rigidbody2D rb2d;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upforce));

            }

        }
    }
    void OnCollsionEnter2D()
    {
        isDead = true;
    }
}
