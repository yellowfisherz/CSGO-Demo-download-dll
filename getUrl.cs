using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace libShareCodeToURL
{
    public class GetUrl
    {
        public static void Main()
        {
            Console.WriteLine(Urlstring("52um8FaZvFAjutmhCoKH2JedJ"));
            Thread.Sleep(10000);
        }
        public static int Urlstring(string sharecode)
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve2;
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve3;
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve4;
            Sharecodetransform.ShareCodeStruct s = Sharecodetransform.Decode(sharecode);
            int back = Downloadserver.StartBoiler($"{s.MatchId} {s.OutcomeId} {s.TokenId}");
            if (back != 0) return back;
            Dictionary<string, string> demoDownloadList = Url();
            String realurl = demoDownloadList.ElementAt(0).Value;
            if (realurl == null)  return 100;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"URL.txt", false))
            {
                file.WriteLine(realurl);

            }
            return back;
        }

        static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return LoadFromResource("protobuf-net.dll");
        }

        static System.Reflection.Assembly CurrentDomain_AssemblyResolve2(object sender, ResolveEventArgs args)
        {
            return LoadFromResource("boiler.exe");
        }

        static System.Reflection.Assembly CurrentDomain_AssemblyResolve3(object sender, ResolveEventArgs args)
        {
            return LoadFromResource("steam_api.dll");
        }
        static System.Reflection.Assembly CurrentDomain_AssemblyResolve4(object sender, ResolveEventArgs args)
        {
            return LoadFromResource("steam_appid.txt");
        }
        private static Assembly LoadFromResource(string resName)
        {
            Assembly ass = Assembly.GetExecutingAssembly();
            using (Stream stream = ass.GetManifestResourceStream("libShareCodeToURL.Resources." + resName))
            {
                byte[] bt = new byte[stream.Length];
                stream.Read(bt, 0, bt.Length);
                Assembly asm = Assembly.Load(bt);
                return asm;
            }
        }

        public static Dictionary<string, string> Url()
        {
            FileStream file;
            try
            {
                file = File.OpenRead("matches.dat");
            }
            catch
            {
                return null;
            }
            Dictionary<string, string> demoUrlList = new Dictionary<string, string>();
            CMsgGCCStrike15_v2_MatchList matchList = Serializer.Deserialize<CMsgGCCStrike15_v2_MatchList>(file);
            file.Close();
            foreach (CDataGCCStrike15_v2_MatchInfo matchInfo in matchList.matches)
            {
                List<CMsgGCCStrike15_v2_MatchmakingServerRoundStats> roundStatsList = matchInfo.roundstatsall;
                foreach (CMsgGCCStrike15_v2_MatchmakingServerRoundStats roundStats in roundStatsList)
                {
                    ProcessRoundStats(matchInfo, roundStats, demoUrlList);
                }
            }
            return demoUrlList;
        }
        private static void ProcessRoundStats(CDataGCCStrike15_v2_MatchInfo matchInfo, CMsgGCCStrike15_v2_MatchmakingServerRoundStats roundStats, Dictionary<string, string> demoUrlList)
        {
            string demoName = GetDemoName(matchInfo, roundStats);
            if (roundStats.reservationid != 0 && roundStats.map != null)
            {
                demoUrlList.Add(demoName, roundStats.map);
            }
        }
        private static string GetDemoName(CDataGCCStrike15_v2_MatchInfo matchInfo,
    CMsgGCCStrike15_v2_MatchmakingServerRoundStats roundStats)
        {
            return "match730_" + string.Format("{0,21:D21}", roundStats.reservationid) + "_"
                + string.Format("{0,10:D10}", matchInfo.watchablematchinfo.tv_port) + "_"
                + matchInfo.watchablematchinfo.server_ip;
        }
    }
}
