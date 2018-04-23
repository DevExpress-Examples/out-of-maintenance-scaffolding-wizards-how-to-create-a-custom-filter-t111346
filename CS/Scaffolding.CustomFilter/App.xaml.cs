using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Core;
using System.Data.Entity;
using Scaffolding.CustomFilter.Model;
using DevExpress.Internal;

namespace Scaffolding.CustomFilter {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            ApplicationThemeHelper.UpdateApplicationThemeName();
            DbEngineDetector.PatchConnectionStringsAndConfigureEntityFrameworkDefaultConnectionFactory();
            Database.SetInitializer<IssueContext>(new IssueContextInitializer());
        }
        protected override void OnExit(ExitEventArgs e) {
            ApplicationThemeHelper.SaveApplicationThemeName();
        }
    }
}
