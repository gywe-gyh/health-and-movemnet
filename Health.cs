using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{   // �������� ��
  [SerializeField]  private int health = 7;
  [SerializeField]  private int level = 2;
    void Start()
    { // sum up hp and lv and typing in console current hp
        health += level;
        Debug.Log(message:"Current hp:"+ health);
    }

    public void Reducehp(int hpminus)
    {  // ������� �� ���������� ��
        health -= hpminus;
        if (health == 0)
        {
            // ������
            Die();
        
        
        
        }
    }
    private void Die()
    {
        Destroy(gameObject);

    }
}
     
