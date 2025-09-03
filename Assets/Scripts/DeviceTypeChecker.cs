using UnityEngine;

public class DeviceTypeChecker : MonoBehaviour
{
    GameObject Player;
    DesktopController DController;

    MobileController MController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.Find("DodgyThePlayer");
        DeviceType deviceType = SystemInfo.deviceType;

        if (deviceType == DeviceType.Desktop)
        {
            DController = Player.GetComponent<DesktopController>();
            DController.enabled = true;
            Debug.Log("Your Device Type is a Desktop");
        }
        if (deviceType == DeviceType.Handheld)
        {
            if (Application.isMobilePlatform == true)
            {
                MController = Player.GetComponent<MobileController>();
                MController.enabled = true;
                Debug.Log("Your Device Type is a Mobile");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
