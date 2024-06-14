using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    bool isdead= false;
    [SerializeField] AudioSource death;
    void Update(){
        if (transform.position.y < -0.8f && !isdead){
            Die();
        }
    }
    
    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.CompareTag("Enemy")){
            Die();
         }
    
    }

    void Die(){
        death.Play();
        GetComponent<MeshRenderer>().enabled=false; //Remove the body 
        GetComponent<Rigidbody>().isKinematic=true; //Remove Physics
        GetComponent<PlayerMovement>().enabled=false; //disable movements
        Invoke(nameof(ReloadLevel),1f); //Restart by loading again the name 
        isdead = true;


    }
    void ReloadLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
