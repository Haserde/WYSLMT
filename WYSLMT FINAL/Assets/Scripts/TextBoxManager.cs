using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

	public GameObject textBox;
	public Text theDialogue;
	public TextAsset textFile;
	public GameObject button;
	public Text theChoice;

	public string[] textLines;
	
	public int currentLine;
	public int endAtLine;

	private bool isTyping = false;
	private bool cancelTyping = false;


	public float typeSpeed;



	//public PlayerController player;
	
	void Start () {
		if (textFile != null) {
			textLines = (textFile.text.Split ('\n'));
		}

		if(endAtLine == 0) {
		endAtLine = textLines.Length - 1; 
		}
	}

	void Update() {
	
		//theText.text = textLines[currentLine];

		if (Input.GetKeyDown (KeyCode.Return)) {
			if (!isTyping) {
				currentLine += 1;

				if (currentLine > endAtLine) {
					DisableTextBox ();
				} else {
					StartCoroutine(TextScroll(textLines[currentLine]));
				}
			} else if (isTyping && !cancelTyping) {
				cancelTyping = true;
			}
		}
	}

	private IEnumerator TextScroll (string lineofText){
		int letter = 0;
		theDialogue.text = "";
		isTyping = true;
		cancelTyping = false;
		while (isTyping && !cancelTyping && (letter < lineofText.Length - 1)) {
			theDialogue.text += lineofText [letter];
			letter += 1;
			yield return new WaitForSeconds(typeSpeed);
		}
		theDialogue.text = lineofText;
		isTyping = false;
		cancelTyping = false;
	}


	public void DisableTextBox(){
		textBox.SetActive (false);
	}

}

