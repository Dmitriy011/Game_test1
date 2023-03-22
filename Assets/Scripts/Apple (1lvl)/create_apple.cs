using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputManagerEntry;

public class create_apple : MonoBehaviour
{
    private float x; 
    private float y; 
    private float z;

    public GameObject apple;
    private Transform some_transform;

    void Start()
    {
        CreateApple();
    }

    void CreateApple()
    {
        GameObject.Instantiate(apple, new Vector3(758.04f, 50.49f, 148.74f), Quaternion.identity); //создание объекта //Quaternion.identity - поворот 
        GameObject.Instantiate(apple, new Vector3(756.11f, 50.49f, 150.07f), Quaternion.identity); //создание объекта //Quaternion.identity - поворот
        GameObject.Instantiate(apple, new Vector3(756.11f, 50.49f, 152.51f), Quaternion.identity); //создание объекта //Quaternion.identity - поворот                                                                                           
        GameObject.Instantiate(apple, new Vector3(758.84f, 50.49f, 152.51f), Quaternion.identity); //создание объекта //Quaternion.identity - поворот 
        GameObject.Instantiate(apple, new Vector3(754.75f, 50.49f, 154.46f), Quaternion.identity); //создание объекта //Quaternion.identity - поворот 
        GameObject.Instantiate(apple, new Vector3(756.67f, 50.49f, 154.14f), Quaternion.identity); //создание объекта //Quaternion.identity - поворот 
        GameObject.Instantiate(apple, new Vector3(758.84f, 50.49f, 154.46f), Quaternion.identity); //создание объекта //Quaternion.identity - поворот 
        GameObject.Instantiate(apple, new Vector3(754.75f, 50.49f, 156.52f), Quaternion.identity); //создание объекта //Quaternion.identity - поворот 
        GameObject.Instantiate(apple, new Vector3(757.2f, 50.49f, 156.52f), Quaternion.identity); //создание объекта //Quaternion.identity - поворот 
        GameObject.Instantiate(apple, new Vector3(760.37f, 50.49f, 156.52f), Quaternion.identity); //создание объекта //Quaternion.identity - поворот 
        GameObject.Instantiate(apple, new Vector3(758.51f, 50.49f, 157.64f), Quaternion.identity); //создание объекта //Quaternion.identity - поворот 
        GameObject.Instantiate(apple, new Vector3(756.81f, 50.49f, 158.35f), Quaternion.identity); //создание объекта //Quaternion.identity - поворот 

        x = 758f;
        y = 4f;
        z = 174;

        for (float i_x = 752f; i_x <= x; i_x++)
        {
            for (float k_z = 165f; k_z <= z; k_z++)
            {
                GameObject.Instantiate(apple, new Vector3(i_x, 50.49f, k_z), Quaternion.identity); //создание объекта //Quaternion.identity - поворот
                k_z+= 0.25f;
            }
            i_x+= 0.25f;
        }

    }
}
