using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int coins=0;
    
    [SerializeField] AudioSource collect;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("coin")){
            Destroy(other.gameObject);
            coins++;
            collect.Play();
            

        }
    }
}
