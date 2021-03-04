using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class myAiCarController : MonoBehaviour
{
    [SerializeField]
    private Transform Destination1;
    [SerializeField]
    private Transform Destination2;
    [SerializeField]
    private Transform Destination3;

    //private Transform Destination3;

    private NavMeshAgent Agent;

    
    // Start is called before the first frame update
    void Start()
    {
        Agent = this.GetComponent<NavMeshAgent>();
        if (Agent == null)
        {
            Debug.LogError("not attached ");
        }
        else
        {
            SetDestination();
        }
    }

    private void SetDestination()
    {
        // if (Destination1 != null)
        // {
        //     Vector3 targetVector1 = Destination1.transform.position;
        //     Agent.SetDestination(targetVector1);
        //     
        //     
        //     
        //     targetVector1 = Destination2.transform.position;
        //     Agent.SetDestination(targetVector1);
        //     //Destination1 = null;
        //
        // }
        
        Vector3 targetVector1 = Destination1.transform.position;
        Agent.SetDestination(targetVector1);
            
            
            
        targetVector1 = Destination2.transform.position;
        Agent.SetDestination(targetVector1);
        
        targetVector1 = Destination3.transform.position;
        Agent.SetDestination(targetVector1);
    }


    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.GetComponent<Collider>().enabled = false;
        }
        yield return new WaitForSeconds(.001f);
        //this.GetComponent<BoxCollider>().enabled = true;
    }

}
