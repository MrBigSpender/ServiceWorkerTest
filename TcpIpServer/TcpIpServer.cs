using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpIpServer
{

    public class TcpIpServer
    {
		SimpleTcpServer server;

		private void test()
        {
			server = new SimpleTcpServer();
			server.Delimiter = 0x15;
			server.DataReceived += Server_DataReceived;

		}

		private void Server_DataReceived(object sender, SimpleTcp.Message e)
		{
			throw new NotImplementedException();
		}

	}
}
