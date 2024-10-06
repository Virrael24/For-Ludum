using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ControllerTurn : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Скорость движения
    public float turnSpeed = 200.0f; // Скорость поворота

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // Отключаем вращение Rigidbody для управления персонажем
    }

    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float vertical = Input.GetAxis("Vertical"); // Используем только вертикальную ось (W и S)
        Vector3 direction = new Vector3(0, 0, vertical); // Движение по оси Z

        // Получаем горизонтальное направление (A и D) для поворота
        float horizontal = Input.GetAxis("Horizontal");
        if (horizontal != 0)
        {
            // Поворачиваем персонажа
            Quaternion turnRotation = Quaternion.Euler(0f, horizontal * turnSpeed * Time.deltaTime, 0f);
            rb.MoveRotation(rb.rotation * turnRotation);
        }

        // Применяем движение к Rigidbody
        Vector3 motion = direction * moveSpeed;
        rb.MovePosition(rb.position + rb.transform.TransformDirection(motion) * Time.deltaTime);
    }
}