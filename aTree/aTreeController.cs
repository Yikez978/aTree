using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Security;
using System.Security.Permissions;
using System.Security.AccessControl;
using System.IO;

namespace aTree
{

    class aTreeController
    {
        aTreeConfig _Config;

        int ThreadPoolDefaultWorkerThreads;
        int ThreadPoolDefaultCompletionPortThreads;

        int ActiveChildrenCount = 0;
        int WaitingParentCount = 0;

        public aTreeConfig Config
        {
            get
            {
                return _Config;
            }
        }

        public aTreeController(aTreeConfig Config)
        {

            if (string.IsNullOrEmpty(Config.RootPath))
                throw new ArgumentException("RootPath cannot be null or empty.", "RootPath");

            ThreadPool.GetMaxThreads(
                out ThreadPoolDefaultWorkerThreads,
                out ThreadPoolDefaultCompletionPortThreads
            );

            _Config = Config;
        }

        ////TODO: Inherit from control instead...disposal and whatnot.
        //Control InvokeControl = new Control();

        //List<Thread> RunningThreads = new List<Thread>();

        //aTreeNode RootNode = null;

        //aTreeControllerStatusCallbackDelegate _StatusCallback = null;
        //public aTreeControllerStatusCallbackDelegate StatusCallback
        //{
        //    get {
        //        return _StatusCallback;
        //    }
        //    set {
        //        _StatusCallback = value;
        //    }
        //}

        //public aTreeConfig Config {
        //    get {
        //        return _Config;
        //    }
        //}

        //public aTreeController(aTreeConfig Config) {

        //    if (Config.TargetTreeView == null)
        //        throw new ArgumentException("TargetTreeView cannot be null.", "TargetTreeView");

        //    if (string.IsNullOrEmpty(Config.RootPath))
        //        throw new ArgumentException("RootPath cannot be null or empty.", "RootPath");

        //    ThreadPool.GetMaxThreads(
        //        out ThreadPoolDefaultWorkerThreads, 
        //        out ThreadPoolDefaultCompletionPortThreads
        //    );

        //    _Config = Config;
        //}

        //public aTreeController(TreeView TargetTreeView, string RootPath) : 
        //    this(
        //            new aTreeConfig (){
        //                TargetTreeView = TargetTreeView,
        //                RootPath = RootPath
        //        }
        //    ){}

        //public delegate int GetWaitingParentDelegate();
        //public int GetWaitingParentAsync()
        //{
        //    return (int)InvokeControl.Invoke(
        //        new GetWaitingParentDelegate(GetWaitingParent));
        //}
        //public int GetWaitingParent()
        //{
        //    return WaitingParentCount;
        //}

        //public object IncrementWaitingParentLock = new object();
        //public delegate void IncrementWaitingParentDelegate();
        //public void IncrementWaitingParentAsync()
        //{
        //    InvokeControl.Invoke(
        //        new IncrementWaitingParentDelegate(IncrementWaitingParent));
        //}
        //public void IncrementWaitingParent()
        //{
        //    lock (IncrementWaitingParentLock) { 
        //        WaitingParentCount += 1;
        //    }
        //}

        //public object DecrementWaitingParentLock = new object();
        //public delegate void DecrementWaitingParentDelegate();
        //public void DecrementWaitingParentAsync()
        //{
        //    InvokeControl.Invoke(
        //        new DecrementWaitingParentDelegate(DecrementWaitingParent));
        //}
        //public void DecrementWaitingParent()
        //{
        //    lock (DecrementWaitingParentLock) { 
        //        if (WaitingParentCount > 0)
        //        {
        //            WaitingParentCount += 1;
        //        }
        //    }
        //}

        //public delegate int GetActiveChildrenDelegate();
        //public int GetActiveChildrenAsync()
        //{
        //    return (int)InvokeControl.Invoke(
        //        new GetActiveChildrenDelegate(GetActiveChildren));
        //}
        //public int GetActiveChildren()
        //{
        //    return ActiveChildrenCount;
        //}

