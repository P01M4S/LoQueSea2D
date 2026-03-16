using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rbody2D;
    private float movementSpeed = 5;

    void Awake()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rbody2D.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * movementSpeed, rbody2D.linearVelocity.y);
    }
}
