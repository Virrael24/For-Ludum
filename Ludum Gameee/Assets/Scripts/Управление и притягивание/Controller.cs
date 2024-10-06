using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Controller : MonoBehaviour
{
    public float moveSpeed = 5.0f;

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
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        direction.Normalize(); // ����������� �����������

        // ��������� �������� � Rigidbody
        Vector3 motion = direction * moveSpeed;
        rb.MovePosition(rb.position + motion * Time.deltaTime);
    }
}
//��� ������ ���������� ����������
