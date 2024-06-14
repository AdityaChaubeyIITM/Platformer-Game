using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour

{
    [SerializeField] float SpeedY;



    // Update is called once per frame 
    void Update()
    {
        transform.Rotate(0, 360*SpeedY*Time.deltaTime, 0);
        
    }
}
