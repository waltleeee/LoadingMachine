
using UnityEngine;

public class FullScreenLoadingAnimationReporter : MonoBehaviour
{
    public LoadingMachineDisplay LoadingMachineDisplay;

    public void OpenFullScreenLoadingAnimationFinish()
    {
        LoadingMachineDisplay.OpenFullScreenAnimationFinish();
    }

    public void OffFullScreenLoadingAnimationFinish()
    {
        LoadingMachineDisplay.OffFullScreenLoadingAnimationFinish();
    }

    public void OpenFullScreenBlackFinish()
    {
        LoadingMachineDisplay.OpenFullScreenBlackFinish();
    }
}
