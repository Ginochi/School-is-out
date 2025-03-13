using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private int searchingRadius;

    private NavMeshAgent _myNavMeshAgent;
    private Vector3 _playerLocation;
    private Vector3 _idleLocation;
    
    void Start()
    {
        _myNavMeshAgent = GetComponent<NavMeshAgent>();
        _idleLocation = transform.position;
    }

    void Update()
    {
        _playerLocation = GetPlayerLocation();
        LookForPlayer();
    }

    void LookForPlayer()
    {
        if (Vector3.Distance(transform.position, _playerLocation) < searchingRadius)
        {
            SetDestinationTo(_playerLocation);
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
    
    Vector3 GetPlayerLocation()
    {
        return GameObject.FindWithTag("Player").transform.position;
    }
}
