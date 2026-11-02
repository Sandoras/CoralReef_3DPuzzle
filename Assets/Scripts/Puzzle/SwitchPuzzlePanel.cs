using System;
using System.Collections.Generic;
using UnityEngine;

// [Flags]
// public enum SwitchMask
// {
//     None = 0,
//     A = 1 << 0,
//     B = 1 << 1,
//     C = 1 << 2,
//     D = 1 << 3,
//     E = 1 << 4,

// }

public class SwitchPuzzlePanel : MonoBehaviour
{
    [Header("Button Setup")]
    // private GameObject _switch1;
    // private GameObject _switch2;
    // private GameObject _switch3;
    // private GameObject _switch4;
    // private GameObject _switch5;

    [SerializeField] private List<PuzzleSwitch> switches = new List<PuzzleSwitch>();

    //public int currentCode = 0b01101;
    private readonly int targetCode;

    public void ToggleSwitch(int switchIndex)
    {
        //currentCode() ^= (1 << switchIndex);

        if (IsSolved())
        {
            print("Win");
        }
    }

    // public void Reset()
    // {
    //     currentCode() = 0;
    // }

    public bool IsSolved()
    {
        return currentCode() == targetCode;
    }

    private int currentCode()
    {
        int code = 0;
        for (int i = 0; i < switches.Count; i++)
        {
            if (switches[i].IsOn)
            {
                code |= (1 << i);
            }
        }

        return code;
    }

}
