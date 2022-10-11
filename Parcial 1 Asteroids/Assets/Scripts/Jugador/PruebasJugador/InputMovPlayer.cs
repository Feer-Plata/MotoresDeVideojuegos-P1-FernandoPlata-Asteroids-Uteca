using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMovPlayer : MonoBehaviour
{
    public static float vertical
    {
        get { return Input.GetAxis("Vertical"); }
    }

    public static float horizontal
    {
        get { return Input.GetAxis("Horizontal"); }
    }
    public static bool disp
    {
        get { return Input.GetKey (KeyCode.Space); }
    }



}
