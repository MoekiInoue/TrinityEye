using UnityEngine;
using UnityEditor;

public class CustomLayout : MonoBehaviour
{
    private const string LAYOUT_PATH = "Assets/SeikaGameKit/Layouts/SGKitLayout.wlt";

    [MenuItem("SeikaGameKit/Layouts/Load Custom Layout")]
    static void LoadCustomLayout()
    {
        if (System.IO.File.Exists(LAYOUT_PATH))
        {
            EditorUtility.LoadWindowLayout(LAYOUT_PATH);
        }
        else
        {
            Debug.LogWarning("Layout not loaded. Layout file missing at: " + LAYOUT_PATH);
        }
    }
}
