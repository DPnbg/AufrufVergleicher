using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace AufrufVergleicher.SV {
	[ServiceContract(Namespace = "")]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class l {

		[OperationContract]
		[WebGet(UriTemplate="d/{r}")]
		public System.IO.Stream d(string r) {
		    WebOperationContext.Current.OutgoingResponse.ContentType = "application/octet-stream";
			var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(r);
			return stream;
		}

	}
}
