using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool attachedToHand = false;
    public bool highlightOnHover = false;
}

public class Throwable : MonoBehaviour
{
}

public class IgnoreHovering : MonoBehaviour
{
}

public class InteractTaskTrigger : MonoBehaviour
{
}

public class CircularDrive : MonoBehaviour
{
    public bool rotateGameObject = true;
}

public class Hand : MonoBehaviour
{
    public void HideController(bool value = false)
    {
    }

    public void ShowController(bool value = false)
    {
    }

    public void DetachObject()
    {
    }
}

public class HandleTrigger : MonoBehaviour
{
    public void MusicBoxOpen()
    {
    }
}

public class shooter : MonoBehaviour
{
    public void loadMagazine()
    {
    }
}

public class LinearMapping : MonoBehaviour
{
    public float value;
}

public class LightSwitch : MonoBehaviour
{
    public bool on = false;
}

public class CutterScript : MonoBehaviour
{
    public bool passed = false;
}

public class FlashLightGrabbed : MonoBehaviour
{
    public bool passed = false;
}

public class Teleport : MonoBehaviour
{
    public static Teleport instance;
    public static Teleport Instance;

    void Awake()
    {
        instance = this;
        Instance = this;
    }

   

  

    public void CancelTeleportHint()
    {
    }

    public void ShowTeleportHint()
    {
    }
}

public static class InputManager
{
    public static float GetAxis(string axisName)
    {
        return Input.GetAxis(axisName);
    }

    public static bool GetButton(string buttonName)
    {
        return Input.GetButton(buttonName);
    }

    public static bool GetButtonDown(string buttonName)
    {
        return Input.GetButtonDown(buttonName);
    }
}

public static class Input_Sources
{
    public static object LeftHand;
}

public static class hapticAction
{
    public static void Execute(params object[] args)
    {
    }
}

public static class XrHelpers
{
    public static bool IsSinglePassStereo ()
    {
       return false;
    }
}