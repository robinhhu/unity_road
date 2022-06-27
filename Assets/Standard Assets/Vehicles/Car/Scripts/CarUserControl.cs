using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        [SerializeField] private Transform m_Target; 
        private Vector3 p;
        private Rigidbody m_Rigidbody;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
            m_Rigidbody = GetComponent<Rigidbody>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
//             float h = CrossPlatformInputManager.GetAxis("Horizontal");
//             float v = CrossPlatformInputManager.GetAxis("Vertical");
// #if !MOBILE_INPUT
//             float handbrake = CrossPlatformInputManager.GetAxis("Jump");
//             m_Car.Move(h, v, v, handbrake);
// #else
//             m_Car.Move(h, v, v, 0f);
// #endif
            p = transform.position;
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
            Debug.Log(p.z);
            if(p.z > 10 && m_Rigidbody.velocity.z <= 0) {
                m_Car.Move(0, 0, -1f, 1f);
            }
            else if(p.z >= 240) {
                m_Car.Move(0f, 0f, -0.1f, 0f);
            }
            else if (p.z >= 200) {
                m_Car.Move(0f, -0.8f, 0f, 0f);
            }
            else {
                m_Car.Move(0f, 1f, 0f, 0f);
            }
        }
    }
}
