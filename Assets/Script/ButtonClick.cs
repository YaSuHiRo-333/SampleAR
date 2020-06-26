using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    // Start is called before the first frame update
    /*
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */

    public void OnClickTitleButton()
    {
        //if (SceneManager.GetActiveScene().name == "Select")
          //  SceneManager.LoadScene("Title");
        //else if(SceneManager.GetActiveScene().name == "AR")
      //      SceneManager.LoadScene("Title");
    //    else if (SceneManager.GetActiveScene().name == "Collection")
  //          SceneManager.LoadScene("Title");
//        else if (SceneManager.GetActiveScene().name == "Community")
            SceneManager.LoadScene("Title");
    }
    

    public void OnClickSelectButton()
    {
        SceneManager.LoadScene("Select");
    }

    public void OnClickARButton()
    {
        SceneManager.LoadScene("AR");
    }

    public void OnClickCollectionButton()
    {
        SceneManager.LoadScene("Collection");
    }

    public void OnClickCommunityButton()
    {
        SceneManager.LoadScene("Community");
    }

    public void OnClickMaterialButton()
    {
        SceneManager.LoadScene("MaterialCreate");
    }

    public void OnClickObjectButton()
    {
        SceneManager.LoadScene("ObjectCreate");
    }

}
