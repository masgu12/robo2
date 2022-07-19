using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class Zombie : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject player;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        float dist = Vector3.Distance(transform.position, player.transform.position);
        anim.SetFloat("distance",dist);
        if (dist < 2.5f) agent.speed=0;
        else agent.Setdestination(player.transform.position);
    }
}
