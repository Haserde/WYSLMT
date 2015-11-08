using UnityEngine;
using System.Collections;

public static class DialogueManager {

	public static DialogueChoice[] Alex_choices = new DialogueChoice[10];
	public static  DialogueChoice[] Chad_choices = new DialogueChoice[10];

	// Use this for initialization
	public static void init () {
		setupAlex ();
	}

	public static DialogueChoice getAlexDialogueChoiceFromId( int id ) {
		DialogueChoice toReturn = Alex_choices [0];
		for (int i = 0; i<Alex_choices.Length; i++) {
			if (id == Alex_choices[i].id) {
				toReturn = Alex_choices[i];
				break;
			}
		}
		return toReturn;
	} 

	private static void setupAlex() {
		DialogueChoice dc = new DialogueChoice();
		dc.line = "Today was really fun";
		dc.id = 0;
		dc.gotoLine1 = "Yeah";
		dc.gotoId1 = 120;
		dc.gotoLine2 = "No";
		dc.gotoId2 = 2;
		dc.gotoLine3 = "I’m glad you had fun!";
		dc.gotoId3 = 3;
		Alex_choices [0] = dc;

		dc = new DialogueChoice();
		dc.line = "I guess you're right";
		dc.id = 120;
		dc.gotoLine1 = "GoTo Start";
		dc.gotoId1 = 0;
		dc.gotoLine2 = "I'm always right";
		dc.gotoId2 = 4;
		dc.gotoLine3 = "I’m gld you had fun!";
		dc.gotoId3 = 3;
		Alex_choices [1] = dc;

		dc = new DialogueChoice();
		dc.line = "I guess you're right";
		dc.id = 2;
		dc.gotoLine1 = "Yeah";
		dc.gotoId1 = 0;
		dc.gotoLine2 = "I'm always right";
		dc.gotoId2 = 4;
		dc.gotoLine3 = "I’m glad you had fun!";
		dc.gotoId3 = 3;
		Alex_choices [2] = dc;

		dc = new DialogueChoice();
		dc.line = "I guess you're right";
		dc.id = 3;
		dc.gotoLine1 = "Yeah";
		dc.gotoId1 = 0;
		dc.gotoLine2 = "I'm always right";
		dc.gotoId2 = 4;
		dc.gotoLine3 = "I’m glad you had fun!";
		dc.gotoId3 = 3;
		Alex_choices [3] = dc;
	}
}
