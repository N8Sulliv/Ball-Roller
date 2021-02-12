using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelector : MonoBehaviour
{
    Color Gray = new Color(128, 128, 128);
    Color Red = new Color(255, 0, 0);
    Color Blue = new Color(0,0,255);
    Color Purple = new Color(129, 0, 255);

    public static Color playerColor;
    public Dropdown colorSelect;

    public void colorChange()
    {
        switch (colorSelect.value)
        {
            default:
                playerColor = Gray;
                break;
            case 1:
                playerColor = Red;
                break;
            case 2:
                playerColor = Blue;
                break;
            case 3:
                playerColor = Purple;
                break;
        }
    }
}
