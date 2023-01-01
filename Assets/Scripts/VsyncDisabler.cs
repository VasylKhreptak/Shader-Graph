using UnityEngine;

public class VsyncDisabler : MonoBehaviour
{
    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = int.MaxValue;
    }
}
