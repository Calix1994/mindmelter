using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextToMeshConverter{

    public List<string> textList = new List<string>();
    public MeshFont myFont;

    void createMesh(string text)
    {
        createMesh(text, 0, 0, 0);
    }


    void createMesh(string text, float xPos, float yPos, float zPos)
    {
        // The list of GameObjects that will be Instantiated
        List<GameObject> meshesToCreate = new List<GameObject>();

        // Make sure that all text is Upper Case
        string myText = text;
        myText.ToUpper();

        // Convert string to an array of characters, to make parsing easier
        char[] myTextArray = myText.ToCharArray();

        #region Populate meshesToCreate...
        for (int i = 0; i >= myTextArray.Length; i++)
        {

            switch (myTextArray[i])
            {
                case 'A':
                    {
                        meshesToCreate.Add(myFont.mesh_A);
                        break;
                    }
                case 'B':
                    {
                        meshesToCreate.Add(myFont.mesh_B);
                        break;
                    }
                case 'C':
                    {
                        meshesToCreate.Add(myFont.mesh_C);
                        break;
                    }
                case 'D':
                    {
                        meshesToCreate.Add(myFont.mesh_D);
                        break;
                    }
                case 'E':
                    {
                        meshesToCreate.Add(myFont.mesh_E);
                        break;
                    }
                case 'F':
                    {
                        meshesToCreate.Add(myFont.mesh_F);
                        break;
                    }
                case 'G':
                    {
                        meshesToCreate.Add(myFont.mesh_G);
                        break;
                    }
                case 'H':
                    {
                        meshesToCreate.Add(myFont.mesh_H);
                        break;
                    }
                case 'I':
                    {
                        meshesToCreate.Add(myFont.mesh_I);
                        break;
                    }
                case 'J':
                    {
                        meshesToCreate.Add(myFont.mesh_J);
                        break;
                    }
                case 'K':
                    {
                        meshesToCreate.Add(myFont.mesh_K);
                        break;
                    }
                case 'L':
                    {
                        meshesToCreate.Add(myFont.mesh_L);
                        break;
                    }
                case 'M':
                    {
                        meshesToCreate.Add(myFont.mesh_M);
                        break;
                    }
                case 'N':
                    {
                        meshesToCreate.Add(myFont.mesh_N);
                        break;
                    }
                case 'O':
                    {
                        meshesToCreate.Add(myFont.mesh_O);
                        break;
                    }
                case 'P':
                    {
                        meshesToCreate.Add(myFont.mesh_P);
                        break;
                    }
                case 'Q':
                    {
                        meshesToCreate.Add(myFont.mesh_Q);
                        break;
                    }
                case 'R':
                    {
                        meshesToCreate.Add(myFont.mesh_R);
                        break;
                    }
                case 'S':
                    {
                        meshesToCreate.Add(myFont.mesh_S);
                        break;
                    }
                case 'T':
                    {
                        meshesToCreate.Add(myFont.mesh_T);
                        break;
                    }
                case 'U':
                    {
                        meshesToCreate.Add(myFont.mesh_U);
                        break;
                    }
                case 'V':
                    {
                        meshesToCreate.Add(myFont.mesh_V);
                        break;
                    }
                case 'W':
                    {
                        meshesToCreate.Add(myFont.mesh_W);
                        break;
                    }
                case 'X':
                    {
                        meshesToCreate.Add(myFont.mesh_X);
                        break;
                    }
                case 'Y':
                    {
                        meshesToCreate.Add(myFont.mesh_Y);
                        break;
                    }
                case 'Z':
                    {
                        meshesToCreate.Add(myFont.mesh_Z);
                        break;
                    }
                default:
                    {
                        Debug.LogWarning("Attempted to create mesh of unrecognized or unsupported character /'" + myTextArray[i] + "/'. Mesh has not been created.");
                        break;
                    }
            }
        }
        #endregion
                      
    }
} 
