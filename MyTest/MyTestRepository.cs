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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("acbd1ac2-1c6a-4fcb-811d-72786e18bccf")]
    public partial class MyTestRepository : RepoGenBaseFolder
    {
        static MyTestRepository instance = new MyTestRepository();
        MyTestRepositoryFolders.List1000AppFolder _list1000;
        MyTestRepositoryFolders.RxDemoAppAppFolder _rxdemoapp;
        MyTestRepositoryFolders.RxMainFrameAppFolder _rxmainframe;
        MyTestRepositoryFolders.DESKTOPS21QA0CAppFolder _desktops21qa0c;

        /// <summary>
        /// Gets the singleton class instance representing the MyTestRepository element repository.
        /// </summary>
        [RepositoryFolder("acbd1ac2-1c6a-4fcb-811d-72786e18bccf")]
        public static MyTestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTestRepository() 
            : base("MyTestRepository", "/", null, 0, false, "acbd1ac2-1c6a-4fcb-811d-72786e18bccf", ".\\RepositoryImages\\MyTestRepositoryacbd1ac2.rximgres")
        {
            _list1000 = new MyTestRepositoryFolders.List1000AppFolder(this);
            _rxdemoapp = new MyTestRepositoryFolders.RxDemoAppAppFolder(this);
            _rxmainframe = new MyTestRepositoryFolders.RxMainFrameAppFolder(this);
            _desktops21qa0c = new MyTestRepositoryFolders.DESKTOPS21QA0CAppFolder(this);
        }

#region Variables

        string _varRegister = "Introduction";

        /// <summary>
        /// Gets or sets the value of variable varRegister.
        /// </summary>
        [TestVariable("eaffb028-6697-4ed5-9cf2-7f155f60fd87")]
        public string varRegister
        {
            get { return _varRegister; }
            set { _varRegister = value; }
        }

        string _varDepartmentList = "";

        /// <summary>
        /// Gets or sets the value of variable varDepartmentList.
        /// </summary>
        [TestVariable("f903279f-42d6-45b0-82ec-40fa49141272")]
        public string varDepartmentList
        {
            get { return _varDepartmentList; }
            set { _varDepartmentList = value; }
        }

        string _varDepartment = "";

        /// <summary>
        /// Gets or sets the value of variable varDepartment.
        /// </summary>
        [TestVariable("c7ccea28-90ff-4831-b6fe-b57590e7509a")]
        public string varDepartment
        {
            get { return _varDepartment; }
            set { _varDepartment = value; }
        }

        string _varFirstName = "";

        /// <summary>
        /// Gets or sets the value of variable varFirstName.
        /// </summary>
        [TestVariable("f37b3c18-340b-4fcb-9c9e-966562322cfb")]
        public string varFirstName
        {
            get { return _varFirstName; }
            set { _varFirstName = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("acbd1ac2-1c6a-4fcb-811d-72786e18bccf")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The List1000 folder.
        /// </summary>
        [RepositoryFolder("e8929251-04bb-4155-a1ab-af9e75a66833")]
        public virtual MyTestRepositoryFolders.List1000AppFolder List1000
        {
            get { return _list1000; }
        }

        /// <summary>
        /// The RxDemoApp folder.
        /// </summary>
        [RepositoryFolder("29e3a26f-00c4-4e65-9a41-d4989889f736")]
        public virtual MyTestRepositoryFolders.RxDemoAppAppFolder RxDemoApp
        {
            get { return _rxdemoapp; }
        }

        /// <summary>
        /// The RxMainFrame folder.
        /// </summary>
        [RepositoryFolder("0a3a984d-92e4-407a-8bd7-073a1bfedc4b")]
        public virtual MyTestRepositoryFolders.RxMainFrameAppFolder RxMainFrame
        {
            get { return _rxmainframe; }
        }

        /// <summary>
        /// The DESKTOPS21QA0C folder.
        /// </summary>
        [RepositoryFolder("25412e2d-55fb-4a1f-a9a1-7cf69f10c5d7")]
        public virtual MyTestRepositoryFolders.DESKTOPS21QA0CAppFolder DESKTOPS21QA0C
        {
            get { return _desktops21qa0c; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTestRepositoryFolders
    {
        /// <summary>
        /// The List1000AppFolder folder.
        /// </summary>
        [RepositoryFolder("e8929251-04bb-4155-a1ab-af9e75a66833")]
        public partial class List1000AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _marketingInfo;
            RepoItemInfo _projectmanagementInfo;
            RepoItemInfo _managementInfo;

            /// <summary>
            /// Creates a new List1000  folder.
            /// </summary>
            public List1000AppFolder(RepoGenBaseFolder parentFolder) :
                    base("List1000", "/list[@controlid='1000']", parentFolder, 30000, null, true, "e8929251-04bb-4155-a1ab-af9e75a66833", "")
            {
                _marketingInfo = new RepoItemInfo(this, "Marketing", "listitem[@text='Marketing']", "", 30000, null, "bdde0bff-d749-48d3-9b45-46138e1b23c0");
                _projectmanagementInfo = new RepoItemInfo(this, "ProjectManagement", "listitem[@text=$varDepartment]", "", 30000, null, "149baba5-2f05-4f45-9aed-79a522a9db16");
                _managementInfo = new RepoItemInfo(this, "Management", "listitem[@text=$varDepartmentList]", "", 30000, null, "377a5483-964c-46fb-8961-02c8d4ccc461");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("e8929251-04bb-4155-a1ab-af9e75a66833")]
            public virtual Ranorex.List Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.List>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("e8929251-04bb-4155-a1ab-af9e75a66833")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Marketing item.
            /// </summary>
            [RepositoryItem("bdde0bff-d749-48d3-9b45-46138e1b23c0")]
            public virtual Ranorex.ListItem Marketing
            {
                get
                {
                    return _marketingInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The Marketing item info.
            /// </summary>
            [RepositoryItemInfo("bdde0bff-d749-48d3-9b45-46138e1b23c0")]
            public virtual RepoItemInfo MarketingInfo
            {
                get
                {
                    return _marketingInfo;
                }
            }

            /// <summary>
            /// The ProjectManagement item.
            /// </summary>
            [RepositoryItem("149baba5-2f05-4f45-9aed-79a522a9db16")]
            public virtual Ranorex.ListItem ProjectManagement
            {
                get
                {
                    return _projectmanagementInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The ProjectManagement item info.
            /// </summary>
            [RepositoryItemInfo("149baba5-2f05-4f45-9aed-79a522a9db16")]
            public virtual RepoItemInfo ProjectManagementInfo
            {
                get
                {
                    return _projectmanagementInfo;
                }
            }

            /// <summary>
            /// The Management item.
            /// </summary>
            [RepositoryItem("377a5483-964c-46fb-8961-02c8d4ccc461")]
            public virtual Ranorex.ListItem Management
            {
                get
                {
                    return _managementInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The Management item info.
            /// </summary>
            [RepositoryItemInfo("377a5483-964c-46fb-8961-02c8d4ccc461")]
            public virtual RepoItemInfo ManagementInfo
            {
                get
                {
                    return _managementInfo;
                }
            }
        }

        /// <summary>
        /// The RxDemoAppAppFolder folder.
        /// </summary>
        [RepositoryFolder("29e3a26f-00c4-4e65-9a41-d4989889f736")]
        public partial class RxDemoAppAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _ranorizeyourselfin20minutesInfo;
            RepoItemInfo _ranorexstudiofundamentalsInfo;

            /// <summary>
            /// Creates a new RxDemoApp  folder.
            /// </summary>
            public RxDemoAppAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RxDemoApp", "/contextmenu[@processname='RxDemoApp']", parentFolder, 30000, null, true, "29e3a26f-00c4-4e65-9a41-d4989889f736", "")
            {
                _ranorizeyourselfin20minutesInfo = new RepoItemInfo(this, "RanorizeYourselfIn20Minutes", "menuitem[@accessiblename>'Ranorize yourself in 20 m']", "", 30000, null, "de99ba20-0e19-420e-a3a7-acee55ff2f92");
                _ranorexstudiofundamentalsInfo = new RepoItemInfo(this, "RanorexStudioFundamentals", "menuitem[@accessiblename>'Ranorex Studio fundamenta']", "", 30000, null, "4a681f23-be04-4fe2-b0c9-64aeeb19731a");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("29e3a26f-00c4-4e65-9a41-d4989889f736")]
            public virtual Ranorex.ContextMenu Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("29e3a26f-00c4-4e65-9a41-d4989889f736")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The RanorizeYourselfIn20Minutes item.
            /// </summary>
            [RepositoryItem("de99ba20-0e19-420e-a3a7-acee55ff2f92")]
            public virtual Ranorex.MenuItem RanorizeYourselfIn20Minutes
            {
                get
                {
                    return _ranorizeyourselfin20minutesInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The RanorizeYourselfIn20Minutes item info.
            /// </summary>
            [RepositoryItemInfo("de99ba20-0e19-420e-a3a7-acee55ff2f92")]
            public virtual RepoItemInfo RanorizeYourselfIn20MinutesInfo
            {
                get
                {
                    return _ranorizeyourselfin20minutesInfo;
                }
            }

            /// <summary>
            /// The RanorexStudioFundamentals item.
            /// </summary>
            [RepositoryItem("4a681f23-be04-4fe2-b0c9-64aeeb19731a")]
            public virtual Ranorex.MenuItem RanorexStudioFundamentals
            {
                get
                {
                    return _ranorexstudiofundamentalsInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The RanorexStudioFundamentals item info.
            /// </summary>
            [RepositoryItemInfo("4a681f23-be04-4fe2-b0c9-64aeeb19731a")]
            public virtual RepoItemInfo RanorexStudioFundamentalsInfo
            {
                get
                {
                    return _ranorexstudiofundamentalsInfo;
                }
            }
        }

        /// <summary>
        /// The RxMainFrameAppFolder folder.
        /// </summary>
        [RepositoryFolder("0a3a984d-92e4-407a-8bd7-073a1bfedc4b")]
        public partial class RxMainFrameAppFolder : RepoGenBaseFolder
        {
            MyTestRepositoryFolders.RxTabStandardFolder _rxtabstandard;
            RepoItemInfo _imagebasedautomationInfo;
            RepoItemInfo _aboutInfo;
            RepoItemInfo _testdatabaseInfo;
            RepoItemInfo _testdatabase1Info;
            RepoItemInfo _lastnamerow3Info;
            RepoItemInfo _cellofthomasbachInfo;
            RepoItemInfo _btnsubmitusernameInfo;
            RepoItemInfo _enteryournameInfo;
            RepoItemInfo _rxbuttonexitInfo;

            /// <summary>
            /// Creates a new RxMainFrame  folder.
            /// </summary>
            public RxMainFrameAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RxMainFrame", "/form[@controlname='RxMainFrame']", parentFolder, 30000, null, true, "0a3a984d-92e4-407a-8bd7-073a1bfedc4b", "")
            {
                _rxtabstandard = new MyTestRepositoryFolders.RxTabStandardFolder(this);
                _imagebasedautomationInfo = new RepoItemInfo(this, "ImageBasedAutomation", "?/?/tabpage[@accessiblename='Image-based automation']", "", 30000, null, "e7efca83-9d45-47fd-8387-20393e28bcc7");
                _aboutInfo = new RepoItemInfo(this, "About", "?/?/menuitem[@accessiblename='About']", "", 30000, null, "82626fd7-4fac-4e32-aadd-91989fe7fcc3");
                _testdatabaseInfo = new RepoItemInfo(this, "TestDatabase", "?/?/tabpage[@accessiblename=$varRegister]", "", 30000, null, "cc265ffe-5343-4434-bcee-d91a84c14078");
                _testdatabase1Info = new RepoItemInfo(this, "TestDatabase1", "?/?/tabpage[@accessiblename='Test database']", "", 30000, null, "9e579d27-1c92-41b7-b93c-bc7f9b19b7f9");
                _lastnamerow3Info = new RepoItemInfo(this, "LastNameRow3", "?/?/tabpage[@controlname='RxTabUIElements']/table[@controlname='dataGridView1']/?/?/cell[@accessiblename='LastName Row 3']", "", 30000, null, "26561b61-00c8-4b52-a256-424ef5c78d8d");
                _cellofthomasbachInfo = new RepoItemInfo(this, "CellOfThomasBach", "?/?/tabpage[@controlname='RxTabUIElements']/table[@controlname='dataGridView1']/?/?/cell[@accessiblename>'First' and @text=$varFirstName]/../cell[@accessiblename>'Age']", "", 30000, null, "38bed8a2-e9d8-4644-8439-ae576bcd047a");
                _btnsubmitusernameInfo = new RepoItemInfo(this, "BtnSubmitUserName", "?/?/tabpage[@controlname='RxTabIntroduction']/button[@controlname='btnSubmitUserName']", "", 30000, null, "974fa669-ef0f-4274-bc89-5050a19b7bb0");
                _enteryournameInfo = new RepoItemInfo(this, "EnterYourName", "?/?/tabpage[@controlname='RxTabIntroduction']/?/?/text[@accessiblename='Enter your name']", "", 30000, null, "17c91e4c-ff6c-4cfe-b7ad-2f8940440419");
                _rxbuttonexitInfo = new RepoItemInfo(this, "RxButtonExit", "button[@controlname='RxButtonExit']", "", 30000, null, "d8173968-fc5f-4173-8262-4d01579d7db2");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("0a3a984d-92e4-407a-8bd7-073a1bfedc4b")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("0a3a984d-92e4-407a-8bd7-073a1bfedc4b")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ImageBasedAutomation item.
            /// </summary>
            [RepositoryItem("e7efca83-9d45-47fd-8387-20393e28bcc7")]
            public virtual Ranorex.TabPage ImageBasedAutomation
            {
                get
                {
                    return _imagebasedautomationInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The ImageBasedAutomation item info.
            /// </summary>
            [RepositoryItemInfo("e7efca83-9d45-47fd-8387-20393e28bcc7")]
            public virtual RepoItemInfo ImageBasedAutomationInfo
            {
                get
                {
                    return _imagebasedautomationInfo;
                }
            }

            /// <summary>
            /// The About item.
            /// </summary>
            [RepositoryItem("82626fd7-4fac-4e32-aadd-91989fe7fcc3")]
            public virtual Ranorex.MenuItem About
            {
                get
                {
                    return _aboutInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The About item info.
            /// </summary>
            [RepositoryItemInfo("82626fd7-4fac-4e32-aadd-91989fe7fcc3")]
            public virtual RepoItemInfo AboutInfo
            {
                get
                {
                    return _aboutInfo;
                }
            }

            /// <summary>
            /// The TestDatabase item.
            /// </summary>
            [RepositoryItem("cc265ffe-5343-4434-bcee-d91a84c14078")]
            public virtual Ranorex.TabPage TestDatabase
            {
                get
                {
                    return _testdatabaseInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The TestDatabase item info.
            /// </summary>
            [RepositoryItemInfo("cc265ffe-5343-4434-bcee-d91a84c14078")]
            public virtual RepoItemInfo TestDatabaseInfo
            {
                get
                {
                    return _testdatabaseInfo;
                }
            }

            /// <summary>
            /// The TestDatabase1 item.
            /// </summary>
            [RepositoryItem("9e579d27-1c92-41b7-b93c-bc7f9b19b7f9")]
            public virtual Ranorex.TabPage TestDatabase1
            {
                get
                {
                    return _testdatabase1Info.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The TestDatabase1 item info.
            /// </summary>
            [RepositoryItemInfo("9e579d27-1c92-41b7-b93c-bc7f9b19b7f9")]
            public virtual RepoItemInfo TestDatabase1Info
            {
                get
                {
                    return _testdatabase1Info;
                }
            }

            /// <summary>
            /// The LastNameRow3 item.
            /// </summary>
            [RepositoryItem("26561b61-00c8-4b52-a256-424ef5c78d8d")]
            public virtual Ranorex.Cell LastNameRow3
            {
                get
                {
                    return _lastnamerow3Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The LastNameRow3 item info.
            /// </summary>
            [RepositoryItemInfo("26561b61-00c8-4b52-a256-424ef5c78d8d")]
            public virtual RepoItemInfo LastNameRow3Info
            {
                get
                {
                    return _lastnamerow3Info;
                }
            }

            /// <summary>
            /// The CellOfThomasBach item.
            /// </summary>
            [RepositoryItem("38bed8a2-e9d8-4644-8439-ae576bcd047a")]
            public virtual Ranorex.Cell CellOfThomasBach
            {
                get
                {
                    return _cellofthomasbachInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The CellOfThomasBach item info.
            /// </summary>
            [RepositoryItemInfo("38bed8a2-e9d8-4644-8439-ae576bcd047a")]
            public virtual RepoItemInfo CellOfThomasBachInfo
            {
                get
                {
                    return _cellofthomasbachInfo;
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item.
            /// </summary>
            [RepositoryItem("974fa669-ef0f-4274-bc89-5050a19b7bb0")]
            public virtual Ranorex.Button BtnSubmitUserName
            {
                get
                {
                    return _btnsubmitusernameInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item info.
            /// </summary>
            [RepositoryItemInfo("974fa669-ef0f-4274-bc89-5050a19b7bb0")]
            public virtual RepoItemInfo BtnSubmitUserNameInfo
            {
                get
                {
                    return _btnsubmitusernameInfo;
                }
            }

            /// <summary>
            /// The EnterYourName item.
            /// </summary>
            [RepositoryItem("17c91e4c-ff6c-4cfe-b7ad-2f8940440419")]
            public virtual Ranorex.Text EnterYourName
            {
                get
                {
                    return _enteryournameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The EnterYourName item info.
            /// </summary>
            [RepositoryItemInfo("17c91e4c-ff6c-4cfe-b7ad-2f8940440419")]
            public virtual RepoItemInfo EnterYourNameInfo
            {
                get
                {
                    return _enteryournameInfo;
                }
            }

            /// <summary>
            /// The RxButtonExit item.
            /// </summary>
            [RepositoryItem("d8173968-fc5f-4173-8262-4d01579d7db2")]
            public virtual Ranorex.Button RxButtonExit
            {
                get
                {
                    return _rxbuttonexitInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The RxButtonExit item info.
            /// </summary>
            [RepositoryItemInfo("d8173968-fc5f-4173-8262-4d01579d7db2")]
            public virtual RepoItemInfo RxButtonExitInfo
            {
                get
                {
                    return _rxbuttonexitInfo;
                }
            }

            /// <summary>
            /// The RxTabStandard folder.
            /// </summary>
            [RepositoryFolder("dfe50924-1f73-4df8-9962-3806fc8ba0d7")]
            public virtual MyTestRepositoryFolders.RxTabStandardFolder RxTabStandard
            {
                get { return _rxtabstandard; }
            }
        }

        /// <summary>
        /// The RxTabStandardFolder folder.
        /// </summary>
        [RepositoryFolder("dfe50924-1f73-4df8-9962-3806fc8ba0d7")]
        public partial class RxTabStandardFolder : RepoGenBaseFolder
        {
            RepoItemInfo _openInfo;
            RepoItemInfo _firstnameInfo;
            RepoItemInfo _btnaddpersonInfo;
            RepoItemInfo _departmentInfo;
            RepoItemInfo _serdar0nodepartmentInfo;
            RepoItemInfo _serdar0managementInfo;
            RepoItemInfo _zuhal0marketingInfo;
            RepoItemInfo _firstlistitemInfo;
            RepoItemInfo _btndeletepersonInfo;
            RepoItemInfo _lblnumberofpersonsnumberInfo;

            /// <summary>
            /// Creates a new RxTabStandard  folder.
            /// </summary>
            public RxTabStandardFolder(RepoGenBaseFolder parentFolder) :
                    base("RxTabStandard", "?/?/tabpage[@controlname='RxTabStandard']", parentFolder, 30000, null, false, "dfe50924-1f73-4df8-9962-3806fc8ba0d7", "")
            {
                _openInfo = new RepoItemInfo(this, "Open", "?/?/button[@accessiblename='Open']", "", 30000, null, "c6de4ca1-ff1c-4183-be0c-f470594dbf8d");
                _firstnameInfo = new RepoItemInfo(this, "FirstName", "?/?/text[@accessiblename='First name']", "", 30000, null, "3e30800e-4634-468c-969e-ee0ac774e84b");
                _btnaddpersonInfo = new RepoItemInfo(this, "BtnAddPerson", "button[@controlname='btnAddPerson']", "", 30000, null, "52b5cfd0-6869-47ce-9377-be47dee49932");
                _departmentInfo = new RepoItemInfo(this, "Department", "?/?/text[@controlid='1001']", "", 30000, null, "260b8a65-1d76-436d-acc0-e9a8dc85dc1f");
                _serdar0nodepartmentInfo = new RepoItemInfo(this, "Serdar0NoDepartment", "list[@controlname='lstPersonList']/?/?/listitem[@accessiblename>'Serdar  (0) (no departmen']", "", 30000, null, "809d8e7f-1b6d-4a0a-a900-510778fa2e78");
                _serdar0managementInfo = new RepoItemInfo(this, "Serdar0Management", "list[@controlname='lstPersonList']/?/?/listitem[@accessiblename='Serdar  (0) Management']", "", 30000, null, "5538583d-185c-4902-9bd1-488b14c46db5");
                _zuhal0marketingInfo = new RepoItemInfo(this, "Zuhal0Marketing", "list[@controlname='lstPersonList']/?/?/listitem[@accessiblename='Zuhal  (0) Marketing']", "", 30000, null, "c16fab05-babc-420f-a993-a8cdaad3df16");
                _firstlistitemInfo = new RepoItemInfo(this, "FirstListItem", "list[@controlname='lstPersonList']/?/?/listitem[1]", "", 30000, null, "fccf2443-111d-475c-a49c-ce49816cd21b");
                _btndeletepersonInfo = new RepoItemInfo(this, "BtnDeletePerson", "button[@controlname='btnDeletePerson']", "", 30000, null, "5926cbe1-e15a-49d8-b171-f3d9c6502fdd");
                _lblnumberofpersonsnumberInfo = new RepoItemInfo(this, "LblNumberOfPersonsNumber", "text[@controlname='lblNumberOfPersonsNumber']", "", 30000, null, "088ecd1d-65bd-48eb-97b7-c9df282531f7");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("dfe50924-1f73-4df8-9962-3806fc8ba0d7")]
            public virtual Ranorex.TabPage Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("dfe50924-1f73-4df8-9962-3806fc8ba0d7")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Open item.
            /// </summary>
            [RepositoryItem("c6de4ca1-ff1c-4183-be0c-f470594dbf8d")]
            public virtual Ranorex.Button Open
            {
                get
                {
                    return _openInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Open item info.
            /// </summary>
            [RepositoryItemInfo("c6de4ca1-ff1c-4183-be0c-f470594dbf8d")]
            public virtual RepoItemInfo OpenInfo
            {
                get
                {
                    return _openInfo;
                }
            }

            /// <summary>
            /// The FirstName item.
            /// </summary>
            [RepositoryItem("3e30800e-4634-468c-969e-ee0ac774e84b")]
            public virtual Ranorex.Text FirstName
            {
                get
                {
                    return _firstnameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The FirstName item info.
            /// </summary>
            [RepositoryItemInfo("3e30800e-4634-468c-969e-ee0ac774e84b")]
            public virtual RepoItemInfo FirstNameInfo
            {
                get
                {
                    return _firstnameInfo;
                }
            }

            /// <summary>
            /// The BtnAddPerson item.
            /// </summary>
            [RepositoryItem("52b5cfd0-6869-47ce-9377-be47dee49932")]
            public virtual Ranorex.Button BtnAddPerson
            {
                get
                {
                    return _btnaddpersonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnAddPerson item info.
            /// </summary>
            [RepositoryItemInfo("52b5cfd0-6869-47ce-9377-be47dee49932")]
            public virtual RepoItemInfo BtnAddPersonInfo
            {
                get
                {
                    return _btnaddpersonInfo;
                }
            }

            /// <summary>
            /// The Department item.
            /// </summary>
            [RepositoryItem("260b8a65-1d76-436d-acc0-e9a8dc85dc1f")]
            public virtual Ranorex.Text Department
            {
                get
                {
                    return _departmentInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Department item info.
            /// </summary>
            [RepositoryItemInfo("260b8a65-1d76-436d-acc0-e9a8dc85dc1f")]
            public virtual RepoItemInfo DepartmentInfo
            {
                get
                {
                    return _departmentInfo;
                }
            }

            /// <summary>
            /// The Serdar0NoDepartment item.
            /// </summary>
            [RepositoryItem("809d8e7f-1b6d-4a0a-a900-510778fa2e78")]
            public virtual Ranorex.ListItem Serdar0NoDepartment
            {
                get
                {
                    return _serdar0nodepartmentInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The Serdar0NoDepartment item info.
            /// </summary>
            [RepositoryItemInfo("809d8e7f-1b6d-4a0a-a900-510778fa2e78")]
            public virtual RepoItemInfo Serdar0NoDepartmentInfo
            {
                get
                {
                    return _serdar0nodepartmentInfo;
                }
            }

            /// <summary>
            /// The Serdar0Management item.
            /// </summary>
            [RepositoryItem("5538583d-185c-4902-9bd1-488b14c46db5")]
            public virtual Ranorex.ListItem Serdar0Management
            {
                get
                {
                    return _serdar0managementInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The Serdar0Management item info.
            /// </summary>
            [RepositoryItemInfo("5538583d-185c-4902-9bd1-488b14c46db5")]
            public virtual RepoItemInfo Serdar0ManagementInfo
            {
                get
                {
                    return _serdar0managementInfo;
                }
            }

            /// <summary>
            /// The Zuhal0Marketing item.
            /// </summary>
            [RepositoryItem("c16fab05-babc-420f-a993-a8cdaad3df16")]
            public virtual Ranorex.ListItem Zuhal0Marketing
            {
                get
                {
                    return _zuhal0marketingInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The Zuhal0Marketing item info.
            /// </summary>
            [RepositoryItemInfo("c16fab05-babc-420f-a993-a8cdaad3df16")]
            public virtual RepoItemInfo Zuhal0MarketingInfo
            {
                get
                {
                    return _zuhal0marketingInfo;
                }
            }

            /// <summary>
            /// The FirstListItem item.
            /// </summary>
            [RepositoryItem("fccf2443-111d-475c-a49c-ce49816cd21b")]
            public virtual Ranorex.ListItem FirstListItem
            {
                get
                {
                    return _firstlistitemInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The FirstListItem item info.
            /// </summary>
            [RepositoryItemInfo("fccf2443-111d-475c-a49c-ce49816cd21b")]
            public virtual RepoItemInfo FirstListItemInfo
            {
                get
                {
                    return _firstlistitemInfo;
                }
            }

            /// <summary>
            /// The BtnDeletePerson item.
            /// </summary>
            [RepositoryItem("5926cbe1-e15a-49d8-b171-f3d9c6502fdd")]
            public virtual Ranorex.Button BtnDeletePerson
            {
                get
                {
                    return _btndeletepersonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnDeletePerson item info.
            /// </summary>
            [RepositoryItemInfo("5926cbe1-e15a-49d8-b171-f3d9c6502fdd")]
            public virtual RepoItemInfo BtnDeletePersonInfo
            {
                get
                {
                    return _btndeletepersonInfo;
                }
            }

            /// <summary>
            /// The LblNumberOfPersonsNumber item.
            /// </summary>
            [RepositoryItem("088ecd1d-65bd-48eb-97b7-c9df282531f7")]
            public virtual Ranorex.Text LblNumberOfPersonsNumber
            {
                get
                {
                    return _lblnumberofpersonsnumberInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LblNumberOfPersonsNumber item info.
            /// </summary>
            [RepositoryItemInfo("088ecd1d-65bd-48eb-97b7-c9df282531f7")]
            public virtual RepoItemInfo LblNumberOfPersonsNumberInfo
            {
                get
                {
                    return _lblnumberofpersonsnumberInfo;
                }
            }
        }

        /// <summary>
        /// The DESKTOPS21QA0CAppFolder folder.
        /// </summary>
        [RepositoryFolder("25412e2d-55fb-4a1f-a9a1-7cf69f10c5d7")]
        public partial class DESKTOPS21QA0CAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _desktops21qa0cInfo;

            /// <summary>
            /// Creates a new DESKTOPS21QA0C  folder.
            /// </summary>
            public DESKTOPS21QA0CAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DESKTOPS21QA0C", "", parentFolder, 30000, null, true, "25412e2d-55fb-4a1f-a9a1-7cf69f10c5d7", "")
            {
                _desktops21qa0cInfo = new RepoItemInfo(this, "DESKTOPS21QA0C", "", "", 30000, null, "ab1699a4-1f34-48ae-b410-953a3932fd9a");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("25412e2d-55fb-4a1f-a9a1-7cf69f10c5d7")]
            public virtual Ranorex.Host Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Host>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("25412e2d-55fb-4a1f-a9a1-7cf69f10c5d7")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The DESKTOPS21QA0C item.
            /// </summary>
            [RepositoryItem("ab1699a4-1f34-48ae-b410-953a3932fd9a")]
            public virtual Ranorex.Host DESKTOPS21QA0C
            {
                get
                {
                    return _desktops21qa0cInfo.CreateAdapter<Ranorex.Host>(true);
                }
            }

            /// <summary>
            /// The DESKTOPS21QA0C item info.
            /// </summary>
            [RepositoryItemInfo("ab1699a4-1f34-48ae-b410-953a3932fd9a")]
            public virtual RepoItemInfo DESKTOPS21QA0CInfo
            {
                get
                {
                    return _desktops21qa0cInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
