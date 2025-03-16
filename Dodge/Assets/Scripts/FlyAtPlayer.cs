using UnityEngine;

public class FlyAtThePlayer : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1.0f;
    [SerializeField] Transform player;
    Vector3 playerPos;

    void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        playerPos = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos, Time.deltaTime * moveSpeed);
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPos)
        {
            Destroy(gameObject);
        }
    }
}
