using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowDestination : MonoBehaviour
{
    
    GameObject[] destinations;
    Transform destination;
    
    public float speed;

    GameObject player;

    //bool shouldMove = true;
    
    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        destinations = GameObject.FindGameObjectsWithTag("Waypoint");
        destination = destinations[Random.Range(0, destinations.Length)].GetComponent<Transform>();

    }
    
    void Update()
    {
        // The step size is equal to speed times frame time.
        float step = speed * Time.deltaTime;

        // Move our position a step closer to the target.
        //if (shouldMove)
        //{
            transform.position = Vector3.MoveTowards(transform.position, destination.position, step);
        //}
        
        Vector3 targetDir = destination.position - transform.position;
        
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
        Debug.DrawRay(transform.position, newDir, Color.red);
        
        // Move our position a step closer to the target.
        transform.rotation = Quaternion.LookRotation(newDir);
        
        if(targetDir.magnitude <0.5f){

            /*if(Vector3.Distance(this.transform.position, player.transform.position) < 1.0f){
                shouldMove = false;
            }*/


            if (Random.Range(0, 1) <0.5f)
            {
                destination = destinations[Random.Range(0, destinations.Length)].GetComponent<Transform>();
            }else{
                destination = player.transform;
            }
        }
        
        
    }
}
