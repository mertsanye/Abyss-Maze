using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    public float smooth = 5.0f;
    public float rotateAngle = 30.0f;

    // Start is called before the first frame update
    void Start()
    {

    }
    
        

    

    // Update is called once per frame
    void Update()
    {
        //gets input from user
        float xRotation = Input.GetAxis("Horizontal") * rotateAngle;
        float zRotation = Input.GetAxis("Vertical") * rotateAngle;

        //convert the rotation angles into quartenions
        Quaternion brotation = Quaternion.Euler(xRotation, 0.0f, zRotation);

        //rotate
        transform.rotation = Quaternion.Slerp(transform.rotation, brotation, Time.deltaTime * smooth); 

    }
}
