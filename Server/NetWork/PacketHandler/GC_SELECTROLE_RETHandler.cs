//This code create by CodeEngine

namespace SPacket.SocketInstance
{
    public class GC_SELECTROLE_RETHandler : Ipacket
    {
        public delegate void SelectRoleFailRet(GC_SELECTROLE_RET.SELECTROLE_RESULT result);
        public static SelectRoleFailRet retSelectRoleFail;
        public uint Execute(PacketDistributed ipacket)
        {
            GC_SELECTROLE_RET packet = (GC_SELECTROLE_RET)ipacket;
            if (null == packet) return (uint)PACKET_EXE.PACKET_EXE_ERROR;
            if (packet.Result == (int)GC_SELECTROLE_RET.SELECTROLE_RESULT.SELECTROLE_SUCCESS)
            {
                LoginData.UpdateLoginRoleInfo(packet.PlayerGuid);

            }
            else
            {
                if (null != retSelectRoleFail) retSelectRoleFail((GC_SELECTROLE_RET.SELECTROLE_RESULT)packet.Result);
            }


            return (uint)PACKET_EXE.PACKET_EXE_CONTINUE;
        }
    }
}
