using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
    
    Slider slider;
    public GameObject target;
    
    // Use this for initialization
    void Start () {
        slider = GetComponent<Slider>();
        slider.maxValue = target.GetComponent<Health>().HealthPoints;
    }
    
    // Update is called once per frame
    void Update () {
        slider.value = target.GetComponent<Health>().HealthPoints;
    }
}