        //private object IncrementActiveChildrenLock = new object();
        //public delegate void IncrementActiveChildrenDelegate();
        //public void IncrementActiveChildrenAsync()
        //{
        //    InvokeControl.Invoke(
        //        new IncrementActiveChildrenDelegate(IncrementActiveChildren));
        //}
        //public void IncrementActiveChildren()
        //{
        //    lock (IncrementActiveChildrenLock) { 
        //        ActiveChildrenCount += 1;
        //    }
        //}

        //private object DecrementActiveChildrenLock = new object();
        //public delegate void DecrementActiveChildrenDelegate();
        //public void DecrementActiveChildrenAsync()
        //{
        //    InvokeControl.Invoke(
        //        new DecrementActiveChildrenDelegate(DecrementActiveChildren));
        //}
        //public void DecrementActiveChildren()
        //{
        //    lock (DecrementActiveChildrenLock) { 
        //        if (ActiveChildrenCount > 0)
        //        {
        //            ActiveChildrenCount += 1;
        //        }
        //    }
        //}

        ////public delegate void AddThreadDelegate(ref Thread NewThread);
        ////public void AddThreadAsync(ref Thread NewThread){
        ////    Config.TargetTreeView.Parent.Invoke(
        ////        new AddThreadDelegate(AddThread), NewThread);
        ////}
        ////public void AddThread(ref Thread NewThread){
        ////    RunningThreads.Add(NewThread);
        ////}

        //public delegate void NodeAppendDelegate(ref aTreeNode Parent, ref aTreeNode Child);
        //public void NodeAppendAsync(ref aTreeNode Parent, ref aTreeNode Child){
        //    Config.TargetTreeView.Invoke(new NodeAppendDelegate(NodeAppend), Parent, Child);
        //}
        //public void NodeAppend(ref aTreeNode Parent, ref aTreeNode Child) {
        //    Parent.Nodes.Add(Child);
        //}

        //private object CallbackStatusLock = new object();
        //public delegate void CallbackStatusDelegate(string value);
        //public void CallbackStatusAsync(string value)
        //{
        //    Config.TargetTreeView.Invoke(new CallbackStatusDelegate(CallbackStatus), value);
        //}
        //public void CallbackStatus(string value)
        //{
        //    lock (CallbackStatusLock) { 
        //        if (_StatusCallback != null) {
        //             _StatusCallback.Invoke(value);
        //        }
        //    }
        //}

        ////public delegate int GetRunningThreadCountDelegate();
        ////public int GetRunningThreadCountAsync() {
        ////    return (int)(
        ////        Config.TargetTreeView.Parent.Invoke(
        ////            new GetRunningThreadCountDelegate(GetRunningThreadCount)
        ////        )
        ////    );
        ////}
        ////public int GetRunningThreadCount() {

        ////    List<Thread> temp = new List<Thread>();

        ////    foreach (Thread t in RunningThreads){
        ////        if (t.ThreadState != ThreadState.Running) {
        ////            temp.Add(t);
        ////        }
        ////    }

        ////    return temp.Count;
        ////}

        //public void PopulateTree()
        //{

        //    ///damn config items can be null...check before running.
        //    if (Config.MaxWorkerThreads < 0) Config.MaxWorkerThreads = 0;
        //    if (Config.MaxCompletionPortThreads < 0) Config.MaxCompletionPortThreads = 0;

        //    if (Config.CustomMaxThreads)
        //    {

        //        if (Config.MaxWorkerThreads == 0 && Config.MaxCompletionPortThreads > 0)
        //        {
        //            ThreadPool.SetMaxThreads(ThreadPoolDefaultWorkerThreads, Config.MaxCompletionPortThreads);
        //        }

        //        if (Config.MaxWorkerThreads > 0 && Config.MaxCompletionPortThreads == 0)
        //        {
        //            ThreadPool.SetMaxThreads(Config.MaxWorkerThreads, ThreadPoolDefaultCompletionPortThreads);
        //        }

