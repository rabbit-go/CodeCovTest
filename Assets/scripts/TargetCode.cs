using UnityEngine;

public class TargetCode
{
    public void TestFunc(bool test1, bool test2)
    {
        if (test1)
        {
            Debug.Log("test1");
        }
        else if (test2)
        {
            Debug.Log("test2");
        }
        else
        {
            Debug.Log("else");
        }
    }
}