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
            Artillery art = new Artillery();
            Block blks = dg.grid[5, 5];
            art.Build("Art1");
            blks.building = art;
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
