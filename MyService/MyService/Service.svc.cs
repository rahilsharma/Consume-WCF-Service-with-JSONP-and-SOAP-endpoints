using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace MyService
{

    public class Service : IService
    {
        public cTourList GetTourListJSONP()
        {
            return CreateTourList();
        }

        public cTourList GetTourListXML()
        {
            return CreateTourList();
        }
        
        private cTourList CreateTourList()
        {
            cTourList oTourList = new cTourList();
            oTourList.Add(new cTour() { ID = 1, description = "Barcelona" });
            oTourList.Add(new cTour() { ID = 2, description = "Paris" });
            oTourList.Add(new cTour() { ID = 3, description = "Rome" });
            oTourList.Add(new cTour() { ID = 4, description = "London" });
            oTourList.Add(new cTour() { ID = 5, description = "Moscow" });

            return oTourList;
        }
    }

}
