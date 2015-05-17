using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyService
{
    [ServiceContract]
    public interface IService
    {

        [OperationContract]     
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetTourListJSONP/")]
        cTourList GetTourListJSONP();
                 
        [OperationContract]       
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare,
        RequestFormat = WebMessageFormat.Xml,
        ResponseFormat = WebMessageFormat.Xml,
        UriTemplate = "/GetTourListXML/")]
        cTourList GetTourListXML();

    }



    [CollectionDataContract]
    public class cTourList : Collection<cTour>
    {       
    }

    [DataContract]
    public class cTour
    {
        int _ID = 0;
        string _description = "";

        [DataMember]
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        [DataMember]
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }
    }

}
