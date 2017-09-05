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
    ///The M1 recording.
    /// </summary>
    [TestModule("a88d433b-b2a1-4632-9e24-3a68467ac6e4", ModuleType.Recording, 1)]
    public partial class M1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the w3schools_Oktratas1Repository repository.
        /// </summary>
        public static w3schools_Oktratas1Repository repo = w3schools_Oktratas1Repository.Instance;

        static M1 instance = new M1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public M1()
        {
            varA = "00000";
            varInput = "Proba2";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static M1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _varA;

        /// <summary>
        /// Gets or sets the value of variable varA.
        /// </summary>
        [TestVariable("135e70b4-8fee-4fb0-bfac-ebcdc2a6eabd")]
        public string varA
        {
            get { return _varA; }
            set { _varA = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable varInput.
        /// </summary>
        [TestVariable("a2a6464f-8ea4-4f0c-bf9e-d075ac1afb11")]
        public string varInput
        {
            get { return repo.varInput; }
            set { repo.varInput = value; }
        }

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'W3SchoolsOnlineWebTutorials.TryItYourself' at 94;20.", repo.W3SchoolsOnlineWebTutorials.TryItYourselfInfo, new RecordItemIndex(0));
            repo.W3SchoolsOnlineWebTutorials.TryItYourself.Click("94;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'W3SchoolsOnlineWebTutorials.ThisIsAHeading' at 170;8.", repo.W3SchoolsOnlineWebTutorials.ThisIsAHeadingInfo, new RecordItemIndex(1));
            repo.W3SchoolsOnlineWebTutorials.ThisIsAHeading.Click("170;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back 9}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Delete}'.", new RecordItemIndex(2));
            Keyboard.Press("{Back 9}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varInput'.", new RecordItemIndex(3));
            Keyboard.Press(varInput);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'W3SchoolsOnlineWebTutorials.Run' at 59;30.", repo.W3SchoolsOnlineWebTutorials.RunInfo, new RecordItemIndex(4));
            repo.W3SchoolsOnlineWebTutorials.Run.Click("59;30");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$varInput) on item 'W3SchoolsOnlineWebTutorials.Proba'.", repo.W3SchoolsOnlineWebTutorials.ProbaInfo, new RecordItemIndex(5));
            Validate.Attribute(repo.W3SchoolsOnlineWebTutorials.ProbaInfo, "InnerText", varInput);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
