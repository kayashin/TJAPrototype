/*
MESSAGE FROM CREATOR: This script was coded by Mena. You can use it in your games either these are commercial or
personal projects. You can even add or remove functions as you wish. However, you cannot sell copies of this
script by itself, since it is originally distributed as a free product.
I wish you the best for your project. Good luck!

P.S: If you need more cars, you can check my other vehicle assets on the Unity Asset Store, perhaps you could find
something useful for your game. Best regards, Mena.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrometeoCarController5 : MonoBehaviour
{
        // use carcontroller from CarController2.cs script
    public Transform carController;
    public Slider slider;
    
    //CAR SETUP

      [Space(20)]
      //[Header("CAR SETUP")]
      [Space(10)]
      [Range(20, 190)]
      public int maxSpeed = 90; //The maximum speed that the car can reach in km/h.
      [Range(10, 120)]
      public int maxReverseSpeed = 45; //The maximum speed that the car can reach while going on reverse in km/h.
      [Range(1, 10)]
      public int accelerationMultiplier = 2; // How fast the car can accelerate. 1 is a slow acceleration and 10 is the fastest.
      [Space(10)]
      [Range(10, 45)]
      public int maxSteeringAngle = 27; // The maximum angle that the tires can reach while rotating the steering wheel.
      [Range(0.1f, 1f)]
      public float steeringSpeed = 0.5f; // How fast the steering wheel turns.
      [Space(10)]
      [Range(100, 600)]
      public int brakeForce = 350; // The strength of the wheel brakes.
      [Range(1, 10)]
      public int decelerationMultiplier = 2; // How fast the car decelerates when the user is not using the throttle.
      [Range(1, 10)]
      public int handbrakeDriftMultiplier = 5; // How much grip the car loses when the user hit the handbrake.
      [Space(10)]
      public Vector3 bodyMassCenter; // This is a vector that contains the center of mass of the car. I recommend to set this value
                                    // in the points x = 0 and z = 0 of your car. You can select the value that you want in the y axis,
                                    // however, you must notice that the higher this value is, the more unstable the car becomes.
                                    // Usually the y value goes from 0 to 1.5.

    //WHEELS

      //[Header("WHEELS")]

      /*
      The following variables are used to store the wheels' data of the car. We need both the mesh-only game objects and wheel
      collider components of the wheels. The wheel collider components and 3D meshes of the wheels cannot come from the same
      game object; they must be separate game objects.
      */
      public GameObject frontLeftMesh;
      public WheelCollider frontLeftCollider;
      [Space(10)]
      public GameObject frontRightMesh;
      public WheelCollider frontRightCollider;
      [Space(10)]
      public GameObject rearLeftMesh;
      public WheelCollider rearLeftCollider;
      [Space(10)]
      public GameObject rearRightMesh;
      public WheelCollider rearRightCollider;

    //CAR DATA

      [HideInInspector]
      public float carSpeed; // Used to store the speed of the car.
      [HideInInspector]
      public bool isDrifting; // Used to know whether the car is drifting or not.
      [HideInInspector]

      public float distance = 7.0f;

    //PRIVATE VARIABLES

      /*
      IMPORTANT: The following variables should not be modified manually since their values are automatically given via script.
      */
      Rigidbody carRigidbody; // Stores the car's rigidbody.

    // Start is called before the first frame update
    
    void Start()
    {
      //In this part, we set the 'carRigidbody' value with the Rigidbody attached to this
      //gameObject. Also, we define the center of mass of the car with the Vector3 given
      //in the inspector.
      carRigidbody = gameObject.GetComponent<Rigidbody>();
      carRigidbody.centerOfMass = bodyMassCenter;
    }

    // Update is called once per frame
    void Update()
    {

      //CAR DATA

      carSpeed = 10;

      //CAR PHYSICS
        // if (button.toggle == True){
        //     transform.position = new Vector3(carController.position.x, carController.position.y, carController.position.z - distance);
        // }
        // else {
            //Debug.Log(myText.text);

        if (transform.position.z < -20)
        {
            if (slider.value == 10){
                distance = 7.0f;
            }
            if (slider.value == 15){
                distance = 9.0f;
            }
            if (slider.value == 20){
                distance = 11.0f;
            }
        }
        transform.position = new Vector3(carController.position.x, carController.position.y, carController.position.z - distance);
        if (slider.value == 10){
            if (distance < 7.0f){
                distance += 0.1f;
            }
            if (distance > 7.0f){
                distance -= 0.1f;
            }
        }
        if (slider.value == 15){
            if (distance < 9.0f){
                distance += 0.1f;
            }
            if (distance > 9.0f){
                distance -= 0.1f;
            }
        }
        if (slider.value == 20){
            if (distance < 11.0f){
                distance += 0.1f;
            }
            if (distance > 11.0f){
                distance -= 0.1f;
            }
        }
    }
}