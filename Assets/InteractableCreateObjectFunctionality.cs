using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableCreateObjectFunctionality : MonoBehaviour {

    // This is a script that will be placed around objects of interest with the create functionality. 
    // As th eplayer gets close to the obejct th eobject should begin to glow in some way. Then by
    // pressing the button of choice, the object will turn into another object. 
    // eg. Debris  -> Ladder
    // Just add the meshes of choice to the 
    Collider playerCollider = null;
    public GameObject otherObject;
    public string selectedSkill = "";
    private GameObject g;

    private void Awake()
    {
        g = gameObject;
        //otherObject.GetComponent<Renderer>().enabled = false;
    }
    private void Update()
    {
        if(playerCollider != null){
            
        }
    }

    public void OnTriggerEnter(Collider collider)
    {
        //This checks for the player by checking the player tag. If the player is not tagged as 
        //'Player' this function won't work

        if(collider.gameObject.transform.tag == "Player"){
            Debug.Log("Player has entered the collider");
            collider.gameObject.GetComponent<SkillSetter>().ColliderChecker(gameObject);
            //collider.gameObject.GetComponent<SkillSetter>().SetInteractableObject(gameObject);

            /*playerCollider = collider;
            Debug.Log("I see the player!");
            Debug.Log(collider.gameObject.GetComponent<SkillSetter>().GetSkill().ToString());
            if (collider.gameObject.GetComponent<SkillSetter>().GetSkill().ToString() == "CREATE")
            {

                //Let's make the cube glow at this point
                Debug.Log("Menu options now matter");
                selectedSkill = "CREATE";
            }*/

        } 
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject != null)
        {
            if (other.gameObject.transform.tag == "Player")
            {
                other.gameObject.GetComponent<SkillSetter>().ColliderReset();
            }
        }

    }

    public void ChangeShape()
    {
        Debug.Log("Change Shape!");
        Instantiate(otherObject, gameObject.transform.position, gameObject.transform.localRotation);
        Destroy(gameObject);
        otherObject.GetComponent<Renderer>().enabled = true;
        //Mesh holder = otherShape;
        //otherShape = gameObject.GetComponent<MeshFilter>().mesh;
        //gameObject.GetComponent<MeshFilter>().mesh = holder;

    }
}
