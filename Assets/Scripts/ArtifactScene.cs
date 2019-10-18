using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactScene : MonoBehaviour
{
    public GameObject Exit;

    private void Start()
    {
        Exit.GetComponent<BoxCollider2D>().enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Exit.GetComponent<BoxCollider2D>().enabled = true;
    }

}
