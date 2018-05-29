using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_XML_Read : MonoBehaviour {


		void Start()
		{
		List<Character_XML> CharacterList = Character_stat.Read(Application.dataPath + "/StreamingAssets/Character.xml");
			for(int i = 0; i < CharacterList.Count; ++i)
			{
			Character_XML Character = CharacterList[i];
			Debug.Log(string.Format("Character_ID[{0}] : ({1}, {2}, {3}, {4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})", 
				Character.character_id, Character.character_name, Character.type, Character.level, Character.level, Character.exp, Character.hp
				,Character.mp, Character.patk, Character.matk, Character.pdef, Character.mdef, Character.mspeed, Character.str
				,Character.magic,Character.con,Character.intel,Character.dex));
			
			}
		}
}