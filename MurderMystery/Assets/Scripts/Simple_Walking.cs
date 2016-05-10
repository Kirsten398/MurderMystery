using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]

public class Simple_Walking : MonoBehaviour {

    float Speed = 0.1f;
    public Transform target1;
    public Transform target2;
    private float direction = 1.0f;
    private float currentPosition = 0.0f;

    void Start() {
        
    }

    void Update()
    {
        currentPosition += Speed* Time.deltaTime;
        transform.position = Vector3.Lerp(target1.position, target2.position, Mathf.PingPong(currentPosition, 1));
    }

}
