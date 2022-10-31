
var welcome;
var hint
var realTime
var nowTime
var isWaiting
var tempFunction
var hashCode

function Manager(gameObject)
{
    this.className = "Manager";
    this.gameObject = gameObject;
}
//Write prototype function here
Manager.prototype = Object.assign(Object.create(Object.prototype), {
    // Start is called before the first frame update
    Start: function () {
        isWaiting = false;
        realTime = 0;
        nowTime = 0;
        tempFunction = new Object;
        //hashcode = new Object;
        //
        welcome = Insight.GameObject.Find("welcome");
        hint = Insight.GameObject.Find("Hint");
        //
        this.Init();
    },
    // Update is called once per frame
    Update: function () {
        this.Timer();
        //
        if (isWaiting) {
            this.WaitTime();
        }

    },
    Init: function () {
        welcome.transform.getChild(0).gameObject.setActive(true);
        //hashCode = Insight.InvokeManager.Invoke(this, this.HideBg, 1);
        //print(123+" "+hashCode);
        nowTime = realTime + 1;
        tempFunction = this.HideBg.bind(this);
        isWaiting = true;
    },
    Timer: function () {
        realTime += Insight.Time.deltaTime;
    },
    WaitTime: function () {
        if (realTime >= nowTime) {
            isWaiting = false;
            tempFunction();
            
        }
    },
    HideBg: function () {
        welcome.setActive(false);
        //
        nowTime = realTime + 1;
        tempFunction = this.HintOpen.bind(this);
        isWaiting = true;
        //print(456+" "+hashcode);
        //Insight.InvokeManager.CancelInvoke(hashCode);
        //Insight.InvokeManager.Invoke(this, this.HintOpen, 1);
    },
    HintOpen: function () {
        hint.transform.getChild(0).gameObject.setActive(true);
        text = "请一直往前走！";
        Text = hint.transform.getChild(0).gameObject.getComponent("Text", 0);
        //temp = Insight.DOTween.DOText(Text, text, 4);
        //print(temp);
        //temp.onComplete();,l
        //print(text + " " + Text);
        //pp = this.haha.bind(this);

    },
    haha: function () {
        print("777");
    },
});

// Debugger Methods Begin
var SafeFunctor=SafeFunctor||function(func){return function(){try{return func.apply(this,arguments)}catch(e){var msg="ClassName: "+this.className+", LineNo: "+(e.lineNumber||e.line)+", Msg: "+e.message+"\r\nStackTrace: "+(e.stackTrace||e.stack);console.error(msg)}}};
var SafeWrapper=SafeWrapper||function(classObject){var o=classObject.prototype;for(var key in o){var func=o[key];if(typeof(func)==='function'){o[key]=SafeFunctor(func)}}};
SafeWrapper(Manager);
// Debugger Methods End
//Return the script module
Manager