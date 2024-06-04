using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : MonoBehaviour
{
    [SerializeField] private float Speed = 1.0f;
    [SerializeField] private float Distance = .3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object up and down along the y axis with a sine wave
        transform.position = new Vector3(transform.position.x, transform.position.y + ((Mathf.Sin(Time.time * Speed)/16)*Distance), transform.position.z);
        
    }
}
