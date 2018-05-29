using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using System.Xml;


public class Character_XML //Character.xml에 설정한 캐릭터 컬럼 값 변수로 선언. 
{
	public int character_id;
	public string character_name;
	public string type;
	public int level;
	public int exp;
	public int hp;
	public int mp; 
	public float patk;
	public float matk; 
	public float pdef;
	public float mdef;
	public int mspeed;
	public int str;
	public int magic;
	public int con;
	public int intel; 
	public int dex;
}

public sealed class Character_stat //캐릭터 정보를 xml에서 저장, 불러오기 
{
	public static void Write(List<Character_XML> CharacterList, string filePath)  //캐릭터 XML_에 저장
	{
		XmlDocument CharacterListDocument = new XmlDocument(); 
		XmlElement CharacterListElement = CharacterListDocument.CreateElement("CharacterList");
		CharacterListDocument.AppendChild(CharacterListElement);

		foreach(Character_XML Character in CharacterList)
		{
			XmlElement CharacterElement = CharacterListDocument.CreateElement("Character"); 
			CharacterElement.SetAttribute("CHARACTER_ID", Character.character_id.ToString()); 
			CharacterElement.SetAttribute("CHARACTER_NAME", Character.character_name); 
			CharacterElement.SetAttribute("TYPE", Character.type);
			CharacterElement.SetAttribute ("LEVEL", Character.level.ToString());
			CharacterElement.SetAttribute ("EXP", Character.exp.ToString());
			CharacterElement.SetAttribute ("HP", Character.hp.ToString());
			CharacterElement.SetAttribute ("MP", Character.mp.ToString());
			CharacterElement.SetAttribute ("PATK", Character.patk.ToString());
			CharacterElement.SetAttribute ("MATK", Character.matk.ToString());
			CharacterElement.SetAttribute ("PDEF", Character.pdef.ToString());
			CharacterElement.SetAttribute ("MDEF", Character.mdef.ToString());
			CharacterElement.SetAttribute ("MSPEED", Character.mspeed.ToString());
			CharacterElement.SetAttribute ("STR", Character.str.ToString());
			CharacterElement.SetAttribute ("MAGIC", Character.magic.ToString());
			CharacterElement.SetAttribute ("CON", Character.con.ToString());
			CharacterElement.SetAttribute ("INTEL", Character.intel.ToString());
			CharacterElement.SetAttribute ("DEX", Character.dex.ToString());

			CharacterListElement.AppendChild(CharacterElement);
		}
		CharacterListDocument.Save(Application.dataPath + "/StreamingAssets/Character.xml");
	}

	public static List<Character_XML> Read(string filePath) //캐릭터 XML_에서 불러오기
	{
		XmlDocument CharacterListDocument = new XmlDocument(); 
		CharacterListDocument.Load(filePath); 
		XmlElement CharacterListElement = CharacterListDocument["CharacterList"]; 

		List<Character_XML> CharacterList = new List<Character_XML>();

		foreach(XmlElement Character in CharacterListElement.ChildNodes)
		{ 
			Character_XML Ch = new Character_XML();
			Ch.character_id = System.Convert.ToInt32(Character.GetAttribute("CHARACTER_ID")); 
			Ch.character_name = Character.GetAttribute("CHARACTER_NAME"); 
			Ch.type = Character.GetAttribute("TYPE"); 
			Ch.level = System.Convert.ToInt32(Character.GetAttribute("LEVEL"));
			Ch.exp = System.Convert.ToInt32 (Character.GetAttribute ("EXP"));
			Ch.hp = System.Convert.ToInt32 (Character.GetAttribute ("HP"));
			Ch.mp = System.Convert.ToInt32 (Character.GetAttribute ("MP"));
			Ch.patk = System.Convert.ToSingle (Character.GetAttribute ("PATK"));
			Ch.matk = System.Convert.ToSingle (Character.GetAttribute ("MATK"));
			Ch.pdef = System.Convert.ToSingle (Character.GetAttribute ("PDEF"));
			Ch.mdef = System.Convert.ToSingle (Character.GetAttribute ("MDEF"));
			Ch.mspeed = System.Convert.ToInt32 (Character.GetAttribute ("MSPEED"));
			Ch.str = System.Convert.ToInt32 (Character.GetAttribute ("STR"));
			Ch.magic = System.Convert.ToInt32 (Character.GetAttribute ("MAGIC"));
			Ch.con = System.Convert.ToInt32 (Character.GetAttribute ("CON"));
			Ch.intel = System.Convert.ToInt32 (Character.GetAttribute ("INTEL"));
			Ch.dex = System.Convert.ToInt32 (Character.GetAttribute ("DEX"));
			CharacterList.Add(Ch);
		}
		return CharacterList;
	}
}