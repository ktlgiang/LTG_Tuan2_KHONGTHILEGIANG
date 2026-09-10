using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Tạo ô nhập tốc độ trên Inspector
    public float moveSpeed = 1f;

    void Update()
    {
        // Làm cho nhân vật tự động di chuyển sang phải theo thời gian thực
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }
}