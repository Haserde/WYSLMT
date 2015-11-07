using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

	public GameObject textBox;
	public Text theDialogue;
	public TextAsset textFile;
	public GameObject button;
	public Text theChoice1, theChoice2, theChoice3;

	public string[] textLines;
	
	public int currentLine;
	public int endAtLine;

	private bool isTyping = false;
	private bool cancelTyping = false;


	public float typeSpeed;

	private DialogueChoice currentDC;


	//public PlayerController player;
	
	void Start () {
		if (textFile != null) {
			textLines = (textFile.text.Split ('\n'));
		}

		if(endAtLine == 0) {
		endAtLine = textLines.Length - 1; 
		}
		DialogueManager.init ();
		changeText (DialogueManager.getAlexDialogueChoiceFromId (0));
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

	public void getNextChoiceBasedOnBox(int choiceNumber) {
		int idClickedOn = 0;
		if (choiceNumber == 1) {
			idClickedOn = currentDC.gotoId1;
		} else if (choiceNumber == 2) {
			idClickedOn = currentDC.gotoId2;
		} else if (choiceNumber == 3) {
			idClickedOn = currentDC.gotoId3;
		}

		DialogueChoice nextChoice = DialogueManager.getAlexDialogueChoiceFromId (idClickedOn);
		changeText (nextChoice);
	}

	public void changeText( DialogueChoice current) {
		currentDC = current;
		theDialogue.text = current.line;
		theChoice1.text = current.gotoLine1;
		theChoice2.text = current.gotoLine2;

		if (current.gotoId3 != null) {
			theChoice3.gameObject.SetActive( true );
			theChoice3.text = current.gotoLine3;
		} else {
			theChoice3.gameObject.SetActive( false );
		}
	}

}

