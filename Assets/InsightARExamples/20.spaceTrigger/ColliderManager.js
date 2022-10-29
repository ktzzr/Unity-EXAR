
function ColliderManager(gameObject)
{
    this.transform = gameObject.transform;
    this.gameObject = gameObject;
}
//Write prototype function here
ColliderManager.prototype = Object.assign(Object.create(Object.prototype), {
    // Start is called before the first frame update
    Start: function(){
    },
    Awake: function(){ },
    // Update is called once per frame
    Update: function() {
    },

    //进入到碰撞区域
    OnTriggerEnter: function (other) {
        Insight.Debug.Log("collider enter name is " + other.name);
        
        if(other.name == "VirtualPoi1"){
            // do some actions
        }

        if(other.name == "VirtualPoi2"){
            // do some actions
        }

    },

    OnTriggerStay: function (other) {
        // Insight.Debug.Log("collider stay name is " + other.name);
    },

    //退出碰撞区域
    OnTriggerExit: function (other) {
        Insight.Debug.Log("collider exit name is " + other.name);
        
        if(other.name == "VirtualPoi1"){
            // do some actions
        }

        if(other.name == "VirtualPoi2"){
            // do some actions
        }

    },

});

//Return the script module
ColliderManager