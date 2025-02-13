using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class Scene_Manager : MonoBehaviour
{
    public enum SCENE_LIST
    {
        MAIN_MENU,
        LOAD_SHEET_MUSIC
    }
    private static Scene_Manager instance = null;

    void Awake()
    {
        if (null == instance)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);

            DontDestroyOnLoad(this.gameObject);
        }
    }

    public static Scene_Manager Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }

    public void Change_Scene(SCENE_LIST _Scene_List)
    {
        if(Cur_Scene_List != _Scene_List)
        {
            switch (_Scene_List)
            {
                case SCENE_LIST.MAIN_MENU:
                    SceneManager.LoadScene("Main_Menu");
                    break;
                case SCENE_LIST.LOAD_SHEET_MUSIC:
                    SceneManager.LoadScene("Load_Sheet_Music");
                    break;
            }
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private SCENE_LIST Cur_Scene_List;
}
