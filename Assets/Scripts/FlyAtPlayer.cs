using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    Transform player;
    [SerializeField] float moveSpeed = 0.2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        DestroyWhenReached();
        MoveTowardsPlayer();
    }
    void MoveTowardsPlayer()
    {
        float moveDelta = moveSpeed * Time.deltaTime;
        
        transform.position = Vector3.MoveTowards(transform.position, player.position, moveDelta);
   
    }
    void DestroyWhenReached()
    {
        if (transform.position == player.position)
        {
            Destroy(gameObject);
        }
    }
}
