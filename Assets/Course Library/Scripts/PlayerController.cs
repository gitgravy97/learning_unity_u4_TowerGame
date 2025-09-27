using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool hasPowerUp;
    public GameObject powerUpIndicator;
    private float powerUpStrength = 15f;
    
    public float speed = 5f;
    private Rigidbody playerBody;
    private GameObject focalPoint;
    
    void Start() {
        playerBody = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
        hasPowerUp = false;
    }

    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerBody.AddForce(focalPoint.transform.forward * forwardInput * speed);
        powerUpIndicator.transform.position = transform.position + new Vector3(0, 2.0f, 0);
    }

    void OnTriggerEnter(Collider otherObject) {
        if (otherObject.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            Destroy(otherObject.gameObject);
            StartCoroutine(PowerUpCountDownRoutine());
            powerUpIndicator.gameObject.SetActive(true);
        }
    }

    IEnumerator PowerUpCountDownRoutine() {
        yield return new WaitForSeconds(7);
        hasPowerUp = false;
        powerUpIndicator.gameObject.SetActive(false);
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerUp)
        {
            Rigidbody enemyRigidBody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);
            
            Debug.Log("Collided with " + collision.gameObject.name + " with powerup set to " + hasPowerUp);
            enemyRigidBody.AddForce(awayFromPlayer * powerUpStrength, ForceMode.Impulse);
        }
    }
}
