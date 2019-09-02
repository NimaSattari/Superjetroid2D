using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public AudioClip pickupSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D target){
        if (target.gameObject.tag=="Player")
            if(pickupSound)
                AudioSource.PlayClipAtPoint(pickupSound, transform.position);
        Destroy (gameObject);
    }
}
