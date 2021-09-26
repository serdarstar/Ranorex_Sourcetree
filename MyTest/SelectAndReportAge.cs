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

namespace MyTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SelectAndReportAge recording.
    /// </summary>
    [TestModule("2b9a90ce-e221-4acc-9926-76e863e32846", ModuleType.Recording, 1)]
    public partial class SelectAndReportAge : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTestRepository repository.
        /// </summary>
        public static MyTestRepository repo = MyTestRepository.Instance;

        static SelectAndReportAge instance = new SelectAndReportAge();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectAndReportAge()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectAndReportAge Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varFirstName.
        /// </summary>
        [TestVariable("f37b3c18-340b-4fcb-9c9e-966562322cfb")]
        public string varFirstName
        {
            get { return repo.varFirstName; }
            set { repo.varFirstName = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.CellOfThomasBach' at 32;7.", repo.RxMainFrame.CellOfThomasBachInfo, new RecordItemIndex(0));
            repo.RxMainFrame.CellOfThomasBach.Click("32;7");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}