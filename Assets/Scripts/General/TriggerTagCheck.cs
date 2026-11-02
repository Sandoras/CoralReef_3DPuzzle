using System.Collections.Generic;
using UnityEngine;

public class TriggerTagCheck : MonoBehaviour
{

    [SerializeField] private string[] _allowedTags = { "Player", "Enemy" };

    private readonly HashSet<GameObject> objectsInside = new HashSet<GameObject>();

    public bool IsAnyObjectInside => objectsInside.Count > 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (!IsAllowedTag(other.tag))
            return;

        objectsInside.Add(other.gameObject);
    }

    private bool IsAllowedTag(string tag)
    {
        foreach (string allowedTag in _allowedTags)
        {
            if (allowedTag == tag)
                return true;
        }

        return false;
    }
}
