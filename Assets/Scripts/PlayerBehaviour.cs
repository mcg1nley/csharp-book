using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerBehaviour : MonoBehaviour
{
    // 1
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;

    // 2
    private float _vinput;
    private float _hinput;

    // Update is called once per frame
    void Update()
    {
        // 3 
        _vinput = Input.GetAxis("Vertical") * MoveSpeed;

        // 4
        _hinput = Input.GetAxis("Horizontal") * RotateSpeed;

        // 5
        this.transform.Translate(Vector3.forward * _vinput * Time.deltaTime);

        // 6
        this.transform.Rotate(Vector3.up * _hinput * Time.deltaTime);
    }
}
