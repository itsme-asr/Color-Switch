using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speedRotate = 100f;
    void Update()
    {
        transform.Rotate(0f, 0f, speedRotate * Time.deltaTime);

    }
}
