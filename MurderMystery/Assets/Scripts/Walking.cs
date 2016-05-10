using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Director;

[RequireComponent(typeof(CharacterController))]

public class Walking : MonoBehaviour {
    public CharacterController controller;

    public Transform target;
    public Transform trans;
    public Rigidbody rb;
    float maxSpeed = 2;
    float radius = 1;
    float timeToTarget = 1;

    // Use this for initialization
    void Start() {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 toTarget = target.position - trans.position;

        if (toTarget.magnitude < radius)
        {
            return;
        }

        toTarget /= timeToTarget;

        if (toTarget.magnitude > maxSpeed)
        {
            toTarget.Normalize();

            toTarget *= maxSpeed;
        }

        rb.velocity = toTarget;
        controller.SimpleMove(Vector3.forward);

        transform.rotation = Quaternion.Lerp(trans.rotation, Quaternion.LookRotation(toTarget), 0.2f);
    }
}