using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePointDeterminer : PointDeterminer
{
    public override Vector3 GetPoint()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
