using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    [SerializeField] private Color _color = Color.green;
    public string ShapeName { get; private set; } = "Shape";

    private void Start()
    {
        SetColor();
    }

    private void SetColor()
    {
        GetComponent<MeshRenderer>().material.color = _color;
    }

    private void OnMouseDown()
    {
        DisplayText();
    }

    public virtual void DisplayText()
    {
        Debug.Log($"Click on the {ShapeName}: {gameObject.name}");
    }

}
