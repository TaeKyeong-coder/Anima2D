using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float jumpForce = 1000.0f;
    float walkForce = 100.0f;
    float maxWalkSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }
        int key = 0;
        if (Input.GetKey(KeyCode.D)) key = 1;
        if (Input.GetKey(KeyCode.S)) key = -1;
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);
        if (speedx < this.maxWalkSpeed)
        {
            Debug.Log("speedx = "); Debug.Log(speedx);
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }
        if (key != 0)
            transform.localScale = new Vector3(key, 1, 1);
    }
}
