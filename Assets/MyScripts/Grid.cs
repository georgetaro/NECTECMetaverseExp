using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Grid 
{
    private int width;
    private int height;
    private float cellSize;
    private int[,] gridArray;
    private TextMesh[,] debugTextArray;
    
    public Grid(int width, int height, float cellSize)
    {
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;
        
        gridArray = new int[width, height];
        debugTextArray = new TextMesh[width, height];

        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for(int y=0; y < gridArray.GetLength(1); y++)
            {
                debugTextArray[x, y] =  UtilsClass.CreateWorldText(gridArray[x, y].ToString(), null, GetWorldPosition(x, y) , 20, Color.white, TextAnchor.MiddleCenter, TextAlignment.Center, 1);
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x, y + 1),Color.white,100f);
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x+1, y), Color.white, 100f);
            }
        }
        //  Debug.DrawLine
        SetValue(2, 1, 56);
     }


    private Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x, 0, y) * cellSize;
    }

    public void SetValue(int x, int y, int value)
    {
        gridArray[x, y] = value;
        debugTextArray[x, y].text = gridArray[x, y].ToString();
    }
    //public static TextMesh CreateWorldText(Transform parent, string text, Vector3 localPosition, int fontSize, Color color, TextAnchor textAnchor, TextAlignment textAlignment, int sortingOrder)
    //{
    //    GameObject gameObject = new GameObject("World_Text", typeof(TextMesh));
    //    Transform transform = gameObject.transform;
    //    transform.SetParent(parent, false);
    //    transform.localPosition = localPosition;
    //    TextMesh textMesh = gameObject.GetComponent<TextMesh>();
    //    textMesh.anchor = textAnchor;
    //    textMesh.alignment = textAlignment;
    //    textMesh.text = text;
    //    textMesh.fontSize = fontSize;
    //    textMesh.color = color;
    //    textMesh.GetComponent<MeshRenderer>().sortingOrder = sortingOrder;
    //    return textMesh;
    //}
}
