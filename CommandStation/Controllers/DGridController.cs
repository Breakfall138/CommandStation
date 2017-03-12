using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CommandStation.Controllers
{
    public class DGridController : ApiController
    {

        public DefenseGrid GET()
        {
            DefenseGrid dg = new GridFactory().Create("Defense",15, 15) as DefenseGrid;
            BuildingFactory art = new BuildingFactory();
            Block blks = dg.grid[5, 5];
            blks.building = art.Create("Artillery","Art1");
            blks.state = State.Healthy;
            return dg;
        }

        //public Artillery Get()
        //{
        //    Artillery art = new Artillery();
        //    return art;
        //}
    }
}
