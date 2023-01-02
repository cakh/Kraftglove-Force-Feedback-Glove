using UnityEngine;
using Tinkerforge;

public class InitialiseTinker : MonoBehaviour
{
    [SerializeField]public static bool IMUConnect = true;
    private static IPConnection ipcon;
    //private static string HOST = "192.168.42.1";
    private static string HOST = "localhost";
    private static int PORT = 4223;

    private static string ServoBrick = "6CRhQb";
    
    private static string Poti_T = "KUx";
    private static string Poti_In = "KUn";
    private static string Poti_Mi = "KUK";
    private static string Poti_R = "KVQ";

    private static string IMU_ID = "SdM";

    public static BrickServo servo;
    public static BrickletRotaryPotiV2[] rp = new BrickletRotaryPotiV2[4];
    public static BrickletIMUV3 imu;

    public static float[] fingerOpen = { -64, -84, -90, 82 };
    public static float[] fingerClose = { -120, -150, -140, 150 };
    public static int[] servoOpen = { 7500, 3800, -5000, -4000 };
    public static int[] servoClose = { 2000, -3800 ,2275, 3800 };
    public static short x, y, z;
    [SerializeField] public static bool GloveConnected = true;
    void Start()
    {
        if(GloveConnected)
        {
            ipcon = new IPConnection();
            servo = new BrickServo(ServoBrick, ipcon);
            ipcon.Connect(HOST, PORT);
            servo.SetOutputVoltage(6000);
            if (IMUConnect)
                imu = new BrickletIMUV3(IMU_ID, ipcon);
            rp[0] = new BrickletRotaryPotiV2(Poti_T, ipcon);
            rp[1] = new BrickletRotaryPotiV2(Poti_In, ipcon);
            rp[2] = new BrickletRotaryPotiV2(Poti_Mi, ipcon);
            rp[3] = new BrickletRotaryPotiV2(Poti_R, ipcon);
            for (byte i = 0; i < 4; i++)
            {
                servo.SetDegree(i, -9000, 9000);
                servo.SetPulseWidth(i, 700, 2400);
                servo.SetPeriod(i, 19500);
                servo.SetAcceleration(i, 65535);
                servo.SetVelocity(i, 65535);
            }
        }
    }
}
