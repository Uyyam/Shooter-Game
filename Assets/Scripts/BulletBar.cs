using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletBar : MonoBehaviour
{
    public Slider healthBar;
    public BulletShooter ammo;

    // Start is called before the first frame update
    void Start()
    {
        ammo = GameObject.FindGameObjectWithTag("Girl").GetComponent<BulletShooter>();
        healthBar = GetComponent<Slider>();
        healthBar.maxValue = ammo.maxAmmo;
        healthBar.value = ammo.maxAmmo;
    }

    public void SetHealth(int hp)
    {
        healthBar.value = hp;
    }
}

