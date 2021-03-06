﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace w3schools_Oktratas1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The GoToHTML recording.
    /// </summary>
    [TestModule("a4ac1d5a-984f-478b-9982-4c641c98a80c", ModuleType.Recording, 1)]
    public partial class GoToHTML : ITestModule
    {
        /// <summary>
        /// Holds an instance of the w3schools_Oktratas1Repository repository.
        /// </summary>
        public static w3schools_Oktratas1Repository repo = w3schools_Oktratas1Repository.Instance;

        static GoToHTML instance = new GoToHTML();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GoToHTML()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static GoToHTML Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://www.w3schools.com' with browser 'chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://www.w3schools.com", "chrome", "", false, false, false, true, false);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='w3schools') on item 'W3SchoolsOnlineWebTutorials.W3schools'.", repo.W3SchoolsOnlineWebTutorials.W3schoolsInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.W3SchoolsOnlineWebTutorials.W3schoolsInfo, "InnerText", "w3schools");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'W3SchoolsOnlineWebTutorials.LearnHTML' at 102;11.", repo.W3SchoolsOnlineWebTutorials.LearnHTMLInfo, new RecordItemIndex(2));
            repo.W3SchoolsOnlineWebTutorials.LearnHTML.Click("102;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='HTML5') on item 'W3SchoolsOnlineWebTutorials.HTML5'.", repo.W3SchoolsOnlineWebTutorials.HTML5Info, new RecordItemIndex(3));
            Validate.Attribute(repo.W3SchoolsOnlineWebTutorials.HTML5Info, "InnerText", "HTML5");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
