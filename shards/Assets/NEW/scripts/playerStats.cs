using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerStats : MonoBehaviour
{
    public int MaxHealth = 100;
    public int currentHealth;
    public int minHealth = 0;
    private float[] position;
    public int health;

    [SerializeField] private Animator myDoor;

    
    public health Bar;

    void start(playerStats player)
    {

        health = player.currentHealth;

        currentHealth = MaxHealth;
        Bar.SetMaxHealth(MaxHealth);
    }
    void start(saving2 player)
    {
        player.SaveGame();
    

        void Update()
        {

            if (Input.GetKeyDown(KeyCode.H))
            {
                Damage(20);
            }

            if (Input.GetKeyDown(KeyCode.G))
            {
                Heal(20);
            }

            if (currentHealth >= MaxHealth)
            {
                currentHealth = MaxHealth;
            }

            if (currentHealth <= minHealth)
            {
                currentHealth = minHealth;
            }

        }
    
    void Damage(int damage)
    {
        currentHealth -= damage;
    }

    void Heal(int heal)
    {
        currentHealth += heal;
    }

     void FixedUpdate()
    {
        Bar.Sethealth(currentHealth);
    }

        void SavePlayer ()
    {
        savesystem.SavePlayer(this);
        print("savedcords");
    }
    }
}

