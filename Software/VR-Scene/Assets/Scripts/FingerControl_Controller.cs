// Dieses Skript liest die Werte triggerValue und gripValue aus dem Skript ControllerRead und berechnet die Fingerbeugung.
using UnityEngine;
public class FingerControl_Controller : ControllerRead
{
    public Transform Thumb_PP, Thumb_DP, Thumb_MP, Index_MC, Index_PP, Index_MP, Index_DP, Middle_MC, Middle_PP, Middle_MP, Middle_DP, Ring_MC, Ring_PP, Ring_MP, Ring_DP, Pinky_MC, Pinky_PP, Pinky_MP, Pinky_DP;
    void Update()
    {
        BendThumb();
        BendIndex();
        BendMiddle();
        BendRing();
        BendPinky();
    }
    void BendThumb()
    {
        Thumb_PP.localEulerAngles = new Vector3(67 + gripValue * 33, 25 - gripValue * 85, 90 - gripValue * 90);
        Thumb_MP.localEulerAngles = new Vector3(0 - gripValue * 80, 156 - gripValue * 16, 21 + gripValue * 40);
        Thumb_DP.localEulerAngles = new Vector3(0 - gripValue * 55, 0 + gripValue * 50, 0 - gripValue * 20);
    }
    void BendIndex()
    {
        Index_MC.localEulerAngles = new Vector3(0 - triggerValue * 15, 0, 0);
        Index_PP.localEulerAngles = new Vector3(-triggerValue * 68, 0, 0);
        Index_MP.localEulerAngles = new Vector3(-triggerValue * 65, 0, 0);
        Index_DP.localEulerAngles = new Vector3(-triggerValue * 40, 0, 0);
    }
    void BendMiddle()
    {
        Middle_MC.localEulerAngles = new Vector3(0 - triggerValue * 15, 0, -2.147f);
        Middle_PP.localEulerAngles = new Vector3(-triggerValue * 68, 0, 3.406f);
        Middle_MP.localEulerAngles = new Vector3(-triggerValue * 65, 0, -4.018f);
        Middle_DP.localEulerAngles = new Vector3(-triggerValue * 40, 0, 3.936f);
    }
    void BendRing()
    {
        Ring_MC.localEulerAngles = new Vector3(0 - triggerValue * 15, 0, -9.717f);
        Ring_PP.localEulerAngles = new Vector3(-triggerValue * 68, 0, -6.179f);
        Ring_MP.localEulerAngles = new Vector3(-triggerValue * 65, 0, 0);
        Ring_DP.localEulerAngles = new Vector3(-triggerValue * 40, 0, 1.766f);
    }
    void BendPinky()
    {
        Pinky_MC.localEulerAngles = new Vector3(0 - triggerValue * 15, 0, -9.717f);
        Pinky_PP.localEulerAngles = new Vector3(-triggerValue * 68, 0, -6.179f);
        Pinky_MP.localEulerAngles = new Vector3(-triggerValue * 65, 0, 0);
        Pinky_DP.localEulerAngles = new Vector3(-triggerValue * 40, 0, 1.766f);
    }

    
}
