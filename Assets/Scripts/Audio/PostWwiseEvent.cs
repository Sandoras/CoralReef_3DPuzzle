using UnityEngine;

public class PostWwiseEvent : MonoBehaviour
{
    public AK.Wwise.Event WwiseEvent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        WwiseEvent.Post(gameObject);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
