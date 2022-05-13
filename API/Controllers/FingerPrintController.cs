using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;
using BL;
using System.Web.Http;
using System.Web.Http.Cors;
using WinBioNET;
using WinBioNET.Enums;


namespace API.Controllers
{
    [EnableCors(methods: "*", origins: "*", headers: "*")]
    [RoutePrefix("api/fingerPrint")]
    public class fingerPrintController : ApiController
    {
        [Route("ifThereIsSensor")]
        [HttpGet]
        public static bool IfThereIsSensor()
        {
            try
            {
                var units = WinBio.EnumBiometricUnits(WinBioBiometricType.Fingerprint);
                Console.WriteLine("Found {0} units", units.Length);
                if (units.Length == 0) return false;
                var unit = units[0];
                var unitId = unit.UnitId;
                Console.WriteLine("Using unit id: {0}", unitId);
                Console.WriteLine("Device instance id: {0}", unit.DeviceInstanceId);
                // CreateDataBase(unitId);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}