using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody r3d;
    [Header("速度")]
    [Range(1,100)]
    public float speed = 1;
    [Header("跳躍")]
    [Range(1, 100)]
    public float jump = 1;
    [Header("有無接觸地面")]
    public bool isGround;
    

    // Use this for initialization
    void Start()
    {
        r3d = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        Jump();
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGround = true;
        Debug.Log("touch" + collision.gameObject);
    }

    private void Walk()
    {
        r3d.AddForce(new Vector3(speed * Input.GetAxis("Horizontal"), 0, 0));
        r3d.AddForce(new Vector3(0, 0, speed * Input.GetAxis("Vertical")));

    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            isGround = false;
            r3d.AddForce(new Vector3(0, jump, 0));
        }

    }
}
