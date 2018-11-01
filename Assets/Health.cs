using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    private Animator animator;

    public DamageType type = DamageType.player;

    private void Start()
    {
        if (GetComponent<Animator>() != null)
        {
            animator = GetComponent<Animator>();
            animator.SetFloat("health", HealthPoints);
        }
    }
    public float HealthPoints
    {
        get
        {
            return healthPoints;
        }
        
        set
        {
            healthPoints = value;
            if (animator != null)
            {
                animator.SetFloat("health", value);
            }
            
            if (healthPoints <= 0)
            {
                GetComponent<Rigidbody>().useGravity = true;
                if (type == DamageType.enemy)
                {
                    Destroy(gameObject, 2.0f);
                }/* else {
                //TODO: menu de reset
                    SceneManager.LoadScene("SampleScene");
                }*/
            }
            
        }
        
    }
    
    [SerializeField]
    private float healthPoints = 100.0f;
    
}
