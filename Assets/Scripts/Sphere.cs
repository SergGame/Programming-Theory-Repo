using UnityEngine;

public class Sphere : Shape
{
    public override void DisplayText()
    {
        base.DisplayText();

        Debug.Log($"{gameObject.name} color");
    }
}
