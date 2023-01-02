using UnityEngine;
public class HandControl : TinkerIO
{
    [SerializeField]
    Transform Controller;
    public  Vector3 angleAdjust = new Vector3(90, 90, 0);
    void Update()
    {
        this.transform.position = Controller.position;
        if (IMUConnect) this.transform.eulerAngles = IMU_Orientation + angleAdjust;
        else this.transform.rotation = Controller.rotation;
    }
}
