import { HttpRequest } from "./duktape/http";
import { Coroutine } from "./duktape/coroutine";
import Time = UnityEngine.Time;

export function sampleTests() {
    // test protobuf
    // (function () {
    //     // let writer = protobuf.Writer.create()
    //     let msg = new protos.Ping()
    //     msg.payload = "hello, protobuf"
    //     msg.time = 123
    //     let w = protos.Ping.encode(msg)
    //     let buf = w.finish()

    //     // > go run examples\echoserver\src\main.go
    //     // you need a simple echo server to run the code below
    //     let ws = new DuktapeJS.WebSocket()
    //     ws.connect("ws://127.0.0.1:8080/websocket")
    //     ws.on("open", this, () => {
    //         console.log("ws opened")
    //         ws.send(buf)
    //     })
    //     ws.on("close", this, () => {
    //         console.log("ws closed")
    //     })
    //     ws.on("data", this, data => {
    //         let dmsg = protos.Ping.decode(data)
    //         console.log(`msg.payload = ${dmsg.payload}`)
    //         console.log(`msg.time = ${dmsg.time}`)
    //     })
    //     let go = new UnityEngine.GameObject("ws")
    //     go.AddComponent(DuktapeJS.Bridge).SetBridge({
    //         Update: () => {
    //             ws.poll()
    //         },
    //         OnDestroy: () => {
    //             console.log("ws close")
    //             ws.close()
    //         },
    //     })
    // })();

    (function () {
        console.log("http requesting...");
        HttpRequest.GET("http://t.weather.sojson.com/api/weather/city/101030100", null, (status, res) => {
            console.warn("http response:", status, res);
            if (status) {
                let obj = JSON.parse(res);
                console.log("as object", obj.message);
            }
        });
    })();

    (function () {
        let sample = new SampleNamespace.SampleClass("test match type");
        sample.MethodOverride(new UnityEngine.Vector3(1, 2, 3));
    })();

    (function () {
        let Vector3 = UnityEngine.Vector3;
        let start: number;
        let DoNothing = SampleNamespace.SampleClass.DoNothing;
        start = Date.now();
        for (let i = 1; i < 1000000; i++) {
            DoNothing();
        }
        SampleNamespace.SampleClass.WriteLog(`js/DoNothing: ${(Date.now() - start) / 1000}`);
        let DoNothing1 = SampleNamespace.SampleClass.DoNothing1;
        start = Date.now();
        for (let i = 1; i < 1000000; i++) {
            DoNothing1(i);
        }
        SampleNamespace.SampleClass.WriteLog(`js/DoNothing1: ${(Date.now() - start) / 1000}`);
        let v1 = new Vector3(0, 0, 0)
        start = Date.now();
        for (let i = 1; i < 200000; i++) {
            v1.Set(i, i, i)
            v1.Normalize()
        }
        console.log("js/vector3/normailize", (Date.now() - start) / 1000);
        let v = Vector3.zero
        let w = Vector3.one
        start = Date.now();
        for (let i = 1; i < 200000; i++) {
            v.Scale(w);
        }
        console.log("js/vector3/scale", (Date.now() - start) / 1000);
        let sum = 0;
        start = Date.now();
        for (let i = 1; i < 20000000; i++) {
            sum += i;
        }
        console.log("js/number/add", (Date.now() - start) / 1000, sum);
    })();

    (function () {
        console.log("### Vector3 (replaced)")
        let v1 = new UnityEngine.Vector3(1, 2, 3)
        console.log(`v: ${v1.x}, ${v1.y}, ${v1.z} (${v1.magnitude})`)
        console.log(`v: ${v1[0]}, ${v1[1]}, ${v1[2]}`)
        let v2 = v1.normalized
        console.log(`v: ${v2.x}, ${v2.y}, ${v2.z} (${v2.magnitude})`)
        v2.x += 10
        console.log(`v: ${v2.x}, ${v2.y}, ${v2.z} (${v2.magnitude})`)

        let q1 = new UnityEngine.Quaternion(1, 2, 3, 1)
        console.log(`q: ${q1.x}, ${q1.y}, ${q1.z} eulerAngles: ${q1.eulerAngles.ToString()}`)
    })();

    (function () {
        console.log("### Delegates begin")
        let d = new DuktapeJS.Delegate0<void>()
        d.on(this, () => {
            console.log("delegate0")
        })
        d.dispatch()
        d.clear()
        d.dispatch()
        console.log("### Delegates end")
    })();

    (function () {
        SampleNamespace.SampleClass.staticTestEvent.on(function () {
            console.log("sampleClass.staticTestEvent invoked!!!!")
        })
        SampleNamespace.SampleClass.DispatchStaticTestEvent()
        let sampleClass = new SampleNamespace.SampleClass("sampleclass.constructor");
        sampleClass.testEvent.on(function () {
            console.log("sampleClass.testEvent invoked!!!!")
        })
        sampleClass.DispatchTestEvent();

        sampleClass.delegateFoo4 = (a, b) => a + b;
        sampleClass.TestDelegate4();
        console.log("trytrytrytry111", sampleClass.delegateFoo4);

        let d4 = new DuktapeJS.Delegate2<number, number, number>();
        d4.on(sampleClass, function (a, b) {
            return (a + b) * 3;
        });
        sampleClass.delegateFoo4 = d4;
        sampleClass.TestDelegate4();
        console.log("trytrytrytry222", sampleClass.delegateFoo4);

        var fn = function () {
            console.log(this, "TestDelegate")
        };
        SampleNamespace.SampleClass.TestDelegate(fn);
        SampleNamespace.SampleClass.TestDelegate(fn);

        let d = new DuktapeJS.Dispatcher()
        d.on("this", function () {
            console.log(this, "TestDelegate")
        })
        SampleNamespace.SampleClass.TestDelegate(d)
    })();

    console.log(UnityEngine.Mathf.PI);
    // UnityEngine.Debug.Log("greeting")

    (function () {
        let go = UnityEngine.GameObject.CreatePrimitive(UnityEngine.PrimitiveType.Cube)
        go.name = "testing_cube"
        let hello = go.AddComponent(SampleNamespace.Hello);
        // DONT DO THIS, IT IS NOT READY
        // SCRATCH CODE
        {
            hello.StartCoroutine(new Coroutine(function () {
                console.warn("js function in unity coroutine  11");
                Coroutine.yield(new UnityEngine.WaitForSeconds(2.5));
                console.warn("js function in unity coroutine  22");
            }));
        }
        console.log("hello.name = ", hello.gameObject.name)
        console.log("DuktapeJS.Bridge = ", DuktapeJS.Bridge)
        let bridge = go.AddComponent(DuktapeJS.Bridge)

        class MyBridge {
            hitInfo: any = {}
            gameObject: UnityEngine.GameObject
            transform: UnityEngine.Transform;
            private rotx = 10
            private roty = 20

            constructor(gameObject: UnityEngine.GameObject) {
                this.gameObject = gameObject
                this.transform = gameObject.transform;
            }

            OnEnable() {
                console.log("bridge.OnEnable")
            }

            Start() {
                console.log("bridge.Start")
                this.transform.localPosition = new UnityEngine.Vector3(3, 0, 0)
            }

            OnDisable() {
                console.log("bridge.OnDisable")
            }

            Update() {
                this.transform.localRotation = UnityEngine.Quaternion.Euler(this.rotx, this.roty, 0)
                this.rotx += Time.deltaTime * 3.0
                this.roty += Time.deltaTime * 1.5
                if (UnityEngine.Input.GetMouseButtonUp(0) || UnityEngine.Input.GetKeyUp(UnityEngine.KeyCode.Space)) {
                    if (UnityExtensions.RaycastMousePosition(this.hitInfo, 1000, 1)) {
                        console.log("you clicked " + this.hitInfo.collider.name)
                    }
                }
            }

            OnDestroy() {
                console.log("bridge.OnDestroy")
            }
        }
        bridge.SetBridge(new MyBridge(go))
    })();

    (function () {
        let go2 = new UnityEngine.GameObject("testing2_wait_destroy")
        console.log("go2.activeSelf", go2.activeSelf)
        console.log("go2.activeSelf", go2.activeSelf)

        setTimeout(() => {
            go2.SetActive(false)
        }, 3500)

        setTimeout(() => {
            UnityEngine.Object.Destroy(go2)
        }, 30000)

        let time = 0;
        setInterval(() => {
            setTimeout(() => {
                time++;
                // setTimeout/setInterval gc test
            }, 50);
        }, 200);

        // if (DuktapeJS.Socket) {
        //     var buffer = new Buffer(1024);
        //     var sock = new DuktapeJS.Socket(1, 0);
        //     var count = 0;
        //     sock.connect("localhost", 1234);
        //     console.log("buffer.length:", buffer.length);
        //     setInterval(() => {
        //         count++;
        //         sock.send("test" + count);
        //         var recv_size = sock.recv(buffer, 0, buffer.length);
        //         if (recv_size > 0) {
        //             console.log("echo", buffer.toString("utf8", 0, recv_size));
        //         }
        //     }, 1000);
        // } else {
        //     console.error("no DuktapeJS.Socket", DuktapeJS.SocketType, DuktapeJS.SocketFamily);
        // }
    })();

    (function () {
        // console.log(UnityEngine.UI.Text)
        let textui = UnityEngine.GameObject.Find("/Canvas/Text").GetComponent(UnityEngine.UI.Text)
        if (textui) {
            textui.text = "hello, javascript"
        }

        let buttonui = UnityEngine.GameObject.Find("/Canvas/Button").GetComponent(UnityEngine.UI.Button)
        if (buttonui) {
            let delegate = new DuktapeJS.Delegate0<void>()
            delegate.on(buttonui, () => {
                if (textui) {
                    textui.color = UnityEngine.Color.Lerp(UnityEngine.Color.black, UnityEngine.Color.green, UnityEngine.Random.value)
                }
                console.log("you clicked the button")
            })
            delegate.on(buttonui, function () {
                console.log("another listener", this == buttonui)
            })
            buttonui.onClick.AddListener(delegate)
        }
    })();

    (function () {
        console.log("[Buffer] tests");
        let buffer = SampleNamespace.SampleClass.GetBytes();
        console.log(buffer);
        let str = SampleNamespace.SampleClass.InputBytes(buffer);
        console.log(str);
        setInterval(function () {
            SampleNamespace.SampleClass.AnotherBytesTest(buffer);
        }, 5000);
    })();

    (function () {
        let co = new Coroutine(function (x) {
            console.log("duktape thread, start:", x);
            for (var i = 1; i <= 5; ++i) {
                let r = Coroutine.yield(i);
                console.log("duktape thread, yield:", r);
            }
            // Coroutine.break();
            return "all done!";
        });
        let c = 'A'.charCodeAt(0);
        while (co.next(String.fromCharCode(c++))) {
            console.log("duktape thread, next:", co.value);
        }
        console.log("duktape thread, done:", co.value);
    })();

    (function () {
        setTimeout(function () {
            let time_id = setInterval(function () {
                console.log(`[setInterval@${Time.frameCount}] test zero interval timer1`);
            }, 0);

            setTimeout(function () {
                clearInterval(time_id);
                console.log(`[setTimeout] clear interval timer1 [id:${time_id}]`);
            }, 0);

            console.log(`[setInterval@${Time.frameCount}] before timer2 ${Time.realtimeSinceStartup}`);
            let timer2frames = 0;
            let time_id2 = setInterval(function () {
                timer2frames++;
                console.log(`[setInterval@${Time.frameCount}] test zero interval timer2`);
            }, 0);

            setTimeout(function () {
                clearInterval(time_id2);
                console.log(`[setTimeout] clear interval timer2 [id:${time_id2}] realtime:${Time.realtimeSinceStartup} frames:${timer2frames}`);
            }, 150);
        }, 5000);
    })();

    // (function () {
    //     console.log("[error] tests");
    //     let u = null;
    //     console.log(u.value);
    // })();
}
