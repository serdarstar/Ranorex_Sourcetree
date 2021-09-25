/*
 * Created by Ranorex
 * User: star
 * Date: 24/09/2021
 * Time: 05:54
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace MyTest
{
    /// <summary>
    /// Description of DeleteNames.
    /// </summary>
    [TestModule("58E8A00F-67A9-4525-890C-B275D18632DA", ModuleType.UserCode, 1)]
    public class DeleteNames : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteNames()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            var varNumberOfListItems=MyTestRepository.Instance.RxMainFrame.RxTabStandard.LblNumberOfPersonsNumber.TextValue;
            int numberofEntries=Convert.ToInt32(varNumberOfListItems);
            
            while (numberofEntries>0) {
            	
            	MyTestRepository.Instance.RxMainFrame.RxTabStandard.FirstListItem.Select();
            	MyTestRepository.Instance.RxMainFrame.RxTabStandard.BtnDeletePerson.Click();

            	
            	numberofEntries--;
            }
            
        }
    }
}
