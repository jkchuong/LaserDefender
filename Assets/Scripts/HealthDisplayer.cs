using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthDisplayer : MonoBehaviour
{
    TextMeshProUGUI healthText;
    Player player;

    private void Start()
    {
        healthText = GetComponent<TextMeshProUGUI>();
        player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        healthText.text = player.GetHealth().ToString();
    }
}
