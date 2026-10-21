
using UnityEngine;
using System.Collections;

public class AirplaneTakeoff : MonoBehaviour
{
    public float takeoffDelay = 1f;
    public float flySpeed = 3f;
    public float liftSpeed = 0.3f;

    private bool isFlying = false;

    void Start()
    {
        StartCoroutine(StartTakeoff());
    }

    IEnumerator StartTakeoff()
    {
        // Cho canh xoay xong trong 1 giay
        yield return new WaitForSeconds(takeoffDelay);

        // Bat dau bay
        isFlying = true;
    }

    void FixedUpdate()
    {
        if (isFlying)
        {
            Vector3 movement =
                (Vector3.forward * flySpeed +
                 Vector3.up * liftSpeed) * Time.fixedDeltaTime;

            transform.position += movement;
        }
    }
}
