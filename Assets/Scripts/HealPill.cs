using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPill : MonoBehaviour
{
    [SerializeField] int healAmount = 300;
    [SerializeField] float dropSpeed = 3f;
    private Rigidbody2D rigidbody2d;

    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        rigidbody2d.velocity = new Vector2(0, -dropSpeed);
    }

    public int GetHeal()
    {
        return healAmount;
    }
}
