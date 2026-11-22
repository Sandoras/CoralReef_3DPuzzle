using UnityEngine;

public class SwitchPuzzleAudio : MonoBehaviour
{
    public AK.Wwise.Event WwiseEvent;

    public AK.Wwise.State InsideSphere;
    public AK.Wwise.State OutsideSphere;
    public AK.Wwise.RTPC IsPlayerInside;

    [SerializeField] private bool _isInside;
    [SerializeField] private float IsPlayerInsideDebug;

    private MoveAndRespawn _moveAndRespawn;

    void Awake()
    {
        _moveAndRespawn = GetComponentInParent<MoveAndRespawn>();
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        WwiseEvent.Post(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        //IsPlayerInsideDebug = IsPlayerInside.GetValue(gameObject);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _isInside = true;
            IsPlayerInside.SetValue(gameObject, 1);
            InsideSphere.SetValue();
            _moveAndRespawn.CanMove = false;
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _isInside = false;
            IsPlayerInside.SetValue(gameObject, 0);
            OutsideSphere.SetValue();
            _moveAndRespawn.CanMove = true;
        }
    }
}
