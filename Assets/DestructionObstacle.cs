using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionObstacle : MonoBehaviour
{
    
    void OnCollisionEnter(Collision collision){
        print(collision.gameObject.name + " : " + collision.gameObject.tag);
        if(collision.gameObject.CompareTag("Obstacle4")){
            Destroy(collision.gameObject);
        }
    }

    void OnTriggerEnter(Collider collision){
if(collision.gameObject.name=="Bille"){
gameObject.SetActive(false);
}
else{
Debug.Log("Nothing happened");
}
}
}
