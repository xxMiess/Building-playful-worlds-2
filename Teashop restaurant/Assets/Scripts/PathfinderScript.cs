using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PathfinderScript : MonoBehaviour {

    private NavMeshAgent agent;
    private Animator anim;
    public Transform target;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        //anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //agent.SetDestination(target.position);

        if (Input.GetMouseButtonDown (0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Vector3 newTargetPos = hit.point;
                Debug.Log(newTargetPos);
                agent.SetDestination(newTargetPos);
            }

            //anim.SetFloat ("speed", agent.velocity.magnitude);
        }
    }
}
