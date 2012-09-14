

using System;
using System.Collections.Generic;

namespace TechEdAu2012.Models {

	public static class Evaluation {
		public static readonly IDictionary<string, string> TheCodes = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase) {
					{ "AIT001", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=56415c8b-9ff1-e111-84a1-001ec953730b" },
					{ "AIT002", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=352997a1-9ff1-e111-84a1-001ec953730b" },
					{ "AIT003", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=5abc0aae-9ff1-e111-84a1-001ec953730b" },
					{ "AIT004", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=68d5d8ca-9ff1-e111-84a1-001ec953730b" },
					{ "AIT005", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=3c5458d7-9ff1-e111-84a1-001ec953730b" },
					{ "AIT006", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=f08d96e4-9ff1-e111-84a1-001ec953730b" },
					{ "AIT007", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=4a9ca503-a0f1-e111-84a1-001ec953730b" },
					{ "AIT008", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=7c9e2522-a0f1-e111-84a1-001ec953730b" },
					{ "AIT009", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=6af11e3c-a0f1-e111-84a1-001ec953730b" },
					{ "AIT010", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=405fac0d-f9fb-e111-84a1-001ec953730b" },
					{ "AZR211", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=e14e8f3b-4ca5-e111-b8c3-001ec953730b" },
					{ "AZR213", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=64dc3522-e1cb-e111-b8c3-001ec953730b" },
					{ "AZR215", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=9c9e9ec5-71be-e111-b8c3-001ec953730b" },
					{ "AZR216", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=30d54592-46a5-e111-b8c3-001ec953730b" },
					{ "AZR221", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=84048716-42bf-e111-b8c3-001ec953730b" },
					{ "AZR225", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=1aa581ad-83aa-e111-b8c3-001ec953730b" },
					{ "AZR317", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=30769419-08a6-e111-b8c3-001ec953730b" },
					{ "AZR323a", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=8dc32ec2-5abf-e111-b8c3-001ec953730b" },
					{ "AZR323b", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=a8616128-2cb6-e111-b8c3-001ec953730b" },
					{ "AZR324", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=fa8a12ec-4ba5-e111-b8c3-001ec953730b" },
					{ "AZR326", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=bee02221-d6b9-e111-b8c3-001ec953730b" },
					{ "AZR331", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=a43c01eb-47b9-e111-b8c3-001ec953730b" },
					{ "AZR333", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=5f35496c-4ca5-e111-b8c3-001ec953730b" },
					{ "AZR432", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=a033cdb2-b7ae-e111-b8c3-001ec953730b" },
					{ "DBI217", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=bf4dae5d-f8a3-e111-b8c3-001ec953730b" },
					{ "DBI224", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=7cb6c31d-a8b6-e111-b8c3-001ec953730b" },
					{ "DBI225", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=c43f4c65-f3be-e111-b8c3-001ec953730b" },
					{ "DBI226", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=05736fe0-9ebe-e111-b8c3-001ec953730b" },
					{ "DBI233", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=205bde1e-d6d9-e111-84a1-001ec953730b" },
					{ "DBI312", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=277025a1-d4a3-e111-b8c3-001ec953730b" },
					{ "DBI313", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=c0b825c3-f2be-e111-b8c3-001ec953730b" },
					{ "DBI315", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=57d7946b-05a9-e111-b8c3-001ec953730b" },
					{ "DBI321", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=b75a9d3f-e9af-e111-b8c3-001ec953730b" },
					{ "DBI331", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=f22c5d65-81b3-e111-b8c3-001ec953730b" },
					{ "DBI332", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=9f10b9e4-3aa9-e111-b8c3-001ec953730b" },
					{ "DEV212", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=01dac10e-22c4-e111-b8c3-001ec953730b" },
					{ "DEV214", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=f93e0ae0-22c4-e111-b8c3-001ec953730b" },
					{ "DEV216", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=cf540b04-23c4-e111-b8c3-001ec953730b" },
					{ "DEV221", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=c4f82757-b0b9-e111-b8c3-001ec953730b" },
					{ "DEV223", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=a57f393a-24c4-e111-b8c3-001ec953730b" },
					{ "DEV321", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=ac136efa-72b7-e111-b8c3-001ec953730b" },
					{ "DEV322", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=58abbaaa-23c4-e111-b8c3-001ec953730b" },
					{ "DEV323", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=ce475c57-b4b5-e111-b8c3-001ec953730b" },
					{ "DEV326", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=a48e2091-a2b7-e111-b8c3-001ec953730b" },
					{ "DEV331", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=e7478e45-e7ce-e111-b8c3-001ec953730b" },
					{ "DEV333", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=215e2290-e4ce-e111-b8c3-001ec953730b" },
					{ "EXL224", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=8c5c09be-52b8-e111-b8c3-001ec953730b" },
					{ "EXL231", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=7c41875c-52b8-e111-b8c3-001ec953730b" },
					{ "EXL311", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=cb5931fd-7cd1-e111-b8c3-001ec953730b" },
					{ "EXL314", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=1f2df521-7ed1-e111-b8c3-001ec953730b" },
					{ "EXL315", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=5d3fcfdc-7ada-e111-84a1-001ec953730b" },
					{ "EXL316", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=67075073-7dda-e111-84a1-001ec953730b" },
					{ "EXL321", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=7a802097-7fda-e111-84a1-001ec953730b" },
					{ "EXL325", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=21c7e2ee-7dda-e111-84a1-001ec953730b" },
					{ "EXL326", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=343b29bd-7cda-e111-84a1-001ec953730b" },
					{ "EXL332", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=1672a7ab-7dd1-e111-b8c3-001ec953730b" },
					{ "EXL333", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=00d2e559-7ada-e111-84a1-001ec953730b" },
					{ "KOS308", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=54afa3d9-f4e7-e111-84a1-001ec953730b" },
					{ "KOS309", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=88807de1-f4e7-e111-84a1-001ec953730b" },
					{ "OSP211", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=55220423-8dd4-e111-84a1-001ec953730b" },
					{ "OSP212", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=6d9fad30-8dd4-e111-84a1-001ec953730b" },
					{ "OSP213", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=e30f247c-8dd4-e111-84a1-001ec953730b" },
					{ "OSP216", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=62011080-d4da-e111-84a1-001ec953730b" },
					{ "OSP223", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=57b72dee-d4da-e111-84a1-001ec953730b" },
					{ "OSP224", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=675f4646-8dd4-e111-84a1-001ec953730b" },
					{ "OSP225", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=bd2ba2f9-d4da-e111-84a1-001ec953730b" },
					{ "OSP314", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=fe443a93-8dd4-e111-84a1-001ec953730b" },
					{ "OSP321", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=b6c575a3-8dd4-e111-84a1-001ec953730b" },
					{ "OSP322", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=c7237a54-8dd4-e111-84a1-001ec953730b" },
					{ "OSP331", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=9cb25be0-d4da-e111-84a1-001ec953730b" },
					{ "OSP433", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=bd0e1d4b-79b8-e111-b8c3-001ec953730b" },
					{ "SIM212", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=ffbc1808-1fa6-e111-b8c3-001ec953730b" },
					{ "SIM216", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=069db955-8eb6-e111-b8c3-001ec953730b" },
					{ "SIM311", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=30695d45-1aa6-e111-b8c3-001ec953730b" },
					{ "SIM313", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=7164c249-1ba6-e111-b8c3-001ec953730b" },
					{ "SIM317", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=4541a30f-06ba-e111-b8c3-001ec953730b" },
					{ "SIM321", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=39069733-94ab-e111-b8c3-001ec953730b" },
					{ "SIM322", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=69fe6261-56a4-e111-b8c3-001ec953730b" },
					{ "SIM331", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=bc844708-63c9-e111-b8c3-001ec953730b" },
					{ "SIM332", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=67603ed6-08b5-e111-b8c3-001ec953730b" },
					{ "SIM333", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=b838224a-d1c4-e111-b8c3-001ec953730b" },
					{ "SIM414", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=afa6a64d-06b5-e111-b8c3-001ec953730b" },
					{ "SIM415", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=571a7508-c1a3-e111-b8c3-001ec953730b" },
					{ "SIM423", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=d186f859-58a4-e111-b8c3-001ec953730b" },
					{ "SIM424", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=a7f8bf7f-40ae-e111-b8c3-001ec953730b" },
					{ "SIM425", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=10ed58b8-70a4-e111-b8c3-001ec953730b" },
					{ "VIR232", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=0ff97bb8-a8e2-e111-84a1-001ec953730b" },
					{ "VIR311", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=443a174c-c2c1-e111-b8c3-001ec953730b" },
					{ "VIR312", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=92768c63-63c3-e111-b8c3-001ec953730b" },
					{ "VIR314", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=6c085094-dfc1-e111-b8c3-001ec953730b" },
					{ "VIR315", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=ce33227b-14da-e111-84a1-001ec953730b" },
					{ "VIR316", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=92684090-63c3-e111-b8c3-001ec953730b" },
					{ "VIR317", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=8ccbf9e6-dfc1-e111-b8c3-001ec953730b" },
					{ "VIR321", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=1c7fb0eb-c2c1-e111-b8c3-001ec953730b" },
					{ "VIR322", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=50284f7e-17da-e111-84a1-001ec953730b" },
					{ "VIR323", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=bac636d8-63c3-e111-b8c3-001ec953730b" },
					{ "VIR324", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=2273d9fa-63c3-e111-b8c3-001ec953730b" },
					{ "VIR325", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=31a5f2f1-17da-e111-84a1-001ec953730b" },
					{ "VIR331", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=d8b2c82b-1fda-e111-84a1-001ec953730b" },
					{ "VIR413", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=1ce165aa-d5c1-e111-b8c3-001ec953730b" },
					{ "WCL216", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=8449ab1d-d1b9-e111-b8c3-001ec953730b" },
					{ "WCL217", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=2e77df9d-42a5-e111-b8c3-001ec953730b" },
					{ "WCL311", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=3891ae86-45b4-e111-b8c3-001ec953730b" },
					{ "WCL312", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=d609f63c-c3b9-e111-b8c3-001ec953730b" },
					{ "WCL313", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=b8e978a7-a2af-e111-b8c3-001ec953730b" },
					{ "WCL314", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=975facf0-a2af-e111-b8c3-001ec953730b" },
					{ "WCL315", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=c9b8b0fd-88af-e111-b8c3-001ec953730b" },
					{ "WCL322", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=f99b27ee-a7d0-e111-b8c3-001ec953730b" },
					{ "WCL324", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=3c4836f2-44bb-e111-b8c3-001ec953730b" },
					{ "WCL326", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=1292a933-beb0-e111-b8c3-001ec953730b" },
					{ "WCL331", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=bf79e21e-71a4-e111-b8c3-001ec953730b" },
					{ "WCL332", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=a65336da-70be-e111-b8c3-001ec953730b" },
					{ "WCL333", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=e4268cde-c0b9-e111-b8c3-001ec953730b" },
					{ "WCL425", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=5c5d6a1b-99bc-e111-b8c3-001ec953730b" },
					{ "WHP331", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=3d750409-dfb5-e111-b8c3-001ec953730b" },
					{ "WPH217", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=7d47f99a-deb5-e111-b8c3-001ec953730b" },
					{ "WPH222", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=fec4b1c5-eace-e111-b8c3-001ec953730b" },
					{ "WPH323", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=ad1cc876-dfb5-e111-b8c3-001ec953730b" },
					{ "WPH332", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=24571b3a-dfb5-e111-b8c3-001ec953730b" },
					{ "WPH333", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=44718756-e0b5-e111-b8c3-001ec953730b" },
					{ "WSV311", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=70a79b9a-19da-e111-84a1-001ec953730b" },
					{ "WSV312", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=44eb4393-cdb8-e111-b8c3-001ec953730b" },
					{ "WSV313", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=0e3ca131-63c3-e111-b8c3-001ec953730b" },
					{ "WSV314", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=eab37d95-fccb-e111-b8c3-001ec953730b" },
					{ "WSV315", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=bff1d6c3-52d1-e111-b8c3-001ec953730b" },
					{ "WSV316", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=7bf7613d-c4c1-e111-b8c3-001ec953730b" },
					{ "WSV317", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=a4917554-ccc1-e111-b8c3-001ec953730b" },
					{ "WSV321", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=fc0e70c2-ccc1-e111-b8c3-001ec953730b" },
					{ "WSV322", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=32ff4d89-a8e2-e111-84a1-001ec953730b" },
					{ "WSV324", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=30a829f6-ccc1-e111-b8c3-001ec953730b" },
					{ "WSV325", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=74dc3a6e-c4c1-e111-b8c3-001ec953730b" },
					{ "WSV326", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=dbe67502-53d1-e111-b8c3-001ec953730b" },
					{ "WSV326a", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=042fe829-c2f8-e111-84a1-001ec953730b" },
					{ "WSV331", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=605ff0d0-accb-e111-b8c3-001ec953730b" },
					{ "WSV332", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=b927b33a-64c3-e111-b8c3-001ec953730b" },
					{ "WSV333", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=4c3564c8-c3c1-e111-b8c3-001ec953730b" },
					{ "WSV422", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=af2e3cb4-64c3-e111-b8c3-001ec953730b" },
					{ "WSV423", "https://australia.msteched.com/ws/evalselect.aspx?sessionid=00700e1d-64c3-e111-b8c3-001ec953730b" },

			};
		}
	}

