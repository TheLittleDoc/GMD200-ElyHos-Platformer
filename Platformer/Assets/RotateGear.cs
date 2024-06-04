using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGear : MonoBehaviour
{
    [SerializeField] private float Speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
//        Rotate once every 10 seconds
        transform.Rotate(0, 0, Time.deltaTime*Speed);
        
    }
}
