using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Chracter_XML_Write : MonoBehaviour
{    
	void Start()
	{
		List<Character_XML> CharacterList = new List<Character_XML>();

		for(int i = 0; i < 1; ++i)
		{
			Character_XML Character = new Character_XML();
			Character.character_id = i+1;
			Character.character_name = "김준구";
			Character.type = "PC";
			Character.level = 1;
			Character.exp = 1000;
			Character.hp = 2000;
			Character.mp = 1000;
			Character.patk = 15.5f;
			Character.matk = 20.2f;
			Character.pdef = 33.2f;
			Character.mdef = 55.1f; 
			Character.mspeed = 3;
			Character.str = 10;
			Character.magic = 90;
			Character.con = 300;
			Character.intel = 200;
			Character.dex = 50;

			CharacterList.Add(Character);
		}
		Character_stat.Write(CharacterList, Application.dataPath + "/StreamingAssets/Character.xml");
		Debug.Log ("ddd222");
	}
}