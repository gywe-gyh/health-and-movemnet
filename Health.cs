using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{   // основное хп
  [SerializeField]  private int health = 7;
  [SerializeField]  private int level = 2;
    void Start()
    { // sum up hp and lv and typing in console current hp
        health += level;
        Debug.Log(message:"Current hp:"+ health);
    }

    public void Reducehp(int hpminus)
    {  // команда по уменьшению хп
        health -= hpminus;
        if (health == 0)
        {
            // смерть
            Die();
        
        
        
        }
    }
    private void Die()
    {
        Destroy(gameObject);

    }
}
     
