using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincibility : MonoBehaviour
{
    [SerializeField] int buffDuration = 3;
    [SerializeField] float dropSpeed = 3f;
    private Rigidbody2D rigidbody2d;

    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        rigidbody2d.velocity = new Vector2(0, -dropSpeed);
    }

    public int GetBuff()
    {
        return buffDuration;
    }
}
