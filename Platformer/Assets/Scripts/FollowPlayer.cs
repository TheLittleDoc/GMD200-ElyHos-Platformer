using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //lerp to player, a little ahead of player
        transform.position = Vector3.Lerp(transform.position, new Vector3(player.position.x + 4, player.position.y, transform.position.z), 3f * Time.deltaTime);
    }
}
