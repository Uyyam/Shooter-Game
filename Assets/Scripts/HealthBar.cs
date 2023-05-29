using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public Monster monsterHealth;

    // Start is called before the first frame update
    void Start()
    {
        monsterHealth = GameObject.FindGameObjectWithTag("Monster").GetComponent<Monster>();
        healthBar = GetComponent<Slider>();
        healthBar.maxValue = monsterHealth.maxHealth;
        healthBar.value = monsterHealth.maxHealth;
    }

    public void SetHealth(int hp)
    {
        healthBar.value = hp;
    }
}
