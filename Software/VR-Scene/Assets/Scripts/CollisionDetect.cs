using UnityEngine;
public class CollisionDetect : coldetectthumbsmall
{
    public static GameObject collideobject =null, pickupobject = null;
    [SerializeField] Transform Hand;
    void Update()
    {
        if (objectnamefinger == objectnamethumb && objectnamefinger!= null)
        {
            collideobject = GameObject.Find(objectnamefinger);
            if (collideobject.tag == "cube" || collideobject.tag == "heart")
            {
                grabobject();
                pickupobject = collideobject;
            }
        }
        else collideobject = null;
        if (pickupobject!=null && collideobject ==null) dropobject();
        if(pickupobject)
        {
            if (TinkerIO.fingerPosNorm[1] < 0.05 && TinkerIO.fingerPosNorm[2] < 0.05 && TinkerIO.fingerPosNorm[3] < 0.05)
            {
                if(TinkerIO.fingerPosNorm[0] < 0.05) dropobject();
            }  
        }
    }
    private void dropobject()
    {
        pickupobject.transform.parent = null;
        pickupobject.GetComponent<Rigidbody>().useGravity = true;
        pickupobject.GetComponent<Rigidbody>().isKinematic = false;
        pickupobject = null;
    }
    private void grabobject()
    {
        collideobject.GetComponent<Rigidbody>().useGravity = false;
        collideobject.GetComponent<Rigidbody>().isKinematic = true; 
        collideobject.transform.parent = Hand;
    }
}
