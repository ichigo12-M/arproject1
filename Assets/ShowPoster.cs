using UnityEngine;

public class ShowPoster : MonoBehaviour
{
    public GameObject poster;

    public void Show()
    {
        poster.SetActive(true);
    }
}