        //        if (Config.MaxWorkerThreads == 0 && Config.MaxCompletionPortThreads == 0)
        //        {
        //            ThreadPool.SetMaxThreads(Config.MaxWorkerThreads, Config.MaxCompletionPortThreads);
        //        }

        //        if (Config.MaxWorkerThreads > 0 && Config.MaxCompletionPortThreads > 0)
        //        {
        //            ThreadPool.SetMaxThreads(ThreadPoolDefaultWorkerThreads, ThreadPoolDefaultCompletionPortThreads);
        //        }
        //    }

        //    RootNode = new aTreeNode();
        //    RootNode.Name = "Scan Results";
        //    RootNode.Text = "Scan Results";

        //    Config.TargetTreeView.Nodes.Clear();
        //    Config.TargetTreeView.Nodes.Add(RootNode);

        //    ProcessFolder(Config.RootPath, RootNode, Config);

        //}

        //private void ProcessFolder(object State)
        //{

        //    object[] args = State as object[];

        //    if (args == null && args.Length != 3)
        //    {
        //        throw new ArgumentException("State cannot be null, and must be castable to an argument array for ProcessFolder.", "State");
        //    }

        //    ProcessFolder(
        //                (string)args[0],
        //                (aTreeNode)args[1],
        //                (aTreeConfig)args[2]
        //    );

        //}

        //private void ProcessFolder(string FolderPath, aTreeNode CurrentNode, aTreeConfig Config) {

        //    //Send notification that we're starting on this folder. Display purposes only.
        //    CallbackStatusAsync(FolderPath);

        //    //I HATE doing this, but can't find a better way anywhere. Hell, I can't even use SecurityManager.IsGranted.
        //    //because it's deprecated.
        //    DirectoryInfo CurrentFolder = null;
        //    DirectoryInfo[] Children = null;

        //    try {

        //        //Any filtering happens here.
        //        CurrentFolder = new DirectoryInfo(FolderPath);
        //        Children = CurrentFolder.GetDirectories();

        //    }
        //    catch(Exception e) {

        //        //No access, set display parameters accordingly.
        //        //These will need to be set async since CurrentNode

        //        return;
        //    }

        //    List<Thread> ChildThreads = new List<Thread>();
        //    List<aTreeNode> ChildNodes = new List<aTreeNode>();

        //    foreach (DirectoryInfo Folder in Children) {

        //        aTreeNode NewNode = new aTreeNode();

        //        NewNode.Name = Folder.FullName;
        //        NewNode.Text = Folder.Name;

        //        ChildNodes.Add(NewNode);

        //        do {

        //            //Chill...
        //            Thread.Sleep(1000);

        //        } while (GetActiveChildrenAsync() >= Config.MaxWorkerThreads);

        //        Thread NewThread = new Thread(new ParameterizedThreadStart(ProcessFolder));

        //        //We've started a new child, increment the children counter. The parent won't worry about
        //        //decrementing this later, the child will decrement itself when finished.
        //        IncrementActiveChildrenAsync();
        //        NewThread.Start(new object[] { Folder.FullName, NewNode, Config });

        //    }

        //    //Then do files!(if applicable)

        //    //Since THIS "active child" is done, decrement it from the counter.
        //    DecrementActiveChildrenAsync();

        //    //It is now a waiting parent instead.
        //    IncrementWaitingParentAsync();

        //    int MyActiveChildren = 0;
        //    do {

        //        MyActiveChildren = 0;

        //        foreach (Thread t in ChildThreads) {
        //            if (t.ThreadState == ThreadState.Running) {
        //                MyActiveChildren += 1;
        //            }
        //        }

        //        Thread.Sleep(1000);

        //    } while (MyActiveChildren > 0);

        //    foreach (aTreeNode n in ChildNodes) {
        //        aTreeNode node = n;
        //        NodeAppendAsync(ref CurrentNode, ref node);
        //    }
        //    CurrentNode.ExpandAll();

        //    //No longer a waiting parent, about to be a stopped thread. So decrement.
        //    DecrementWaitingParentAsync();
    }
}