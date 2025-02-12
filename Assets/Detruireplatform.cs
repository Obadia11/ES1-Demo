using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detruireplatform : MonoBehaviour
{
    [SerializeField] private GameObject platform;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("platform"))
        {
            
                platform.SetActive(false);
                Debug.Log(platform.name + "a disparu");
                Destroy(platform);
        }
    }

    
}
