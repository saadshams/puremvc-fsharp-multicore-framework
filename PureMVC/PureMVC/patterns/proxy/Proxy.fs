namespace PureMVC.patterns.proxy

open PureMVC.interfaces

type Proxy(name: string, data: obj option) =
    let mutable data = defaultArg data null
    let name = if name = null then Proxy.NAME else name
    
    static member val NAME = "Proxy" with get
    
    interface IProxy with // The type 'IProxy' is not defined. The type 'obj' is not an interface type
        member _.Name = name
        member _.Data
            with get() = data
            and set(value) = data <- value
        member _.OnRegister() = ()
        member _.OnRemove() = ()