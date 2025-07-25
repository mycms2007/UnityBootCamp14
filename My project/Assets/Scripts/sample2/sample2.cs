using System;
using UnityEngine;

public class sample2 : MonoBehaviour
{
    
    public enum Projection
    {
        Perspective = 1 << 0, Orthographic = 2
    }

    [Flags]
    public enum FeildofviewAxis
    {
        vertical = 1 << 0,
        horizontal = 1 << 1,//1에서 1칸 이동하겠습니다. (비트 연산)

    }
}

    