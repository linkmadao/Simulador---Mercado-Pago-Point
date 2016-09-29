using UnityEngine;
using UnityEngine.Advertisements;

public class unityADS : MonoBehaviour {

    public void ShowAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
}
