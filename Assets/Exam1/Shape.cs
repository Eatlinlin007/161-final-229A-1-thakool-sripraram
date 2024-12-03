using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName;

    public void Init(string shape)
    {
        this.shapeName = shape;
    }
    public abstract float CalculateArea();
    public virtual void Resize()
    {

    }
    public void Draw()
    {
        
    }
}
