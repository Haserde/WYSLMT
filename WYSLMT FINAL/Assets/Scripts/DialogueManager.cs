using UnityEngine;
using System.Collections;

public static class DialogueManager {

	public static DialogueChoice[] Alex_choices = new DialogueChoice[12];
	public static  DialogueChoice[] Chad_choices = new DialogueChoice[12];

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
		dc.line = "...";
		dc.id = 0;
		dc.gotoLine1 = "Hi";
		dc.gotoId1 = 1;
		dc.gotoLine2 = "Hey";
		dc.gotoId2 = 1;
		dc.gotoLine3 = "Hey, how are you?";
		dc.gotoId3 = 2;
		Alex_choices [0] = dc;

		dc = new DialogueChoice();
		dc.line = "Hi, how are you?";
		dc.id = 1;
		dc.gotoLine1 = "Fine, you?";
		dc.gotoId1 = 2;
		dc.gotoLine2 = "I'm alright, what about you?";
		dc.gotoId2 = 2;
		dc.gotoLine3 = "Not having the best day actually";
		dc.gotoId3 = 3;
		Alex_choices [1] = dc;

		dc = new DialogueChoice();
		dc.line = "I'm feeling great!";
		dc.id = 2;
		dc.gotoLine1 = "Are you enjoying this club?";
		dc.gotoId1 = 6;
		dc.gotoLine2 = "And how is the night treating you so far?";
		dc.gotoId2 = 8;
		dc.gotoLine3 = " ";
		dc.gotoId3 = 0;
		Alex_choices [2] = dc;

		dc = new DialogueChoice();
		dc.line = "Really? What happened?";
		dc.id = 3;
		dc.gotoLine1 = "Oh you know, just life.";
		dc.gotoId1 = 4;
		dc.gotoLine2 = "Life stuff you know, but I dont wanna bother you with that.";
		dc.gotoId2 = 7;
		dc.gotoLine3 = " ";
		dc.gotoId3 = 0;
		Alex_choices [3] = dc;

		dc = new DialogueChoice();
		dc.line = "That sucks, did you want something from me?";
		dc.id = 4;
		dc.gotoLine1 = "..I guess not.";
		dc.gotoId1 = 5;
		dc.gotoLine2 = "Yeah, you seem nice, just wanted someone to talk to.";
		dc.gotoId2 = 7;
		dc.gotoLine3 = " ";
		dc.gotoId3 = 0;
		Alex_choices [4] = dc;

		dc = new DialogueChoice();
		dc.line = "K, bye!";
		dc.id = 5;
		dc.gotoLine1 = "...bye.";
		dc.gotoId1 = 0;
		dc.gotoLine2 = " ";
		dc.gotoId2 = 0;
		dc.gotoLine3 = " ";
		dc.gotoId3 = 0;
		Alex_choices [5] = dc;

		dc = new DialogueChoice();
		dc.line = "Yeah, the music is really good!";
		dc.id = 6;
		dc.gotoLine1 = "It sure is.";
		dc.gotoId1 = 10;
		dc.gotoLine2 = "You seem really nice, can I pay you a drink?";
		dc.gotoId2 = 8;
		dc.gotoLine3 = "You like this kind of music? That's sad.";
		dc.gotoId3 = 5;
		Alex_choices [6] = dc;

		dc = new DialogueChoice();
		dc.line = "Sorry about that, I just don't like when people keep complaining about their problems you know?";
		dc.id = 7;
		dc.gotoLine1 = "Yeah, I understand... Anyway, are you enjoying the club?";
		dc.gotoId1 = 6;
		dc.gotoLine2 = "That's okay! Maybe I can pay you a drink to make it up for that?";
		dc.gotoId2 = 8;
		dc.gotoLine3 = " ";
		dc.gotoId3 = 0;
		Alex_choices [7] = dc;

		dc = new DialogueChoice();
		dc.line = "Uhmm, I don't know... I don't really know you.";
		dc.id = 8;
		dc.gotoLine1 = "Oh, that's okay...";
		dc.gotoId1 = 5;
		dc.gotoLine2 = "Well, if you accept my offer you will.";
		dc.gotoId2 = 9;
		dc.gotoLine3 = " ";
		dc.gotoId3 = 0;
		Alex_choices [8] = dc;

		dc = new DialogueChoice();
		dc.line = "...Okay, sure.";
		dc.id = 9;
		dc.gotoLine1 = "";
		dc.gotoId1 = 0;
		dc.gotoLine2 = "";
		dc.gotoId2 = 0;
		dc.gotoLine3 = " ";
		dc.gotoId3 = 0;
		Alex_choices [9] = dc;

		dc = new DialogueChoice();
		dc.line = "What about you? Are you enjoying it?";
		dc.id = 10;
		dc.gotoLine1 = "I guess it's alright.";
		dc.gotoId1 = 11;
		dc.gotoLine2 = "I am, but I would enjoy it more if you had a drink with me!";
		dc.gotoId2 = 8;
		dc.gotoLine3 = " ";
		dc.gotoId3 = 0;
		Alex_choices [10] = dc;

		dc = new DialogueChoice();
		dc.line = "Oh c'mon! Let's get a drink then, maybe it'll make it better.";
		dc.id = 11;
		dc.gotoLine1 = "Sure, that would be awesome!";
		dc.gotoId1 = 0;
		dc.gotoLine2 = "Nah, i'm ok.";
		dc.gotoId2 = 5;
		dc.gotoLine3 = " ";
		dc.gotoId3 = 0;
		Alex_choices [11] = dc;


	}
}
