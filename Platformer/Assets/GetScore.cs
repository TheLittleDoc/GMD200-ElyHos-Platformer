using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //set text to score
        GetComponent<TMPro.TextMeshProUGUI>().text = "Score: " + GameManager.Instance.score;
        
    }
}
