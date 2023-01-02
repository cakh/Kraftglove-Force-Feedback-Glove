using UnityEngine;
using System;
public class TinkerIO : InitialiseTinker
{
    public static float[] fingerPosNorm = new float[4];
    private static int[] fingerPos = new int[4];
    private static short[] servoPos = new short[4];
    public static Vector3 IMU_Orientation;
    private static long[] millis = { 0, 0, 0, 0 };
    bool[] hearttimer = { false, false, false, false };

    void Update()
    {
        ReadPos();
        WritePos();
        if (IMUConnect) IMURead();
    }
    void ReadPos()
    {
        for (byte i = 0; i < 4; i++)
        {
            fingerPos[i] = rp[i].GetPosition();
            fingerPosNorm[i] = (fingerPos[i] - fingerOpen[i]) / (fingerClose[i] - fingerOpen[i]);
            if (fingerPosNorm[i] < 0) fingerPosNorm[i] = 0;
            if (fingerPosNorm[i] > 1) fingerPosNorm[i] = 1;
        }
    }
    void WritePos()
    {
         for (int i = 0; i < 4; i++)
         {
             if (coldetectthumbsmall.colfin[i]&& CollisionDetect.pickupobject != null && CollisionDetect.pickupobject.name != "heart")
             {    
                 servo.SetPosition((byte)i, Convert.ToInt16(servoOpen[i]));
                 millis[i] = DateTimeOffset.Now.ToUnixTimeMilliseconds();
             }

             else if ((coldetectthumbsmall.colfin[i]) == false && DateTimeOffset.Now.ToUnixTimeMilliseconds() - millis[i] > 150)
             {
                 servo.SetPosition((byte)i, Convert.ToInt16(servoClose[i]));
                 servo.Enable((byte)i);
             }
         }
        for (int i = 0; i < 4; i++)
        {
            if (CollisionDetect.pickupobject != null && CollisionDetect.pickupobject.name == "heart" && hearttimer[i] == false)
            {
                servo.SetPosition((byte)i, Convert.ToInt16(servoOpen[i]));
                millis[i] = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                hearttimer[i] = true;
            }
            if (DateTimeOffset.Now.ToUnixTimeMilliseconds() - millis[i] > 500 && hearttimer[i] == true)
            {
                servo.SetPosition((byte)i, Convert.ToInt16(servoClose[i]));
                servo.Enable((byte)i);
                hearttimer[i] = false;
            }
        }
    }
    void IMURead()
    {
        imu.GetOrientation(out x, out y, out z);
        IMU_Orientation = new Vector3(Convert.ToSingle(z) / 10, Convert.ToSingle(x) / 10, Convert.ToSingle(y) / 10);//-+-
    }
}
