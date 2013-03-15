using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace SevenEighter
{
    class availablePackages
    {
        public static int[] languages = {0x0404,
                                         0x0405,
                                         0x0406,
                                         0x0407,
                                         0x0408,
                                         0x0409,
                                         0x040b,
                                         0x040c,
                                         0x040e,
                                         0x0410,
                                         0x0411,
                                         0x0412,
                                         0x0413,
                                         0x0414,
                                         0x0415,
                                         0x0416,
                                         0x0419,
                                         0x041d,
                                         0x0804,
                                         0x0809,
                                         0x0816,
                                         0x0c0a,
                                         };

        public static Collection<int> selectedLanguages = new Collection<int>();

        public static string ver7740 = "http://download.windowsupdate.com/msdownload/update/software/dflt/2011/10/diff-7.10.7720.68-7.10.7740.16-armv7-retail-microsoft.pks_2cb1bfdd82133914239b8ee1a78e61e9000d124a.cab";

        public static string ver8107 = "http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.pks_c9b7f3bc5bb340ba30473b566b4557de0cf3322e.cab";
        public static string[] ver8107langs = {"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_0404.pks_14f5fe7f4a13691af0836c66b24609a7cc4d91bf.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_0405.pks_39e23349a19a6a22080ef7a2feb92e392bf760d4.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_0406.pks_405c4cea1c731f7e162bb22e856bb581bb2a487b.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_0407.pks_b50019ef50d52090d408d854c0708ddbf520706c.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_0408.pks_03d24647cd9678f10b7bb59aed3527312ea165e9.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_0409.pks_bfd9c047a7b27c28208c8a717f8d7511fb2586f1.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_040b.pks_398799fcdc32f92bced716dcd7606916d9c6a02d.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_040c.pks_2d74e8c5f6a835f1fe4c62b488c96ac2d7f01c29.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_040e.pks_bb52bdd5424ec4921a80a5e70b280ff021613b0f.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_0410.pks_9ecf9b052b6cc3161462e998dac8204a0f754556.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_0411.pks_02108a1813a8f3ddfaba98f21d72ad0942e696a9.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_0412.pks_94f886dab44851ddfc1481f6ce183930d58625c7.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_0413.pks_8fb73a926d0b157da33edde9e6332a68a4ee2fb2.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_0414.pks_b79d55444fefc11af29ddb3abab85c255f9bbb8b.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_0415.pks_53749601c866e4521044b02fe4a03625fbb8a31f.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_0416.pks_4cadd6d75bd962d8e0d25cf3fa85cd71b011a750.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_0419.pks_8d8f924349f1f1e98c2677380ca38b73b6ef245f.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_041d.pks_7be1f542160ac7088439c273b1d40469569a32b4.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_0804.pks_f72389ae04c3dadd144cffa0c4951c4c7970f7eb.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_0809.pks_2666da3127f526b23b492f293983ccce1d28f375.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_0816.pks_c595c2d27f7d43a6357ea17adde815e9495274c7.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2011/12/diff-7.10.7740.16-7.10.8107.79-armv7-retail-microsoft.lang_0c0a.pks_97df86b81a40df06bb2b15c6739e2ee772e53bbf.cab"};

        public static string ver8112_1 = "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft-pluspkr.pks_d500a10eeb11fb6c1913adac4759d67185474d3e.cab";
        public static string ver8112_2 = "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.dpi_262.pks_24bb20423e86130365686c1796577d4b22343be9.cab";

        public static string[] ver8112langs = {"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_0404.pks_5264adfac00822e6f264444879d579fd9d83d521.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_0405.pks_808ff53261123dfd0e86ee7ae9c63d1ed2f0809a.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_0406.pks_4b758bd9c162dbf64abaf65e5ea831a06f2e7eda.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_0407.pks_d89120e9719b4791ecf5f5581730952790d85505.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_0408.pks_d0b6fbbb0bf96899196cee43179224b2451d5c31.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_0409.pks_ae068921fd637ba2e3e268b28e6ca1c9f3a9c11f.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_040b.pks_ce1435085bb7dfcb0453f7ff7b0fa8b8f34010eb.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_040c.pks_0e4fe7facb5bd169c742f7811f10e3caf4110e9a.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_040e.pks_22555d0f89f9ebbe95926056f21d8bdc24b7d520.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_0410.pks_9b7013b1a94c12121b92964f6a0d12425986c195.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_0411.pks_2123187dd97da62bcf68d06b481e1bb200d4a3ad.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_0412.pks_bb4fd590e3e3ea568fba17484261d68e191bf148.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_0413.pks_bd8d1a0427266b9e7a98598eb95b1f378ad9781f.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_0414.pks_63665eebb1733349f4454b75bf967453493ca1e5.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_0415.pks_c5eae4190043d0ecc156edc363c677f685788544.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_0416.pks_0faf0a17c2d51efe8a54f7063a56bc06537e62ee.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_0419.pks_a3be6ca52716096243398b5aa646825c4cd28fbe.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_041d.pks_6642fcd0eb59dbd981aa1a91034df5462013d8c7.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_0804.pks_26d9ffdca74b379504c2607ef260cd9d52c4add9.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_0809.pks_80abdd4c9c9f3df25432fe4465e23fc3048012cb.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_0816.pks_74bc78c410e0ea1433a3eb3aa3f71296ed8a34aa.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/03/diff-7.10.8107.79-7.10.8112.7-armv7-retail-microsoft.lang_0c0a.pks_69aaa5b4911d99c4669344254bfa7ba5f8cd0408.cab"};



        public static string ver8773_1 = "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.pks_113460c78ac6233e3bb776ceddb6ac94e98c4221.cab";
        public static string ver8773_2 = "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.dpi_262.pks_4dbf7302a7b3da01eeafbcfbf1b9b75e6f6de15e.cab";


        public static string[] ver8773langs = {"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_0404.pks_7419d68221a4b73171c8d57b02fa74d62047eaf6.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_0405.pks_b4ca08158f722ba8bfcd7dc6ffd8bcfc2078dbcb.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_0406.pks_8865f440166f08be5c5232f7246555b2c66606d2.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_0407.pks_e1a132dbad341e61c902f697bbde9d2ebb98a08f.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_0408.pks_99053859daedfb6f20eae29659254996d765b8ff.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_0409.pks_3e940c840ee4815422610bb6da8f28ac327767cc.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_040b.pks_3bf50f7208f7fdf69932428e323a2c93bbede976.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_040c.pks_7cbfbdf414fcea12530080f94cb7c29fea74c54a.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_040e.pks_5780cdb32b99d0adf4ff39350bddfec14a792dc5.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_0410.pks_926fdca3ca7df7ac163d22b15ab18a716eef0042.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_0411.pks_d1b4cdb9029da5c6a25bf671de494231ec0b3e27.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_0412.pks_576bb7afb8fc4e6d89563184a8a6a5d625b449a5.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_0413.pks_20bee08afa00d72fb169522f028d94fdcca87664.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_0414.pks_b29084e38981e548bc53419430f789077a15207c.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_0415.pks_0613867ea56454150ce63f8b4b2612b86dfa85c3.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_0416.pks_1b4634522f8f6c1792c9f85615945ed536201185.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_0419.pks_71182794a1023bec4548529ac00bbb1a5098d787.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_041d.pks_e42bb7e6d9cd9687d43cadb06c9843d7ccfe89f0.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_0804.pks_60b681c892fd55ccab4bd2c94bdec543dd207631.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_0809.pks_04fcbfbd2d6f419b7f0b854da77f6ce13a16698d.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_0816.pks_3ecb9ac90f3614c5ee80bc95c7d8f300b7de4996.cab",
"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8112.7-7.10.8773.98-armv7-retail-microsoft.lang_0c0a.pks_09cab7985d025414c9923461e0a0729d95ec6737.cab"};


        public static string ver8779 = "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.pks_b9598a098a3a4e902d043cef778a79ff3e6b0869.cab";
        public static string[] ver8779langs = {"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_0404.pks_6115196e156d87998115301d5f7701f553ad62ad.cab",
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_0405.pks_4b52c0fec6e8e61fe64aa30d0fdf0010e577743d.cab",
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_0406.pks_defde7bd0ea4224f6543a2edd87f17cfed5d882c.cab",
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_0407.pks_a325cee9b2e502ee7cba73ad3b5276e23972080d.cab ",
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_0408.pks_6fb04331ffc9661c5a3f7d277381cee669b05d1f.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_0409.pks_4d87f62a11c7898a516df7563a9333e1082fad57.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_040b.pks_3a0612d1fef666dd641041937f5d2857e9bbde2b.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_040c.pks_b345d08ab6583dbf9e1d132533ec68e2af411e0f.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_040e.pks_929ee747819d7d412930d249097f6b244f96e6ae.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_0410.pks_1645c0de81f21046e42bad6feadcc50a621bb025.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_0411.pks_cafd951a55fd204f7bb36dd58d75ce418e25d3d2.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_0412.pks_e56ab94ce9cac98569acabb738f4bbb92dfb0d53.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_0413.pks_4151025cfe909a57fadca5e55992bc1c5b048f31.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_0414.pks_06ada7ba2cfe46fe9a3e6b09f89b3e5aeb834d32.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_0415.pks_ae243651640b98ef062dca683b9abc740c5f4ff0.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_0416.pks_2ec5d33ce2eee244829a6149d3d6a34c18d228f5.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_0419.pks_dd8f1fddaaab3841974f51e314bb85e65b330a07.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_041d.pks_b280b5a8e035926c6250a212d4d5099949f06aec.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_0804.pks_75e37ebd5af30ce17224d0d9cc592461cb037bd8.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_0809.pks_255010547a84862a8621b8819aa202e0d2aa9b0d.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_0816.pks_93e895b92230eba2981d19630974583dc19d38fc.cab",
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/05/diff-7.10.8773.98-7.10.8779.8-armv7-retail-microsoft.lang_0c0a.pks_3a0b5492a3b3bbbdbb0aa57f66faaa14c88df184.cab"
                               };


        public static string ver8783 = "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/10/diff-iucorefixed-7.10.8779.8-7.10.8783.12-armv7-retail-microsoft.pks_8a50b92b21951c7baf9f3600cea8c77e0918021f.cab";


        public static string ver8858_1 = "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.pks_d6fb2a271eed6a5d1187b17aba60806753d0ffce.cab";
        public static string ver8858_2 = "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.dpi_262.pks_39b9cc884c90d83c0df50ed5623166e9257d1162.cab";
        public static string[] ver8858langs = {"http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_0404.pks_9c7b9cf5b557e3e5b733fb06527ab833803e6c75.cab",
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_0405.pks_ba4200f9db8fad1ada3df976069205553570fa2e.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_0406.pks_45eb7780e173a87e6e3bfc6ad2a962495ce3289a.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_0407.pks_91c88df3371a97e95fddec6d490f184d79069b92.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_0408.pks_9d5775aa94029a2cabc0874b4fc8df606314f0f8.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_0409.pks_653898f93f54d951992766d317db1b846ca71e36.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_040b.pks_61e4412c01fb0c83e85750d8650dad74955a02fb.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_040c.pks_b34792a900bc0aeafeb0a2aaa666b490e44eb1ca.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_040e.pks_b6d36b4d816b42c43b29c658d72228a96aacc424.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_0410.pks_01ab9c5b927d1fdfb5de71774056a146697065ac.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_0411.pks_8df9bbde337291d775c3598b92a9e7388166bc42.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_0412.pks_e9736c093630ae8d0fb771ba126499e816a30175.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_0413.pks_753be0cb9312af1bac326f9ee30643985b776a8d.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_0414.pks_0cf081099d1bc130e16b5e31d663752b1f1eca64.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_0415.pks_a5b81c390ec85695ae99e4900e2beb4f365246d9.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_0416.pks_11efb7f385c2947b6b705ebc6901cedee00f799d.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_0419.pks_3931812023d755b700c8e5ffe0ee43e52c9cc19a.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_041d.pks_32c3d21c383f0c491a8a8d745c9bef8d1a83914e.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_0804.pks_d541f79c49e28d3c5a4c2cf817bed78d6d2b4ef9.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_0809.pks_45cef4457233690e536db6b7821af0a39b8aeb98.cab", 
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_0816.pks_8d78f889ff380ced118e823feed328487dce668b.cab",
                                                "http://download.windowsupdate.com/msdownload/update/software/dflt/2012/11/diff-7.10.8783.12-7.10.8858.136-armv7-retail-microsoft.lang_0c0a.pks_29c153eae13ce7184ac8abc63eb6345694e9fce0.cab"};

        public static string ver8860 = "http://download.windowsupdate.com/msdownload/update/software/dflt/2013/02/diff-7.10.8858.136-7.10.8860.142-armv7-retail-microsoft.pks_4a5e9f454174c7bdcb2da953d1e18fe5443ba7e8.cab";

        public static string ver8862 = "http://download.windowsupdate.com/msdownload/update/software/dflt/2013/03/diff-7.10.8860.142-7.10.8862.144-armv7-retail-microsoft.plustuner.pks_d802531eab4e9bce3ab747805ea7e33fc8cd29bf.cab";
    
    }

    

}
