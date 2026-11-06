using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveAndRespawn : MonoBehaviour
{
    [SerializeField] private Vector3 _endPosition;
    public GameObject EndPositionGameObject;

    [SerializeField] private Vector3 _startPosition;

    [SerializeField] private float _moveSpeed;

    public bool CanMove;
    public bool RespawnOnEnd;

    void Awake()
    {
        _startPosition = transform.position;
        _endPosition = EndPositionGameObject.transform.position;

    }


    // Update is called once per frame
    void Update()
    {
        if (CanMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, _endPosition, _moveSpeed * Time.deltaTime);

            if (transform.position == _endPosition)
            {
                if (RespawnOnEnd)
                { transform.position = _startPosition; }

                else { CanMove = false; }
            }
        }


    }
}
