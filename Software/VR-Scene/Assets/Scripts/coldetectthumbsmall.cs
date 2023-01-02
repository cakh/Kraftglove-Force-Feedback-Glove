
using UnityEngine;
public class coldetectthumbsmall : MonoBehaviour
{
    public static string objectnamethumb;
    public static string objectnamefinger;
    public static bool[] colfin = new bool[4];
    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "cube" || collision.gameObject.tag == "heart")
        {
            objectnamethumb = collision.gameObject.name;
            colfin[0] = true;
        }
    }
    void OnTriggerExit(Collider collision)
    {
        objectnamethumb = null;
        colfin[0] = false;
    }
}
