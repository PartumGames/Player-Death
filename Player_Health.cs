using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour {

    public GameManager manager;
    public Slider healthBar;
    public float health = 100f;

    private void Start()
    {
        healthBar.maxValue = health;
        healthBar.value = health;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            TakeDamage(10f);
        }
    }

    public void TakeDamage(float amnt)
    {
        health -= amnt;
        if (health <= 0f)
        {
            //we have no more health?????
            manager.GameOver();
        }
        float _h = Mathf.Clamp(health, 0, 100f);
        healthBar.value = _h;
    }

//end o class
}
