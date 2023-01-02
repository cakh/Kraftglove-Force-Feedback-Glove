using UnityEngine;

public class coldetectthumbvisual : MonoBehaviour
{
    public static bool thumbcollider = false;
    void OnTriggerEnter(Collider collision)
    {
        thumbcollider = true;
    }
    void OnTriggerExit(Collider collision)
    {
        thumbcollider = false;
    }
}
