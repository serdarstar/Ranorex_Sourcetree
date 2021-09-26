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
    ///The Recording11 recording.
    /// </summary>
    [TestModule("1e8ede6e-8b41-4650-9bc8-e11d8aa1ab1a", ModuleType.Recording, 1)]
    public partial class Recording11 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTestRepository repository.
        /// </summary>
        public static MyTestRepository repo = MyTestRepository.Instance;

        static Recording11 instance = new Recording11();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording11()
        {
            varRegister = "Introduction";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording11 Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varRegister.
        /// </summary>
        [TestVariable("eaffb028-6697-4ed5-9cf2-7f155f60fd87")]
        public string varRegister
        {
            get { return repo.varRegister; }
            set { repo.varRegister = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.TestDatabase' at Center.", repo.RxMainFrame.TestDatabaseInfo, new RecordItemIndex(0));
            repo.RxMainFrame.TestDatabase.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Title=$varRegister) on item 'RxMainFrame.TestDatabase'.", repo.RxMainFrame.TestDatabaseInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.RxMainFrame.TestDatabaseInfo, "Title", varRegister);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "Tab title check", null, false, new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "User", "OK", new RecordItemIndex(3));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}