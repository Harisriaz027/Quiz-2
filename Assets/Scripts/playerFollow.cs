using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class playerFollow : MonoBehaviour
{
    
    private NavMeshAgent enemy;
    private Transform player;
    public float speed=5;
    public bool canDie;
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
        enemy = GetComponent<NavMeshAgent>();
        canDie = false;
        
 
    }

    void Update()
    {
        
            enemy.SetDestination(player.position);
            transform.LookAt(player.position);
            
     
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("wall") && canDie == true)
        {
            Destroy(gameObject);
            Score.score++;
        }
    }
}
