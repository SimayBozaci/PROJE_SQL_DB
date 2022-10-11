using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Proje_SQL_DB
{
    partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: Hizmetinizi başlatmak için kodu buraya ekleyin.
        }

        protected override void OnStop()
        {
            // TODO: Hizmetinizi durdurmak için ihtiyaç olunan bir kapatmayı gerçekleştirmek için kodu buraya ekleyin.
        }
    }
}
