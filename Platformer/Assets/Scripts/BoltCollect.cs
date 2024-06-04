using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltCollect : MonoBehaviour


{

    public int boltCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Nut"))
        {
            Debug.Log("Bolt Collected");
            //access singleton
            GameManager.Instance.score += 1;
            Destroy(collision.gameObject);
        }
    }
}
