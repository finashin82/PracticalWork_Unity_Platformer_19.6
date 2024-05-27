using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorAutoUpDown : MonoBehaviour
{
    private SliderJoint2D elevatorMovement;
    
    private float elevatorSpeedDown = -1f;
    private float elevatorSpeedUp = 1f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        elevatorMovement = GetComponent<SliderJoint2D>();
        
        // �������� ������������� ������ � ����� (���� �� ��� ������� � ����������)
        elevatorMovement.useMotor = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // ��� ���������� ������� ������ ��� ��������, ���� ���� ����� ��� ���� (������ �������� � ����������)
        if (elevatorMovement.limitState == JointLimitState2D.LowerLimit)
        {
            MotionElevator(elevatorSpeedUp);
        }
        else if (elevatorMovement.limitState == JointLimitState2D.UpperLimit)
        {
            MotionElevator(elevatorSpeedDown);
        }      
    }   

    /// <summary>
    /// �������� ����� (����������� �������� ����� ������� �� ��������)
    /// </summary>
    /// <param name="speed"></param>
    private void MotionElevator(float speed)
    {
        var elevatorMotor = elevatorMovement.motor;
        elevatorMotor.motorSpeed = speed;

        elevatorMovement.motor = elevatorMotor;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(this.transform);
        }
        else
        {
            collision.transform.SetParent(null);
        }
    }

    //private void OnTriggerStay2D(Collider2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        collision.transform.SetParent(transform);
    //    }
    //    else
    //    {
    //        collision.transform.SetParent(null);
    //    }
    //}
}
