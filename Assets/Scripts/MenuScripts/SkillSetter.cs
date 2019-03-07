using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSetter: MonoBehaviour {

    // This is a skill enum! It's used to determine what the current selected skill is
    // We can use these states to allow the player to actually activate different skills
    // For example, we will write code for the "light" functionality, but it won't actually
    // do anything unless the CurrentSkill variable is set to LIGHT

    // Make sure to attach this to the player model 

    GameObject interactableObject = null;

    private bool ReadyToCreate = false;
    public Material NotInRange;
    public Material InRange;
    public enum Skill
    {
        HEAL,
        LIGHT,
        CREATE,
        RESURRECT,
        DEFAULT
    };

    public Skill CurrentSkill;
    public GameObject SkillMenu;
    //public int a;

    public void Start()
    {
        CurrentSkill = Skill.DEFAULT;
        //SkillMenu.GetComponent<Renderer>().enabled = false;
        SkillMenu.SetActive(false);
    }

    public void Update()
    {
        //Open and close menu
        if (Input.GetKeyDown("p")){
            SkillMenu.SetActive(!SkillMenu.activeSelf);
        }

        // Action button
        if (Input.GetKeyDown("k")){
            if(ReadyToCreate){
                interactableObject.GetComponent<InteractableCreateObjectFunctionality>().ChangeShape();
            }
        }
    }


    // At the moment these methods are activated by clcking the buttons. 
    // There are colliders attached to the button prefab so it should be a matter of getting
    // a collider checker on each button, to replace the "onClick" functionality. 
    public void OnHealthPress()
    {
        CurrentSkill = Skill.HEAL;
        Debug.Log("Currently on HEAL mode");
        ColliderReset();
    }

    public void OnLightPress()
    {
        CurrentSkill = Skill.LIGHT;
        Debug.Log("Currently on LIGHT mode");
        ColliderReset();
    }


    public void OnCreatePress()
    {
        CurrentSkill = Skill.CREATE;
        Debug.Log("Currently on CREATE mode");
        ColliderChecker(interactableObject);
    }

    public Skill GetSkill(){
        return CurrentSkill;
    }

    public void ColliderChecker(GameObject g){
        interactableObject = g;
        //Debug.Log("Interactbale object has been set " + interactableObject.name);
        if(CurrentSkill.ToString() == "CREATE" && g != null){
            Debug.Log("You are in range to cast CREATE");

            g.GetComponent<Renderer>().material = InRange;

            ReadyToCreate = true;
        }
    }

    public void ColliderReset()
    {
        if (interactableObject != null)
        {
            interactableObject.GetComponent<Renderer>().material = NotInRange;
            interactableObject = null;
           
        }
        ReadyToCreate = false;
    }

    /*public void SetInteractableObject(GameObject g){
        interactableObject = g;
    }*/

   



}
