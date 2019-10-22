using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayFromAgentTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = transform.TransformDirection(new Vector3(0, 0, 1)) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);
        Vector3 backward = transform.TransformDirection(new Vector3(0, 0, -1)) * 10;
        Debug.DrawRay(transform.position, backward, Color.green);
        Vector3 left = transform.TransformDirection(new Vector3(-1, 0, 0)) * 10;
        Debug.DrawRay(transform.position, left, Color.green);
        Vector3 right = transform.TransformDirection(new Vector3(1, 0, 0)) * 10;
        Debug.DrawRay(transform.position, right, Color.green);

        Vector3 forward_right = transform.TransformDirection(new Vector3(1, 0, 1)) * 10;
        Debug.DrawRay(transform.position, forward_right, Color.green);
        Vector3 forward_left = transform.TransformDirection(new Vector3(-1, 0, 1)) * 10;
        Debug.DrawRay(transform.position, forward_left, Color.green);
        Vector3 backward_right= transform.TransformDirection(new Vector3(1, 0, -1)) * 10;
        Debug.DrawRay(transform.position, backward_right, Color.green);
        Vector3 backward_left = transform.TransformDirection(new Vector3(-1, 0, -1)) * 10;
        Debug.DrawRay(transform.position, backward_left, Color.green);

        Vector3 forward_up = transform.TransformDirection(new Vector3(0, 1, 1)) * 10;
        Debug.DrawRay(transform.position, forward_up, Color.green);
        Vector3 backward_up = transform.TransformDirection(new Vector3(0, 1, -1)) * 10;
        Debug.DrawRay(transform.position, backward_up, Color.green);
        Vector3 right_up = transform.TransformDirection(new Vector3(-1, 1, 0)) * 10;
        Debug.DrawRay(transform.position, right_up, Color.green);
        Vector3 left_up = transform.TransformDirection(new Vector3(1, 1, 0)) * 10;
        Debug.DrawRay(transform.position, left_up, Color.green);

        Vector3 forward_right_up = transform.TransformDirection(new Vector3(1, 1, 1)) * 10;
        Debug.DrawRay(transform.position, forward_right_up, Color.green);
        Vector3 forward_left_up = transform.TransformDirection(new Vector3(-1, 1, 1)) * 10;
        Debug.DrawRay(transform.position, forward_left_up, Color.green);
        Vector3 backward_right_up = transform.TransformDirection(new Vector3(1, 1, -1)) * 10;
        Debug.DrawRay(transform.position, backward_right_up, Color.green);
        Vector3 backward_left_up = transform.TransformDirection(new Vector3(-1, 1, -1)) * 10;
        Debug.DrawRay(transform.position, backward_left_up, Color.green);

        Vector3 forward_down = transform.TransformDirection(new Vector3(0, -1, 1)) * 10;
        Debug.DrawRay(transform.position, forward_down, Color.green);
        Vector3 backward_down = transform.TransformDirection(new Vector3(0, -1, -1)) * 10;
        Debug.DrawRay(transform.position, backward_down, Color.green);
        Vector3 right_down = transform.TransformDirection(new Vector3(-1, -1, 0)) * 10;
        Debug.DrawRay(transform.position, right_down, Color.green);
        Vector3 left_down = transform.TransformDirection(new Vector3(1, -1, 0)) * 10;
        Debug.DrawRay(transform.position, left_down, Color.green);

        Vector3 forward_right_down = transform.TransformDirection(new Vector3(1, -1, 1)) * 10;
        Debug.DrawRay(transform.position, forward_right_down, Color.green);
        Vector3 forward_left_down = transform.TransformDirection(new Vector3(-1, -1, 1)) * 10;
        Debug.DrawRay(transform.position, forward_left_down, Color.green);
        Vector3 backward_right_down = transform.TransformDirection(new Vector3(1, -1, -1)) * 10;
        Debug.DrawRay(transform.position, backward_right_down, Color.green);
        Vector3 backward_left_down = transform.TransformDirection(new Vector3(-1, -1, -1)) * 10;
        Debug.DrawRay(transform.position, backward_left_down, Color.green);

        Vector3 up = transform.TransformDirection(new Vector3(0, 1, 0)) * 10;
        Debug.DrawRay(transform.position, up, Color.green);
        Vector3 down = transform.TransformDirection(new Vector3(0, -1, 0)) * 10;
        Debug.DrawRay(transform.position, down, Color.green);

    }
}
