using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float obstacleSpeed = 3f;


    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D obstacleRB = GetComponent<Rigidbody2D>();
        obstacleRB.velocity = Vector2.left * obstacleSpeed;
        GameManager.Instance.currentObstacleSpeed = obstacleSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
