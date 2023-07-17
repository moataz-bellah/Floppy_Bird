using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    //public Text scoreText;
  //  public TextMeshPro scoreText;
//    public TextMeshPro scoreText2;
    public TextMeshPro scoreText;

//    public TextElement scoreText;
    // Update is called once per frame
    public void updateScore()
    {
       
        int number = int.Parse(scoreText.text);
        scoreText.text = (number+1).ToString(); 
    }
    
}
