var barier
var hint

function Camera(gameObject)
{
    this.className = "Camera";
    this.gameObject = gameObject;
}
//Write prototype function here
Camera.prototype = Object.assign(Object.create(Object.prototype), {
    // Start is called before the first frame update
    Start: function(){
        barier = Insight.GameObject.Find("Barier");
        hint = Insight.GameObject.Find("Hint");
    },
    // Update is called once per frame
    Update: function()
    {
        
    },
    OnTriggerEnter: function (other) {
        //print(other.name.replace("Cube",""));
        barier.transform.getChild(other.name.replace("Cube", "")).gameObject.setActive(true);
        hint.transform.getChild(0).gameObject.getComponent("Text",0).text = "点击这个方块！";
    },
});

// Debugger Methods Begin
var SafeFunctor=SafeFunctor||function(func){return function(){try{return func.apply(this,arguments)}catch(e){var msg="ClassName: "+this.className+", LineNo: "+(e.lineNumber||e.line)+", Msg: "+e.message+"\r\nStackTrace: "+(e.stackTrace||e.stack);console.error(msg)}}};
var SafeWrapper=SafeWrapper||function(classObject){var o=classObject.prototype;for(var key in o){var func=o[key];if(typeof(func)==='function'){o[key]=SafeFunctor(func)}}};
SafeWrapper(Camera);
// Debugger Methods End
//Return the script module
Camera