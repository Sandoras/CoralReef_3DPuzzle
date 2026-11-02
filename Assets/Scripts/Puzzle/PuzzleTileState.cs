using UnityEngine;

public class PuzzleTileState : MonoBehaviour
{

    private MeshRenderer _renderer;

    public bool ChosenForPuzzle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _renderer = gameObject.GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeMaterial(Material material)
    {

    }
}
