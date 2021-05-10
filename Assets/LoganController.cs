using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoganController : MonoBehaviour
{
    Rigidbody2D rigid2D;
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
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 2;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -2;

        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        if (key != 0)
            transform.localScale = new Vector3(key, 2, 1);
    }
}
