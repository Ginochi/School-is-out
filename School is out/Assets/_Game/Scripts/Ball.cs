using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] GameObject fence;
    [SerializeField] GameObject Text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Text.SetActive(false);
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
            Text.SetActive(true);
        }
    }
}
