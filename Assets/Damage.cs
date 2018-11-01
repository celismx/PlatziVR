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

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log(other.name + " vs "+this.name);

        if (other.tag == "Player" && DamageType.player == type)
            return;


        if (other.GetComponent<Health>() != null)
        {
            if (other.GetComponent<Health>().type != type)
            {
                float currentDamage = damage;
                if(other.GetComponent<ChangeWeapon>()!=null &&
                   other.GetComponent<ChangeWeapon>().shieldActive){
                    currentDamage = 0;
                }
                other.GetComponent<Health>().HealthPoints -= currentDamage;
            }
        }
    }
    
}
