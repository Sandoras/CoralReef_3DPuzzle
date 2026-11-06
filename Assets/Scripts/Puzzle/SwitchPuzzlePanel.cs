using System;
using System.Collections.Generic;
using UnityEngine;


public class SwitchPuzzlePanel : MonoBehaviour
{
    [Header("Button Setup")]
    [SerializeField] private List<PuzzleSwitch> switches = new List<PuzzleSwitch>();

    //public int currentCode = 0b01101;
    [SerializeField] private int targetCode = 0b01101;

    [SerializeField] private int currentInputCode;

    public MoveAndRespawn DoorScript;

    void Update()
    {

        currentInputCode = currentCode();
        if (IsSolved())
        {
            //print("Win");
            DoorScript.CanMove = true;
        }

    }

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
                code |= (1 << (switches.Count - 1 - i));
            }
        }

        return code;
    }

}
