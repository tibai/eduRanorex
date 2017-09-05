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
    ///The M2 recording.
    /// </summary>
    [TestModule("5dc02fb2-22b0-45ff-a082-2532a8551033", ModuleType.Recording, 1)]
    public partial class M2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the w3schools_Oktratas1Repository repository.
        /// </summary>
        public static w3schools_Oktratas1Repository repo = w3schools_Oktratas1Repository.Instance;

        static M2 instance = new M2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public M2()
        {
            varB = "11111";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static M2 Instance
        {
            get { return instance; }
        }

#region Variables

        string _varB;

        /// <summary>
        /// Gets or sets the value of variable varB.
        /// </summary>
        [TestVariable("fc3b77b6-a2ff-492d-9ea3-d5b81d44a495")]
        public string varB
        {
            get { return _varB; }
            set { _varB = value; }
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

        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
