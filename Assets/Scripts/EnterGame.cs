
using UnityEngine;

public class EnterGame : MonoBehaviour
{
    public Canvas GameMenu;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AirplaneTakeoff airplane =
                other.GetComponent<AirplaneTakeoff>();

            if (airplane != null)
            {
                airplane.enabled = false;
            }

            GameMenu.enabled = true;
        }
    }
}
