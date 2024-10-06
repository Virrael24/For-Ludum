using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ControllerTurn : MonoBehaviour
{
    public float moveSpeed = 5.0f; // �������� ��������
    public float turnSpeed = 200.0f; // �������� ��������

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // ��������� �������� Rigidbody ��� ���������� ����������
    }

    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float vertical = Input.GetAxis("Vertical"); // ���������� ������ ������������ ��� (W � S)
        Vector3 direction = new Vector3(0, 0, vertical); // �������� �� ��� Z

        // �������� �������������� ����������� (A � D) ��� ��������
        float horizontal = Input.GetAxis("Horizontal");
        if (horizontal != 0)
        {
            // ������������ ���������
            Quaternion turnRotation = Quaternion.Euler(0f, horizontal * turnSpeed * Time.deltaTime, 0f);
            rb.MoveRotation(rb.rotation * turnRotation);
        }

        // ��������� �������� � Rigidbody
        Vector3 motion = direction * moveSpeed;
        rb.MovePosition(rb.position + rb.transform.TransformDirection(motion) * Time.deltaTime);
    }
}