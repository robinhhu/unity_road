using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myscript : MonoBehaviour
{
    private float currentSteerAngle;
    private float currentbreakForce;

    public Rigidbody rigidb;
    private float time = 0.0f;
    private Vector3 vchange;
    private Vector3 vchangelarge;
    private Vector3 lowerV;
    private Vector3 temp;
    private Vector3 horizontalVector;

    [SerializeField] private float motorForce;
    [SerializeField] private float breakForce;
    [SerializeField] private float maxSteerAngle;

    [SerializeField] private WheelCollider frontLeftWheelCollider;
    [SerializeField] private WheelCollider frontRightWheelCollider;
    [SerializeField] private WheelCollider rearLeftWheelCollider;
    [SerializeField] private WheelCollider rearRightWheelCollider;

    [SerializeField] private Transform frontLeftWheelTransform;
    [SerializeField] private Transform frontRightWheeTransform;
    [SerializeField] private Transform rearLeftWheelTransform;
    [SerializeField] private Transform rearRightWheelTransform;

    void Start()
    {
        rigidb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        HandleMotor();
        // HandleSteering();
        UpdateWheels();
        
    }


    private void HandleMotor()
    {
        //constant speed, not yielding
        time = time + Time.fixedDeltaTime;
        horizontalVector = new Vector3(-0.5f,0,11.11f);
        rigidb.velocity = new Vector3(0, 0, 11.11f); 
        if(gameObject.transform.position.z > 280 && gameObject.transform.position.x > 1.26f) {
            rigidb.velocity = horizontalVector; 
        } else{
            rigidb.velocity = new Vector3(0, 0, 11.11f); 
        }
        Debug.Log(gameObject.transform.position.z);
        Debug.Log(gameObject.transform.position.x);

        // red line, constant acceleration   
        // rigidb.velocity =  new Vector3(0, 0, 11.11f); 
        // horizontalVector = new Vector3(0.5f,0,11.11f);
        // time = time + Time.fixedDeltaTime;
        // vchange = new Vector3(0,0,1.5f);
        // if (time <= 2.316) {
            // if(gameObject.transform.position.z > 280 && gameObject.transform.position.x < 2.24f) {
            //     rigidb.velocity = horizontalVector; 
            // } else{
            //     rigidb.velocity =  new Vector3(0, 0, 11.11f); 
            // }
        // }
        // else 
        // {
        //     rigidb.velocity = rigidb.velocity - vchange * (time - 2.316f); 
        // }
        // if (rigidb.velocity.z <= 0 )
        // {
        //     rigidb.velocity = new Vector3(0,0,0f);
        // }
        //Debug.Log(rigidb.velocity.z);
        // Debug.Log(gameObject.transform.position.x);
        // Debug.Log(time);

        // green line, constant acceleration   
        // rigidb.velocity = new Vector3(0, 0, 11.11f);  
        // horizontalVector = new Vector3(0.5f,0,11.11f); 
        // lowerV = new Vector3(0,0,5.56f);
        // time = time + Time.fixedDeltaTime;
        // vchange = new Vector3(0,0,1.5f);
        // vchangelarge = new Vector3(0,0,3.0f);
        // if (time > 10.65f )
        // {
        //     rigidb.velocity = new Vector3(0,0,0f);
        // }
        // else if (time > 6.94f)
        // {
        //     rigidb.velocity = lowerV - vchange * (time - 6.946f);
        // }
        // else if (time > 4.15f) 
        // {
        //     rigidb.velocity = lowerV;
        // }
        // else if (time > 2.316f && rigidb.velocity.z >= 5.56f)
        // {
        //     rigidb.velocity = rigidb.velocity - vchangelarge * (time - 2.316f); 
        // } 
        // else if (time <= 2.316) {
        //     if(gameObject.transform.position.z > 280 && gameObject.transform.position.x < 2.24f) {
        //         rigidb.velocity = horizontalVector; 
        //     } else{
        //         rigidb.velocity =  new Vector3(0, 0, 11.11f); 
        //     }
        // }
        // Debug.Log(rigidb.velocity.z);
        // Debug.Log(time);
        // Debug.Log(gameObject.transform.position.z);


        //blue line, varying acceleration   
        // rigidb.velocity = new Vector3(0, 0, 11.11f);  
        // temp = new Vector3(0, 0, 11.11f);
        // time = time + Time.fixedDeltaTime;
        // vchange = new Vector3(0,0,0.1375f);
        // vchangelarge = new Vector3(0,0,0.55f);
        // if (time <= 8.0f) {
        //     rigidb.velocity = temp - vchange*time*time;
        // }
        // else if (time <= 10.0f ){
        //     rigidb.velocity = vchangelarge * (10.0f - time) * (10.0f - time);
        // } 
        // else 
        // {
        //     rigidb.velocity = new Vector3(0,0,0f);
        // }
        // Debug.Log(rigidb.velocity.z);
        // Debug.Log(time);
        // Debug.Log(gameObject.transform.position.z);
    }

    private void ApplyBreaking()
    {
        frontRightWheelCollider.brakeTorque = currentbreakForce;
        frontLeftWheelCollider.brakeTorque = currentbreakForce;
        rearLeftWheelCollider.brakeTorque = currentbreakForce;
        rearRightWheelCollider.brakeTorque = currentbreakForce;
    }

    private void HandleSteering()
    {
        //constant velocity
        // if(flag == false) {
        //     currentSteerAngle = maxSteerAngle * -1;
        //     frontLeftWheelCollider.steerAngle = currentSteerAngle;
        //     frontRightWheelCollider.steerAngle = currentSteerAngle;
        //     flag = true;
        // } 
        // if (flag == true) {
        //     currentSteerAngle = 0;
        //     frontLeftWheelCollider.steerAngle = currentSteerAngle;
        //     frontRightWheelCollider.steerAngle = currentSteerAngle;
        // }
        // frontLeftWheelCollider.transform.localEulerAngles = new Vector3(0f, frontLeftWheelCollider.steerAngle, 0f);
        // frontRightWheelCollider.transform.localEulerAngles = new Vector3(0f, frontRightWheelCollider.steerAngle, 0f);
        // Debug.Log(gameObject.transform.position.x);
        // float h = Input.GetAxis ("Horizontal");
        // float turn = h * speed * Time.deltaTime;
        // Quaternion turnRotation = Quaternion.Euler (0f, turn, 0f);
        // rigidb.MoveRotation (m_RigidBody.position + turnRotation);
    }

    private void UpdateWheels()
    {
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheeTransform);
        UpdateSingleWheel(rearRightWheelCollider, rearRightWheelTransform);
        UpdateSingleWheel(rearLeftWheelCollider, rearLeftWheelTransform);
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot
;       wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }
}
