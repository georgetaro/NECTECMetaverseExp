using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTesting : MonoBehaviour
{

    public delegate void TestDelegate();
    public delegate bool TestBoolDelegate(int i);

    private TestDelegate testDelegateFunction;
    private TestBoolDelegate testBoolDelegateFunction;

    private Action testAction;
    private Action<int, float> testIntFloatAction;
    private Func<bool> testFunc;
    private Func<int, bool> testIntBoolFunc;

    // Start is called before the first frame update
    void Start()
    {

        //testDelegateFunction += () => { Debug.Log("Lambda expression"); };
        //testDelegateFunction += () => { Debug.Log("Second Lambda expression"); };
        //testDelegateFunction();

        //testIntFloatAction = (int i, float f) => { Debug.Log("Test int float action"); };
        //testIntFloatAction(5, 10.1f);

        //testFunc = () => false;

        //testIntBoolFunc = (int i) => { return i < 5 };

        //testBoolDelegateFunction = (int i) => { return i < 5; };
        //Debug.Log(testBoolDelegateFunction(1));


    }

    private void MyTestDelegateFunction()
    {
        Debug.Log("MyTestDelegateFunction");
    }

    private void MySecondTestDelegateFunction()
    {
        Debug.Log("MySecondTestDelegateFunction");
    }
    
    private bool MyTestBoolDelegateFunction(int i)
    {
        return i < 5;
    }
    
    
    // Update is called once per frame

    void Update()
    {
        
    }
}
