using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    // https://forum.unity.com/threads/how-to-create-object-reference-to-text-mesh-pro-object.505796/
    // add "using TMPro;" to top of script and use a "TextMeshProUGUI" variable instead of a "Text" one

    [SerializeField] Text textComponent;
    [SerializeField] TextMeshProUGUI textComponentImproved;
    [SerializeField] State startingState;


    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
        textComponentImproved.text = state.GetStateStory(); // to use the Text Mesh Pro text fields
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        State[] nextStates = state.GetNextState();

        for (int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = nextStates[i];
            }
        }


        /*        if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    state = nextStates[0];
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    state = nextStates[1];
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    state = nextStates[2];
                }*/
        textComponent.text = state.GetStateStory();
        textComponentImproved.text = state.GetStateStory();
    }
}
