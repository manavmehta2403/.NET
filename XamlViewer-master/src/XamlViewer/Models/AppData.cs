﻿using System;
using System.Threading.Tasks;

namespace XamlViewer.Models
{
    public class AppData
    {
        public XamlConfig Config { get; set; }
        public Func<Task> DealExistedFileAction { get; set; }

        public string Version { get; set; }
    }
}
