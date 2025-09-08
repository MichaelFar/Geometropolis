using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.Image;

public class GridManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] gridSpaces;

    public GameObject[] possibleShapes;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            InstantiateRandomShapeToGridSpace();
        }
    }

    void InstantiateRandomShapeToGridSpace()
    {
        var rand_shape_index = Random.Range(0, possibleShapes.Length);

        var rand_space_index = Random.Range(0, gridSpaces.Length);

        print("rand shape index is " + rand_shape_index);

        gridSpaces[rand_space_index].GetComponent<GamePlane>().AddBlockToPlane(possibleShapes[rand_shape_index]);
    }
}
