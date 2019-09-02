using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public const int IDLE = 0;
    public const int OPENING = 1;
    public const int OPEN = 2;
    public const int CLOSING = 3;
    public float closeDelay = .5f;

    private int state = IDLE;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnOpenStart(){
        state = OPENING;
    }

    void OnOpenEnd(){
        state = OPEN;
    }

    void OnCloseStart(){
        state = CLOSING;
    }

    void OnCloseEnd(){
        state = IDLE;
    }

    void DissableCollidor2D(){
        GetComponent<Collider2D>().enabled = false;
    }

    void EnableCollidor2D(){
        GetComponent<Collider2D>().enabled = true;
    }

    public void Open(){
        animator.SetInteger ("AnimState", 1);
    }

    public void Close(){
        StartCoroutine (CloseNow ());
    }

    private IEnumerator CloseNow(){
        yield return new WaitForSeconds(closeDelay);
        animator.SetInteger ("AnimState", 2);
    }

}
