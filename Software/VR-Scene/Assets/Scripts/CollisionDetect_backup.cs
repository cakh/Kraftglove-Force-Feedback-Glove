using UnityEngine;
public class CollisionDetect_backup : MonoBehaviour
{
    private static bool[] col = new bool[4];
    public static bool[] iscollision = new bool[4];
    private string fingerTag;
    public Transform handpos;
    [SerializeField] bool parentObject = true;
    Rigidbody thisobj;
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            col[i] = false;
            iscollision[i] = false;
        }
        thisobj = GetComponent<Rigidbody>();
    }
    void OnTriggerEnter(Collider collision)
    {
        fingerTag = collision.gameObject.tag;
        if (fingerTag == "0") col[0] = true; 
        if (fingerTag == "1") col[1] = true;
        if (fingerTag == "2") col[2] = true;
        if (fingerTag == "3") col[3] = true;
    }
    void OnTriggerExit(Collider collision)
    {
        fingerTag = collision.gameObject.tag; 
        if (fingerTag == "00") col[0] = false;
        if (fingerTag == "10") col[1] = false;
        if (fingerTag == "20") col[2] = false;
        if (fingerTag == "30") col[3] = false;
    }
    private void Update()
    {
        for (int i = 0; i < 4; i++)
        {
            iscollision[i] = col[i];
        }
        if(parentObject == true)
        {
            if (col[0] == true)
            {
                if (col[1] == true || col[2] == true || col[3] == true)
                {
                    this.transform.parent = handpos;
                    thisobj.useGravity = false;
                    thisobj.isKinematic = true;
                    Debug.Log("pickup");
                }
            }
            else if (col[0] == false)
            {
                dropobject();
            }
            else if (col[0] == true && col[1] == false && col[2] == false && col[3] == false)
            {
                dropobject();
            }
            if (InitialiseTinker.GloveConnected == false)
            {
                if (ControllerRead.triggerValue < 0.1f || ControllerRead.gripValue < 0.1f)
                {
                    dropobject();
                }
            }
            else if (InitialiseTinker.GloveConnected == true)
            {
                if (TinkerIO.fingerPosNorm[1] < 0.1f)
                {
                    dropobject();
                }
                if (TinkerIO.fingerPosNorm[1] < 0.1f && TinkerIO.fingerPosNorm[2] < 0.1f && TinkerIO.fingerPosNorm[3] < 0.1f) dropobject();
            }
        }
    }
    private void dropobject()
    {
        this.transform.parent = null;
        thisobj.useGravity = true;
        thisobj.isKinematic = false;
    }
}
