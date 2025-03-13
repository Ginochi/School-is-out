using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] GameObject fence;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            Debug.Log("Ball hit the target");
            Destroy(fence);
        }
    }
}
