using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class playerFollow : MonoBehaviour
{
    
    private NavMeshAgent enemy;
    private Transform player;
    private Rigidbody enemyRb;
    public float speed=5;
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
        enemy = GetComponent<NavMeshAgent>();
        enemyRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (player.transform != null)
        {
            enemy.SetDestination(player.position);
            transform.LookAt(player.position);
        }
        if (player.transform == null)
        {
            enemy.SetDestination(new Vector3(0, 1, 0));
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce((collision.transform.position-transform.position) * 7, ForceMode.Impulse);
        }
    }
}
