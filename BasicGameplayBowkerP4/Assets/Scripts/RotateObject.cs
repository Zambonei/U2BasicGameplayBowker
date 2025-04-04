
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [Header("Rotation Amount (Degrees)")]
    public Vector3 rotationAmount = new Vector3(0f, 90f, 0f);

    void Start()
    {
        transform.Rotate(rotationAmount);
    }
}
