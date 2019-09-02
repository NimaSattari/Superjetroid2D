using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{

    public BodyPart bodyPart;
    public int totalParts = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D target){
        if (target.gameObject.tag == "Deadly"){
            OnExplode();
        }
    }

    void OnCollisionEnter2D(Collision2D target){
        if (target.gameObject.tag == "Deadly"){
            OnExplode();
        }
    }

    public void OnExplode(){
        Destroy (gameObject);

        var t = transform;

        for (int i = 0; i < totalParts; i++){
            BodyPart clone = Instantiate(bodyPart, t.position, UnityEngine.Quaternion.identity) as BodyPart;
            clone.GetComponent<Rigidbody2D>().AddForce(Vector3.right * (Random.Range(-50,50)));
            clone.GetComponent<Rigidbody2D>().AddForce(Vector3.up * Random.Range(100,400));
        }

        GameObject go = new GameObject ("ClickToContinue");
        ClickToContinue script = go.AddComponent<ClickToContinue>();
        script.scene = Application.loadedLevelName;
        go.AddComponent<DisplayRestartText>();
    }

}
