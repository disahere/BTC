using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int spaceCount = 0;
    public Text spaceCountText;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceCount++;
            spaceCountText.text = " " + spaceCount + " Score";
        }
    }
}
