using System.Collections.Generic;
using UnityEngine;

public class TriggerTagCheck : MonoBehaviour
{

    [SerializeField] private string[] _allowedTags = { "Player", "Enemy" };

    private readonly HashSet<GameObject> objectsInside = new HashSet<GameObject>();

    public bool IsAnyObjectInside => objectsInside.Count > 0;


    void OnTriggerEnter(Collider other)
    {
        if (!IsAllowedTag(other.tag))
            return;

        objectsInside.Add(other.gameObject);
    }
    void OnTriggerExit(Collider other)
    {
        if (!IsAllowedTag(other.tag))
            return;
        objectsInside.Remove(other.gameObject);
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
