using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSprite : MonoBehaviour
{
    public Sprite[] Sprites;
    public string resourceName;
    public int currentSprite = -1;

    // Start is called before the first frame update
    void Start()
    {
        if(resourceName != ""){
        Sprites = Resources.LoadAll<Sprite>(resourceName);

            if(currentSprite== -1)
                currentSprite = Random.Range(0, Sprites.Length);
            else if(currentSprite > Sprites.Length)
                currentSprite = Sprites.Length-1;

        GetComponent<SpriteRenderer>().sprite = Sprites[currentSprite];
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
