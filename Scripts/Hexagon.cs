using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
public Rigidbody2D rigidBody;
public float shrinkspeed = 4f;
//public float score = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody.rotation = Random.Range(0f,360f);
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = transform.localScale - Vector3.one * shrinkspeed * Time.deltaTime;
        if(transform.localScale.x <= 0.5f){      
            Destroy(gameObject);
        }
    }
}
