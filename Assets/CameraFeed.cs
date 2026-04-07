using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CameraFeed : MonoBehaviour
{
    private WebCamTexture webcamTexture;

    IEnumerator Start()
    {
        // Request permission
        yield return Application.RequestUserAuthorization(UserAuthorization.WebCam);

        if (Application.HasUserAuthorization(UserAuthorization.WebCam))
        {
            WebCamDevice[] devices = WebCamTexture.devices;

            if (devices.Length > 0)
            {
                webcamTexture = new WebCamTexture(devices[0].name);

                RawImage rawImage = GetComponent<RawImage>();
                rawImage.texture = webcamTexture;

                webcamTexture.Play();
            }
            else
            {
                Debug.Log("No camera found");
            }
        }
        else
        {
            Debug.Log("Camera permission denied");
        }
    }
}