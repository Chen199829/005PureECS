// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestDouble2x2
    {
        [TestCompiler]
        public static void double2x2_zero()
        {
            TestUtils.AreEqual(double2x2.zero.c0.x, 0.0);
            TestUtils.AreEqual(double2x2.zero.c0.y, 0.0);
            TestUtils.AreEqual(double2x2.zero.c1.x, 0.0);
            TestUtils.AreEqual(double2x2.zero.c1.y, 0.0);
        }

        [TestCompiler]
        public static void double2x2_identity()
        {
            TestUtils.AreEqual(double2x2.identity.c0.x, 1.0);
            TestUtils.AreEqual(double2x2.identity.c0.y, 0.0);
            TestUtils.AreEqual(double2x2.identity.c1.x, 0.0);
            TestUtils.AreEqual(double2x2.identity.c1.y, 1.0);
        }

        [TestCompiler]
        public static void double2x2_operator_equal_wide_wide()
        {
            double2x2 a0 = double2x2(-135.18925172425304, -49.094127439471947, 169.12980778940482, 240.80529772527757);
            double2x2 b0 = double2x2(-220.01464591734793, 66.980020792679852, 499.20158576369363, -371.113114291389);
            bool2x2 r0 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double2x2 a1 = double2x2(314.73919382446411, 442.39301916695808, 177.92444881141398, 335.53340283759564);
            double2x2 b1 = double2x2(208.44865212610398, 390.80369133074009, -72.443806920407269, 362.97643273089841);
            bool2x2 r1 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double2x2 a2 = double2x2(168.1544516869609, 350.72955982327903, 367.17843668869625, 46.941470406456574);
            double2x2 b2 = double2x2(194.6783255053117, 471.6448635867074, -404.04466719368691, -144.69675476136467);
            bool2x2 r2 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double2x2 a3 = double2x2(188.76415094582558, -97.211392209497944, -293.3210057193977, -234.82292353120766);
            double2x2 b3 = double2x2(-494.44664334433463, -252.97038209297244, 234.41711746641306, 398.72397465199413);
            bool2x2 r3 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_equal_wide_scalar()
        {
            double2x2 a0 = double2x2(65.671194345537174, 404.41550440546848, -269.7301577393572, 83.630607882342588);
            double b0 = (-155.8157547245807);
            bool2x2 r0 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double2x2 a1 = double2x2(152.99450476141385, 314.67125597348024, 386.36515325417986, 290.04894007837811);
            double b1 = (-155.86829836474186);
            bool2x2 r1 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double2x2 a2 = double2x2(-132.63519460178691, -69.683271678948415, -191.19075521789063, 186.84520086406042);
            double b2 = (-65.667489797653388);
            bool2x2 r2 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double2x2 a3 = double2x2(-232.89569221851218, -49.701092981594172, -300.88189925853248, 333.39685193328046);
            double b3 = (-319.14406481345372);
            bool2x2 r3 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_equal_scalar_wide()
        {
            double a0 = (36.383921878591195);
            double2x2 b0 = double2x2(-400.48919958644046, -71.286823544319191, 156.97811491646712, -225.23872791288363);
            bool2x2 r0 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double a1 = (499.14180993435059);
            double2x2 b1 = double2x2(-211.97992358542047, 428.31192394174263, -489.50133322621758, -5.6915457275190988);
            bool2x2 r1 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double a2 = (-30.865948453017495);
            double2x2 b2 = double2x2(-362.98307221149241, 184.50319322594589, -160.47062142215231, 316.66882315122928);
            bool2x2 r2 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double a3 = (390.36923879681581);
            double2x2 b3 = double2x2(505.10510301268891, -294.64870967280524, 443.19909283295226, 96.559236333034619);
            bool2x2 r3 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_not_equal_wide_wide()
        {
            double2x2 a0 = double2x2(279.99414576217259, -43.342018386042696, -465.72473523846116, 317.46655645848557);
            double2x2 b0 = double2x2(-460.912120318465, -476.00904844515446, 468.13642070635058, -341.01254312182431);
            bool2x2 r0 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double2x2 a1 = double2x2(85.714987079480238, 360.89050572034466, 366.08152668833804, 154.5428384070018);
            double2x2 b1 = double2x2(-62.658060341448561, -458.80166718866752, -457.73023316717251, -59.523265627922171);
            bool2x2 r1 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double2x2 a2 = double2x2(332.426219856565, 397.11323160543725, -431.3749584776233, 489.01079319837072);
            double2x2 b2 = double2x2(3.024243117787023, 155.81276352508587, -19.839918384253963, -6.0169332055453992);
            bool2x2 r2 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double2x2 a3 = double2x2(398.43358320669904, -489.81794594685454, 171.4049242340983, -67.829682620162941);
            double2x2 b3 = double2x2(-406.20792145571107, -102.42070083619126, -40.362921018322425, 452.67542645552919);
            bool2x2 r3 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_not_equal_wide_scalar()
        {
            double2x2 a0 = double2x2(-155.44111282911206, -19.426602134214079, 174.63305409934048, 507.9207296352464);
            double b0 = (-393.41354173860213);
            bool2x2 r0 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double2x2 a1 = double2x2(59.177048472304364, -58.923273352404692, -398.17684835855704, 492.20105361016522);
            double b1 = (171.15146430356026);
            bool2x2 r1 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double2x2 a2 = double2x2(-165.24150879925185, -380.24326222960059, 501.8990516615562, -134.34545642433011);
            double b2 = (270.34102333259818);
            bool2x2 r2 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double2x2 a3 = double2x2(458.40042302496749, 161.45995123752391, 261.51423442620512, -145.61239559278471);
            double b3 = (46.771004937016869);
            bool2x2 r3 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_not_equal_scalar_wide()
        {
            double a0 = (478.35313938481409);
            double2x2 b0 = double2x2(459.55319592894671, 436.45324369727314, -488.71416806090349, 392.76794475725296);
            bool2x2 r0 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double a1 = (-266.73665369056937);
            double2x2 b1 = double2x2(338.55788270503183, -338.10012475498957, -152.3145445102428, -452.82067868338);
            bool2x2 r1 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double a2 = (209.43931422449612);
            double2x2 b2 = double2x2(50.107968592135194, 372.4343656843688, -488.0213141329686, 489.74075697816011);
            bool2x2 r2 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double a3 = (270.40006149485714);
            double2x2 b3 = double2x2(-472.8467831429312, -286.85046090132113, -384.69186681541237, 443.42352959300558);
            bool2x2 r3 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_less_wide_wide()
        {
            double2x2 a0 = double2x2(51.710243010758518, -313.85556450200062, 283.04767359562572, 235.02188621974642);
            double2x2 b0 = double2x2(-261.83523881707117, -19.810742149041403, -149.25882084167506, 205.99822316225539);
            bool2x2 r0 = bool2x2(false, true, false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            double2x2 a1 = double2x2(44.0783565249659, -207.25566659088042, 3.3829410091894943, -144.30134326978651);
            double2x2 b1 = double2x2(-306.02438535635565, 102.12168006884008, 231.90633760760829, 179.49885305180158);
            bool2x2 r1 = bool2x2(false, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            double2x2 a2 = double2x2(-69.369597705718888, -135.66796762108243, -194.78736576567746, -33.473868147225062);
            double2x2 b2 = double2x2(473.22488496882136, 15.891647107848712, 270.04990614114786, 490.91400240869916);
            bool2x2 r2 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            double2x2 a3 = double2x2(-19.675088653189619, 423.23796697297973, -71.698315415390937, -501.88598870760109);
            double2x2 b3 = double2x2(-185.73412164753961, 76.433086669274189, 97.75231246731812, 419.30080600236579);
            bool2x2 r3 = bool2x2(false, false, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_less_wide_scalar()
        {
            double2x2 a0 = double2x2(-221.86977325280651, -121.54646807608498, -97.52392511140738, 479.88107775146193);
            double b0 = (199.06751808853244);
            bool2x2 r0 = bool2x2(true, true, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            double2x2 a1 = double2x2(67.118990214131259, 282.96659601990439, 258.27909362422258, -111.41316061439608);
            double b1 = (137.32880574899207);
            bool2x2 r1 = bool2x2(true, false, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            double2x2 a2 = double2x2(-288.08113278452356, -361.64292042406413, -68.088202269788951, 12.788020378345664);
            double b2 = (82.665427008022334);
            bool2x2 r2 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            double2x2 a3 = double2x2(-66.703050406045747, 25.727694284975428, 101.37087182950734, -330.442660724019);
            double b3 = (-78.762971199472872);
            bool2x2 r3 = bool2x2(false, false, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_less_scalar_wide()
        {
            double a0 = (-250.4849370692321);
            double2x2 b0 = double2x2(-377.19654887597846, -505.14754104295167, 375.92672198634909, 110.17393474940855);
            bool2x2 r0 = bool2x2(false, false, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            double a1 = (-118.09757452742082);
            double2x2 b1 = double2x2(-40.45089079833167, -299.74430932651478, 31.437125935888389, -458.904539560389);
            bool2x2 r1 = bool2x2(true, false, true, false);
            TestUtils.AreEqual(a1 < b1, r1);

            double a2 = (13.684679276163024);
            double2x2 b2 = double2x2(-458.50690839183841, 248.27646624682302, 389.23142999654237, 488.74553679337055);
            bool2x2 r2 = bool2x2(false, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            double a3 = (-221.63786731550368);
            double2x2 b3 = double2x2(-424.26720329013989, 249.05904948388184, -22.136127720650336, -442.24773928255206);
            bool2x2 r3 = bool2x2(false, true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_greater_wide_wide()
        {
            double2x2 a0 = double2x2(-229.29066501804192, 505.536608216137, -73.80706862071861, 100.29203777215071);
            double2x2 b0 = double2x2(-445.84502407808088, -420.03529210576568, 299.02440108872224, -13.880978829171966);
            bool2x2 r0 = bool2x2(true, true, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            double2x2 a1 = double2x2(-419.21478124112582, -159.55974753180504, -396.7703608929973, 127.03739482119556);
            double2x2 b1 = double2x2(151.56173593903043, -163.5094302461992, -391.09603733154762, 479.2837710228207);
            bool2x2 r1 = bool2x2(false, true, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            double2x2 a2 = double2x2(489.13989733585151, 51.91890885863404, 155.38475544535777, -135.63165027258526);
            double2x2 b2 = double2x2(-77.674873149802409, -46.5841996886694, -415.37701888353422, 71.466978344818131);
            bool2x2 r2 = bool2x2(true, true, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            double2x2 a3 = double2x2(-425.97813554572787, -228.430505143679, 383.03834909155887, 136.53358298937496);
            double2x2 b3 = double2x2(-206.06102643071722, 360.83628218287424, 236.96878658838978, 14.550342328171382);
            bool2x2 r3 = bool2x2(false, false, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_greater_wide_scalar()
        {
            double2x2 a0 = double2x2(11.156317000815761, -411.02322382993214, 385.88556188432756, -485.10304831206008);
            double b0 = (-302.81693877969724);
            bool2x2 r0 = bool2x2(true, false, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            double2x2 a1 = double2x2(-491.18003033622171, 173.57509740329124, 69.269281181166548, 501.30683183172107);
            double b1 = (405.17534632476759);
            bool2x2 r1 = bool2x2(false, false, false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            double2x2 a2 = double2x2(-367.027771405423, -489.09058998948456, -172.51816066192379, -18.149639853346002);
            double b2 = (-86.124509613087639);
            bool2x2 r2 = bool2x2(false, false, false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            double2x2 a3 = double2x2(-236.41493498367021, -27.239137900638923, 471.77934072528933, 240.16453253485474);
            double b3 = (-238.8945134798505);
            bool2x2 r3 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_greater_scalar_wide()
        {
            double a0 = (453.54610201974685);
            double2x2 b0 = double2x2(-226.20441423459187, -423.46500487973213, 409.40550227156166, 453.87706277048073);
            bool2x2 r0 = bool2x2(true, true, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            double a1 = (87.475727837288673);
            double2x2 b1 = double2x2(113.79560308987072, 176.40926154721956, -140.44002944810319, -182.48286804113673);
            bool2x2 r1 = bool2x2(false, false, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            double a2 = (-158.29329188088576);
            double2x2 b2 = double2x2(-162.68531830733889, -193.328676075362, 230.18129955519987, -102.58784227379965);
            bool2x2 r2 = bool2x2(true, true, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            double a3 = (392.5205878655056);
            double2x2 b3 = double2x2(-177.47865947404813, -10.295010809924008, -24.048938524000789, 172.44867499752377);
            bool2x2 r3 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_less_equal_wide_wide()
        {
            double2x2 a0 = double2x2(240.09053169940159, 462.2131528622532, 293.08251561461134, -427.87067361728782);
            double2x2 b0 = double2x2(-81.203838624620744, 493.63743876555816, -411.47211451617636, 99.164449499530974);
            bool2x2 r0 = bool2x2(false, true, false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            double2x2 a1 = double2x2(-405.5227226715175, 204.59190211286386, 294.670105832941, -327.56444445604666);
            double2x2 b1 = double2x2(-295.66769875943089, -480.46254824123463, 74.414040361723892, 260.916124226952);
            bool2x2 r1 = bool2x2(true, false, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            double2x2 a2 = double2x2(-456.12326667091031, 282.3012408140587, 421.8811549720732, -311.71284809322697);
            double2x2 b2 = double2x2(306.17329730939741, 139.56480438055689, -505.75247955031341, -489.62680958659706);
            bool2x2 r2 = bool2x2(true, false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            double2x2 a3 = double2x2(84.5674827492644, 447.24461647832982, -154.49435217422172, -424.36474986763892);
            double2x2 b3 = double2x2(-280.03260267899958, 303.15991058161478, 511.19015788994272, -104.65973358259527);
            bool2x2 r3 = bool2x2(false, false, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_less_equal_wide_scalar()
        {
            double2x2 a0 = double2x2(309.1924356469849, 69.673792633076118, -101.72418622939114, -315.97240629604664);
            double b0 = (292.92427148154206);
            bool2x2 r0 = bool2x2(false, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            double2x2 a1 = double2x2(-346.01106731314724, -410.87006945669191, -483.90265320423185, 183.82114538169515);
            double b1 = (424.15386577330241);
            bool2x2 r1 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            double2x2 a2 = double2x2(320.44249287268258, -386.801748694294, -182.9388249772316, 349.25012962392077);
            double b2 = (-257.87003791419329);
            bool2x2 r2 = bool2x2(false, true, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            double2x2 a3 = double2x2(485.31159304329731, 259.15151822713744, 450.13007828692446, -128.5255282523695);
            double b3 = (373.56911652794531);
            bool2x2 r3 = bool2x2(false, true, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_less_equal_scalar_wide()
        {
            double a0 = (-511.15238141974078);
            double2x2 b0 = double2x2(51.159012579898786, 340.44369022010062, 312.81429519914752, 354.19252626699983);
            bool2x2 r0 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            double a1 = (136.39671165142056);
            double2x2 b1 = double2x2(-94.767871185563422, 288.544332877055, 304.04282369466625, -148.61806089646092);
            bool2x2 r1 = bool2x2(false, true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            double a2 = (-506.30010127755816);
            double2x2 b2 = double2x2(27.581254256694251, 48.471146844546865, 104.88351326104419, -488.6858386884843);
            bool2x2 r2 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            double a3 = (-480.43516968210935);
            double2x2 b3 = double2x2(421.9366516647566, 239.72105299668431, -101.01844673092404, -283.95147551407638);
            bool2x2 r3 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_greater_equal_wide_wide()
        {
            double2x2 a0 = double2x2(-386.59181302906563, -157.12078221008215, 391.01526445477054, -511.88687133783793);
            double2x2 b0 = double2x2(153.44301350109424, 49.892483019219981, 78.025787628267835, 138.81373292711271);
            bool2x2 r0 = bool2x2(false, false, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            double2x2 a1 = double2x2(-5.4220387960886569, 287.64527501149348, -122.53520184500849, 7.4814426933794493);
            double2x2 b1 = double2x2(-225.51057802211056, -339.35611335344436, -373.302078182484, 364.9358934671319);
            bool2x2 r1 = bool2x2(true, true, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            double2x2 a2 = double2x2(152.94642765491574, 48.986223482054811, 57.338148859021317, 300.46493138953338);
            double2x2 b2 = double2x2(-322.71539870030961, 125.47818165900105, -25.776589167200314, 297.51890792395864);
            bool2x2 r2 = bool2x2(true, false, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            double2x2 a3 = double2x2(349.25705139211243, 85.749700824613569, -230.95330654408468, 418.7112159294594);
            double2x2 b3 = double2x2(73.222349439385539, 462.78374288174496, 393.19134515951919, -95.001432224643168);
            bool2x2 r3 = bool2x2(true, false, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_greater_equal_wide_scalar()
        {
            double2x2 a0 = double2x2(495.457423679278, -14.345115906719627, -463.47478053694346, 217.51749215718246);
            double b0 = (189.20512804258851);
            bool2x2 r0 = bool2x2(true, false, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            double2x2 a1 = double2x2(-246.86571776441565, 53.815095211293169, -123.33294373533357, -221.50546441856096);
            double b1 = (-377.65869706573835);
            bool2x2 r1 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            double2x2 a2 = double2x2(252.99433410027734, -395.36331028275345, 164.77259667439978, -287.00733889593153);
            double b2 = (-116.44038277326172);
            bool2x2 r2 = bool2x2(true, false, true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            double2x2 a3 = double2x2(355.83704559683667, 273.01225555735277, -418.14240308205706, 249.38409697701411);
            double b3 = (184.19556316369938);
            bool2x2 r3 = bool2x2(true, true, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_greater_equal_scalar_wide()
        {
            double a0 = (215.43534169692327);
            double2x2 b0 = double2x2(204.80295310020585, -101.10404853760451, -122.05503827056617, -70.456147941973143);
            bool2x2 r0 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            double a1 = (-239.62025677395064);
            double2x2 b1 = double2x2(-185.99272426683115, -455.61258027312, 276.66581476697036, 79.39918831707871);
            bool2x2 r1 = bool2x2(false, true, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            double a2 = (416.42054791768112);
            double2x2 b2 = double2x2(379.27350801009379, -439.51472612820322, 67.141009600433108, -74.560638224035813);
            bool2x2 r2 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            double a3 = (-367.25635474140586);
            double2x2 b3 = double2x2(494.950765601802, -61.235545425319856, -429.17024846988278, -213.82468924942646);
            bool2x2 r3 = bool2x2(false, false, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_add_wide_wide()
        {
            double2x2 a0 = double2x2(465.14837644302679, 278.91072548502621, -277.52992237616792, -65.197214395365336);
            double2x2 b0 = double2x2(483.99436186440028, -204.07667193379098, -365.67356007437854, -509.92086076639634);
            double2x2 r0 = double2x2(949.14273830742707, 74.834053551235229, -643.20348245054652, -575.11807516176168);
            TestUtils.AreEqual(a0 + b0, r0);

            double2x2 a1 = double2x2(-473.32437561141529, -4.6955420992782138, -470.53676698661258, -109.95011453980118);
            double2x2 b1 = double2x2(-270.69751108377125, 486.76397846954126, 267.49177587567442, 251.6425212601398);
            double2x2 r1 = double2x2(-744.02188669518659, 482.06843637026304, -203.04499111093816, 141.69240672033862);
            TestUtils.AreEqual(a1 + b1, r1);

            double2x2 a2 = double2x2(-178.70145782209067, -420.03378339299644, 290.71109236903078, -446.5296368294068);
            double2x2 b2 = double2x2(244.4951094335388, -78.675763882079991, 352.20551340291536, 82.779185095233515);
            double2x2 r2 = double2x2(65.793651611448126, -498.70954727507643, 642.91660577194614, -363.75045173417328);
            TestUtils.AreEqual(a2 + b2, r2);

            double2x2 a3 = double2x2(491.066454400805, -261.11730039358014, -298.40688409395835, 502.42861890347149);
            double2x2 b3 = double2x2(462.54732606492348, -405.492017696375, -428.4983238785054, -41.872599859662614);
            double2x2 r3 = double2x2(953.6137804657285, -666.6093180899552, -726.90520797246381, 460.55601904380887);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_add_wide_scalar()
        {
            double2x2 a0 = double2x2(459.89829728561369, -447.66336104258119, -94.438627525436971, 126.42986279652916);
            double b0 = (500.99725913489112);
            double2x2 r0 = double2x2(960.89555642050482, 53.333898092309937, 406.55863160945415, 627.42712193142029);
            TestUtils.AreEqual(a0 + b0, r0);

            double2x2 a1 = double2x2(-36.254356162741033, -2.7912590516690443, -478.41478489265535, 443.11525246273504);
            double b1 = (-349.64130060264904);
            double2x2 r1 = double2x2(-385.89565676539007, -352.43255965431808, -828.05608549530439, 93.473951860086);
            TestUtils.AreEqual(a1 + b1, r1);

            double2x2 a2 = double2x2(268.092225914864, -471.25607584009697, -2.6649749291431704, 78.985822952811532);
            double b2 = (41.32102133767728);
            double2x2 r2 = double2x2(309.41324725254128, -429.93505450241969, 38.65604640853411, 120.30684429048881);
            TestUtils.AreEqual(a2 + b2, r2);

            double2x2 a3 = double2x2(202.14799151297098, 10.345855002452595, -151.24445898423181, 355.23276703210206);
            double b3 = (311.7254551908585);
            double2x2 r3 = double2x2(513.87344670382947, 322.07131019331109, 160.48099620662668, 666.95822222296056);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_add_scalar_wide()
        {
            double a0 = (-325.51276484388518);
            double2x2 b0 = double2x2(-264.08813178915909, -106.00925998855814, -355.44729320865463, -447.33029362528134);
            double2x2 r0 = double2x2(-589.60089663304427, -431.52202483244332, -680.96005805253981, -772.84305846916652);
            TestUtils.AreEqual(a0 + b0, r0);

            double a1 = (-158.70021040677102);
            double2x2 b1 = double2x2(-199.48369154682553, 180.31809123806568, 337.57936898692481, -37.05501486596421);
            double2x2 r1 = double2x2(-358.18390195359655, 21.617880831294656, 178.87915858015378, -195.75522527273523);
            TestUtils.AreEqual(a1 + b1, r1);

            double a2 = (230.80498014707348);
            double2x2 b2 = double2x2(-140.17433339924287, 18.02419591789328, -138.61435825126915, 26.904163611542458);
            double2x2 r2 = double2x2(90.63064674783061, 248.82917606496676, 92.190621895804327, 257.70914375861594);
            TestUtils.AreEqual(a2 + b2, r2);

            double a3 = (-374.53758233345);
            double2x2 b3 = double2x2(154.4676006559597, 268.3838204203098, -190.96302255939833, 188.61725362977813);
            double2x2 r3 = double2x2(-220.06998167749032, -106.15376191314022, -565.50060489284829, -185.92032870367188);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_sub_wide_wide()
        {
            double2x2 a0 = double2x2(133.37101680290471, -131.8321183341705, -197.29314407952739, -485.286571013409);
            double2x2 b0 = double2x2(123.46028739002543, 359.56010048443454, -48.24847819667707, 478.97904680621764);
            double2x2 r0 = double2x2(9.9107294128792773, -491.39221881860504, -149.04466588285032, -964.26561781962664);
            TestUtils.AreEqual(a0 - b0, r0);

            double2x2 a1 = double2x2(-337.55033103448818, 471.66710470228782, 146.5066197600712, -130.58504372955537);
            double2x2 b1 = double2x2(207.15832886805686, 142.36730462981723, -125.60551005490379, -65.299004823574307);
            double2x2 r1 = double2x2(-544.708659902545, 329.29980007247059, 272.112129814975, -65.286038905981059);
            TestUtils.AreEqual(a1 - b1, r1);

            double2x2 a2 = double2x2(110.77707367333448, -235.54160486699158, 78.879356659427, -347.68616811730254);
            double2x2 b2 = double2x2(-477.876434787119, 164.50000031501986, 428.00958915614035, 72.6278169493321);
            double2x2 r2 = double2x2(588.65350846045351, -400.04160518201144, -349.13023249671335, -420.31398506663464);
            TestUtils.AreEqual(a2 - b2, r2);

            double2x2 a3 = double2x2(-470.82054565419469, -11.459293609233271, -167.94791730118351, 330.67676917215658);
            double2x2 b3 = double2x2(-446.880505531505, 432.09146114443035, -225.55465637219822, -112.45196705332586);
            double2x2 r3 = double2x2(-23.940040122689709, -443.55075475366363, 57.606739071014715, 443.12873622548244);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_sub_wide_scalar()
        {
            double2x2 a0 = double2x2(48.936717294592768, 410.45158953706346, -364.44171612544062, 163.98060353285666);
            double b0 = (-291.59041442144212);
            double2x2 r0 = double2x2(340.52713171603489, 702.04200395850557, -72.8513017039985, 455.57101795429878);
            TestUtils.AreEqual(a0 - b0, r0);

            double2x2 a1 = double2x2(-460.06732318367222, 204.35834441164434, 180.26971420099483, -377.92569344952972);
            double b1 = (110.91942339340198);
            double2x2 r1 = double2x2(-570.9867465770742, 93.438921018242354, 69.350290807592842, -488.8451168429317);
            TestUtils.AreEqual(a1 - b1, r1);

            double2x2 a2 = double2x2(-470.26204297983185, 461.50756499800252, -246.28726660753006, 21.605312595891405);
            double b2 = (400.53491968686455);
            double2x2 r2 = double2x2(-870.79696266669634, 60.972645311137967, -646.82218629439467, -378.92960709097315);
            TestUtils.AreEqual(a2 - b2, r2);

            double2x2 a3 = double2x2(246.35072171238755, -122.71842413894757, -122.93872099879138, 360.15095417581074);
            double b3 = (-121.42736178330489);
            double2x2 r3 = double2x2(367.77808349569244, -1.29106235564268, -1.5113592154864932, 481.57831595911563);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_sub_scalar_wide()
        {
            double a0 = (294.58645905861);
            double2x2 b0 = double2x2(452.35251757705237, 256.98980891750648, -275.159888634067, -89.027518075437968);
            double2x2 r0 = double2x2(-157.76605851844238, 37.59665014110351, 569.746347692677, 383.61397713404796);
            TestUtils.AreEqual(a0 - b0, r0);

            double a1 = (488.22838829840919);
            double2x2 b1 = double2x2(-333.21728030462623, -64.232989102710519, -66.041730196234653, 341.20492831859963);
            double2x2 r1 = double2x2(821.44566860303541, 552.46137740111976, 554.27011849464384, 147.02345997980956);
            TestUtils.AreEqual(a1 - b1, r1);

            double a2 = (-385.775056303374);
            double2x2 b2 = double2x2(75.394746577085357, 354.94371645289641, 169.13141520746581, 88.216608326982964);
            double2x2 r2 = double2x2(-461.16980288045937, -740.71877275627048, -554.90647151083976, -473.991664630357);
            TestUtils.AreEqual(a2 - b2, r2);

            double a3 = (1.7350065716240124);
            double2x2 b3 = double2x2(122.53803997977548, -264.94502771317264, -50.837180399725753, -347.65032283759228);
            double2x2 r3 = double2x2(-120.80303340815146, 266.68003428479665, 52.572186971349765, 349.3853294092163);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_mul_wide_wide()
        {
            double2x2 a0 = double2x2(-394.78053898121254, -412.37219519744264, -25.874570143350638, -241.04595886964626);
            double2x2 b0 = double2x2(-149.76397831261346, -345.04538671348496, -284.33404721148963, 267.97923648915219);
            double2x2 r0 = double2x2(59123.904078224172, 142287.1235617903, 7357.0212487164608, -64595.312016683383);
            TestUtils.AreEqual(a0 * b0, r0);

            double2x2 a1 = double2x2(-93.675987525692221, 244.15999257013198, 494.68846606402121, 53.537962700025105);
            double2x2 b1 = double2x2(-326.64849558782225, -150.68967754705329, 207.73243794577775, 366.19289248352538);
            double2x2 r1 = double2x2(30599.120397970968, -36792.390550284115, 102762.84107913627, 19605.221418797286);
            TestUtils.AreEqual(a1 * b1, r1);

            double2x2 a2 = double2x2(-239.49641167349017, 236.67584644848284, -211.85620818466703, -216.65482030466887);
            double2x2 b2 = double2x2(358.88076202891807, 214.85359368792433, 253.42280900358355, -307.71382751488773);
            double2x2 r2 = double2x2(-85950.654724573629, 50850.6561485879, -53689.195383006307, 66667.684005499876);
            TestUtils.AreEqual(a2 * b2, r2);

            double2x2 a3 = double2x2(467.95832870339893, -178.02191146557311, -386.3942503344241, -422.43540521265726);
            double2x2 b3 = double2x2(184.4711149597872, 426.43644185850235, -144.28142625851621, 459.47961518703016);
            double2x2 r3 = double2x2(86324.794650634591, -75915.030498228327, 55749.513536340863, -194100.45742848891);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_mul_wide_scalar()
        {
            double2x2 a0 = double2x2(328.20302191758674, -290.10672272839895, 236.99572454998065, 120.48136692889102);
            double b0 = (192.21119055161773);
            double2x2 r0 = double2x2(63084.293585418032, -55761.758562653624, 45553.230371395039, 23157.866976688449);
            TestUtils.AreEqual(a0 * b0, r0);

            double2x2 a1 = double2x2(357.90315811610924, -477.31047104173825, -438.272912467957, -46.729179165665585);
            double b1 = (134.86723214707672);
            double2x2 r1 = double2x2(48269.408311817213, -64373.542104216656, -59108.654629591387, -6302.235054578161);
            TestUtils.AreEqual(a1 * b1, r1);

            double2x2 a2 = double2x2(-238.40500103608008, -48.83483722099794, 355.30832998608628, 119.35660391643489);
            double b2 = (422.08249374017237);
            double2x2 r2 = double2x2(-100626.57735743705, -20612.3298756342, 149969.42596718337, 50378.333025406864);
            TestUtils.AreEqual(a2 * b2, r2);

            double2x2 a3 = double2x2(-196.995807977857, -325.55215683837991, 53.937323833786536, -87.4509838034636);
            double b3 = (98.2360046367329);
            double2x2 r3 = double2x2(-19352.081105929705, -31980.943188673486, 5298.5871942288177, -8590.8352504039049);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_mul_scalar_wide()
        {
            double a0 = (-464.534700371574);
            double2x2 b0 = double2x2(329.36093846399376, -198.68342671109525, 184.07942518223047, 256.01618754864489);
            double2x2 r0 = double2x2(-152999.58486347177, 92295.346096036214, -85511.280621599, -118928.40297318244);
            TestUtils.AreEqual(a0 * b0, r0);

            double a1 = (266.22629297255833);
            double2x2 b1 = double2x2(-97.894749448585685, 159.74810583877752, -351.82222263506719, 491.80157660497423);
            double2x2 r1 = double2x2(-26062.156247174364, 42529.146026845636, -93664.326117500037, 130930.51061760196);
            TestUtils.AreEqual(a1 * b1, r1);

            double a2 = (49.902031206480274);
            double2x2 b2 = double2x2(424.46256871915546, 160.11807616060514, -395.99208492599058, 125.20168858636248);
            double2x2 r2 = double2x2(21181.544350206073, 7990.2172332881028, -19760.809379495968, 6247.8185709406853);
            TestUtils.AreEqual(a2 * b2, r2);

            double a3 = (-265.01581991138676);
            double2x2 b3 = double2x2(314.65609779705107, -292.71202029507236, -37.729878681586058, 165.3622206027444);
            double2x2 r3 = double2x2(-83388.843747802981, 77573.316056417083, 9999.0147339576815, -43823.604475403918);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_div_wide_wide()
        {
            double2x2 a0 = double2x2(246.26574933075619, -269.85612953354428, -451.61952588130697, -7.38850236283082);
            double2x2 b0 = double2x2(172.11981423763552, -77.141104972521362, -325.8353723612779, -450.60868117334724);
            double2x2 r0 = double2x2(1.4307809383918566, 3.4982144685336105, 1.3860359070548143, 0.016396715535066435);
            TestUtils.AreEqual(a0 / b0, r0);

            double2x2 a1 = double2x2(-308.20558681534862, -373.394808704683, 360.41863482092447, 25.80972458133931);
            double2x2 b1 = double2x2(-261.26215398556656, -122.44949847201326, -93.210781379235357, -442.00522705633438);
            double2x2 r1 = double2x2(1.1796794220427942, 3.0493780159501847, -3.8667054335113131, -0.05839235149599218);
            TestUtils.AreEqual(a1 / b1, r1);

            double2x2 a2 = double2x2(-274.050461181463, 127.53858977534742, -447.6717600522897, -137.4586017771897);
            double2x2 b2 = double2x2(484.36271380091216, -390.78178686219348, 402.02531714086672, 316.65072193585831);
            double2x2 r2 = double2x2(-0.56579594872388561, -0.32636779415802974, -1.1135412148569459, -0.43410165287743668);
            TestUtils.AreEqual(a2 / b2, r2);

            double2x2 a3 = double2x2(-136.13317424437645, 12.43763423545181, 228.51298319013461, 356.9723681681661);
            double2x2 b3 = double2x2(397.15440744774151, -303.26218643005109, -118.59124451437555, -81.650312223308845);
            double2x2 r3 = double2x2(-0.3427714050039572, -0.041012809351094658, -1.9268959030313104, -4.37196574572633);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_div_wide_scalar()
        {
            double2x2 a0 = double2x2(-244.51745116175965, 69.112274917360537, -333.02311888943575, 257.39682519500923);
            double b0 = (-60.024377612408443);
            double2x2 r0 = double2x2(4.0736357608014941, -1.1514034408425655, 5.5481311449798705, -4.2882048166676752);
            TestUtils.AreEqual(a0 / b0, r0);

            double2x2 a1 = double2x2(403.24561257066466, 131.52659160062979, -261.88639200007844, -348.92380516087815);
            double b1 = (154.34436066185322);
            double2x2 r1 = double2x2(2.6126358672353378, 0.85216324740743876, -1.6967668327956258, -2.2606838608462096);
            TestUtils.AreEqual(a1 / b1, r1);

            double2x2 a2 = double2x2(-275.53868187383688, 287.64239968342815, 504.37224626185946, 491.78708600056689);
            double b2 = (210.55792174607416);
            double2x2 r2 = double2x2(-1.308612279171939, 1.3660963087882074, 2.39540855114497, 2.3356380131527215);
            TestUtils.AreEqual(a2 / b2, r2);

            double2x2 a3 = double2x2(-26.63160015392657, 272.89512098622276, 178.09617313095191, -460.87559030059521);
            double b3 = (-253.23667275776933);
            double2x2 r3 = double2x2(0.10516486361910435, -1.0776287573769281, -0.70327954948810989, 1.8199401582781043);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_div_scalar_wide()
        {
            double a0 = (41.737658758525527);
            double2x2 b0 = double2x2(-422.676129776368, 248.12963235011773, 449.39137741988122, 245.85813796047967);
            double2x2 r0 = double2x2(-0.098746193168297289, 0.1682090863683405, 0.092875967042706856, 0.16976317767945767);
            TestUtils.AreEqual(a0 / b0, r0);

            double a1 = (-326.62061253498337);
            double2x2 b1 = double2x2(163.71510489457989, 333.664472020075, 38.291076916405473, -472.97976062864984);
            double2x2 r1 = double2x2(-1.9950548408181534, -0.97888939316060053, -8.5299406242357652, 0.69055938482624146);
            TestUtils.AreEqual(a1 / b1, r1);

            double a2 = (192.23013958345643);
            double2x2 b2 = double2x2(-200.29686960964318, -490.18150376257557, -211.10257468517057, -322.85234108700058);
            double2x2 r2 = double2x2(-0.95972613030893628, -0.3921611446125986, -0.91060063985548412, -0.59541194261204144);
            TestUtils.AreEqual(a2 / b2, r2);

            double a3 = (-137.98529035317961);
            double2x2 b3 = double2x2(84.32973555677097, 355.06345550858578, 276.42724455354141, -382.9880213136729);
            double2x2 r3 = double2x2(-1.6362590187453818, -0.38862149346102726, -0.49917398907636662, 0.36028617782843814);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_mod_wide_wide()
        {
            double2x2 a0 = double2x2(-442.30985924336585, 368.50046246522129, -1.0938966279355213, -364.67383473211612);
            double2x2 b0 = double2x2(-43.245045443645211, -144.19587690392319, -62.640481739603217, -336.82826510855381);
            double2x2 r0 = double2x2(-9.8594048069137443, 80.1087086573749, -1.0938966279355213, -27.845569623562312);
            TestUtils.AreEqual(a0 % b0, r0);

            double2x2 a1 = double2x2(-197.34394487987458, -34.034902350062, -101.34858350704826, 208.31857142612273);
            double2x2 b1 = double2x2(-154.6102545981343, -154.02935583611452, 487.0462093237071, -469.82909105244516);
            double2x2 r1 = double2x2(-42.73369028174028, -34.034902350062, -101.34858350704826, 208.31857142612273);
            TestUtils.AreEqual(a1 % b1, r1);

            double2x2 a2 = double2x2(-140.77031404374645, 183.446989383291, -463.36838100076113, 83.839106360375467);
            double2x2 b2 = double2x2(-145.20377237405802, -203.38401780062543, -22.520082245823062, 224.6900237652892);
            double2x2 r2 = double2x2(-140.77031404374645, 183.446989383291, -12.966736084299896, 83.839106360375467);
            TestUtils.AreEqual(a2 % b2, r2);

            double2x2 a3 = double2x2(-64.714058190916717, 295.06681050689281, 212.257051805154, 349.62829916068745);
            double2x2 b3 = double2x2(-435.62674614210925, 12.095571285158144, 40.378765363422531, 345.78484813579587);
            double2x2 r3 = double2x2(-64.714058190916717, 4.773099663097355, 10.363224988041338, 3.8434510248915785);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_mod_wide_scalar()
        {
            double2x2 a0 = double2x2(-433.41699548876704, -5.5141427542614565, 393.39439958771425, 299.41153277988155);
            double b0 = (-90.499235433758827);
            double2x2 r0 = double2x2(-71.420053753731736, -5.5141427542614565, 31.39745785267894, 27.913826478605074);
            TestUtils.AreEqual(a0 % b0, r0);

            double2x2 a1 = double2x2(-120.80601626299602, -450.80766245853511, 186.09479698263794, -84.473635951277629);
            double b1 = (-502.939041133476);
            double2x2 r1 = double2x2(-120.80601626299602, -450.80766245853511, 186.09479698263794, -84.473635951277629);
            TestUtils.AreEqual(a1 % b1, r1);

            double2x2 a2 = double2x2(-318.78148356023314, -54.6001856581309, -172.33886607565864, -429.71466728193434);
            double b2 = (433.45469041981482);
            double2x2 r2 = double2x2(-318.78148356023314, -54.6001856581309, -172.33886607565864, -429.71466728193434);
            TestUtils.AreEqual(a2 % b2, r2);

            double2x2 a3 = double2x2(222.36186109406958, 254.51082885196, -433.09369703433185, -203.08261284748215);
            double b3 = (5.796394112425105);
            double2x2 r3 = double2x2(2.09888482191559, 5.2658820176804966, -4.16053271487408, -0.20881891260347629);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_mod_scalar_wide()
        {
            double a0 = (-396.4224028049141);
            double2x2 b0 = double2x2(-159.14024384279747, 230.17333399046834, 14.779358632294134, -303.15649738123477);
            double2x2 r0 = double2x2(-78.141915119319151, -166.24906881444576, -12.159078365266623, -93.265905423679328);
            TestUtils.AreEqual(a0 % b0, r0);

            double a1 = (399.63502020371845);
            double2x2 b1 = double2x2(206.69470534412881, 397.04482263934096, -393.89064735634747, -372.06709426085797);
            double2x2 r1 = double2x2(192.94031485958965, 2.5901975643774904, 5.7443728473709825, 27.567925942860484);
            TestUtils.AreEqual(a1 % b1, r1);

            double a2 = (201.01229796233224);
            double2x2 b2 = double2x2(-95.5668547598491, -258.95146882671463, 106.98357563232241, 469.3235559264773);
            double2x2 r2 = double2x2(9.8785884426340544, 201.01229796233224, 94.028722330009828, 201.01229796233224);
            TestUtils.AreEqual(a2 % b2, r2);

            double a3 = (-34.808985011097491);
            double2x2 b3 = double2x2(184.83653434777466, 374.79425376224992, -131.87271911086174, -120.09286003936683);
            double2x2 r3 = double2x2(-34.808985011097491, -34.808985011097491, -34.808985011097491, -34.808985011097491);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_plus()
        {
            double2x2 a0 = double2x2(271.6708086802023, -79.080240524876956, -330.98506203805334, 31.824682965793045);
            double2x2 r0 = double2x2(271.6708086802023, -79.080240524876956, -330.98506203805334, 31.824682965793045);
            TestUtils.AreEqual(+a0, r0);

            double2x2 a1 = double2x2(315.44952860262686, 190.32466015141677, -350.30858270745193, -320.51845875406565);
            double2x2 r1 = double2x2(315.44952860262686, 190.32466015141677, -350.30858270745193, -320.51845875406565);
            TestUtils.AreEqual(+a1, r1);

            double2x2 a2 = double2x2(102.0544069288552, -428.77622075973835, 377.23016208095021, 234.77393042052813);
            double2x2 r2 = double2x2(102.0544069288552, -428.77622075973835, 377.23016208095021, 234.77393042052813);
            TestUtils.AreEqual(+a2, r2);

            double2x2 a3 = double2x2(34.283600107898792, 465.35593555185756, 309.59316530339106, -316.93713655925222);
            double2x2 r3 = double2x2(34.283600107898792, 465.35593555185756, 309.59316530339106, -316.93713655925222);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_neg()
        {
            double2x2 a0 = double2x2(420.22718854445372, -196.25749811728366, -335.42683068636188, 509.04366969924592);
            double2x2 r0 = double2x2(-420.22718854445372, 196.25749811728366, 335.42683068636188, -509.04366969924592);
            TestUtils.AreEqual(-a0, r0);

            double2x2 a1 = double2x2(-33.014395013923945, -495.8379526063045, -270.85946787095605, 19.686896571743773);
            double2x2 r1 = double2x2(33.014395013923945, 495.8379526063045, 270.85946787095605, -19.686896571743773);
            TestUtils.AreEqual(-a1, r1);

            double2x2 a2 = double2x2(268.23670662019254, 223.38126312167446, -410.39206070936848, -395.68154186554324);
            double2x2 r2 = double2x2(-268.23670662019254, -223.38126312167446, 410.39206070936848, 395.68154186554324);
            TestUtils.AreEqual(-a2, r2);

            double2x2 a3 = double2x2(-349.14948885010062, -238.21960913307015, 292.54351224216794, 469.29257867731735);
            double2x2 r3 = double2x2(349.14948885010062, 238.21960913307015, -292.54351224216794, -469.29257867731735);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_prefix_inc()
        {
            double2x2 a0 = double2x2(-99.79557113526181, 458.74185082816609, 96.179026886904126, -48.552469514567633);
            double2x2 r0 = double2x2(-98.79557113526181, 459.74185082816609, 97.179026886904126, -47.552469514567633);
            TestUtils.AreEqual(++a0, r0);

            double2x2 a1 = double2x2(-315.728967098393, -323.61485853959567, -456.89028832730384, -76.507656371457358);
            double2x2 r1 = double2x2(-314.728967098393, -322.61485853959567, -455.89028832730384, -75.507656371457358);
            TestUtils.AreEqual(++a1, r1);

            double2x2 a2 = double2x2(-305.58477344437722, 148.67930967578627, 363.2849182390072, -115.5592263283018);
            double2x2 r2 = double2x2(-304.58477344437722, 149.67930967578627, 364.2849182390072, -114.5592263283018);
            TestUtils.AreEqual(++a2, r2);

            double2x2 a3 = double2x2(-326.87781992874937, 339.8765849265626, -38.410431164507941, -153.3736775635619);
            double2x2 r3 = double2x2(-325.87781992874937, 340.8765849265626, -37.410431164507941, -152.3736775635619);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_postfix_inc()
        {
            double2x2 a0 = double2x2(322.94356623429042, 472.05246542024076, 203.48761925636211, -49.854570650427888);
            double2x2 r0 = double2x2(322.94356623429042, 472.05246542024076, 203.48761925636211, -49.854570650427888);
            TestUtils.AreEqual(a0++, r0);

            double2x2 a1 = double2x2(-31.420532002775246, 271.45466840986842, 55.736877228942149, 153.75031645305);
            double2x2 r1 = double2x2(-31.420532002775246, 271.45466840986842, 55.736877228942149, 153.75031645305);
            TestUtils.AreEqual(a1++, r1);

            double2x2 a2 = double2x2(-174.17301925186672, 215.11022744658874, 159.86103184514729, -333.05045262586816);
            double2x2 r2 = double2x2(-174.17301925186672, 215.11022744658874, 159.86103184514729, -333.05045262586816);
            TestUtils.AreEqual(a2++, r2);

            double2x2 a3 = double2x2(241.46487509527469, -170.10464366250886, -270.65246380057766, -162.86024792625579);
            double2x2 r3 = double2x2(241.46487509527469, -170.10464366250886, -270.65246380057766, -162.86024792625579);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_prefix_dec()
        {
            double2x2 a0 = double2x2(-416.20121712992022, -96.637880131899351, -50.145671629414721, -207.31644759295341);
            double2x2 r0 = double2x2(-417.20121712992022, -97.637880131899351, -51.145671629414721, -208.31644759295341);
            TestUtils.AreEqual(--a0, r0);

            double2x2 a1 = double2x2(439.47906156977592, 337.96895734312432, 246.08898293510492, 171.96452935597142);
            double2x2 r1 = double2x2(438.47906156977592, 336.96895734312432, 245.08898293510492, 170.96452935597142);
            TestUtils.AreEqual(--a1, r1);

            double2x2 a2 = double2x2(-227.44280134301761, 326.50782338087811, 400.720900006928, -478.03137253133178);
            double2x2 r2 = double2x2(-228.44280134301761, 325.50782338087811, 399.720900006928, -479.03137253133178);
            TestUtils.AreEqual(--a2, r2);

            double2x2 a3 = double2x2(-326.45297852459038, 112.79684668071422, -341.97629300783217, -503.27416181158003);
            double2x2 r3 = double2x2(-327.45297852459038, 111.79684668071422, -342.97629300783217, -504.27416181158003);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public static void double2x2_operator_postfix_dec()
        {
            double2x2 a0 = double2x2(-376.59242719066907, 16.969734438215255, -0.25066399585949739, -202.32328734282555);
            double2x2 r0 = double2x2(-376.59242719066907, 16.969734438215255, -0.25066399585949739, -202.32328734282555);
            TestUtils.AreEqual(a0--, r0);

            double2x2 a1 = double2x2(409.55752940175944, -281.11170376516492, -262.062590959511, -182.40572866350681);
            double2x2 r1 = double2x2(409.55752940175944, -281.11170376516492, -262.062590959511, -182.40572866350681);
            TestUtils.AreEqual(a1--, r1);

            double2x2 a2 = double2x2(450.12809559801974, -332.15495768755443, -261.00890052551819, 205.46112570793423);
            double2x2 r2 = double2x2(450.12809559801974, -332.15495768755443, -261.00890052551819, 205.46112570793423);
            TestUtils.AreEqual(a2--, r2);

            double2x2 a3 = double2x2(-230.22777878038016, 378.64123433578811, 487.34482287212495, -192.17785772689518);
            double2x2 r3 = double2x2(-230.22777878038016, 378.64123433578811, 487.34482287212495, -192.17785772689518);
            TestUtils.AreEqual(a3--, r3);
        }


    }
}
