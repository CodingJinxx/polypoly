using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
   public float Health;
   public float MaxHealth;
   public event Action OnDeath;
   public void Hit(float damage){
       Health -= damage;

       if(Health <= 0.0f) OnDeath?.Invoke();
   }
}
