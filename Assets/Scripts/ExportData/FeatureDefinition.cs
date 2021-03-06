﻿using System;
using System.Xml.Serialization;

namespace Graphene.ADInterpreter.ExportData
{
    [Serializable] [XmlRoot(ElementName="FeatureDefinition", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
    public class FeatureDefinition {
        [XmlElement(ElementName="DisplayName", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public DisplayName DisplayName;
        [XmlElement(ElementName="Color", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string Color;
        [XmlElement(ElementName="TechnicalName", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string TechnicalName;
        [XmlElement(ElementName="Url", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public string Url;
        [XmlElement(ElementName="PropertyDefinitions", Namespace="http://www.nevigo.com/schemas/articydraft/2.4/XmlContentExport_FullProject.xsd")]
        public PropertyDefinitions PropertyDefinitions;
        [XmlAttribute(AttributeName="Id")]
        public string Id;
    }
}