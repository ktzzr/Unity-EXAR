
var welcome;
var hint
var realTime
var nowTime
var isWaiting
var tempFunction

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
            this.WaitTime()
        }

    },
    Init: function () {
        welcome.transform.getChild(0).gameObject.setActive(true);
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
    },
    HintOpen: function () {
        hint.transform.getChild(0).gameObject.setActive(true);
    },
});

// Debugger Methods Begin
var SafeFunctor=SafeFunctor||function(func){return function(){try{return func.apply(this,arguments)}catch(e){var msg="ClassName: "+this.className+", LineNo: "+(e.lineNumber||e.line)+", Msg: "+e.message+"\r\nStackTrace: "+(e.stackTrace||e.stack);console.error(msg)}}};
var SafeWrapper=SafeWrapper||function(classObject){var o=classObject.prototype;for(var key in o){var func=o[key];if(typeof(func)==='function'){o[key]=SafeFunctor(func)}}};
SafeWrapper(Manager);
// Debugger Methods End
//Return the script module
Manager