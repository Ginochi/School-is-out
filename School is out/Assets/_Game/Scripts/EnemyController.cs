using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private int searchingRadius;
    [SerializeField] private GameObject target;

    private NavMeshAgent _myNavMeshAgent;
    private Vector3 _idleLocation;
    
    void Start()
    {
        _myNavMeshAgent = GetComponent<NavMeshAgent>();
        _idleLocation = transform.position;
    }

    void Update()
    {
        LookForPlayer();
    }

    void LookForPlayer()
    {
        if (Vector3.Distance(transform.position, target.transform.position) < searchingRadius)
        {
            SetDestinationTo(target.transform.position);
        }
        else
        {
            SetDestinationTo(_idleLocation);
        }
    }

    void SetDestinationTo(Vector3 playerLocation)
    {
        _myNavMeshAgent.SetDestination(playerLocation);
    }
}
