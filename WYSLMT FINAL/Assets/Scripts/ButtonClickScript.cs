using UnityEngine;
using System.Collections;

public class ButtonClickScript : MonoBehaviour {

	public int buttonNumber = 1;
	public TextBoxManager tbm;

	public void buttonPressed() {
		//give textBoxManager the number of this button
		//textBoxManager.ButtonPressed(buttonNumber);
		print (buttonNumber);
		tbm.getNextChoiceBasedOnBox(buttonNumber);

	}
}
