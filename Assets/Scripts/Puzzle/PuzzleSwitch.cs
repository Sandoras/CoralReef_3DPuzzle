using Unity.Mathematics;
using UnityEngine;

public class PuzzleSwitch : MonoBehaviour
{
    private bool _isPlayerNearby;
    public bool IsOn { get; private set; }
    public TriggerTagCheck TriggerTagCheck;

    [Header("Switch Lever Setup")]
    public Transform SwitchTransform;
    [SerializeField] private float _switchTargetAngle;

    [Header("Light Setup")]
    public GameObject Light;


    void Update()
    {

        if (_isPlayerNearby && Input.GetKeyDown(KeyCode.E))
        {
            Toggle();
        }

        if (TriggerTagCheck.IsAnyObjectInside)
        {
            _isPlayerNearby = true;
            Light.SetActive(true);

        }
        else
        {
            _isPlayerNearby = false;
            Light.SetActive(false);
        }
    }


    public void Toggle()
    {

        IsOn = !IsOn;

        float switchTargetAngle = !IsOn ? -60 : _switchTargetAngle;
        SwitchTransform.localRotation = Quaternion.Euler(switchTargetAngle, 0, 0);
    }




}
