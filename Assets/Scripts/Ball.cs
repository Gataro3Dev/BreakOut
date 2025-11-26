using UnityEngine;
using UnityEngine.InputSystem;

public class Ball : MonoBehaviour
{
    public float BallInitialVelocity = 600f;
    private Rigidbody ballRigidBody;
    private bool isBallInPlay = false;

    private void Awake()
    {
        ballRigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (!isBallInPlay && Input.GetKeyDown(KeyCode.Space))
        {
            transform.parent = null;
            isBallInPlay = true;
            ballRigidBody.isKinematic = false;
            ballRigidBody.AddForce(new Vector3(BallInitialVelocity, BallInitialVelocity, 0));
        }
    }
}
