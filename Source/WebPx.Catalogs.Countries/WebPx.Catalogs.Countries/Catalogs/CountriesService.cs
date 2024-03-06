using System;
using System.Collections.Generic;
using System.Linq;
using WebPx.Catalogs.Resources;

namespace WebPx.Catalogs
{
    /// <summary>
    /// Class that provides a list of all countries in the world
    /// </summary>
    public class CountriesService : ICountries
    {
        /// <summary>
        /// Creates an empty instance of the <see cref="CountriesService"/>
        /// </summary>
        public CountriesService()
        {
            _countryList = new Lazy<List<Country>>(CreateList);
        }

        /// <summary>
        /// Static field that stores a lazy list of all countries
        /// </summary>
        private readonly Lazy<List<Country>> _countryList;

        /// <summary>
        /// Creates a static list of all countries
        /// </summary>
        /// <returns></returns>
        private List<Country> CreateList() => [..GetCountries()];

        /// <summary>
        /// Gets an enumerator of all countries in alphabetical order by their english names
        /// </summary>
        /// <returns>The new instance of an enumerator</returns>
        public IEnumerable<Country> GetCountries()
        {
            yield return new Country("{08909F75-8D5D-4EB8-B4CF-C7FDB3882943}", 4, Countries.AF, "AF", "AFG");
            yield return new Country("{d9e62a06-7cc0-48e5-ab99-c6beeba6b12f}", 248, Countries.AX, "AX", "ALA");
            yield return new Country("{8fe8d45a-45e9-42e8-a366-04e542300dbd}", 8, Countries.AL, "AL", "ALB");
            yield return new Country("{e710781b-82f5-4818-9eb1-07a12460d5f8}", 12, Countries.DZ, "DZ", "DZA");
            yield return new Country("{3349a4bd-2785-4919-8a15-255ed92ddc3c}", 16, Countries.AS, "AS", "ASM");
            yield return new Country("{9b621e70-b4ca-4d9f-9569-a10ec17c346e}", 20, Countries.AD, "AD", "AND");
            yield return new Country("{b5965ff1-6478-4630-8bdb-6eaaa17068b7}", 24, Countries.AO, "AO", "AGO");
            yield return new Country("{d058469b-d96c-4a54-9942-ce99f64ed4ae}", 660, Countries.AI, "AI", "AIA");
            yield return new Country("{f49d7b48-abc7-43e3-be43-5be1618293e4}", 10, Countries.AQ, "AQ", "ATA");
            yield return new Country("{3f842d40-2907-43be-88b7-b74582abcf86}", 28, Countries.AG, "AG", "ATG");
            yield return new Country("{b2e7b76f-5a22-4f53-880c-9d027b201c53}", 32, Countries.AR, "AR", "ARG");
            yield return new Country("{288ff902-fc9a-4094-9189-96c3a8ff89a3}", 51, Countries.AM, "AM", "ARM");
            yield return new Country("{106a82b2-4571-47b7-a009-95d30a804502}", 533, Countries.AW, "AW", "ABW");
            yield return new Country("{19c5b8fa-f137-44a4-9764-b993bbde4a63}", 36, Countries.AU, "AU", "AUS");
            yield return new Country("{68b87b86-9a6b-4eeb-9210-285f4c89d990}", 40, Countries.AT, "AT", "AUT");
            yield return new Country("{964ae8ea-fe72-4b4c-a651-be3a6adb76c1}", 31, Countries.AZ, "AZ", "AZE");
            yield return new Country("{71b01bb7-fea5-463f-9d43-c3b04dee17a6}", 44, Countries.BS, "BS", "BHS");
            yield return new Country("{ac4bbbb4-a160-46ff-b922-a847f3c2fc74}", 48, Countries.BH, "BH", "BHR");
            yield return new Country("{f6fb8cc9-6696-4955-8f7a-64abf7aaad72}", 50, Countries.BD, "BD", "BGD");
            yield return new Country("{33a41d1e-dffb-48f3-bc1f-7a227b140747}", 52, Countries.BB, "BB", "BRB");
            yield return new Country("{1b2f4cd1-0f22-4403-9ddb-8d6fce25b299}", 112, Countries.BY, "BY", "BLR");
            yield return new Country("{a2b382b1-db01-47ac-b61f-6eae3ec43bbb}", 56, Countries.BE, "BE", "BEL");
            yield return new Country("{faa48d30-b1e1-4a14-ad9e-92f99c2e8d76}", 84, Countries.BZ, "BZ", "BLZ");
            yield return new Country("{3488c3eb-82cc-459e-92b0-f3d6f20442f7}", 204, Countries.BJ, "BJ", "BEN");
            yield return new Country("{9e3524b2-b894-4acc-bfb6-602509446081}", 60, Countries.BM, "BM", "BMU");
            yield return new Country("{8a8a77a0-8e20-461e-b44d-f45adc630ad0}", 64, Countries.BT, "BT", "BTN");
            yield return new Country("{5c33f27e-a752-4bd3-968b-65e34e8e32ca}", 68, Countries.BO, "BO", "BOL");
            yield return new Country("{6bb9bd59-5932-4c7e-a7e5-260654ce60a1}", 535, Countries.BQ, "BQ", "BES");
            yield return new Country("{2632b5d5-9011-4d18-8c79-c18a73c32240}", 70, Countries.BA, "BA", "BIH");
            yield return new Country("{af82201b-8544-4d8c-ab56-acee12462ad2}", 72, Countries.BW, "BW", "BWA");
            yield return new Country("{a750ab28-f6dc-47cf-8572-5f436d69b891}", 74, Countries.BV, "BV", "BVT");
            yield return new Country("{f46915a9-c401-486f-9d50-8f68a076a6b0}", 76, Countries.BR, "BR", "BRA");
            yield return new Country("{6b94e40b-9252-4d9b-946c-e4b1a08d2988}", 86, Countries.IO, "IO", "IOT");
            yield return new Country("{c54a8afb-e92d-4e37-ad2c-4e9c46178b80}", 96, Countries.BN, "BN", "BRN");
            yield return new Country("{1742fe55-93e5-401e-b877-128e630da7f6}", 100, Countries.BG, "BG", "BGR");
            yield return new Country("{7a7e802e-ef3e-4be4-86f7-783f32c3ad91}", 854, Countries.BF, "BF", "BFA");
            yield return new Country("{46a3aed7-049d-4d6a-abd6-c68be5d25804}", 108, Countries.BI, "BI", "BDI");
            yield return new Country("{86ba0f1f-7d40-4137-a2cb-963df7d728c8}", 132, Countries.CV, "CV", "CPV");
            yield return new Country("{5e15a13e-3fcb-49ec-b451-11160ce75034}", 116, Countries.KH, "KH", "KHM");
            yield return new Country("{2cb18203-0107-4793-819f-c9fc227649c0}", 120, Countries.CM, "CM", "CMR");
            yield return new Country("{8cbd1597-768f-4466-a93a-007d19df11ed}", 124, Countries.CA, "CA", "CAN");
            yield return new Country("{7945dbc9-197f-4c7d-9da8-024dcc684a67}", 136, Countries.KY, "KY", "CYM");
            yield return new Country("{0a1e3fa2-0ccf-4ebd-99d3-b62d0cc2e20e}", 140, Countries.CF, "CF", "CAF");
            yield return new Country("{392b001c-87bc-435e-924a-24d73156c1ed}", 148, Countries.TD, "TD", "TCD");
            yield return new Country("{ff36ea99-a655-4869-9ce5-25102094e5fb}", 152, Countries.CL, "CL", "CHL");
            yield return new Country("{528f46e2-974f-4165-819a-c8901b58397a}", 156, Countries.CN, "CN", "CHN");
            yield return new Country("{dfce665d-fde1-4e2b-b145-31d933146142}", 162, Countries.CX, "CX", "CXR");
            yield return new Country("{8db92a35-5d2f-4e73-bc22-b31dc7525b75}", 166, Countries.CC, "CC", "CCK");
            yield return new Country("{b89bd750-005f-49db-8d9c-a2e8f111ee36}", 170, Countries.CO, "CO", "COL");
            yield return new Country("{2ee61a2b-4695-4702-947d-fd9f3d907442}", 174, Countries.KM, "KM", "COM");
            yield return new Country("{6a450498-4c10-4e9a-8809-21d3f2325cff}", 180, Countries.CD, "CD", "COD");
            yield return new Country("{cef06a8f-b24f-481a-9403-2ad3da3566dd}", 178, Countries.CG, "CG", "COG");
            yield return new Country("{0387ab8c-d4af-4745-b0e6-8685bbc58d47}", 184, Countries.CK, "CK", "COK");
            yield return new Country("{14d49dec-2944-40c4-8fe5-07b6135104d9}", 188, Countries.CR, "CR", "CRI");
            yield return new Country("{6623e686-7f11-4dda-b04a-63eeba1ce09c}", 191, Countries.HR, "HR", "HRV");
            yield return new Country("{b12ae910-a03a-4b93-8dfd-de75cea30525}", 192, Countries.CU, "CU", "CUB");
            yield return new Country("{495bfc11-4ed1-4293-b95c-6b02714fa41b}", 531, Countries.CW, "CW", "CUW");
            yield return new Country("{390a9495-1d13-4e6b-b6c2-2bbb1af7d483}", 196, Countries.CY, "CY", "CYP");
            yield return new Country("{f06f07dc-c818-4ee6-85b3-6f70c102945e}", 203, Countries.CZ, "CZ", "CZE");
            yield return new Country("{a6938698-14e3-42c8-a71e-e295b51d9952}", 384, Countries.CI, "CI", "CIV");
            yield return new Country("{628368fc-c8b2-4e87-bfa0-aa5acef09725}", 208, Countries.DK, "DK", "DNK");
            yield return new Country("{3856a5fb-2171-4887-b678-b6a80b9d40fc}", 262, Countries.DJ, "DJ", "DJI");
            yield return new Country("{8f794c3a-4324-41f4-aba0-d8512a4ecb56}", 212, Countries.DM, "DM", "DMA");
            yield return new Country("{bc3c5cba-2fc3-45e9-a098-2cf80b4addc0}", 214, Countries.DO, "DO", "DOM");
            yield return new Country("{826200b9-27b5-4d45-b8c3-084ed1daed5e}", 218, Countries.EC, "EC", "ECU");
            yield return new Country("{73b6c456-8e58-4eac-bdb8-b2ca41cdb8a4}", 818, Countries.EG, "EG", "EGY");
            yield return new Country("{cc05ddd3-f4d2-4476-8752-5fb47588156a}", 222, Countries.SV, "SV", "SLV");
            yield return new Country("{21dd883e-9649-487d-a341-bd2065b85f3e}", 226, Countries.GQ, "GQ", "GNQ");
            yield return new Country("{ebd37dc8-351c-4a9f-af40-66805032d0c8}", 232, Countries.ER, "ER", "ERI");
            yield return new Country("{f25df550-db5e-4323-9612-0e9a39cb237a}", 233, Countries.EE, "EE", "EST");
            yield return new Country("{95a7bbe0-998d-4f14-a293-b8630733deb0}", 748, Countries.SZ, "SZ", "SWZ");
            yield return new Country("{82028951-9fa9-42a1-97d5-f0777bd0e090}", 231, Countries.ET, "ET", "ETH");
            yield return new Country("{0d82d7b6-c10c-4109-b893-3e739911b1a0}", 238, Countries.FK, "FK", "FLK");
            yield return new Country("{c87abb8d-7999-42f9-ab57-6007053a302e}", 234, Countries.FO, "FO", "FRO");
            yield return new Country("{2c7860b4-b014-4813-a8cf-4784cb00fd21}", 242, Countries.FJ, "FJ", "FJI");
            yield return new Country("{48c22298-d8e5-4224-b242-23e1c3e365ff}", 246, Countries.FI, "FI", "FIN");
            yield return new Country("{f1ac81ef-e362-4f3f-9852-d2abc9cb04e5}", 250, Countries.FR, "FR", "FRA");
            yield return new Country("{c54f8c5f-1608-4f89-8fe2-97204356c618}", 254, Countries.GF, "GF", "GUF");
            yield return new Country("{2c644e29-a392-4ff2-b418-2a0db51c5516}", 258, Countries.PF, "PF", "PYF");
            yield return new Country("{901fe4ac-90d2-44a0-ab14-4b6bfbd19513}", 260, Countries.TF, "TF", "ATF");
            yield return new Country("{869fd447-ad33-4f96-8f97-2f4a64efb7c0}", 266, Countries.GA, "GA", "GAB");
            yield return new Country("{6e7f72dd-b7a1-4498-a494-54b92ace2742}", 270, Countries.GM, "GM", "GMB");
            yield return new Country("{bacbc959-a921-420b-8842-681465a9c4f6}", 268, Countries.GE, "GE", "GEO");
            yield return new Country("{957865f8-7a44-446d-9313-eb9a5d44b87a}", 276, Countries.DE, "DE", "DEU");
            yield return new Country("{73dfd3ab-d10a-4c93-bd54-f1f617821957}", 288, Countries.GH, "GH", "GHA");
            yield return new Country("{36ab644f-c365-4ad8-a236-21514dbf5de0}", 292, Countries.GI, "GI", "GIB");
            yield return new Country("{44f0e60e-8def-44a2-a63a-03d4d9ad1d4c}", 300, Countries.GR, "GR", "GRC");
            yield return new Country("{36e087b1-966b-4ab4-b06d-34951de8f96b}", 304, Countries.GL, "GL", "GRL");
            yield return new Country("{b2035214-3e68-43c4-ba6d-c6e8649c1500}", 308, Countries.GD, "GD", "GRD");
            yield return new Country("{5ed3dfba-e8cc-498a-b66a-858f8b8c61f8}", 312, Countries.GP, "GP", "GLP");
            yield return new Country("{0b25b22f-9bc5-4f5d-8294-800eb2bb44c2}", 316, Countries.GU, "GU", "GUM");
            yield return new Country("{2c4c6951-88d6-46e2-8c65-e95fe542f0f9}", 320, Countries.GT, "GT", "GTM");
            yield return new Country("{f5f2dbb8-46f3-4ac9-a818-3d99fc9e9bf6}", 831, Countries.GG, "GG", "GGY");
            yield return new Country("{21ba24a3-6c84-4b5e-9465-d61997e8494f}", 324, Countries.GN, "GN", "GIN");
            yield return new Country("{15b893ac-edab-4db0-b0e8-888ad3656902}", 624, Countries.GW, "GW", "GNB");
            yield return new Country("{5da62cfd-b5ca-427d-a2ef-be43329010c9}", 328, Countries.GY, "GY", "GUY");
            yield return new Country("{8f083a5e-fbde-4ecd-a46c-99d753a135d3}", 332, Countries.HT, "HT", "HTI");
            yield return new Country("{7d808086-516c-495c-a67b-ab845befb658}", 334, Countries.HM, "HM", "HMD");
            yield return new Country("{c034dc28-4f51-4e5e-9a43-dbbb6845b903}", 336, Countries.VA, "VA", "VAT");
            yield return new Country("{20879b0e-5db5-479d-b699-e4011ba89ca4}", 340, Countries.HN, "HN", "HND");
            yield return new Country("{4359f920-46ea-4713-94a7-9a597a30c6a8}", 344, Countries.HK, "HK", "HKG");
            yield return new Country("{2bd27ae2-cd1a-4b4b-91d4-74e89fb8fc74}", 348, Countries.HU, "HU", "HUN");
            yield return new Country("{5068715f-5dfc-4fbb-8490-1c10488bc086}", 352, Countries.IS, "IS", "ISL");
            yield return new Country("{99c1778a-4c29-426f-a538-b2c3b506aa3a}", 356, Countries.IN, "IN", "IND");
            yield return new Country("{24afb201-4cab-47e0-a5da-2c3d40d3eaa0}", 360, Countries.ID, "ID", "IDN");
            yield return new Country("{996234c5-dccb-4efe-9a51-a8df86435133}", 364, Countries.IR, "IR", "IRN");
            yield return new Country("{db44da36-07ff-4631-9e3a-81b07b989889}", 368, Countries.IQ, "IQ", "IRQ");
            yield return new Country("{1677b33a-da03-47fa-a373-1879774c8bd9}", 372, Countries.IE, "IE", "IRL");
            yield return new Country("{5fb9af2b-6311-4c19-81fe-b3892d7e6f6f}", 833, Countries.IM, "IM", "IMN");
            yield return new Country("{52ad7d96-b26b-4b9a-8412-9430d628c930}", 376, Countries.IL, "IL", "ISR");
            yield return new Country("{7e76cea0-e75f-470f-959e-71433ef4f0dd}", 380, Countries.IT, "IT", "ITA");
            yield return new Country("{debbb6c1-485d-4344-98a8-3fa6bd413d33}", 388, Countries.JM, "JM", "JAM");
            yield return new Country("{bdc3492b-7180-43c4-8fb9-5f47c12450f9}", 392, Countries.JP, "JP", "JPN");
            yield return new Country("{a34d8357-e15c-492e-981c-a4fcb1d8540a}", 832, Countries.JE, "JE", "JEY");
            yield return new Country("{e34584cd-26ce-4650-a704-37de218e0c0d}", 400, Countries.JO, "JO", "JOR");
            yield return new Country("{d819b5bf-d703-4b41-9cbe-5b6214456727}", 398, Countries.KZ, "KZ", "KAZ");
            yield return new Country("{c79bd5a2-aa55-4551-910f-d4ac1f26d8b0}", 404, Countries.KE, "KE", "KEN");
            yield return new Country("{7ff7b31e-768f-4971-831d-1e5481580874}", 296, Countries.KI, "KI", "KIR");
            yield return new Country("{7147a099-835a-4246-ba63-c49597838820}", 408, Countries.KP, "KP", "PRK");
            yield return new Country("{652abecf-1479-481f-b428-0c0121dd59b9}", 410, Countries.KR, "KR", "KOR");
            yield return new Country("{f4d3beeb-ca39-4129-9d65-9e99e9e9df89}", 414, Countries.KW, "KW", "KWT");
            yield return new Country("{fb7a1aec-7961-4598-9e90-f3a32ec85171}", 417, Countries.KG, "KG", "KGZ");
            yield return new Country("{39457fa9-338f-4ecb-9ef7-ef93ea68edf3}", 418, Countries.LA, "LA", "LAO");
            yield return new Country("{42642b89-91aa-4d46-9b15-ac7b5e439c38}", 428, Countries.LV, "LV", "LVA");
            yield return new Country("{66e0ba7f-2a42-4467-a62e-2a923c8f9c4e}", 422, Countries.LB, "LB", "LBN");
            yield return new Country("{3250265b-e75a-452d-91a7-ebfba7c58c43}", 426, Countries.LS, "LS", "LSO");
            yield return new Country("{c50a0f32-9b4d-4624-8b02-60638a853251}", 430, Countries.LR, "LR", "LBR");
            yield return new Country("{8c639c51-7707-4ae9-bcde-c4b491137c36}", 434, Countries.LY, "LY", "LBY");
            yield return new Country("{b17f24c5-f963-4bef-a59f-6cd2a1f1c402}", 438, Countries.LI, "LI", "LIE");
            yield return new Country("{18698eb9-85d1-4856-9cc4-f131b2bcc3d0}", 440, Countries.LT, "LT", "LTU");
            yield return new Country("{f5338782-9542-43aa-a428-1f26750939c0}", 442, Countries.LU, "LU", "LUX");
            yield return new Country("{d71330be-a5bc-4b48-a164-91bfca27d939}", 446, Countries.MO, "MO", "MAC");
            yield return new Country("{329f3bd2-8c7d-4e57-ad6f-02476b6a3e1b}", 450, Countries.MG, "MG", "MDG");
            yield return new Country("{c6d0ebdc-edc5-447f-b732-79edab7ff483}", 454, Countries.MW, "MW", "MWI");
            yield return new Country("{a9f160c8-3d6b-4aa2-b2df-e3ad80ca6e81}", 458, Countries.MY, "MY", "MYS");
            yield return new Country("{dd04aba3-0b25-4717-876d-5a179804678a}", 462, Countries.MV, "MV", "MDV");
            yield return new Country("{f9a12648-5eaa-4116-adb5-0366a16e537e}", 466, Countries.ML, "ML", "MLI");
            yield return new Country("{58c5d71a-f6ae-42fa-aaf7-17ce6cc19855}", 470, Countries.MT, "MT", "MLT");
            yield return new Country("{47729621-e1fa-4441-9ba0-5b7e29bc497f}", 584, Countries.MH, "MH", "MHL");
            yield return new Country("{9e22b5fa-00f2-4780-bb7a-adaa71f31cbb}", 474, Countries.MQ, "MQ", "MTQ");
            yield return new Country("{a41f5c10-d37d-44c6-918c-cc6d8b83b626}", 478, Countries.MR, "MR", "MRT");
            yield return new Country("{116face4-7a5d-40c1-96af-6d5f7e7b67ee}", 480, Countries.MU, "MU", "MUS");
            yield return new Country("{78585116-51f4-404c-8491-520a742d3d00}", 175, Countries.YT, "YT", "MYT");
            yield return new Country("{4eec2cef-ef6a-43c8-a9a0-2ba9bcaf429a}", 484, Countries.MX, "MX", "MEX");
            yield return new Country("{396f82a6-50da-4665-a5c9-e26258dda4f7}", 583, Countries.FM, "FM", "FSM");
            yield return new Country("{4c9648ef-d6be-4e31-98d5-3892b3b6973c}", 498, Countries.MD, "MD", "MDA");
            yield return new Country("{990b62ed-415f-49ad-88d4-7c5ebbc5a565}", 492, Countries.MC, "MC", "MCO");
            yield return new Country("{38369e91-d22b-4d64-b90a-f68216e26071}", 496, Countries.MN, "MN", "MNG");
            yield return new Country("{25d88d94-6a10-41c5-85bb-1d32fecad64f}", 499, Countries.ME, "ME", "MNE");
            yield return new Country("{3bbdd0b4-abf6-48aa-bcda-629dbaa7f907}", 500, Countries.MS, "MS", "MSR");
            yield return new Country("{77f0d115-c8a2-410c-ac4c-a438a2d4058b}", 504, Countries.MA, "MA", "MAR");
            yield return new Country("{a4fbffbb-688b-464f-a684-f60dee81cc80}", 508, Countries.MZ, "MZ", "MOZ");
            yield return new Country("{6357053a-4f13-4516-9973-01ff1009d560}", 104, Countries.MM, "MM", "MMR");
            yield return new Country("{d248b7c4-de52-404c-a0c3-c2f999aeb1af}", 516, Countries.NA, "NA", "NAM");
            yield return new Country("{6b9313c3-1d35-4620-96b2-007f92507602}", 520, Countries.NR, "NR", "NRU");
            yield return new Country("{41ff0112-f071-4b94-b394-a4c00ce0c329}", 524, Countries.NP, "NP", "NPL");
            yield return new Country("{767b2a55-2949-4476-93de-8b2857b37be8}", 528, Countries.NL, "NL", "NLD");
            yield return new Country("{5eaf42a4-2ce2-4181-bda2-4e59f74be638}", 540, Countries.NC, "NC", "NCL");
            yield return new Country("{3d7119a8-6e37-46e2-b40f-f110f8fcaff7}", 554, Countries.NZ, "NZ", "NZL");
            yield return new Country("{7475a57b-47df-4752-9e20-e6dfee6dc70d}", 558, Countries.NI, "NI", "NIC");
            yield return new Country("{174473d4-a910-4228-84b3-e06546284f52}", 562, Countries.NE, "NE", "NER");
            yield return new Country("{2228b1fd-3519-4fbd-a201-24777549fbd6}", 566, Countries.NG, "NG", "NGA");
            yield return new Country("{5512300f-50a9-4ea4-a288-11b050402d4b}", 570, Countries.NU, "NU", "NIU");
            yield return new Country("{98fdcef4-c598-4df8-ab98-d2ec1a14a607}", 574, Countries.NF, "NF", "NFK");
            yield return new Country("{47c34273-03b6-43ad-af06-e58eca9b767f}", 580, Countries.MP, "MP", "MNP");
            yield return new Country("{58c14587-7cf9-4884-87d5-e73bb7b64e6b}", 578, Countries.NO, "NO", "NOR");
            yield return new Country("{c6e74f3a-a97a-4776-b0f0-e76aef84a248}", 512, Countries.OM, "OM", "OMN");
            yield return new Country("{b7804a60-1e31-46b9-b669-b2ef63956d89}", 586, Countries.PK, "PK", "PAK");
            yield return new Country("{616b1f7b-c4f1-4e5e-a3db-1744e11c7ee7}", 585, Countries.PW, "PW", "PLW");
            yield return new Country("{719dce87-9468-4ce0-b8fe-110a29f4b792}", 275, Countries.PS, "PS", "PSE");
            yield return new Country("{7c221c9b-a14e-4983-ad0d-7ebfe0e8e5f2}", 591, Countries.PA, "PA", "PAN");
            yield return new Country("{0f35e858-8f55-4335-a471-366d2666ae7d}", 598, Countries.PG, "PG", "PNG");
            yield return new Country("{bbf42704-e04b-4edf-a62e-d8f5937e8465}", 600, Countries.PY, "PY", "PRY");
            yield return new Country("{1f3f2365-a6f6-43b3-be45-f9d2f25f16be}", 604, Countries.PE, "PE", "PER");
            yield return new Country("{dd54d4e1-1f69-4302-9e5a-b9d4f6bf054b}", 608, Countries.PH, "PH", "PHL");
            yield return new Country("{d6ba467f-75b6-402c-b711-aa3f2484e8ea}", 612, Countries.PN, "PN", "PCN");
            yield return new Country("{788e8280-b4ce-4429-80ab-fda90dae89e1}", 616, Countries.PL, "PL", "POL");
            yield return new Country("{9fff390d-5596-4060-9867-370d1b337d3a}", 620, Countries.PT, "PT", "PRT");
            yield return new Country("{68438b9e-b005-4211-bb47-bd078ee3801f}", 630, Countries.PR, "PR", "PRI");
            yield return new Country("{f756ff97-2387-41f8-b694-46f50558865c}", 634, Countries.QA, "QA", "QAT");
            yield return new Country("{48ea6731-fd8b-4122-8a51-21fcafad85ca}", 807, Countries.MK, "MK", "MKD");
            yield return new Country("{a7c5cd74-1304-490c-8f2e-efae71a335e5}", 642, Countries.RO, "RO", "ROU");
            yield return new Country("{f9523023-0c98-45a1-b08a-0885359f56d5}", 643, Countries.RU, "RU", "RUS");
            yield return new Country("{001dec33-b5ba-4b68-978f-909cad8df608}", 646, Countries.RW, "RW", "RWA");
            yield return new Country("{c5a6aefe-9be5-4759-97e1-ad54f04446ea}", 638, Countries.RE, "RE", "REU");
            yield return new Country("{b3a7a5c7-4604-4061-b82f-d24e545f152d}", 652, Countries.BL, "BL", "BLM");
            yield return new Country("{64632d08-1741-47e4-8c1c-43a142310913}", 654, Countries.SH, "SH", "SHN");
            yield return new Country("{8c5ad0ce-44ef-4c3d-b46e-5df9e4f22dcf}", 659, Countries.KN, "KN", "KNA");
            yield return new Country("{8c0965e6-1114-465d-9dff-b11965ca4a14}", 662, Countries.LC, "LC", "LCA");
            yield return new Country("{24d1ee00-6fea-424c-8857-7ae6f5b00b7c}", 663, Countries.MF, "MF", "MAF");
            yield return new Country("{4ccf9258-130d-4a24-9d6f-7d3f74943ee6}", 666, Countries.PM, "PM", "SPM");
            yield return new Country("{9297c685-09d2-4272-a002-01726e8a0e4e}", 670, Countries.VC, "VC", "VCT");
            yield return new Country("{feade41d-6462-47ae-b09a-efa9e84175ed}", 882, Countries.WS, "WS", "WSM");
            yield return new Country("{2fa3ca63-a1d8-4270-81a4-645692b238f6}", 674, Countries.SM, "SM", "SMR");
            yield return new Country("{2113bd71-543c-4e33-95cc-2df92b03539c}", 678, Countries.ST, "ST", "STP");
            yield return new Country("{9cd15a05-4cbd-4fb8-8329-bf6a711291b0}", 682, Countries.SA, "SA", "SAU");
            yield return new Country("{482e737b-805b-463d-a7e6-40675873e9b7}", 686, Countries.SN, "SN", "SEN");
            yield return new Country("{b3b097e2-3036-4ba0-a6b0-68bccfa10da7}", 688, Countries.RS, "RS", "SRB");
            yield return new Country("{cce1d730-7eb9-49b8-9a52-41785b631acd}", 690, Countries.SC, "SC", "SYC");
            yield return new Country("{f013c9a1-fae7-4eb1-a644-a5c400b1942d}", 694, Countries.SL, "SL", "SLE");
            yield return new Country("{6e2249d3-ec5e-4fa0-a931-391d0d23da41}", 702, Countries.SG, "SG", "SGP");
            yield return new Country("{368cf2a0-31ff-466f-8bb9-a39df57b14f3}", 534, Countries.SX, "SX", "SXM");
            yield return new Country("{841f03b4-0dca-4d5e-bee0-14db05b136c4}", 703, Countries.SK, "SK", "SVK");
            yield return new Country("{6c53a500-f15e-4ba0-be51-22a2de06702d}", 705, Countries.SI, "SI", "SVN");
            yield return new Country("{b927b9c3-0a1f-4eb2-a6cf-3c31d94dcb63}", 90, Countries.SB, "SB", "SLB");
            yield return new Country("{1be980f7-bff7-414b-b7db-5c6a128f7067}", 706, Countries.SO, "SO", "SOM");
            yield return new Country("{347b5dca-96b3-4636-b238-ee25d9242f45}", 710, Countries.ZA, "ZA", "ZAF");
            yield return new Country("{963280a0-ccde-42b0-b13d-bffc75598427}", 239, Countries.GS, "GS", "SGS");
            yield return new Country("{95776e7d-5e80-46fa-88b4-f23acde0be32}", 728, Countries.SS, "SS", "SSD");
            yield return new Country("{657c3638-e328-43f3-9fa1-591f92cc8528}", 724, Countries.ES, "ES", "ESP");
            yield return new Country("{ea9e06ba-4f16-49f4-a08b-12b90d92ac09}", 144, Countries.LK, "LK", "LKA");
            yield return new Country("{dc4c8e51-9f61-4fa1-a10f-d1d360748267}", 729, Countries.SD, "SD", "SDN");
            yield return new Country("{7e3468a3-0179-431a-b42d-a9e4849285b4}", 740, Countries.SR, "SR", "SUR");
            yield return new Country("{2bb7c6cb-c4fc-4f24-a776-60c83c2337c7}", 744, Countries.SJ, "SJ", "SJM");
            yield return new Country("{054e810e-feb3-43ff-b878-ce2bcbca5f51}", 752, Countries.SE, "SE", "SWE");
            yield return new Country("{bd853bdd-0b32-4b90-88c4-484e3efff02d}", 756, Countries.CH, "CH", "CHE");
            yield return new Country("{228b15ed-d3cd-44b6-8906-30ba5cf9b43c}", 760, Countries.SY, "SY", "SYR");
            yield return new Country("{e79865ec-0bc2-4c23-812b-380e333b05e5}", 158, Countries.TW, "TW", "TWN");
            yield return new Country("{29ec50dd-0747-45a7-89a1-3f9dd2aadcdb}", 762, Countries.TJ, "TJ", "TJK");
            yield return new Country("{dd5cc94e-337c-4576-b6f7-e262c7bdc4c1}", 834, Countries.TZ, "TZ", "TZA");
            yield return new Country("{7ba491de-9afd-4dfd-a8a7-7a7479423048}", 764, Countries.TH, "TH", "THA");
            yield return new Country("{b7b9b71d-fd1c-420f-8856-a4be34fcd783}", 626, Countries.TL, "TL", "TLS");
            yield return new Country("{a61888cd-d318-4013-bbc4-2057baeda9b2}", 768, Countries.TG, "TG", "TGO");
            yield return new Country("{fa18fbfe-a3a2-490f-8215-350575bdafcd}", 772, Countries.TK, "TK", "TKL");
            yield return new Country("{ce84f5c7-fbcc-4acc-9875-a63b4ca78068}", 776, Countries.TO, "TO", "TON");
            yield return new Country("{b133a6ec-0eb9-4130-b106-223cc3d33cda}", 780, Countries.TT, "TT", "TTO");
            yield return new Country("{f19afabf-4365-4826-b104-633362cdb67f}", 788, Countries.TN, "TN", "TUN");
            yield return new Country("{398af0a1-baa9-4bdf-987f-7814c97a3df5}", 792, Countries.TR, "TR", "TUR");
            yield return new Country("{fc5260a4-4463-4c9c-8dd4-89900920f918}", 795, Countries.TM, "TM", "TKM");
            yield return new Country("{03d8ee52-38a4-48a7-9185-53d541453e54}", 796, Countries.TC, "TC", "TCA");
            yield return new Country("{7cd08ad8-3e35-4135-be60-853d4a8c936f}", 798, Countries.TV, "TV", "TUV");
            yield return new Country("{57d5f564-a6e0-45d6-8e82-0af9ff7cc604}", 800, Countries.UG, "UG", "UGA");
            yield return new Country("{49850f05-3c32-42e4-b9d3-63245a44ae5b}", 804, Countries.UA, "UA", "UKR");
            yield return new Country("{377bf591-1743-480b-b97e-998bf1e9036e}", 784, Countries.AE, "AE", "ARE");
            yield return new Country("{a65f3c51-70b1-4909-9eac-9aa7eae11330}", 826, Countries.GB, "GB", "GBR");
            yield return new Country("{755f7cfd-953e-422a-be7e-7c532c7cb1f0}", 581, Countries.UM, "UM", "UMI");
            yield return new Country("{be1bd82b-6566-4c67-9628-dcdb36663471}", 840, Countries.US, "US", "USA");
            yield return new Country("{6b300a4e-d521-47e6-b041-2b805d18959d}", 858, Countries.UY, "UY", "URY");
            yield return new Country("{56cf4e36-4b4c-412a-839f-54a7c4072751}", 860, Countries.UZ, "UZ", "UZB");
            yield return new Country("{cc15f5d6-7beb-4086-a33d-99edbe1e6668}", 548, Countries.VU, "VU", "VUT");
            yield return new Country("{6b5ed593-5943-4ce6-a8a0-5abc2fccf1b9}", 862, Countries.VE, "VE", "VEN");
            yield return new Country("{d54bb6f0-8d9b-4b00-999a-68695e3dbb3a}", 704, Countries.VN, "VN", "VNM");
            yield return new Country("{b676451c-7722-48fb-b3f7-8d9a1a3f825d}", 92, Countries.VG, "VG", "VGB");
            yield return new Country("{098ab0f0-fd45-453c-a6a9-ddbe581009c4}", 850, Countries.VI, "VI", "VIR");
            yield return new Country("{5fe8f20d-c0c7-44af-8951-c581888dcd51}", 876, Countries.WF, "WF", "WLF");
            yield return new Country("{c5e70ef5-69b0-4701-9a4b-b0af7706c067}", 732, Countries.EH, "EH", "ESH");
            yield return new Country("{c6cf6e91-43db-4720-9cc7-d0d6efca5513}", 887, Countries.YE, "YE", "YEM");
            yield return new Country("{2caf69c7-72bd-49be-a8fc-ace88b8accbf}", 894, Countries.ZM, "ZM", "ZMB");
            yield return new Country("{b55002b4-aa9a-4a53-ba4e-264165a76052}", 716, Countries.ZW, "ZW", "ZWE");
        }

        /// <summary>
        /// Gets an instance of a unique list of all countries in the world
        /// </summary>
        /// <returns>The instance of the list of countries</returns>
        public List<Country> GetList() => _countryList.Value;

        public Country? GetCountry(int code) => GetList().FirstOrDefault(x => x.Code == code);

        public Country? GetCountryByCodeA2(string alphaCode2) => GetList().FirstOrDefault(x => x.CodeA2 == alphaCode2);

        public Country? GetCountryByCodeA3(string alphaCode3) => GetList().FirstOrDefault(x => x.CodeA3 == alphaCode3);
    }
}