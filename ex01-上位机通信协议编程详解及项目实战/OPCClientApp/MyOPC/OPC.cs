using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPCAutomation;

namespace MyOPC
{
    public class OPC
    {
        // define OPC server, groups, group, items, browser
        OPCServer kepServer = new OPCServer();
        OPCGroups kepGroups;
        OPCGroup kepGroup;
        OPCItems kepItems;
        // define OPC variables
        public List<MyOPCItem> opcList = new List<MyOPCItem>();
        List<int> serverHandles = new List<int>();
        List<int> clientHandles = new List<int>();
        List<string> tempIDList = new List<string>();
        // define returned OPC tag errors
        Array iErrors;
        // define ids of OPC tags to add
        Array strTempIDs;
        Array strClientHandles;
        Array strServerHandles;
        Array readServerHandles;
        Array writeServerHandles;
        Array writeArrayHandles;
        Array readErrors;
        Array writeErrors;
        int readTransID;
        int writeTransID;
        int readCancelID;
        int writeCancelID;

        public void Connect(string serverName, string serverNode)
        {
            // kepServer.Connect("KEPware.KEPServerEx.V4", "DESKTOP-18047CQ");
            kepServer.Connect(serverName, serverNode);
            // assign values to kepGroups
            kepGroups = kepServer.OPCGroups;
            kepGroups.DefaultGroupDeadband = 0;
            kepGroups.DefaultGroupIsActive = true;
            kepGroup = kepGroups.Add("Group1");
            kepGroup.IsActive = true;
            kepGroup.IsSubscribed = true;
            kepGroup.UpdateRate = 250;
            kepGroup.AsyncReadComplete += kepGroupAsyncReadComplete;

            tempIDList.Clear();
            clientHandles.Clear();
            tempIDList.Add("0");
            clientHandles.Add(0);
            int count = this.opcList.Count;
            for (int i = 0; i < count; i++)
            {
                tempIDList.Add(this.opcList[i].Tag);
                clientHandles.Add(i + 1);
            }
            strTempIDs = (Array)tempIDList.ToArray();
            strClientHandles = (Array)clientHandles.ToArray();
            kepItems = kepGroup.OPCItems;
            // add tags for kep items
            kepItems.AddItems(this.opcList.Count, ref strTempIDs, ref strClientHandles, out strServerHandles, out iErrors);
            serverHandles.Clear();
            serverHandles.Add(0);
            for (int i = 0; i < count; i++)
            {
                serverHandles.Add(Convert.ToInt32(strServerHandles.GetValue(i + 1)));
            }
            readServerHandles = (Array)serverHandles.ToArray();
        }

        public void kepGroupAsyncReadComplete(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps, ref Array Errors)
        {
            for (int i = 1; i <= NumItems; i++)
            {
                object value = ItemValues.GetValue(i);
                if (value != null)
                {
                    this.opcList[i - 1].Value = value.ToString();
                    this.opcList[i - 1].Time = ((DateTime)TimeStamps.GetValue(i)).AddHours(8).ToString();   // ToLongTimeString()
                }
            }
        }

        public void readOPCItems()
        {
            if (this.opcList.Count > 0)
            {
                if (kepServer != null)
                {
                    kepGroup.AsyncRead(this.opcList.Count, ref readServerHandles, out readErrors, readTransID, out readCancelID);
                }
            }
        }

        public void writeOPCItem(int idx, object value)
        {
            MyOPCItem objItem = this.opcList[idx];
            int[] serverHandle = new int[] { 0, Convert.ToInt32(strServerHandles.GetValue(idx + 1)) };
            object[] values = new object[2];
            writeServerHandles = (Array)serverHandle;
            values[1] = value;
            writeArrayHandles = (Array)values;
            kepGroup.AsyncWrite(1, writeServerHandles, writeArrayHandles, out writeErrors, writeTransID, out writeCancelID);
        }
    }
}
