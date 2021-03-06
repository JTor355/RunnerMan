using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 2;

    [SerializeField]
    private float increaseSpeed = 1;

    private Transform player;
    private float playerDistance;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        playerDistance = Vector3.Distance(transform.position, player.position);
        //Debug.Log(playerDistance);
        //Debug.Log(moveSpeed);
        Chase();
    }

    //increase speed overtime
    private float Speed() 
    {
        moveSpeed += increaseSpeed * Time.deltaTime;
        return moveSpeed;
    }

    private void Chase()
    {
        Vector3 targetPosition = new Vector3(player.position.x, player.position.y, player.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Speed() * Time.deltaTime);
        transform.LookAt(targetPosition);
    }

}
