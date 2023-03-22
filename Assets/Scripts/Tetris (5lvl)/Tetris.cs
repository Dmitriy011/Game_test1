using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tetris : MonoBehaviour
{
    private float x;
    private float y;
    private float z;

    public GameObject J, Z, O, L, I, cube_2, cube_7, RED_Z;
    private Transform some_transform;

    void Start()
    {
        CreateFigures();
    }

    void CreateFigures()
    {
        for (int i = 0; i < 8; i++)
        {
            //int rnd_x = new Random().Next();
            int min_x;
            int max_x;

            int rnd_z;
            int min_z;
            int max_z;

        }
        
        GameObject.Instantiate(J, new Vector3(758.04f, 0.8f, 148.74f), Quaternion.identity); //создание объекта //Quaternion.identity - поворот 
        GameObject.Instantiate(Z, new Vector3(756.11f, 0.8f, 150.07f), Quaternion.identity); //создание объекта //Quaternion.identity - поворот
        GameObject.Instantiate(O, new Vector3(756.11f, 0.8f, 152.51f), Quaternion.identity); //создание объекта //Quaternion.identity - поворот                                                                                           
        GameObject.Instantiate(L, new Vector3(758.84f, 0.8f, 152.51f), Quaternion.identity); //создание объекта //Quaternion.identity - поворот 
        GameObject.Instantiate(I, new Vector3(754.75f, 0.8f, 154.46f), Quaternion.identity); //создание объекта //Quaternion.identity - поворот 
        GameObject.Instantiate(cube_2, new Vector3(756.67f, 0.8f, 154.14f), Quaternion.identity); //создание объекта //Quaternion.identity - поворот 
        GameObject.Instantiate(cube_7, new Vector3(758.84f, 0.8f, 154.46f), Quaternion.identity); //создание объекта //Quaternion.identity - поворот 
        GameObject.Instantiate(RED_Z, new Vector3(754.75f, 0.8f, 156.52f), Quaternion.identity); //создание объекта //Quaternion.identity - поворот  

       /* x = 758f;
        y = 4f;
        z = 174;

        for (float i_x = 752f; i_x <= x; i_x++)
        {
            for (float k_z = 165f; k_z <= z; k_z++)
            {
                GameObject.Instantiate(apple, new Vector3(i_x, 0.8f, k_z), Quaternion.identity); //создание объекта //Quaternion.identity - поворот
                k_z += 0.25f;
            }
            i_x += 0.25f;
        }*/

    }

}
