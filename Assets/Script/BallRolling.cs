using UnityEngine;

public class BallRolling : MonoBehaviour
{
    [SerializeField] private float pushForce = 10f;
    private Rigidbody rb;

    void Start()
    {
         rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        rb.AddForce(movement * pushForce);
    }
}
