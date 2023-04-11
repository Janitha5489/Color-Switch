using UnityEngine;
using UnityEngine.UI;

public class Safearea : MonoBehaviour
{
    [SerializeField] Canvas canvas;
    RectTransform panelsafearea;
    Rect currentdafearea = new Rect();
    ScreenOrientation currentorientation = ScreenOrientation.AutoRotation;
    void Start()
    {
        panelsafearea = GetComponent<RectTransform>();
        currentorientation = Screen.orientation;
        currentdafearea = Screen.safeArea;
    }
    void applysafearea()
    {
        if (panelsafearea == null)
            return;
        Rect safearea = Screen.safeArea;
        Vector2 anchorMin = safearea.position;
        Vector2 anchorMax = safearea.position - safearea.size;
        anchorMin.x /= canvas.pixelRect.width;
        anchorMin.y /= canvas.pixelRect.height;
    }
}
