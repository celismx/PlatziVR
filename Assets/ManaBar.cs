using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour {
    
    Slider slider;
    public GameObject target;
    
    // Use this for initialization
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.maxValue = ChangeWeapon.MAGIC_COOLDOWN_TIME;
    }
    
    // Update is called once per frame
    void Update()
    {
        slider.value = target.GetComponent<ChangeWeapon>().magicCooldown;
    }
}
