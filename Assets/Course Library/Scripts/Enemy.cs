using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Rigidbody enemyBody;
    private GameObject player;
    
    void Start()
    {
        enemyBody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }
    
    void Update() {
        Vector3 directionOfPlayer = player.transform.position - transform.position.normalized;
        enemyBody.AddForce(directionOfPlayer * speed);
    }
}
