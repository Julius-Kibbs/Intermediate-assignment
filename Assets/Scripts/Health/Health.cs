using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
   [SerializeField]private float startingHealth;
   public float currentHealth{get; private set;}
   private Animator anim;
    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }

    private void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if(currentHealth > 0)
        {
            //Player hurt
            anim.SetTrigger("hurt");
        }

        else
        {
            //Player dead
            anim.SetTrigger("die");
        }

    }

    
}
