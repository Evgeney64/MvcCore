﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using System.Text.Json;
using System.Text.Json.Serialization;

using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.Routing;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.Configuration;

using Server.Core.Public;
using Server.Core.Model;

namespace Server.Core
{
    public partial class VmBase
    {
        #region Define
        public VmBase()
        { }
        public VmBase(string _connectionString)
        {
            connectionString = _connectionString;
        }
        private string connectionString;
        public string ConnectionString { get { return connectionString; } }
        public string HtmlString { get; set; }
        public HtmlHelper Html { get; set; }
        private EntityServ serv { get; }
        #endregion
    }

    public partial class scr_user1
    {
        public int user_id { get; set; }
        public string user_name { get; set; }

    }
}
