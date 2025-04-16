using UnityEngine;

public class JoystickController : MonoBehaviour
{
    public Joystick joystick;
    public float rotationSpeed = 100f;

    private GameObject currentModel;

    void Update()
    {
        currentModel = ActiveModelTracker.GetActiveModel();

        if (currentModel != null)
        {
            float horizontal = joystick.Horizontal;
            float vertical = joystick.Vertical;

            currentModel.transform.Rotate(Vector3.up, horizontal * rotationSpeed * Time.deltaTime, Space.World);
            currentModel.transform.Rotate(Vector3.right, vertical * rotationSpeed * Time.deltaTime, Space.World);
        }
    }
}