﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by SlSvcUtil, version 5.0.61118.0
// 


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IMyService")]
public interface IMyService
{
    
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMyService/Delay", ReplyAction="http://tempuri.org/IMyService/DelayResponse")]
    System.IAsyncResult BeginDelay(int timespan, System.AsyncCallback callback, object asyncState);
    
    int EndDelay(System.IAsyncResult result);
    
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMyService/TestOut", ReplyAction="http://tempuri.org/IMyService/TestOutResponse")]
    System.IAsyncResult BeginTestOut(System.AsyncCallback callback, object asyncState);
    
    int EndTestOut(out System.DateTime time, System.IAsyncResult result);
    
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMyService/TestByRef", ReplyAction="http://tempuri.org/IMyService/TestByRefResponse")]
    System.IAsyncResult BeginTestByRef(long foo, ref int test, System.AsyncCallback callback, object asyncState);
    
    void EndTestByRef(ref int test, out System.DateTime time, System.IAsyncResult result);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IMyServiceChannel : IMyService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class DelayCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{
    
    private object[] results;
    
    public DelayCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState)
    {
        this.results = results;
    }
    
    public int Result
    {
        get
        {
            base.RaiseExceptionIfNecessary();
            return ((int)(this.results[0]));
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class TestOutCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{
    
    private object[] results;
    
    public TestOutCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState)
    {
        this.results = results;
    }
    
    public System.DateTime time
    {
        get
        {
            base.RaiseExceptionIfNecessary();
            return ((System.DateTime)(this.results[0]));
        }
    }
    
    public int Result
    {
        get
        {
            base.RaiseExceptionIfNecessary();
            return ((int)(this.results[1]));
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class TestByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{
    
    private object[] results;
    
    public TestByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState)
    {
        this.results = results;
    }
    
    public int test
    {
        get
        {
            base.RaiseExceptionIfNecessary();
            return ((int)(this.results[0]));
        }
    }
    
    public System.DateTime time
    {
        get
        {
            base.RaiseExceptionIfNecessary();
            return ((System.DateTime)(this.results[1]));
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class MyServiceClient : System.ServiceModel.ClientBase<IMyService>, IMyService
{
    
    private BeginOperationDelegate onBeginDelayDelegate;
    
    private EndOperationDelegate onEndDelayDelegate;
    
    private System.Threading.SendOrPostCallback onDelayCompletedDelegate;
    
    private BeginOperationDelegate onBeginTestOutDelegate;
    
    private EndOperationDelegate onEndTestOutDelegate;
    
    private System.Threading.SendOrPostCallback onTestOutCompletedDelegate;
    
    private BeginOperationDelegate onBeginTestByRefDelegate;
    
    private EndOperationDelegate onEndTestByRefDelegate;
    
    private System.Threading.SendOrPostCallback onTestByRefCompletedDelegate;
    
    private BeginOperationDelegate onBeginOpenDelegate;
    
    private EndOperationDelegate onEndOpenDelegate;
    
    private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
    
    private BeginOperationDelegate onBeginCloseDelegate;
    
    private EndOperationDelegate onEndCloseDelegate;
    
    private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
    
    public MyServiceClient()
    {
    }
    
    public MyServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public MyServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public System.Net.CookieContainer CookieContainer
    {
        get
        {
            System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
            if ((httpCookieContainerManager != null))
            {
                return httpCookieContainerManager.CookieContainer;
            }
            else
            {
                return null;
            }
        }
        set
        {
            System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
            if ((httpCookieContainerManager != null))
            {
                httpCookieContainerManager.CookieContainer = value;
            }
            else
            {
                throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                        "ookieContainerBindingElement.");
            }
        }
    }
    
    public event System.EventHandler<DelayCompletedEventArgs> DelayCompleted;
    
    public event System.EventHandler<TestOutCompletedEventArgs> TestOutCompleted;
    
    public event System.EventHandler<TestByRefCompletedEventArgs> TestByRefCompleted;
    
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
    
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult IMyService.BeginDelay(int timespan, System.AsyncCallback callback, object asyncState)
    {
        return base.Channel.BeginDelay(timespan, callback, asyncState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    int IMyService.EndDelay(System.IAsyncResult result)
    {
        return base.Channel.EndDelay(result);
    }
    
    private System.IAsyncResult OnBeginDelay(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        int timespan = ((int)(inValues[0]));
        return ((IMyService)(this)).BeginDelay(timespan, callback, asyncState);
    }
    
    private object[] OnEndDelay(System.IAsyncResult result)
    {
        int retVal = ((IMyService)(this)).EndDelay(result);
        return new object[] {
                retVal};
    }
    
    private void OnDelayCompleted(object state)
    {
        if ((this.DelayCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.DelayCompleted(this, new DelayCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void DelayAsync(int timespan)
    {
        this.DelayAsync(timespan, null);
    }
    
    public void DelayAsync(int timespan, object userState)
    {
        if ((this.onBeginDelayDelegate == null))
        {
            this.onBeginDelayDelegate = new BeginOperationDelegate(this.OnBeginDelay);
        }
        if ((this.onEndDelayDelegate == null))
        {
            this.onEndDelayDelegate = new EndOperationDelegate(this.OnEndDelay);
        }
        if ((this.onDelayCompletedDelegate == null))
        {
            this.onDelayCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDelayCompleted);
        }
        base.InvokeAsync(this.onBeginDelayDelegate, new object[] {
                    timespan}, this.onEndDelayDelegate, this.onDelayCompletedDelegate, userState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult IMyService.BeginTestOut(System.AsyncCallback callback, object asyncState)
    {
        return base.Channel.BeginTestOut(callback, asyncState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    int IMyService.EndTestOut(out System.DateTime time, System.IAsyncResult result)
    {
        return base.Channel.EndTestOut(out time, result);
    }
    
    private System.IAsyncResult OnBeginTestOut(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        return ((IMyService)(this)).BeginTestOut(callback, asyncState);
    }
    
    private object[] OnEndTestOut(System.IAsyncResult result)
    {
        System.DateTime time = this.GetDefaultValueForInitialization<System.DateTime>();
        int retVal = ((IMyService)(this)).EndTestOut(out time, result);
        return new object[] {
                time,
                retVal};
    }
    
    private void OnTestOutCompleted(object state)
    {
        if ((this.TestOutCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.TestOutCompleted(this, new TestOutCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void TestOutAsync()
    {
        this.TestOutAsync(null);
    }
    
    public void TestOutAsync(object userState)
    {
        if ((this.onBeginTestOutDelegate == null))
        {
            this.onBeginTestOutDelegate = new BeginOperationDelegate(this.OnBeginTestOut);
        }
        if ((this.onEndTestOutDelegate == null))
        {
            this.onEndTestOutDelegate = new EndOperationDelegate(this.OnEndTestOut);
        }
        if ((this.onTestOutCompletedDelegate == null))
        {
            this.onTestOutCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnTestOutCompleted);
        }
        base.InvokeAsync(this.onBeginTestOutDelegate, null, this.onEndTestOutDelegate, this.onTestOutCompletedDelegate, userState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult IMyService.BeginTestByRef(long foo, ref int test, System.AsyncCallback callback, object asyncState)
    {
        return base.Channel.BeginTestByRef(foo, ref test, callback, asyncState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    void IMyService.EndTestByRef(ref int test, out System.DateTime time, System.IAsyncResult result)
    {
        base.Channel.EndTestByRef(ref test, out time, result);
    }
    
    private System.IAsyncResult OnBeginTestByRef(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        long foo = ((long)(inValues[0]));
        int test = ((int)(inValues[1]));
        return ((IMyService)(this)).BeginTestByRef(foo, ref test, callback, asyncState);
    }
    
    private object[] OnEndTestByRef(System.IAsyncResult result)
    {
        int test = this.GetDefaultValueForInitialization<int>();
        System.DateTime time = this.GetDefaultValueForInitialization<System.DateTime>();
        ((IMyService)(this)).EndTestByRef(ref test, out time, result);
        return new object[] {
                test,
                time};
    }
    
    private void OnTestByRefCompleted(object state)
    {
        if ((this.TestByRefCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.TestByRefCompleted(this, new TestByRefCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void TestByRefAsync(long foo, int test)
    {
        this.TestByRefAsync(foo, test, null);
    }
    
    public void TestByRefAsync(long foo, int test, object userState)
    {
        if ((this.onBeginTestByRefDelegate == null))
        {
            this.onBeginTestByRefDelegate = new BeginOperationDelegate(this.OnBeginTestByRef);
        }
        if ((this.onEndTestByRefDelegate == null))
        {
            this.onEndTestByRefDelegate = new EndOperationDelegate(this.OnEndTestByRef);
        }
        if ((this.onTestByRefCompletedDelegate == null))
        {
            this.onTestByRefCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnTestByRefCompleted);
        }
        base.InvokeAsync(this.onBeginTestByRefDelegate, new object[] {
                    foo,
                    test}, this.onEndTestByRefDelegate, this.onTestByRefCompletedDelegate, userState);
    }
    
    private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
    }
    
    private object[] OnEndOpen(System.IAsyncResult result)
    {
        ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
        return null;
    }
    
    private void OnOpenCompleted(object state)
    {
        if ((this.OpenCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void OpenAsync()
    {
        this.OpenAsync(null);
    }
    
    public void OpenAsync(object userState)
    {
        if ((this.onBeginOpenDelegate == null))
        {
            this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
        }
        if ((this.onEndOpenDelegate == null))
        {
            this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
        }
        if ((this.onOpenCompletedDelegate == null))
        {
            this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
        }
        base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
    }
    
    private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
    }
    
    private object[] OnEndClose(System.IAsyncResult result)
    {
        ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
        return null;
    }
    
    private void OnCloseCompleted(object state)
    {
        if ((this.CloseCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void CloseAsync()
    {
        this.CloseAsync(null);
    }
    
    public void CloseAsync(object userState)
    {
        if ((this.onBeginCloseDelegate == null))
        {
            this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
        }
        if ((this.onEndCloseDelegate == null))
        {
            this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
        }
        if ((this.onCloseCompletedDelegate == null))
        {
            this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
        }
        base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
    }
    
    protected override IMyService CreateChannel()
    {
        return new MyServiceClientChannel(this);
    }
    
    private class MyServiceClientChannel : ChannelBase<IMyService>, IMyService
    {
        
        public MyServiceClientChannel(System.ServiceModel.ClientBase<IMyService> client) : 
                base(client)
        {
        }
        
        public System.IAsyncResult BeginDelay(int timespan, System.AsyncCallback callback, object asyncState)
        {
            object[] _args = new object[1];
            _args[0] = timespan;
            System.IAsyncResult _result = base.BeginInvoke("Delay", _args, callback, asyncState);
            return _result;
        }
        
        public int EndDelay(System.IAsyncResult result)
        {
            object[] _args = new object[0];
            int _result = ((int)(base.EndInvoke("Delay", _args, result)));
            return _result;
        }
        
        public System.IAsyncResult BeginTestOut(System.AsyncCallback callback, object asyncState)
        {
            object[] _args = new object[0];
            System.IAsyncResult _result = base.BeginInvoke("TestOut", _args, callback, asyncState);
            return _result;
        }
        
        public int EndTestOut(out System.DateTime time, System.IAsyncResult result)
        {
            object[] _args = new object[1];
            int _result = ((int)(base.EndInvoke("TestOut", _args, result)));
            time = ((System.DateTime)(_args[0]));
            return _result;
        }
        
        public System.IAsyncResult BeginTestByRef(long foo, ref int test, System.AsyncCallback callback, object asyncState)
        {
            object[] _args = new object[2];
            _args[0] = foo;
            _args[1] = test;
            System.IAsyncResult _result = base.BeginInvoke("TestByRef", _args, callback, asyncState);
            test = ((int)(_args[1]));
            return _result;
        }
        
        public void EndTestByRef(ref int test, out System.DateTime time, System.IAsyncResult result)
        {
            object[] _args = new object[2];
            _args[0] = test;
            base.EndInvoke("TestByRef", _args, result);
            test = ((int)(_args[0]));
            time = ((System.DateTime)(_args[1]));
        }
    }
}
