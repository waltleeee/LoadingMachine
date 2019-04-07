
using UnityEngine;

public class WindowLoadingAnimationReporter : MonoBehaviour
{
    public LoadingMachineDisplay LoadingMachineDisplay;

    public void OpenWindowLoadingFinish()
    {
        LoadingMachineDisplay.OpenWindowAnimationFinish();
    }

    public void OffWindowLoadingAnimationFinish()
    {
        LoadingMachineDisplay.OffWindowLoadingAnimationFinish();
    }
}
