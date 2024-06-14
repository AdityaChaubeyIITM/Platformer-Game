using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int curretnindex = 0;
    float speed = 2f;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[curretnindex].transform.position) < 0.1f){
            curretnindex ++;
            if (curretnindex >= waypoints.Length){
                curretnindex = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[curretnindex].transform.position, speed * Time.deltaTime);
        
    }
}
