using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody playerBody;
    private GameObject focalPoint;
    
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerBody.AddForce(focalPoint.transform.forward * forwardInput * speed);
    }
}
