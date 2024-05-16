using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorAutoUpDown : MonoBehaviour
{
    private SliderJoint2D elevatorMovement;
    
    private float elevatorSpeedDown = -2f;
    private float elevatorSpeedUp = 2f;
    
    
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
}
