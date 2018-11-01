using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DamageType{
    player, 
    enemy
}

public class Damage : MonoBehaviour {
    public float damage = 10.0f;
    public DamageType type = DamageType.enemy;
    
    private void OnCollisionEnter(Collision collision)
    {
    
        if (collision.gameObject.tag == "Player" && DamageType.player == type)
            return;


        if (collision.gameObject.GetComponent<Health>() != null)
        {
            if (collision.gameObject.GetComponent<Health>().type != type)
            {
                float currentDamage = damage;
                if(collision.gameObject.GetComponent<ChangeWeapon>()!=null &&
                   collision.gameObject.GetComponent<ChangeWeapon>().shieldActive){
                    currentDamage /= 2;
                }
                collision.gameObject.GetComponent<Health>().HealthPoints -= currentDamage;
            }
        }
    }
    
}
