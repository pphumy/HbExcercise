using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3 : MonoBehaviour
{
    private enum MovementState
    {
        Forward,
        Backward,
        None
    }

    private MovementState state = MovementState.Forward;
    private Vector3[] targetPoints; // Chứa 3 điểm bất kỳ

    private int currentTargetIndex = 0;
    private float speed = 2f;
    [SerializeField] Transform Apoint, Bpoint, CPoint;

    private void Start()
    {
        // Khởi tạo các điểm bất kỳ (ví dụ)
        targetPoints = new Vector3[]
        {
            Apoint.position,
            Bpoint.position,
            CPoint.position,
        };
    }

    private void Update()
    {
        if (state == MovementState.None)
        {
            // Đối tượng đã hoàn thành việc di chuyển qua 3 điểm, thực hiện hành động khác (nếu cần)
            Debug.Log("Hoàn thành di chuyển qua 3 điểm, đang chờ...");
            return;
        }

        Vector3 targetPosition = targetPoints[currentTargetIndex];
        //Ex4
        //transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);
        transform.position = Vector3.Slerp(transform.position, targetPosition, Time.deltaTime * speed);

        // Kiểm tra xem đối tượng đã đến điểm đích chưa
        if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
        {
            //Random huong di chuyen
            currentTargetIndex = (Random.Range(1,4)) % targetPoints.Length;
            // Đổi hướng di chuyển
            //currentTargetIndex = (currentTargetIndex+1) % targetPoints.Length;

            //// Nếu đã đi qua tất cả 3 điểm, quay trở về điểm đầu tiên
            //if (currentTargetIndex == 0)
            //{
            //    //state = MovementState.Backward;
            //}
        }
    }
}
