// Dieses Skript erstellt eine Verbindung mit dem Oculus-Controller und liest die Werte des Trigger- und Gripbuttons.
// Diese Werte werden in den Variablen triggervalue und GripValue gespeichert.
// Weiterhin liest es die Position und Orientierung des Controllers und weist diese der virtuellen Hand zu.
// Dafür muss dieses Skript an der Hand angeweiesen sein.

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ControllerRead : MonoBehaviour
{
    private InputDevice targetDevice;
    public static float triggerValue, gripValue;
    [SerializeField] Transform Controller;
    void Start()
	{
		List<InputDevice> devices = new List<InputDevice>();
        InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
		InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);
		if(devices.Count > 0)
        {
            targetDevice = devices[0];
        }
	}
    void Update()
    {
        targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float trigVal);
        targetDevice.TryGetFeatureValue(CommonUsages.grip, out float gripVal);
        triggerValue = trigVal;
        gripValue = gripVal;
        this.transform.position = Controller.position;
        if(InitialiseTinker.IMUConnect == false) this.transform.rotation = Controller.rotation;
        this.transform.eulerAngles = TinkerIO.IMU_Orientation;
    }
}