using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGun : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float rotateSpeed = 15.0f; // Degrees per second

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        //Debug.Log(hInput);
        // Input.GetAxis: Returns a value from -1.0 till
        // 1.0 depending on the duration we have been
        // pressing the key. Can be set up in
        // Edit->Project Settings->Input->Axes

        // Time.deltaTime = Multiplying by Time.deltaTime
        // Makes the movement frame independent. Now, it is
        // in m/s
        //transform.Translate(new Vector3(0, 0, hInput) * Time.deltaTime * moveSpeed);

        // MICROCHALLENGE: Make the gun move forward and backwards.
        // Pause the video and try.
        float vInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(hInput, 0, vInput) * Time.deltaTime * moveSpeed);

        // MICROCHALLENGE: Make the gun rotate with <- and -> keys
        // Pause the video and try.
        //transform.Rotate(new Vector3(0, hInput, 0) * Time.deltaTime * rotateSpeed);

    }
}
