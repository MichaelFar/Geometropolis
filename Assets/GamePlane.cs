using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class GamePlane : MonoBehaviour
{
    // Start is called before the first frame update

    private List<GameObject> blocks = new List<GameObject>();

    private int recentBlockIndex = 0; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddBlockToPlane(GameObject block_to_add)
    {

        GameObject parent = gameObject;

        recentBlockIndex = blocks.Count - 1;

        if (recentBlockIndex > -1)
        {
            parent = blocks[recentBlockIndex].GetComponent<BlockNode>().topMarker;
        }

        blocks.Add(Instantiate(block_to_add, parent.transform, false));

        

        
    }
}
