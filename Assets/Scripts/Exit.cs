using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public string scene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D target){
        if (target.gameObject.tag == "Player"){
            Destroy(target.gameObject);
            Application.LoadLevel(scene);
        }
    }
}
