var hint

function Collision(gameObject)
{
    this.className = "Collision";
    this.gameObject = gameObject;
}
//Write prototype function here
Collision.prototype = Object.assign(Object.create(Object.prototype), {
    // Start is called before the first frame update
    Start: function () {
        hint = Insight.GameObject.Find("Hint");
    },
    // Update is called once per frame
    Update: function()
    {
        
    },
    OnMouseDown: function () {
        print(this.gameObject.name.replace("barrier", ""));
        if (this.gameObject.name.replace("barrier", "")!="2")
      {
        hint.transform.getChild(0).gameObject.getComponent("Text", 0).text = "请继续往前走！";
      }
      else
      {
        hint.transform.getChild(0).gameObject.getComponent("Text", 0).text = "测试完成！";
      }
      Insight.GameObject.Destroy(this.gameObject);
    }
});

// Debugger Methods Begin
var SafeFunctor=SafeFunctor||function(func){return function(){try{return func.apply(this,arguments)}catch(e){var msg="ClassName: "+this.className+", LineNo: "+(e.lineNumber||e.line)+", Msg: "+e.message+"\r\nStackTrace: "+(e.stackTrace||e.stack);console.error(msg)}}};
var SafeWrapper=SafeWrapper||function(classObject){var o=classObject.prototype;for(var key in o){var func=o[key];if(typeof(func)==='function'){o[key]=SafeFunctor(func)}}};
SafeWrapper(Collision);
// Debugger Methods End
//Return the script module
Collision