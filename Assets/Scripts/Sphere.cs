using UnityEngine;

public class Sphere : Shape // INHERITANCE
{
    // POLYMORPHISM
    public override void DisplayText()
    {
        base.DisplayText();

        Debug.Log($"{gameObject.name} color");
    }
}
