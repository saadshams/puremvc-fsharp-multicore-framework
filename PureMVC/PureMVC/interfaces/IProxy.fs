namespace PureMVC.interfaces

type IProxy =
    abstract member Name: string
    abstract member Data: obj with get, set
    abstract member OnRegister : unit -> unit
    abstract member OnRemove : unit -> unit