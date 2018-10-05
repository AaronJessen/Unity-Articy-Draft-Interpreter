using System.IO;
using UnityEngine;
using System.Xml.Serialization;
using System.Xml;
using Graphene.ADInterpreter.ExportData;

namespace Graphene.ADInterpreter
{
    [ExecuteInEditMode]
    public class NevgoXmlImporter : MonoBehaviour
    {
        public ArticyDraftData Data;

        public string FilePath = "/DynamicAssets/Resources/Export.xml";
        
        private void Awake()
        {
            Deserialize();
        }

        private void Deserialize()
        {
            if(!File.Exists(Application.dataPath+FilePath)) return;
            
            XmlSerializer serializer = new XmlSerializer(typeof(ArticyDraftData));
            Data = (ArticyDraftData) serializer.Deserialize(new XmlTextReader(Application.dataPath+FilePath));
            Debug.Log(Data.Content.DialogueFragment.Count);
        }
    }
}