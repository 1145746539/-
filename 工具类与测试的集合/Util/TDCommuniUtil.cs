using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Net;

namespace 工具类与测试的集合.Util
{
    /// <summary>
    /// 连接台达PLC的工具类 
    /// </summary>
    class TDCommuniUtil
    {
        // Data Access
        [DllImport("DMT.dll", CharSet = CharSet.Auto)]
        public static extern int RequestData(int comm_type, int conn_num, int slave_addr, int func_code, byte[] sendbuf, int sendlen);
        [DllImport("DMT.dll", CharSet = CharSet.Auto)]
        public static extern int ResponseData(int comm_type, int conn_num, ref int slave_addr, ref int func_code, byte[] recvbuf);

        // Socket Communication
        [DllImport("DMT.dll", CharSet = CharSet.Auto)]
        public static extern int OpenModbusTCPSocket(int conn_num, int ipaddr);
        [DllImport("DMT.dll", CharSet = CharSet.Auto)]
        public static extern void CloseSocket(int conn_num);
        [DllImport("DMT.dll", CharSet = CharSet.Auto)]
        public static extern int GetLastSocketErr();
        [DllImport("DMT.dll", CharSet = CharSet.Auto)]
        public static extern void ResetSocketErr();
        [DllImport("DMT.dll", CharSet = CharSet.Auto)]
        public static extern int ReadSelect(int conn_num, int millisecs);
    }

    /// <summary>
    /// 连接台达PLC的工具类  LoadLibrary加载
    /// </summary>
    class TDCommunicate
    {
        /// <summary>
        /// 加载DLL
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        private extern static IntPtr LoadLibrary(String path);
        /// <summary>
        /// 取函数
        /// </summary>
        /// <param name="lib"></param>
        /// <param name="funcName"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        private extern static IntPtr GetProcAddress(IntPtr lib, String funcName);
        /// <summary>
        /// 卸载DLL
        /// </summary>
        /// <param name="lib"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]

        private extern static bool FreeLibrary(IntPtr lib);
        private IntPtr hLib;
        private static TDCommunicate tdCmu;
        public static Object LockObject = new Object(); //锁
        private const int _connNum = 0;   //通讯端口号，以太网固定为0
        public static TDCommunicate Instance(string DLLPath)
        {
            if (tdCmu == null)
            {
                tdCmu = new TDCommunicate(DLLPath);
            }
            return tdCmu;
        }

        private TDCommunicate(string DLLPath)
        {
            hLib = LoadLibrary(DLLPath);
        }

        ~TDCommunicate()
        {
            FreeLibrary(hLib);
        }

        /// <summary>
        /// 将要执行的函数转换为委托
        /// </summary>
        public Delegate Invoke(String APIName, Type t)
        {
            IntPtr api = GetProcAddress(hLib, APIName);
            return (Delegate)Marshal.GetDelegateForFunctionPointer(api, t);
        }

        /// <summary>
        /// 连接
        /// </summary>
        /// <param name="conn_num"></param>
        /// <param name="ipaddr"></param>
        /// <returns></returns>
        private delegate int OpenModbusTCPSocket(int conn_num, int ipaddr);//编译

        /// <summary>
        /// 断开
        /// </summary>
        /// <param name="conn_num"></param>
        private delegate void CloseSocket(int conn_num);


        /// <summary>
        /// 连接TDPLC
        /// </summary>
        private int ConnTDPLC(int conn_num, int ipaddr)
        {
            OpenModbusTCPSocket OMTSocket = (OpenModbusTCPSocket)Invoke("OpenModbusTCPSocket", typeof(OpenModbusTCPSocket));
            return OMTSocket(conn_num, ipaddr);
        }

        /// <summary>
        /// 断开TDPLC
        /// </summary>
        /// <param name="conn_num"></param>
        private void CloseTDPLC(int conn_num)
        {
            CloseSocket CSocket = (CloseSocket)Invoke("CloseSocket", typeof(CloseSocket));
            CSocket(conn_num);
        }

        // DllInvoke dll ＝ new DllInvoke(Server.MapPath(@"~/Bin/Judge.dll"));
        //Compile compile = (Compile)dll.Invoke("Compile", typeof(Compile));
        //StringBuilder inf;
        //compile(@“gcc a.c -o a.exe“, inf); //这里就是调用我的DLL里定义的Compile函数

        /// <summary>
        /// 外部接口 连接PLC
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public bool ConnPLC(string ip)
        {
            lock (LockObject)
            {
                try
                {
                    IPAddress ipaddress = IPAddress.Parse(ip);
                    int ipAddress = BitConverter.ToInt32(ipaddress.GetAddressBytes(), 0);
                    int status = ConnTDPLC(_connNum, ipAddress);
                    if (status == -1)
                    {
                        throw new Exception("建立联接异常。");
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        /// <summary>
        /// 外部接口 断开PLC
        /// </summary>
        /// <returns></returns>
        public bool CloPLC()
        {
            lock (LockObject)
            {
                try
                {
                    CloseTDPLC(_connNum);
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
