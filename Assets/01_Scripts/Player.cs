using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public KeyCode upKey;
    public KeyCode downKey;

    void Update()
    {
        float movement = 0f;

        if (Input.GetKey(upKey))
            movement = speed * Time.deltaTime;
        else if (Input.GetKey(downKey))
            movement = -speed * Time.deltaTime;

        transform.Translate(0, movement, 0);

        // Clamp position
        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, -4f, 4f);
        transform.position = pos;
    }
}
