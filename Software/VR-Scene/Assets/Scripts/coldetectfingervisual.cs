using UnityEngine;

public class coldetectfingervisual : MonoBehaviour
{
    public static bool fingercollider = false;

    void OnTriggerEnter(Collider other)
    {
        fingercollider = true;
    }
    void OnTriggerExit(Collider collision)
    {
        fingercollider = false;
    }
}
