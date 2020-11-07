using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Linq;  //重要
using System.Xml;

public class Summary : MonoBehaviour
{

    public IEnumerator Start()
    {

        // リクエスト先は仮
        string url = "https://jlp.yahooapis.jp/MAService/V1/parse?appid=<あなたのアプリケーションID>&results=ma,uniq&uniq_filter=9%7C10&sentence=%E5%BA%AD%E3%81%AB%E3%81%AF%E4%BA%8C%E7%BE%BD%E3%83%8B%E3%83%AF%E3%83%88%E3%83%AA%E3%81%8C%E3%81%84%E3%82%8B%E3%80%82";
        WWW www = new WWW(url);
        //  wait until HTML Contents will come 
        yield return www;

        if (www.error != null)
        {
            Debug.Log("Error!");
        }
        else
        {
            Debug.Log("Success");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(www.text);
            Debug.Log(www.text);
            // 目的のノードだけを取り出す
            XmlNodeList levelsList = xmlDoc.GetElementsByTagName("word_list");
            foreach (XmlNode levelInfo in levelsList)
            {
                Debug.Log(levelInfo.Name.ToString());
                XmlNodeList levelcontent = levelInfo.ChildNodes;
                foreach (XmlNode levelsItens in levelcontent)
                {
                    foreach (XmlNode word in levelsItens)
                    {
                        if (word.Name == "surface")
                        {
                            Debug.Log(word.InnerText.ToString());
                        }
                    }

                }
            }

        }

    }

}


