//This code create by CodeEngine

namespace SPacket.SocketInstance
{
    public class GC_CONNECTED_HEARTBEATHandler : Ipacket
    {
        public uint Execute(PacketDistributed ipacket)
        {
            GC_CONNECTED_HEARTBEAT packet = (GC_CONNECTED_HEARTBEAT)ipacket;
            if (null == packet) return (uint)PACKET_EXE.PACKET_EXE_ERROR;
            //GlobalData.ServerAnsiTime = (int)packet.Serveransitime;

            //Obj_MainPlayer mainPlayer = Singleton<ObjManager>.Instance.MainPlayer;
            //if (null != mainPlayer)
            //{
            //    mainPlayer.LastHeartBeatTime = UnityEngine.Time.time;
            //}

            CG_CONNECTED_HEARTBEAT cgBeat = (CG_CONNECTED_HEARTBEAT)PacketDistributed.CreatePacket(MessageID.PACKET_CG_CONNECTED_HEARTBEAT);
            cgBeat.SetIsresponse(1);
            UnityEngine.Debug.Log("这里是心跳包回复");
            cgBeat.SendPacket();
            return (uint)PACKET_EXE.PACKET_EXE_CONTINUE;
        }
    }
}
