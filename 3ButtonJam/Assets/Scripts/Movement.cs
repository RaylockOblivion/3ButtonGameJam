using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            direction = new Vector3(0, 0, -speed) * Time.deltaTime;
        }
        else if(Input.GetAxis("Horizontal") < 0)
        {
            direction = new Vector3(0, 0, +speed) * Time.deltaTime;
        }

        transform.Rotate(direction);
    }
}
